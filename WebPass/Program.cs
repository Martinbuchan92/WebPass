using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebPass
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Clippy a = new Clippy();
            a.StartPosition = FormStartPosition.Manual;
            a.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - a.Width,
                                   Screen.PrimaryScreen.WorkingArea.Height - a.Height);
            Application.Run(a);
        }
    }
}
