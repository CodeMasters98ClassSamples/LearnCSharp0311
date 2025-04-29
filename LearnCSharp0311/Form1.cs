using BaseBackend.Businesses;
using BaseBackend.Entities;

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
            List<Student> students = studentBusiness.GetAll();
            studentDataGridView.DataSource = students;
            studentDataGridView.Refresh();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            StudentCourse studentCourse = new StudentCourse();
            Student student = new Student(firstName: firstNameTextBox.Text, lastName: lastNameTextBox.Text, mobileNumber: mobileNumberTextBox.Text);
            studentBusiness.Add(student);

            List<Student> students = studentBusiness.GetAll();
            studentDataGridView.DataSource = students;
            studentDataGridView.Refresh();

            ResetRegistreationForm();
        }

        private void ResetRegistreationForm()
        {
            firstNameTextBox.Text = null;
            lastNameTextBox.Text = null;
            mobileNumberTextBox.Text = null;
            nationalCodeTextBox.Text = null;
        }

        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            //Code
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
