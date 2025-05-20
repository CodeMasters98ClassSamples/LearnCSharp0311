namespace LearnCSharp0311
{
    partial class RegisterStudentForm
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
            courseComboBox = new ComboBox();
            label1 = new Label();
            registerButton = new Button();
            studentDataGridView = new DataGridView();
            searchGroupBox = new GroupBox();
            label2 = new Label();
            firstNameTextBox = new TextBox();
            lastNametextBox = new TextBox();
            label3 = new Label();
            searchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).BeginInit();
            searchGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // courseComboBox
            // 
            courseComboBox.FormattingEnabled = true;
            courseComboBox.Location = new Point(86, 12);
            courseComboBox.Name = "courseComboBox";
            courseComboBox.Size = new Size(304, 23);
            courseComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Courses";
            // 
            // registerButton
            // 
            registerButton.Location = new Point(690, 7);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(98, 34);
            registerButton.TabIndex = 2;
            registerButton.Text = "Regitser";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // studentDataGridView
            // 
            studentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentDataGridView.Location = new Point(12, 169);
            studentDataGridView.Name = "studentDataGridView";
            studentDataGridView.Size = new Size(776, 269);
            studentDataGridView.TabIndex = 3;
            // 
            // searchGroupBox
            // 
            searchGroupBox.Controls.Add(searchButton);
            searchGroupBox.Controls.Add(lastNametextBox);
            searchGroupBox.Controls.Add(label3);
            searchGroupBox.Controls.Add(firstNameTextBox);
            searchGroupBox.Controls.Add(label2);
            searchGroupBox.Location = new Point(12, 47);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Size = new Size(776, 100);
            searchGroupBox.TabIndex = 4;
            searchGroupBox.TabStop = false;
            searchGroupBox.Text = "Search Box For Students";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 25);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 0;
            label2.Text = "First Name: ";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(95, 22);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(236, 23);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNametextBox
            // 
            lastNametextBox.Location = new Point(520, 22);
            lastNametextBox.Name = "lastNametextBox";
            lastNametextBox.Size = new Size(236, 23);
            lastNametextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 25);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name: ";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(620, 51);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(136, 33);
            searchButton.TabIndex = 5;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // RegisterStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchGroupBox);
            Controls.Add(studentDataGridView);
            Controls.Add(registerButton);
            Controls.Add(label1);
            Controls.Add(courseComboBox);
            Name = "RegisterStudentForm";
            Text = "RegisterStudentForm";
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).EndInit();
            searchGroupBox.ResumeLayout(false);
            searchGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox courseComboBox;
        private Label label1;
        private Button registerButton;
        private DataGridView studentDataGridView;
        private GroupBox searchGroupBox;
        private TextBox lastNametextBox;
        private Label label3;
        private TextBox firstNameTextBox;
        private Label label2;
        private Button searchButton;
    }
}