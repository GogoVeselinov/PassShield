using System;
using System.Windows.Forms;

namespace PassShield
{
    // This class represents the main form for entering the master password.
    public partial class MainPasswordForm : Form
    {
        // Variable to hold the title of the form.
        public string title = "";

        // Constructor for the MainPasswordForm class.
        public MainPasswordForm()
        {
            InitializeComponent();
        }

        // Event handler for the toggle button to show/hide password.
        private void pwToggleButton_Click(object sender, EventArgs e)
        {
            // Check if the password textbox is currently showing password characters.
            if (PasswordTextBox.UseSystemPasswordChar)
            {
                PasswordTextBox.UseSystemPasswordChar = true; // Hide password characters.
            }
            
        }

        // Event handler for form load event.
        private void MainPasswordForm_Load(object sender, EventArgs e)
        {
            this.Text = title; // Set the title of the form.
        }

        // Event handler for OK button click event.
        private void okButton_Click_1(object sender, EventArgs e)
        {
            // Check if the password textbox is empty.
            if (PasswordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Моля въведете вашата парола!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show message box indicating that password is required.
                return; // Exit method.
            }
            PasswordManager.MainPassword = PasswordTextBox.Text; // Set the master password.
            this.Close(); // Close the form.
        }

        private void ShowPass_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.PasswordChar == '●')
            {
                PasswordTextBox.PasswordChar = '\0';
            }
            else if (PasswordTextBox.PasswordChar == '\0')
            {
                PasswordTextBox.PasswordChar = '●';
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
