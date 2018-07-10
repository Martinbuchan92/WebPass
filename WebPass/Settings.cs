using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace WebPass
{
    public partial class Settings : Form
    {
        public OpenFileDialog file;
        List<ItemInfo> items;
        ItemInfo selectedItem;

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
            foreach (ItemInfo thing in items)
            {
                if (thing.Position1 == ItemInfo.Position.dropDownOne || thing.Position1 == ItemInfo.Position.dropDownTwo)
                {
                    if (!CmbItemSelect.Items.Contains(thing.Position1))
                    {
                        CmbItemSelect.Items.Add(thing.Position1);
                    }
                }
                else
                {
                    CmbItemSelect.Items.Add(thing.Position1);
                }
            }
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
           selectedItem = ItemInfo.Details_From_Position(CmbItemSelect.SelectedItem.ToString(), 0, items);
            CmbItemSelect2.Items.Clear();
            foreach (ItemInfo thing in items)
            {
                if (selectedItem.Position1 == thing.Position1)
                {
                    CmbItemSelect2.Items.Add(thing.Location);
                }
            }

            FillSettingsForm(selectedItem);
        }

        private void CmbItemSelect2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = ItemInfo.Details_From_Position(CmbItemSelect.SelectedItem.ToString(), int.Parse(CmbItemSelect2.SelectedItem.ToString()), items);

            FillSettingsForm(selectedItem);
        }

        private void FillSettingsForm(ItemInfo selectedItem)
        {
            if (selectedItem.Type1 == ItemInfo.Type.Clip)
            {
                clearboxes();
                rbClipboard.Checked = true;
                txtClipboard.Text = selectedItem.Detail;
                txtName.Text = selectedItem.Name;
            }
            else if (selectedItem.Type1 == ItemInfo.Type.File)
            {
                clearboxes();
                rbOpenFile.Checked = true;
                txtFilePath.Text = selectedItem.Detail;
                txtName.Text = selectedItem.Name;
            }
            else if (selectedItem.Type1 == ItemInfo.Type.Program)
            {
                clearboxes();
                rbOpenSoftware.Checked = true;
                txtProgramPath.Text = selectedItem.Detail;
                txtName.Text = selectedItem.Name;
            }
        }

        private ItemInfo.Type ReturnType()
        {
            if (rbClipboard.Checked)
            {
                return ItemInfo.Type.Clip;
            }
            else if(rbOpenFile.Checked)
            {
                return ItemInfo.Type.File;
            }
            else
            {
                return ItemInfo.Type.Program;
            }
        }

        private String UpdateData(ItemInfo.Type type)
        {
            if (type == ItemInfo.Type.Clip)
            {
                return txtClipboard.Text;
            }else if (type == ItemInfo.Type.File)
            {
                return txtFilePath.Text;
            }else
                return txtProgramPath.Text;
        }

        private void clearboxes()
        {
            txtClipboard.Text = "";
            txtFilePath.Text = "";
            txtProgramPath.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            selectedItem.Name = txtName.Text;
            selectedItem.Type1 = ReturnType();
            selectedItem.Detail = UpdateData(ReturnType());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();           
        }
    }
}
