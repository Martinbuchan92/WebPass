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
        List<ItemInfo> items = ClippyIO.Data_Load(path + "workstuff2.csv");

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

        void MyButtonHandler(ItemInfo item)
        {
            if (item.Type1 == ItemInfo.Type.Clip)
            {
                try
                {
                    Clipboard.SetText(item.Detail);
                }
                catch
                {

                }
            }
            else if(item.Type1 == ItemInfo.Type.File)
            {
                try
                {
                    Process.Start(item.Detail);
                }
                catch
                {

                }
            }else
            {
                Clipboard.SetText(item.Detail);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText(CDKey);
            items[2].Detail = "AnotherPassword";
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Button2);

        }

        private void btnRBS_Click(object sender, EventArgs e)
        {
           Clipboard.SetText(items[2].Detail);

        }

        private void btnCCleaner_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Button10);

        }

        private void btnRegAdd_Click(object sender, EventArgs e)
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
                this.Size = new Size(this.Width, this.Height/2);
                more = false;
            }
                
        }

        private void cmbOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
{
                int value = cmbOne.SelectedIndex;
                switch (value)
                {
                    case 0:
                        Clipboard.SetText(Community);
                        break;
                    case 1:
                        Clipboard.SetText(Pro);
                        break;
                    case 2:
                        Clipboard.SetText(ProPlus);
                        break;

                }
           }
            catch (System.Runtime.InteropServices.ExternalException)
            {

            }
        }

        private void cmbTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = cmbTwo.SelectedIndex;
            switch (value)
            {
                case 0:
                    Clipboard.SetText(NoBackupHeader);
                    break;
                case 1:
                    Clipboard.SetText(NoBackup);
                    break;
                case 2:
                    Clipboard.SetText(ZeroMBHeader);
                    break;
                case 3:
                    Clipboard.SetText(ZeroMB);
                    break;
                case 4:
                    Clipboard.SetText(Permissions);
                    break;
            }
        }

        public void comboSetItems(String name, int comboBoxNumber)
        {
            if (comboBoxNumber == 1)
            {
                cmbOne.Items.Add(name);
            }
            else
            {
                cmbTwo.Items.Add(name);
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Clippy_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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
