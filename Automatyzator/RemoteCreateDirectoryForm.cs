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
    public partial class RemoteCreateDirectoryForm : Form
    {
        public string DirectoryPath { get; private set; }
        public string DirectoryName { get; private set; }


        public RemoteCreateDirectoryForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            DirectoryPath = txtDirectoryPath.Text;
            DirectoryName = txtDirectoryName.Text;

            
            if (string.IsNullOrEmpty(DirectoryPath) || string.IsNullOrEmpty(DirectoryName))
            {
                MessageBox.Show("Proszę podać ścieżkę i nazwę katalogu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
