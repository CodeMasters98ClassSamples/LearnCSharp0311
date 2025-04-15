using LearnCSharp0311.Businesses;
using LearnCSharp0311.Entities;

namespace LearnCSharp0311;

public partial class CourseForm : Form
{
    public CourseForm()
    {
        InitializeComponent();

        CourseBusiness courseBusiness = new CourseBusiness();
        List<Course> courses = courseBusiness.GetAll();

        courseDataGridView.DataSource = courses;
        courseDataGridView.Refresh();
    }
}
