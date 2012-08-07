using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplicationRemote
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // TODO. ToDo Uno.
            Application.EnableVisualStyles();

            // TODO. ToDo Dos.
            Application.SetCompatibleTextRenderingDefault(false);

            // TODO. ToDo Tres.
            Application.Run(new Form1());
        }
    }
}
