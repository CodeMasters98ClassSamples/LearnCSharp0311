namespace LearnCSharp0311
{
    partial class MasterForm
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
            AddMasterButton = new Button();
            label1 = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // AddMasterButton
            // 
            AddMasterButton.Location = new Point(12, 87);
            AddMasterButton.Name = "AddMasterButton";
            AddMasterButton.Size = new Size(263, 34);
            AddMasterButton.TabIndex = 0;
            AddMasterButton.Text = "Add Master";
            AddMasterButton.UseVisualStyleBackColor = true;
            AddMasterButton.Click += AddMasterButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "FirstName";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(90, 16);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(185, 23);
            firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(90, 49);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(185, 23);
            lastNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 52);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "LastName";
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lastNameTextBox);
            Controls.Add(label2);
            Controls.Add(firstNameTextBox);
            Controls.Add(label1);
            Controls.Add(AddMasterButton);
            Name = "MasterForm";
            Text = "MasterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddMasterButton;
        private Label label1;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Label label2;
    }
}