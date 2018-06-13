using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebPass
{
    public partial class Settings : Form
    {
        public OpenFileDialog file;
        List<ItemInfo> items;

        public Settings()
        {
            InitializeComponent();
        }

        public Settings(List<ItemInfo> items) : this()
        {
            this.items = items;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void rbClipboard_CheckedChanged(object sender, EventArgs e)
        {
            toggleSelection(0);
        }

        private void rbOpenFile_CheckedChanged(object sender, EventArgs e)
        {
            toggleSelection(1);
        }

        private void rbOpenSoftware_CheckedChanged(object sender, EventArgs e)
        {
            toggleSelection(2);
        }

        private void toggleSelection(int selected)
        {
            switch (selected)
            {
                case 0:
                    txtClipboard.Enabled = true;
                    txtFilePath.Enabled = false;
                    txtProgramPath.Enabled = false;
                    break;
                case 1:
                    txtClipboard.Enabled = false;
                    txtFilePath.Enabled = true;
                    txtProgramPath.Enabled = false;
                    break;
                case 2:
                    txtClipboard.Enabled = false;
                    txtFilePath.Enabled = false;
                    txtProgramPath.Enabled = true;
                    break;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = file.SafeFileName;
            }
        }

        private void CmbItemSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
           ItemInfo selectedItem = ItemInfo.Details_From_Position(CmbItemSelect.SelectedItem.ToString(), items);
           FillSettingsForm(selectedItem);
        }

        private void FillSettingsForm(ItemInfo selectedItem)
        {
            if(selectedItem.Type1 == ItemInfo.Type.Clip)
            {
                rbClipboard.Select();
            }else if(selectedItem.Type1 == ItemInfo.Type.File)
            {

            }else if(selectedItem.Type1 == ItemInfo.Type.Program)
            {

            }
        }
    }
}
