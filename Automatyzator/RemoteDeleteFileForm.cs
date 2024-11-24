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
    public partial class RemoteDeleteFileForm : Form
    {
        public string FilePath { get; private set; }
        public bool ForceDelete { get; private set; }
        public RemoteDeleteFileForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            FilePath = txtFilePath.Text;
            ForceDelete = chkForceDelete.Checked;

            
            if (string.IsNullOrEmpty(FilePath))
            {
                MessageBox.Show("Proszę podać ścieżkę do pliku.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
