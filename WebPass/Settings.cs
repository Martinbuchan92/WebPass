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
        public Settings()
        {
            InitializeComponent();
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

    }
}
