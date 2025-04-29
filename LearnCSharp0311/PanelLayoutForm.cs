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
    public partial class PanelLayoutForm : Form
    {
        public PanelLayoutForm()
        {
            InitializeComponent();
        }

        private void courseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.ShowDialog();
        }

        private void studentManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentManagmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 studentForm = new Form1();
            studentForm.ShowDialog();
        }
    }
}
