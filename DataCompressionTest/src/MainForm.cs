using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataCompressionTest
{
    public partial class MainForm : Form
    {
        private byte[] dataBytes;
        private string fileName;

        public MainForm()
        {
            InitializeComponent();
            this.textBoxDirectoryPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
        }

        private void buttonInputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogInput = new OpenFileDialog();

            openFileDialogInput.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            //openFileDialogInput.Filter = "bin files (*.bin)|*.bin|hex files (*.hex)|*.hex|All files (*.*)|*.*";
            //openFileDialogInput.FilterIndex = 1;
            openFileDialogInput.RestoreDirectory = true;

            if (openFileDialogInput.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Stream myStream = openFileDialogInput.OpenFile())
                    {
                        if (myStream != null)
                        {
                            dataBytes = new byte[myStream.Length];

                            myStream.Read(dataBytes, 0, dataBytes.Length);

                            textBoxFilePath.Text = openFileDialogInput.FileName;

                            fileName = openFileDialogInput.SafeFileName;

                            buttonCode.Enabled = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

            }

        }

        private void buttonOutputDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
                this.textBoxDirectoryPath.Text = folderBrowserDialog1.SelectedPath + "\\";
        }

        private void buttonCode_Click(object sender, EventArgs e)
        {

        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {

        }
    }
}
