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
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(117, 12);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(178, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(117, 41);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(178, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // mobileNumberTextBox
            // 
            mobileNumberTextBox.Location = new Point(117, 70);
            mobileNumberTextBox.Name = "mobileNumberTextBox";
            mobileNumberTextBox.Size = new Size(178, 23);
            mobileNumberTextBox.TabIndex = 2;
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(117, 99);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(178, 23);
            nationalCodeTextBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(20, 15);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(67, 15);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(20, 46);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(66, 15);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // mobileNumberLabel
            // 
            mobileNumberLabel.AutoSize = true;
            mobileNumberLabel.Location = new Point(20, 75);
            mobileNumberLabel.Name = "mobileNumberLabel";
            mobileNumberLabel.Size = new Size(91, 15);
            mobileNumberLabel.TabIndex = 6;
            mobileNumberLabel.Text = "MobileNumber:";
            // 
            // nationalCodelabel
            // 
            nationalCodelabel.AutoSize = true;
            nationalCodelabel.Location = new Point(20, 102);
            nationalCodelabel.Name = "nationalCodelabel";
            nationalCodelabel.Size = new Size(83, 15);
            nationalCodelabel.TabIndex = 7;
            nationalCodelabel.Text = "NationalCode:";
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(12, 128);
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
            studentDataGridView.Location = new Point(301, 12);
            studentDataGridView.Name = "studentDataGridView";
            studentDataGridView.Size = new Size(487, 426);
            studentDataGridView.TabIndex = 10;
            // 
            // updateStudentButton
            // 
            updateStudentButton.FlatStyle = FlatStyle.System;
            updateStudentButton.Location = new Point(12, 171);
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
            deleteStudentButton.Location = new Point(12, 214);
            deleteStudentButton.Name = "deleteStudentButton";
            deleteStudentButton.Size = new Size(283, 37);
            deleteStudentButton.TabIndex = 12;
            deleteStudentButton.Text = "Delete Student";
            deleteStudentButton.UseVisualStyleBackColor = true;
            deleteStudentButton.Click += deleteStudentButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
