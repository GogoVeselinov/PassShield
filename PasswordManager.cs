using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace PassShield
{
    class PasswordManager
    {
        // Static random object for generating random numbers
        public static Random rand = new Random();

        // Master password
        public static string MainPassword = "";

        // File extension for encrypted password files
        public static string Extension = ".ps";

        // Program name
        public static string ProgramName = "PassShield";

        // File location
        public static string Directory = "";

        // Length of generated passwords
        public static int PasswordLength = Properties.Settings.Default.PasswordLength;

        // Time after which password is deleted (in seconds)
        public static int SecondDeletePassword = 5;

        // Method to save passwords to a file
        public static void SavePasswords(string path, string pass)
        {
            // Serialize account list to JSON
            string json = JsonConvert.SerializeObject(Account.Auditors);
            // Write JSON to file
            File.WriteAllText(path, json);
            // Encrypt the file
            Encryption.EncryptFile(path, pass);
        }

        // Method to read accounts from a file
        public static bool ReadAccounts(string path, string password)
        {
            // Temporary variable to store permitted characters
            var bkCharactersAllowed = CharactersAllowed;
            CharactersAllowed = "ABCDEFHIJKLMNOPQRSTUVWXYZ1234567890";

            // Create a temporary file path
            string tempFilePath = Path.GetTempPath() + $"atomtemp{RandomString(8)}.ps";
            CharactersAllowed = bkCharactersAllowed;

            // Copy the encrypted file to temporary location
            File.Copy(path, tempFilePath);

            try
            {
                // Decrypt the temporary file
                Encryption.DecryptFile(tempFilePath, MainPassword);

                // Read decrypted file content
                string convertMe = File.ReadAllText(tempFilePath);
                // Delete the temporary file
                File.Delete(tempFilePath);
                // Deserialize JSON to list of accounts
                Account.Auditors = JsonConvert.DeserializeObject<List<Account>>(convertMe);
            }
            catch
            {
                // Delete the temporary file if decryption fails
                if (File.Exists(tempFilePath))
                    File.Delete(tempFilePath);
                return false;
            }
            return true;
        }

        // Method to add example accounts
        public static void AdaugaExemple(int nr)
        {
            for (int i = 0; i < nr; i++)
            {
                Account.Auditors.Add(new Account($"email{i}", RandomString(PasswordLength), $"site{i}", "Example Account"));
            }
        }

        // Permitted characters for generating passwords
        public static string CharactersAllowed = Properties.Settings.Default.PasswordCharacter;

        // Method to generate a random string of specified length
        public static string RandomString(int length)
        {
            StringBuilder res = new StringBuilder();

            int randomInteger = rand.Next(0, CharactersAllowed.Length);
            while (0 < length--)
            {
                res.Append(CharactersAllowed[randomInteger]);
                randomInteger = rand.Next(0, CharactersAllowed.Length);
            }
            return res.ToString();
        }
    }
}
