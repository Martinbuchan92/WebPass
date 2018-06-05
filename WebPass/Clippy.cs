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

        private String CDKey;
        private String SQL;
        private String RBS;
        private String CCLeaner;
        private String RegAdd;
        private String Community;
        private String Pro;
        private String ProPlus;
        private String NoBackupHeader;
        private String NoBackup;
        private String ZeroMBHeader;
        private String ZeroMB;
        private String Permissions;

        private bool more = false;
        List<itemInfo> items = ClippyIO.Data_Load(path + "workstuff2.csv");

        public Clippy()
        {
            InitializeComponent();
            MouseDown += Clippy_MouseDown;

            
            if (items[0].Type1 == itemInfo.Type.Clip)
            {
                button1.Click += new EventHandler(this.MyButtonHandler);
            }
        }

        void MyButtonHandler(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Name = items[0].Name;
            if (items[0].Type1 == itemInfo.Type.Clip)
            {

            }else if(items[0].Type1 == itemInfo.Type.File)
            {

            }else if(items[0].Type1 == itemInfo.Type.File)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CDKey);
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SQL);

        }

        private void btnRBS_Click(object sender, EventArgs e)
        {
           Clipboard.SetText(RBS);

        }

        private void btnCCleaner_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CCLeaner);

        }

        private void btnRegAdd_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RegAdd);

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
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



        private void Clippy_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(path + "workstuff.csv"))
            {
                List<string> information = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');


                    information.Add(values[1]);
                }

                CDKey = information[0];
                SQL = information[1];
                RBS = information[2];
                CCLeaner = information[3];
                RegAdd = information[4];
                Community = information[5];
                Pro = information[6];
                ProPlus = information[7];
                NoBackupHeader = information[8];
                NoBackup = information[9];
                ZeroMBHeader = information[10];
                ZeroMB = information[11];
                Permissions = information[12];
            }
        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
{
                int value = cmbVersion.SelectedIndex;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = comboBox1.SelectedIndex;
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
