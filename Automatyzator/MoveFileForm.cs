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
    public partial class MoveFileForm : Form
    {
        public delegate void MoveFileHandler(string sourcePath, string destinationPath);
        public event MoveFileHandler OnMoveFileConfirmed;
        public MoveFileForm()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSourcePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDestinationPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
{
    if (string.IsNullOrEmpty(txtSourcePath.Text) || string.IsNullOrEmpty(txtDestinationPath.Text))
    {
        MessageBox.Show("Proszę wybrać zarówno plik źródłowy, jak i folder docelowy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    
    this.DialogResult = DialogResult.OK;
    this.Close();
}

    }
}
