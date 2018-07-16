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
        List<ItemInfo.Position> positions = new List<ItemInfo.Position>();

        public Clippy()
        {
            InitializeComponent();
        }

        private void Clippy_Load(object sender, EventArgs e)
        {
            Height = 27;
            Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - Width / 2, 0);
            MouseDown += Clippy_MouseDown;
            List<List<ItemInfo>> myList = ClippyIO.Data_Load(@"..\..\savefiles\workstuff2.csv");

            foreach (List<ItemInfo> sublist in myList)
            {
                foreach (ItemInfo thing in sublist)
                {
                    items.Add(thing);
                }
            }

            Populate_Combo();
            Button_namer("ButtonOne", ButtonOne);
            Button_namer("ButtonTwo", ButtonTwo);
            Button_namer("ButtonThree", ButtonThree);
            Button_namer("ButtonFour", ButtonFour);
            Button_namer("ButtonFive", ButtonFive);
            Button_namer("ButtonSix", ButtonSix);
            Button_namer("ButtonSeven", ButtonSeven);
            Button_namer("ButtonEight", ButtonEight);
            Button_namer("ButtonNine", ButtonNine);
            Button_namer("ButtonTen", ButtonTen);
        }

        public void Button_namer(String btnName, Button selectedBtn)
        {
            foreach (ItemInfo thing in items)
            {
                if (thing.Position1.ToString().Equals(btnName))
                {
                    ToolTip test = new ToolTip();
                    selectedBtn.Text = thing.Name;
                    test.SetToolTip(selectedBtn, thing.Detail);
                }
            }
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
                    //don't add item to anything
                }
            }
        }

        void MyButtonHandler(object sender, EventArgs e)
        {
            String selectedPosition = ((Button)sender).Name.ToString();
            ItemInfo selectedItem = ItemInfo.Details_From_Position(selectedPosition, 0, items);

            if (selectedItem.Type1 == ItemInfo.Type.File)
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
                try
                {
                    Clipboard.SetText(selectedItem.Detail);
                }
                catch
                {

                }
            }
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            ClippyIO.Data_Save(items, path + "workstuff2.csv");
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings setting = new Settings(items);
            setting.Show();
        }

        private void btnMore_Click(object sender, EventArgs e)
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

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox changedComboBox = (ComboBox)sender;
            try
            {
                String retrievedDetails = ItemInfo.Return_Details(changedComboBox.SelectedItem.ToString(), items);
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
    }
}