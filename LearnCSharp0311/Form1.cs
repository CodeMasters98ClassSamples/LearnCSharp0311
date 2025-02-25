using LearnCSharp0311.Entities;

namespace LearnCSharp0311
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            Student student2 = new Student();

            Student student = new Student(firstName: firstNameTextBox.Text,lastName: lastNameTextBox.Text);
            
            students.Add(student);
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
