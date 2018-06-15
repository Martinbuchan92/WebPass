using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WebPass
{
    public partial class Clippy : Form
    {
        private const String path = @"..\..\savefiles\";
        private bool more = false;
        List<ItemInfo> items = new List<ItemInfo>();

        public Clippy()
        {
            InitializeComponent();
            MouseDown += Clippy_MouseDown;
        }

        public Clippy(List<List<ItemInfo>> myList) : this()
        {
            foreach (List<ItemInfo> sublist in myList)
            {
                foreach(ItemInfo thing in sublist)
                {
                    items.Add(thing);
                }
            }
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

        void MyButtonHandler(String selectedPosition)
        {
            ItemInfo selectedItem = ItemInfo.Details_From_Position(selectedPosition, items);

            if (selectedItem.Type1 == ItemInfo.Type.Clip)
            {
                try
                {
                    Clipboard.SetText(selectedItem.Detail);
                }
                catch
                {

                }
            }
            else if (selectedItem.Type1 == ItemInfo.Type.File)
            {
                try
                {
                    Process.Start(selectedItem.Detail);
                }
                catch
                {

                }
            }
            else if (selectedItem.Type1 == ItemInfo.Type.Program)
            {
                try
                {
                    Process.Start(selectedItem.Detail);
                }
                catch
                {

                }
            }
            else
            {
                Clipboard.SetText(selectedItem.Detail);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MyButtonHandler(btn.Name.ToString());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MyButtonHandler(btn.Name.ToString());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MyButtonHandler(btn.Name.ToString());
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MyButtonHandler(btn.Name.ToString());
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MyButtonHandler(btn.Name.ToString());
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //ClippyIO.Data_Save(items, path + "workstuff2.csv");
            ClippyIO.Data_XML_Save(items, path + "saveDetails.xml");
            this.Close();
        }

        private void btnNotePad_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MyButtonHandler(btn.Name.ToString());
        }

        private void btnMedsPro_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MyButtonHandler(btn.Name.ToString());
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
            Settings setting = new Settings(items);
            setting.Show();
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            ClippyIO.Data_XML_Load(@"C:\Users\martin.buchan\source\repos\WebPass\WebPass\savefiles\saveDetails.xml");
        }
    }
}
