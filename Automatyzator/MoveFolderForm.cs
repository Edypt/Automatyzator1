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
    public partial class MoveFolderForm : Form
    {
        public delegate void MoveFolderHandler(string sourcePath, string destinationPath);
        public event MoveFolderHandler OnMoveFolderConfirmed;

        public string SourcePath { get; private set; }
        public string DestinationPath { get; private set; }
        


        public MoveFolderForm()
        {
            InitializeComponent();
        }

        private void btnChooseSourceFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    SourcePath = folderBrowserDialog.SelectedPath;
                    txtSourcePath.Text = SourcePath;
                }
            }
        }

        private void btnChooseDestinationFolder_Click_1(object sender, EventArgs e)
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

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            // Sprawdzenie, czy obie ścieżki zostały podane
            if (string.IsNullOrEmpty(txtSourcePath.Text) || string.IsNullOrEmpty(txtDestinationPath.Text))
            {
                MessageBox.Show("Proszę wybrać zarówno folder źródłowy, jak i folder docelowy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Przypisanie wartości do właściwości publicznych
            SourcePath = txtSourcePath.Text;
            DestinationPath = txtDestinationPath.Text;

            // Ustawienie wyniku dialogowego i zamknięcie formularza
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
