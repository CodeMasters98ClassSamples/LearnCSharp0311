using BaseBackend.Businesses;
using BaseBackend.Entities;
using System.Windows.Forms;

namespace LearnCSharp0311
{
    public partial class Form1 : Form
    {
        // Declare the Delegate.
        public delegate void ReloadData();

        // Declare the event.
        public event ReloadData ReloadDataEvent;

        StudentBusiness studentBusiness = null;
        public Form1()
        {
            InitializeComponent();
            studentBusiness = new StudentBusiness();

            if (true)
                ReloadDataEvent += FillData;
            else
                ReloadDataEvent += FillSampleData;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadDataEvent.Invoke();
        }

        public void FillData()
        {
            List<Student> students = studentBusiness.GetAll();
            studentDataGridView.DataSource = students;
            studentDataGridView.Refresh();
        }

        public void FillSampleData()
        {
            List<Student> students = studentBusiness.GetAll();
            studentDataGridView.DataSource = students;
            studentDataGridView.Refresh();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedIdTextBox.Text))
            {
                MessageBox.Show("Please Reset Form");
                return;
            }

            if (string.IsNullOrEmpty(firstNameTextBox.Text) ||
                string.IsNullOrEmpty(lastNameTextBox.Text) || 
                string.IsNullOrEmpty(mobileNumberTextBox.Text))
            {
                MessageBox.Show("Please enter all values");
                return;
            }
            StudentCourse studentCourse = new StudentCourse();
            Student student = new Student(firstName: firstNameTextBox.Text, lastName: lastNameTextBox.Text, mobileNumber: mobileNumberTextBox.Text);
            studentBusiness.Add(student);

         

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
            Student student = new Student()
            {
                Id = int.Parse(selectedIdTextBox.Text),
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                MobileNumber = mobileNumberTextBox.Text,
                NationalCode = nationalCodeTextBox.Text
            };
            studentBusiness.Update(student);
            ReloadDataEvent.Invoke();
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            ReloadDataEvent.Invoke();
        }

        private void studentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header row clicks
            if (e.RowIndex >= 0)
            {
                // Get the current row
                var row = studentDataGridView.Rows[e.RowIndex];

                // Access the ID from the row's data
                var id = row.Cells["Id"].Value;

                // Display or use the ID
                selectedIdTextBox.Text = id.ToString();
                firstNameTextBox.Text = row.Cells["FirstName"].Value?.ToString();
                lastNameTextBox.Text = row.Cells["LastName"].Value?.ToString();
                mobileNumberTextBox.Text = row.Cells["MobileNumber"].Value?.ToString();
                nationalCodeTextBox.Text = row.Cells["NationalCode"].Value?.ToString();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetRegistreationForm();
            selectedIdTextBox.Text = null;

        }
    }
}
