using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassShield
{
    // Class representing an account
    class Account
    {
        // List to hold all accounts
        public static List<Account> Auditors = new List<Account>();

        // Properties of an account
        public string email;    // Email associated with the account
        public string password;   // Password for the account
        public string site;     // Website or service name
        public string note;   // Additional notes for the account

        // Constructor to initialize an account
        public Account(string _email, string _password, string _site, string _note)
        {
            this.email = _email;    // Initialize email
            this.password = _password;  // Initialize password
            this.site = _site;      // Initialize website or service name
            this.note = _note;  // Initialize additional notes
        }
    }
}
