namespace LearnCSharp0311
{
    partial class PanelLayoutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            studentManagmentToolStripMenuItem = new ToolStripMenuItem();
            studentManagmentToolStripMenuItem1 = new ToolStripMenuItem();
            courseManagementToolStripMenuItem = new ToolStripMenuItem();
            courseToolStripMenuItem = new ToolStripMenuItem();
            courseListToolStripMenuItem = new ToolStripMenuItem();
            registerOnCourseToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentManagmentToolStripMenuItem, courseManagementToolStripMenuItem, registerOnCourseToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // studentManagmentToolStripMenuItem
            // 
            studentManagmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentManagmentToolStripMenuItem1 });
            studentManagmentToolStripMenuItem.Name = "studentManagmentToolStripMenuItem";
            studentManagmentToolStripMenuItem.Size = new Size(128, 20);
            studentManagmentToolStripMenuItem.Text = "Student Managment";
            studentManagmentToolStripMenuItem.Click += studentManagmentToolStripMenuItem_Click;
            // 
            // studentManagmentToolStripMenuItem1
            // 
            studentManagmentToolStripMenuItem1.Name = "studentManagmentToolStripMenuItem1";
            studentManagmentToolStripMenuItem1.Size = new Size(180, 22);
            studentManagmentToolStripMenuItem1.Text = "StudentManagment";
            studentManagmentToolStripMenuItem1.Click += studentManagmentToolStripMenuItem1_Click;
            // 
            // courseManagementToolStripMenuItem
            // 
            courseManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { courseToolStripMenuItem, courseListToolStripMenuItem });
            courseManagementToolStripMenuItem.Name = "courseManagementToolStripMenuItem";
            courseManagementToolStripMenuItem.Size = new Size(130, 20);
            courseManagementToolStripMenuItem.Text = "Course Management";
            // 
            // courseToolStripMenuItem
            // 
            courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            courseToolStripMenuItem.Size = new Size(129, 22);
            courseToolStripMenuItem.Text = "Course";
            // 
            // courseListToolStripMenuItem
            // 
            courseListToolStripMenuItem.Name = "courseListToolStripMenuItem";
            courseListToolStripMenuItem.Size = new Size(129, 22);
            courseListToolStripMenuItem.Text = "CourseList";
            courseListToolStripMenuItem.Click += courseListToolStripMenuItem_Click;
            // 
            // registerOnCourseToolStripMenuItem
            // 
            registerOnCourseToolStripMenuItem.Name = "registerOnCourseToolStripMenuItem";
            registerOnCourseToolStripMenuItem.Size = new Size(114, 20);
            registerOnCourseToolStripMenuItem.Text = "RegisterOnCourse";
            registerOnCourseToolStripMenuItem.Click += registerOnCourseToolStripMenuItem_Click;
            // 
            // PanelLayoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "PanelLayoutForm";
            Text = "PanelLayoutForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentManagmentToolStripMenuItem;
        private ToolStripMenuItem courseManagementToolStripMenuItem;
        private ToolStripMenuItem courseToolStripMenuItem;
        private ToolStripMenuItem courseListToolStripMenuItem;
        private ToolStripMenuItem registerOnCourseToolStripMenuItem;
        private ToolStripMenuItem studentManagmentToolStripMenuItem1;
    }
}