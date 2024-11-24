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
    public partial class RemoteMoveFileForm : Form
    {
        public string SourcePath { get; private set; }
        public string DestinationPath { get; private set; }
        public RemoteMoveFileForm()
        {
            InitializeComponent();
        }

        private void btnZatwierdz_Click(object sender, EventArgs e)
        {
            SourcePath = txtSourcePath.Text;
            DestinationPath = txtDestinationPath.Text;

            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
