using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatyzator
{
    public partial class CopyFileForm : Form
    {
        public string SourcePath { get; private set; }
        public string DestinationPath { get; private set; }
        public CopyFileForm()
        {
            InitializeComponent();
        }

        private void btnChooseSourceFolder_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SourcePath = openFileDialog.FileName;
                    txtSourcePath.Text = SourcePath;
                }
            }

        }

        private void btnChooseDestinationFolder_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    DestinationPath = folderBrowserDialog.SelectedPath;
                    txtDestinationPath.Text = DestinationPath;
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSourcePath.Text) || string.IsNullOrEmpty(txtDestinationPath.Text))
            {
                MessageBox.Show("Proszę wybrać zarówno plik źródłowy, jak i lokalizację docelową.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SourcePath = txtSourcePath.Text;
            DestinationPath = txtDestinationPath.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
