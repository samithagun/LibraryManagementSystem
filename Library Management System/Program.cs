using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Library_Management_System
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCategory());
        }
    }
}
