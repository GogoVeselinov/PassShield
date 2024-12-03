using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace PassShield
{
    class Encryption
    {
        // AES encryption method
        public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            // Salt bytes for key derivation - adds randomness to the encryption process
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            // MemoryStream to hold encrypted data temporarily
            using (MemoryStream ms = new MemoryStream())
            {
                // RijndaelManaged provides the AES encryption functionality
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256; // Key size in bits (256 bits = 32 bytes for AES)
                    AES.BlockSize = 128; // Block size in bits (128 bits = 16 bytes)

                    // Key and IV derivation using PBKDF2 (Password-Based Key Derivation Function 2)
                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8); // Generate the encryption key
                    AES.IV = key.GetBytes(AES.BlockSize / 8); // Generate the initialization vector (IV)

                    AES.Mode = CipherMode.CBC; // Cipher mode: Cipher Block Chaining (CBC)

                    // Encrypt the input bytes
                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length); // Write the input data to the CryptoStream
                        cs.Close(); // Close the stream to flush the final block
                    }

                    // Retrieve the encrypted bytes from the MemoryStream
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        // AES decryption method
        public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            // Salt bytes for key derivation
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            // MemoryStream to hold decrypted data temporarily
            using (MemoryStream ms = new MemoryStream())
            {
                // RijndaelManaged provides the AES decryption functionality
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256; // Key size in bits
                    AES.BlockSize = 128; // Block size in bits

                    // Key and IV derivation using PBKDF2
                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8); // Generate the decryption key
                    AES.IV = key.GetBytes(AES.BlockSize / 8); // Generate the initialization vector (IV)

                    AES.Mode = CipherMode.CBC; // Cipher mode: Cipher Block Chaining (CBC)

                    // Decrypt the input bytes
                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length); // Write the encrypted data to the CryptoStream
                        cs.Close(); // Close the stream to flush the final block
                    }

                    // Retrieve the decrypted bytes from the MemoryStream
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }

        // Method to encrypt a file
        public static void EncryptFile(string file, string password)
        {
            // Read the content of the file as a byte array
            byte[] bytesToBeEncrypted = File.ReadAllBytes(file);

            // Convert the password to a byte array
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password using SHA256 to produce a fixed-size key
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            // Encrypt the file content
            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            // Overwrite the original file with the encrypted data
            File.WriteAllBytes(file, bytesEncrypted);
        }

        // Method to decrypt a file
        public static void DecryptFile(string file, string password)
        {
            // Read the content of the encrypted file as a byte array
            byte[] bytesToBeDecrypted = File.ReadAllBytes(file);

            // Convert the password to a byte array
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password using SHA256 to produce a fixed-size key
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            // Decrypt the file content
            byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

            // Overwrite the original file with the decrypted data
            File.WriteAllBytes(file, bytesDecrypted);

            // Rename the file with a new extension to indicate decryption
            string extension = Path.GetExtension(file); // Get the current file extension
            string result = file.Substring(0, file.Length - extension.Length); // Remove the current extension
            File.Move(file, result + PasswordManager.Extension); // Add the new extension
        }
    }
}
