using LearnCSharp0311.Businesses;
using LearnCSharp0311.Entities;

namespace LearnCSharp0311
{
    public partial class Form1 : Form
    {
        StudentBusiness studentBusiness = null;
        public Form1()
        {
            InitializeComponent();

            studentBusiness = new StudentBusiness();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> students = studentBusiness.GetStudents();
            for (int i = 0; i < students.Count; i++)
            {
                studentListBox.Items.Add(students[i].FullData);
            }
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            Student student = new Student(firstName: firstNameTextBox.Text,lastName: lastNameTextBox.Text);
            studentBusiness.AddStudent(student);

            //students.Add(student);
            studentListBox.Items.Add(student.FullData);

            ResetRegistreationForm();
        }

        private void ResetRegistreationForm()
        {
            firstNameTextBox.Text = null;
            lastNameTextBox.Text = null;
            mobileNumberTextBox.Text = null;
            nationalCodeTextBox.Text = null;
        }
    }
}
