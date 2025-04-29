
using BaseBackend.Businesses;
using BaseBackend.Entities;

namespace LearnCSharp0311
{
    public partial class RegisterStudentByPartnerForm : Form
    {
        public RegisterStudentByPartnerForm()
        {
            InitializeComponent();
        }

        private void RegisterStudentByPartnerForm_Load(object sender, EventArgs e)
        {
            Student student = new Student(firstName: "", lastName: "");

            StudentBusiness studentBusiness = new StudentBusiness();
            //studentBusiness.AddStudent(student);

        }
    }
}
