using Siticone.Desktop.UI.WinForms;
using System;
using System.Windows.Forms;

namespace PassShield
{
    // Form class for changing the password
    public partial class ChangePasswordForm : Form
    {
        // Constructor
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        // Event handler for the password toggle button click
      

        // Method to toggle the visibility of password fields
        private void Toggle(bool ok)
        {
            OldPassBox.UseSystemPasswordChar = ok;
            NewPassBox.UseSystemPasswordChar = ok;
            CNewPassBox.UseSystemPasswordChar = ok;
        }

        // Event handler for the OK button click
        private void okButton_Click_1(object sender, EventArgs e)
        {
            // Check if the new passwords match and if all fields are filled
            if (NewPassBox.Text != CNewPassBox.Text)
                MessageBox.Show("Паролата е грешна на поне един ред!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (OldPassBox.Text == "" || NewPassBox.Text == "" || CNewPassBox.Text == "")
                MessageBox.Show("Един или повече реда са празни!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Check if the old password matches the stored main password
            else if (OldPassBox.Text != PasswordManager.MainPassword)
                MessageBox.Show("Старата парола е грешна!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // Save the new password and update the main password
                PasswordManager.SavePasswords(PasswordManager.Directory, NewPassBox.Text);
                PasswordManager.MainPassword = NewPassBox.Text;
                MessageBox.Show("Паролата беше променена успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Close the form
                this.Close();
            }
        }

        // Toggle between showing and hiding the password characters in the password text 
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (OldPassBox.PasswordChar == '●' && NewPassBox.PasswordChar== '●' && CNewPassBox.PasswordChar == '●')
            {
                OldPassBox.PasswordChar = '\0';
                NewPassBox.PasswordChar = '\0';
                CNewPassBox.PasswordChar = '\0';
            }
            else if (OldPassBox.PasswordChar == '\0' && NewPassBox.PasswordChar == '\0' && CNewPassBox.PasswordChar == '\0')
            {
                OldPassBox.PasswordChar = '●';
                NewPassBox.PasswordChar = '●';
                CNewPassBox.PasswordChar = '●';
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CNewPassBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
