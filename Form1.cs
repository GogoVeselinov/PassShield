using System;
using System.Windows.Forms;

namespace PassShield
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Initialize form components.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Select(); // Set focus to label1 when form loads.
        }

        private void create_Click_1(object sender, System.EventArgs e)
        {
            // Create a new instance of MainPasswordForm for creating a master password.
            MainPasswordForm PasswordForm = new MainPasswordForm();
            PasswordForm.title = "Създайте главна парола:"; // Set the title for the password form.
            PasswordForm.ShowDialog(); // Show the password form as a dialog.

            // If the master password is not set, return.
            if (PasswordManager.MainPassword.Length == 0)
            {
                return;
            }

            // Add example passwords.
            PasswordManager.AdaugaExemple(1);

            // Create a SaveFileDialog for saving passwords.
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Set filters and default extension for the save file dialog.
            saveFileDialog.Filter = $"{PasswordManager.ProgramName} files |*{PasswordManager.Extension}";
            saveFileDialog.DefaultExt = PasswordManager.Extension;
            saveFileDialog.AddExtension = true;
            saveFileDialog.RestoreDirectory = true;

            // If user chooses to save the file, save the passwords.
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                PasswordManager.SavePasswords(saveFileDialog.FileName, PasswordManager.MainPassword);
        }

        private void load_Click_1(object sender, EventArgs e)
        {
            // Create an OpenFileDialog for opening password files.
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filters and restore directory for the open file dialog.
            openFileDialog.Filter = $"{PasswordManager.ProgramName} files |*{PasswordManager.Extension}";
            openFileDialog.RestoreDirectory = true;

            // If user cancels the file selection, return.
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // Set the location of the password file.
            PasswordManager.Directory = openFileDialog.FileName;

            // Create a new instance of MainPasswordForm for entering the master password.
            MainPasswordForm PasswordForm = new MainPasswordForm();
            PasswordForm.title = "Въведете вашата главна парола:"; // Set the title for the password form.
            PasswordForm.ShowDialog(); // Show the password form as a dialog.

            // If the master password is not set, return.
            if (PasswordManager.MainPassword.Length == 0)
            {
                return;
            }

            // If reading accounts from the file is successful, close the form and set CorrectPassword to true.
            if (PasswordManager.ReadAccounts(PasswordManager.Directory, PasswordManager.MainPassword))
            {
                this.Close();
                Program.CorrectPassword = true;
            }
            else
            {
                // If the entered password is wrong, show a warning message.
                if (PasswordManager.MainPassword.Length != 0)
                    MessageBox.Show("Паролата е грешна!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
