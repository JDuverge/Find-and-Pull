using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FindAndPull
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Check check;
            DialogResult res = DialogResult.Retry;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (res == DialogResult.Retry)
            {
                using (check = new Check())
                {
                    res = check.ShowDialog();
                    if (res == DialogResult.Yes)
                    {
                        Application.Run(new mainForm());
                    }
                }
            }
        }
    }
}
