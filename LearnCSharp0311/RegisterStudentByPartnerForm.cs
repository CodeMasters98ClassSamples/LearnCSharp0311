using LearnCSharp0311.Businesses;
using LearnCSharp0311.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
