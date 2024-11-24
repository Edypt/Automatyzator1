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
   
    public partial class RemoteCopyFileForm : Form
    {
        public string SourcePath { get; private set; }
        public string DestinationPath { get; private set; }
        public RemoteCopyFileForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            SourcePath = txtSourcePath.Text;
            DestinationPath = txtDestinationPath.Text;

            
            if (string.IsNullOrEmpty(SourcePath) || string.IsNullOrEmpty(DestinationPath))
            {
                MessageBox.Show("Proszę podać ścieżki źródłową i docelową.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
