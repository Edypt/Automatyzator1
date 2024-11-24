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
    public partial class CreateDirectoryForm : Form
    {
        public string DirectoryPath { get; private set; }
        public string DirectoryName { get; private set; }

        public CreateDirectoryForm()
        {
            InitializeComponent();
        }

        private void btnChooseLocation_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    DirectoryPath = folderBrowserDialog.SelectedPath;
                    txtDirectoryPath.Text = DirectoryPath;
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDirectoryPath.Text) || string.IsNullOrEmpty(txtDirectoryName.Text))
            {
                MessageBox.Show("Proszę wybrać lokalizację oraz podać nazwę katalogu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DirectoryPath = txtDirectoryPath.Text;
            DirectoryName = txtDirectoryName.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
