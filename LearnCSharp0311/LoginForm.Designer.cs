namespace LearnCSharp0311
{
    partial class LoginForm
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
            firstNameLabel = new Label();
            usernameTextBox = new TextBox();
            label1 = new Label();
            passwordTextBox = new TextBox();
            addStudentButton = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(15, 15);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(63, 15);
            firstNameLabel.TabIndex = 6;
            firstNameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(105, 12);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(185, 23);
            usernameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 53);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 8;
            label1.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(105, 50);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(185, 23);
            passwordTextBox.TabIndex = 7;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(12, 89);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(283, 31);
            addStudentButton.TabIndex = 9;
            addStudentButton.Text = "Login";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 136);
            Controls.Add(addStudentButton);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(usernameTextBox);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox usernameTextBox;
        private Label label1;
        private TextBox passwordTextBox;
        private Button addStudentButton;
    }
}