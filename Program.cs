using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassShield
{
    static class Program
    {
        // Flag to indicate if the correct password was entered
        public static bool CorrectPassword = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable visual styles for the application
            Application.EnableVisualStyles();

            // Set default text rendering for the application
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the main form (Form1)
            Application.Run(new Form1());

            // If the correct password was entered, run the main application form (MainAtomForm)
            if (CorrectPassword)
                Application.Run(new MainForm());
        }
    }
}
