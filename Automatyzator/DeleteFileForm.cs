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
    public partial class DeleteFileForm : Form
    {
        public string FilePath { get; private set; }

        public DeleteFileForm()
        {
            InitializeComponent();

            
            txtFilePath.Enabled = false; 
            chkManualPath.CheckedChanged += chkManualPath_CheckedChanged;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = openFileDialog.FileName;
                    txtFilePath.Text = FilePath;
                }
            }
        }

        private void chkManualPath_CheckedChanged(object sender, EventArgs e)
        {
            if (chkManualPath.Checked)
            {
                
                txtFilePath.Enabled = true;
                btnChooseFile.Enabled = false;
            }
            else
            {
                
                txtFilePath.Enabled = false;
                btnChooseFile.Enabled = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if (chkManualPath.Checked)
            {
                FilePath = txtFilePath.Text;
            }

            if (string.IsNullOrEmpty(FilePath))
            {
                MessageBox.Show("Proszę wybrać lub wpisać ścieżkę do pliku do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
