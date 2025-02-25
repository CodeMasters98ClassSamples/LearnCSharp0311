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
            studentListBox = new ListBox();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(110, 12);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(185, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(110, 41);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(185, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // mobileNumberTextBox
            // 
            mobileNumberTextBox.Location = new Point(110, 70);
            mobileNumberTextBox.Name = "mobileNumberTextBox";
            mobileNumberTextBox.Size = new Size(185, 23);
            mobileNumberTextBox.TabIndex = 2;
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(110, 99);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(185, 23);
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
            addStudentButton.Size = new Size(283, 31);
            addStudentButton.TabIndex = 8;
            addStudentButton.Text = "Add Student";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // studentListBox
            // 
            studentListBox.FormattingEnabled = true;
            studentListBox.ItemHeight = 15;
            studentListBox.Location = new Point(12, 165);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(283, 274);
            studentListBox.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(studentListBox);
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
        private ListBox studentListBox;
    }
}
