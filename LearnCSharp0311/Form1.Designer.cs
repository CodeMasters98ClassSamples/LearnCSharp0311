namespace LearnCSharp0311
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            mobileNumberTextBox = new TextBox();
            nationalCodeTextBox = new TextBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            mobileNumberLabel = new Label();
            nationalCodelabel = new Label();
            addStudentButton = new Button();
            studentDataGridView = new DataGridView();
            updateStudentButton = new Button();
            deleteStudentButton = new Button();
            label1 = new Label();
            selectedIdTextBox = new TextBox();
            resetButton = new Button();
            courseComboBox = new ComboBox();
            label2 = new Label();
            registerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(114, 50);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(178, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(114, 79);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(178, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // mobileNumberTextBox
            // 
            mobileNumberTextBox.Location = new Point(114, 108);
            mobileNumberTextBox.Name = "mobileNumberTextBox";
            mobileNumberTextBox.Size = new Size(178, 23);
            mobileNumberTextBox.TabIndex = 2;
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(114, 137);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(178, 23);
            nationalCodeTextBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(17, 53);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(67, 15);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(17, 84);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(66, 15);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // mobileNumberLabel
            // 
            mobileNumberLabel.AutoSize = true;
            mobileNumberLabel.Location = new Point(17, 113);
            mobileNumberLabel.Name = "mobileNumberLabel";
            mobileNumberLabel.Size = new Size(91, 15);
            mobileNumberLabel.TabIndex = 6;
            mobileNumberLabel.Text = "MobileNumber:";
            // 
            // nationalCodelabel
            // 
            nationalCodelabel.AutoSize = true;
            nationalCodelabel.Location = new Point(17, 140);
            nationalCodelabel.Name = "nationalCodelabel";
            nationalCodelabel.Size = new Size(83, 15);
            nationalCodelabel.TabIndex = 7;
            nationalCodelabel.Text = "NationalCode:";
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(9, 166);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(283, 37);
            addStudentButton.TabIndex = 8;
            addStudentButton.Text = "Add Student";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // studentDataGridView
            // 
            studentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentDataGridView.Location = new Point(298, 12);
            studentDataGridView.Name = "studentDataGridView";
            studentDataGridView.Size = new Size(487, 470);
            studentDataGridView.TabIndex = 10;
            studentDataGridView.CellClick += studentDataGridView_CellClick;
            // 
            // updateStudentButton
            // 
            updateStudentButton.FlatStyle = FlatStyle.System;
            updateStudentButton.Location = new Point(9, 209);
            updateStudentButton.Name = "updateStudentButton";
            updateStudentButton.Size = new Size(283, 37);
            updateStudentButton.TabIndex = 11;
            updateStudentButton.Text = "Update Student";
            updateStudentButton.UseVisualStyleBackColor = true;
            updateStudentButton.Click += updateStudentButton_Click;
            // 
            // deleteStudentButton
            // 
            deleteStudentButton.FlatStyle = FlatStyle.System;
            deleteStudentButton.Location = new Point(9, 252);
            deleteStudentButton.Name = "deleteStudentButton";
            deleteStudentButton.Size = new Size(283, 37);
            deleteStudentButton.TabIndex = 12;
            deleteStudentButton.Text = "Delete Student";
            deleteStudentButton.UseVisualStyleBackColor = true;
            deleteStudentButton.Click += deleteStudentButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 25);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 13;
            label1.Text = "SelectedId:";
            // 
            // selectedIdTextBox
            // 
            selectedIdTextBox.Location = new Point(114, 22);
            selectedIdTextBox.Name = "selectedIdTextBox";
            selectedIdTextBox.ReadOnly = true;
            selectedIdTextBox.Size = new Size(178, 23);
            selectedIdTextBox.TabIndex = 14;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(9, 295);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(283, 37);
            resetButton.TabIndex = 15;
            resetButton.Text = "Rest Form";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // courseComboBox
            // 
            courseComboBox.FormattingEnabled = true;
            courseComboBox.Location = new Point(114, 349);
            courseComboBox.Name = "courseComboBox";
            courseComboBox.Size = new Size(178, 23);
            courseComboBox.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 352);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 17;
            label2.Text = "Courses";
            // 
            // registerButton
            // 
            registerButton.Location = new Point(9, 378);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(283, 37);
            registerButton.TabIndex = 18;
            registerButton.Text = "Register Course";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(registerButton);
            Controls.Add(label2);
            Controls.Add(courseComboBox);
            Controls.Add(resetButton);
            Controls.Add(selectedIdTextBox);
            Controls.Add(label1);
            Controls.Add(deleteStudentButton);
            Controls.Add(updateStudentButton);
            Controls.Add(studentDataGridView);
            Controls.Add(addStudentButton);
            Controls.Add(nationalCodelabel);
            Controls.Add(mobileNumberLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(nationalCodeTextBox);
            Controls.Add(mobileNumberTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox mobileNumberTextBox;
        private TextBox nationalCodeTextBox;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label mobileNumberLabel;
        private Label nationalCodelabel;
        private Button addStudentButton;
        private DataGridView studentDataGridView;
        private Button updateStudentButton;
        private Button deleteStudentButton;
        private Label label1;
        private TextBox selectedIdTextBox;
        private Button resetButton;
        private ComboBox courseComboBox;
        private Label label2;
        private Button registerButton;
    }
}
