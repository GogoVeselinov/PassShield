using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassShield
{
    public partial class MainForm : Form
    {
        // Boolean variable to track whether passwords should be shown or hidden
        bool show = false;

        // Constructor for the MainAtomForm class
        public MainForm()
        {
            // Initialize the form components
            InitializeComponent();
        }

        // Event handler for when the form is loaded
        private void MainAtomForm_Load(object sender, EventArgs e)
        {
            // Set the text boxes to display the saved password settings
            charactersPasswordTextBox.Text = Properties.Settings.Default.PasswordCharacter;
            lengthPasswordTextBox.Text = Properties.Settings.Default.PasswordLength.ToString();

            // Configure the ListView control
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            // Add columns to the ListView control
            listView1.Columns.Add("Акаунт", 143, HorizontalAlignment.Left);
            listView1.Columns.Add("Парола", 122, HorizontalAlignment.Left);
            listView1.Columns.Add("Сайт", 136, HorizontalAlignment.Left);
            listView1.Columns.Add("Записки", 198, HorizontalAlignment.Left);

            // Refresh the list with the current visibility settings for passwords
            RefreshList(show);
        }

        // Event handler for when the "Show passwords" button is clicked
        private void HideColumnPass_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of passwords based on the button text
            if (hidePassword.Text == "  Show passwords")
            {
                show = true;
                hidePassword.Text = "  Hide passwords";
            }
            else
            {
                show = false;
                hidePassword.Text = "  Show passwords";
            }
            // Refresh the list with the updated visibility settings
            RefreshList(show);
        }

        // Method to refresh the ListView control with password visibility settings
        private void RefreshList(bool replace_password)
        {
            // Clear the items in the ListView control
            listView1.Items.Clear();

            // Iterate through each Cont object and add its properties to the ListView
            foreach (Account current_account in Account.Auditors)
            {
                string password;
                // Replace the password with asterisks if required
                if (replace_password)
                    password = current_account.password;
                else
                    password = "************";

                // Create a ListViewItem with the Cont object's properties
                ListViewItem Date = new ListViewItem(new string[] { current_account.email,
                                                                password,
                                                                current_account.site,
                                                                current_account.note,
                                                                });
                // Set the ListViewItem's tag to the password for clipboard functionality
                Date.Tag = current_account.password;
                // Add the ListViewItem to the ListView control
                listView1.Items.Add(Date);
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update text boxes with selected item's information
            if (listView1.SelectedItems.Count == 0)
            {
                loginBox.Text = passBox.Text = siteBox.Text = noteBox.Text = "";
                return;
            }
            else
            {
                loginBox.Text = listView1.SelectedItems[0].SubItems[0].Text;
                passBox.Text = listView1.SelectedItems[0].Tag.ToString();
                siteBox.Text = listView1.SelectedItems[0].SubItems[2].Text;
                noteBox.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
        }

        public async void SetClipboardPw()
        {
            // Set password to clipboard and clear it after a delay
            if (listView1.SelectedItems.Count != 0)
            {
                Clipboard.SetText(listView1.SelectedItems[0].Tag.ToString());
                await Task.Delay(TimeSpan.FromSeconds(PasswordManager.SecondDeletePassword));
                Clipboard.Clear();
            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            // Copy password to clipboard when Ctrl+C is pressed
            if (e.Control && e.KeyCode == Keys.C)
                SetClipboardPw();
        }

        private void charactersPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            // Update allowed characters for password generation
            if (lengthPasswordTextBox.Text.Length == 0)
                return;
            PasswordManager.CharactersAllowed = charactersPasswordTextBox.Text;
        }

        private void lengthPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            // Update password length setting
            if (lengthPasswordTextBox.Text.Length == 0)
                return;
            try
            {
                PasswordManager.PasswordLength = Int32.Parse(lengthPasswordTextBox.Text);
                if (PasswordManager.PasswordLength > 1000 || PasswordManager.PasswordLength < 1)
                    throw new Exception("Дължината на паролата не е валидна!");
            }
            catch { MessageBox.Show("Моля въведете правилно число!"); lengthPasswordTextBox.Text = ""; PasswordManager.PasswordLength = Properties.Settings.Default.PasswordLength; }
        }

        // Copy password to clipboard when an item in the list view is double-clicked
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SetClipboardPw();
        }

        // Generate a random password of specified length and display it in the password text box
        private void genButton_Click_1(object sender, EventArgs e)
        {
            passBox.Text = PasswordManager.RandomString(PasswordManager.PasswordLength);
        }

        // Toggle between showing and hiding the password characters in the password text box
        private void ShowPass_Click_1(object sender, EventArgs e)
        {
            if (passBox.PasswordChar == '●')
            {
                passBox.PasswordChar = '\0';
            }
            else if (passBox.PasswordChar == '\0')
            {
                passBox.PasswordChar = '●';
            }
        }

        // Save changes to passwords and settings when the "Save Changes" button is clicked
        private void saveChanges_Click(object sender, EventArgs e)
        {
            PasswordManager.SavePasswords(PasswordManager.Directory, PasswordManager.MainPassword);
            Properties.Settings.Default.PasswordCharacter = PasswordManager.CharactersAllowed;
            Properties.Settings.Default.PasswordLength = PasswordManager.PasswordLength;
            Properties.Settings.Default.Save();
        }

        // Calculate the strength of the password and update the complexity bar
        private void button2_Click(object sender, EventArgs e)
        {
            int strength = 0;
            if (passBox.Text.Length >= 4)
                strength += 10;
            if (passBox.Text.Length >= 8)
                strength += 10;
            if (passBox.Text.IndexOfAny("abcdefghijklmnopqrstuvwxyz".ToCharArray()) >= 0)
                strength += 15;
            if (passBox.Text.IndexOfAny("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()) >= 0)
                strength += 15;
            if (passBox.Text.IndexOfAny("0123456789".ToCharArray()) >= 0)
                strength += 25;
            if (passBox.Text.IndexOfAny("!@#$%^&*()_-=+;[]{}:.,<>/?".ToCharArray()) >= 0)
                strength += 25;
            complexBar.Value = strength;
            complexLabel.Text = $"Complexity ({strength}/100):";
            strength = 0;
        }

        // Open the form for changing the main password
        private void ChangePassword_Click(object sender, EventArgs e)
        {
            var Change = new ChangePasswordForm();
            Change.Show();
        }

        // Toggle between showing and hiding passwords in the list view
        private void HidePassword_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of passwords based on the button text
            if (hidePassword.Text == "  Покажи парола ")
            {
                show = true;
                hidePassword.Text = "  Скрий парола ";
            }
            else
            {
                show = false;
                hidePassword.Text = "  Покажи парола ";
            }
            // Refresh the list with the updated visibility settings
            RefreshList(show);
        }

        // Replace the selected item's information with new data entered in text boxes
        private void replaceButton_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Моля изберете акаунт, който искате да редактирате!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Account.Auditors.RemoveAt(listView1.SelectedItems[0].Index);
            string login = loginBox.Text;
            string parola = passBox.Text;
            string site = siteBox.Text;
            string notita = noteBox.Text;
            Account.Auditors.Insert(listView1.SelectedItems[0].Index, new Account(login, parola, site, notita));
            RefreshList(show);
            loginBox.Text = passBox.Text = siteBox.Text = noteBox.Text = "";
        }

        // Delete the selected item from the list view and update the display
        private void delButton_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Моля изберете акаунт, който искате да редактирате!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult res = MessageBox.Show("Сигурни ли сте, че искате да изтриете данните?", "Потвърдете изтриване", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Account.Auditors.RemoveAt(listView1.SelectedItems[0].Index);
                RefreshList(show);
                loginBox.Text = passBox.Text = siteBox.Text = noteBox.Text = "";
            }
        }

        // Add a new item with entered data to the list view
        private void addButton_Click_1(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passBox.Text;
            string site = siteBox.Text;
            string note = noteBox.Text;
            if (login == "" && password == "" && site == "" && note == "")
            {
                MessageBox.Show("Моля попълнете всички редове!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Account.Auditors.Add(new Account(login, password, site, note));
            RefreshList(show);
            loginBox.Text = passBox.Text = siteBox.Text = noteBox.Text = "";
        }
        private void HelpButton_Click(object sender, EventArgs e)
        {
            {
                // Пътят до PDF файла
                ProcessStartInfo psInfo = new ProcessStartInfo
                {
                    FileName = "https://drive.google.com/file/d/1MTLvDUgJHpUrqAElZWzQW5h6nPzkytru/view?usp=sharing",
                    UseShellExecute = true
                };
                Process.Start(psInfo);
            }
        }
    }
}
