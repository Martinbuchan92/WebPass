using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebPass
{
    public partial class Clippy : Form
    {
        private const String path = @"..\..\savefiles\";
        private bool more = false;
        List<ItemInfo> items; // = ClippyIO.Data_Load(path + "workstuff2.csv");

        //Button set 1
        private String Button1;
        private String Button2;
        private String Button3;
        private String Button4;
        private String Button5;

        //Main Dropdown        
        private String Community;
        private String Pro;
        private String ProPlus;

        //Button set 2
        private String Button6;
        private String Button7;
        private String Button8;
        private String Button9;
        private String Button10;

        //Second Dropdown
        private String NoBackupHeader;
        private String NoBackup;
        private String ZeroMBHeader;
        private String ZeroMB;
        private String Permissions;

        public Clippy()
        {
            InitializeComponent();
            MouseDown += Clippy_MouseDown;
        }

        public Clippy(List<ItemInfo> items) : this()
        {
            this.items = items;
            Populate_Combo();
        }

        private void Populate_Combo()
        {
            foreach (ItemInfo thing in items)
            {
                if (thing.Position1 == ItemInfo.Position.dropDownOne)
                {
                    cmbOne.Items.Add(thing.Name);

                }
                else if (thing.Position1 == ItemInfo.Position.dropDownTwo)
                {
                    cmbTwo.Items.Add(thing.Name);
                }
                else
                {

                }
            }
        }

        void MyButtonHandler()
        {
            //if (item.Type1 == ItemInfo.Type.Clip)
            //{
            //    try
            //    {
            //        Clipboard.SetText(item.Detail);
            //    }
            //    catch
            //    {

            //    }
            //}
            //else if (item.Type1 == ItemInfo.Type.File)
            //{
            //    try
            //    {
            //        Process.Start(item.Detail);
            //    }
            //    catch
            //    {

            //    }
            //}
            //else
            //{
            //    Clipboard.SetText(item.Detail);
            //}
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (sender.Equals(btn.Equals( ItemInfo.Return_Details("CD key", items))))
            {
                Console.WriteLine("Correct" + sender.ToString());
            }
            else
                Console.WriteLine("WRONG" + sender.ToString());

            MyButtonHandler();
            //Clipboard.SetText("");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
           // Clipboard.SetText(Button2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(items[2].Detail);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Button10);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Button5);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            ClippyIO.Data_Save(items, path + "workstuff2.csv");
            this.Close();
        }

        private void btnNotePad_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Notepad++\notepad++");
        }

        private void btnMedsPro_Click(object sender, EventArgs e)
        {
            Process.Start(@"S:\Core Team\MedsPro");
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            if (more == false)
            {
                this.Size = new Size(this.Width, 54);
                more = true;
            }
            else
            {
                this.Size = new Size(this.Width, this.Height / 2);
                more = false;
            }

        }

        private void cmbOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String retrievedDetails = ItemInfo.Return_Details(cmbOne.SelectedItem.ToString(), items);
                Clipboard.SetText(retrievedDetails);
            }
            catch (System.Runtime.InteropServices.ExternalException)
            {

            }
        }

        private void cmbTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String retrievedDetails = ItemInfo.Return_Details(cmbTwo.SelectedItem.ToString(), items);
                Clipboard.SetText(retrievedDetails);
            }
            catch (System.Runtime.InteropServices.ExternalException)
            {

            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Clippy_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings setting = new Settings();
            setting.Show();
        }
    }
}
