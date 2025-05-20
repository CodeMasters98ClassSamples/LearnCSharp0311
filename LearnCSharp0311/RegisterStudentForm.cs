using BaseBackend.Businesses;
using BaseBackend.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnCSharp0311;

public partial class RegisterStudentForm : Form
{
    public RegisterStudentForm()
    {
        InitializeComponent();

        //ListCourses
        CourseBusiness courseBusiness = new CourseBusiness();
        List<Course> courses = courseBusiness.GetAll();
        courseComboBox.Items.Clear();
        foreach (var item in courses)
        {
            courseComboBox.Items.Add(item.Title);
        }
    }

    private void registerButton_Click(object sender, EventArgs e)
    {
        //
    }

    private void searchButton_Click(object sender, EventArgs e)
    {
        string firstName = firstNameTextBox.Text;
        string lastName = lastNametextBox.Text;

        //DB -> 
    }
}
