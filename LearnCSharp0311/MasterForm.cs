﻿using BaseBackend.Businesses;
using BaseBackend.Entities;

namespace LearnCSharp0311
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void AddMasterButton_Click(object sender, EventArgs e)
        {
            Master master = new Master()
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
            };
            MasterBusiness masterBusiness = new MasterBusiness();
        }
    }
}
