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
            List<List<ItemInfo>> things = ClippyIO.Data_Load(@"..\..\savefiles\workstuff2.csv");
            Clippy a = new Clippy(things);
            a.StartPosition = FormStartPosition.Manual;
            a.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width/2) - a.Width/2,
                                   0);
            a.Size = new Size(a.Width, a.Height / 2);
            Application.Run(a);

        }
    }
}
