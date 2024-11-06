using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrzenoszeniePliku_Click(object sender, EventArgs e)
        {
            
            using (MoveFileForm moveFileForm = new MoveFileForm())
            {
                
                moveFileForm.OnMoveFileConfirmed += MoveFileForm_OnMoveFileConfirmed;

                
                if (moveFileForm.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }


        private void btnKopiowaniePliku_Click(object sender, EventArgs e)
        {
            string fragmentSkryptu = "";

            if (chkBatch.Checked)
            {
                fragmentSkryptu += $"copy \"ścieżka_źródłowa\" \"ścieżka_docelowa\"\n";
            }

            if (chkPowerShell.Checked)
            {
                fragmentSkryptu += $"Copy-Item -Path \"ścieżka_źródłowa\" -Destination \"ścieżka_docelowa\"\n";
            }

            if (chkBash.Checked)
            {
                fragmentSkryptu += $"cp \"ścieżka_źródłowa\" \"ścieżka_docelowa\"\n";
            }

            if (!string.IsNullOrEmpty(fragmentSkryptu))
            {
                txtGeneratedScript.AppendText(fragmentSkryptu + "\n");
            }
            else
            {
                MessageBox.Show("Proszę wybrać co najmniej jeden język skryptu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsuwaniePliku_Click(object sender, EventArgs e)
        {
            string fragmentSkryptu = "";

            if (chkBatch.Checked)
            {
                fragmentSkryptu += $"del \"ścieżka_pliku\"\n";
            }

            if (chkPowerShell.Checked)
            {
                fragmentSkryptu += $"Remove-Item -Path \"ścieżka_pliku\"\n";
            }

            if (chkBash.Checked)
            {
                fragmentSkryptu += $"rm \"ścieżka_pliku\"\n";
            }

            if (!string.IsNullOrEmpty(fragmentSkryptu))
            {
                txtGeneratedScript.AppendText(fragmentSkryptu + "\n");
            }
            else
            {
                MessageBox.Show("Proszę wybrać co najmniej jeden język skryptu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTworzenieKatalogu_Click(object sender, EventArgs e)
        {
            string fragmentSkryptu = "";

            if (chkBatch.Checked)
            {
                fragmentSkryptu += $"mkdir \"ścieżka_katalogu\"\n";
            }

            if (chkPowerShell.Checked)
            {
                fragmentSkryptu += $"New-Item -Path \"ścieżka_katalogu\" -ItemType Directory\n";
            }

            if (chkBash.Checked)
            {
                fragmentSkryptu += $"mkdir \"ścieżka_katalogu\"\n";
            }

            if (!string.IsNullOrEmpty(fragmentSkryptu))
            {
                txtGeneratedScript.AppendText(fragmentSkryptu + "\n");
            }
            else
            {
                MessageBox.Show("Proszę wybrać co najmniej jeden język skryptu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWybierzLokalizacje_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Batch Files (*.bat)|*.bat|PowerShell Files (*.ps1)|*.ps1|Bash Scripts (*.sh)|*.sh|All Files (*.*)|*.*";
                saveFileDialog.Title = "Wybierz miejsce do zapisania skryptu";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPathToSave.Text = saveFileDialog.FileName;
                }
            }
        }

        private void btnGenerujSkrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPathToSave.Text))
            {
                MessageBox.Show("Proszę wybrać miejsce do zapisania skryptu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                File.WriteAllText(txtPathToSave.Text, txtGeneratedScript.Text);
                MessageBox.Show("Skrypt został zapisany pomyślnie.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas zapisywania skryptu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkBatch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBatch.Checked)
            {
                chkPowerShell.Checked = false;
                chkBash.Checked = false;
            }
        }

        private void chkPowerShell_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPowerShell.Checked)
            {
                chkBatch.Checked = false;
                chkBash.Checked = false;
            }
        }

        private void chkBash_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBash.Checked)
            {
                chkBatch.Checked = false;
                chkPowerShell.Checked = false;
            }
        }
        private void MoveFileForm_OnMoveFileConfirmed(string sourcePath, string destinationPath)
        {
            string fragmentSkryptu = "";

            
            if (chkBatch.Checked)
            {
                fragmentSkryptu += $"move \"{sourcePath}\" \"{destinationPath}\"\n";
            }

            
            if (chkPowerShell.Checked)
            {
                fragmentSkryptu += $"Move-Item -Path \"{sourcePath}\" -Destination \"{destinationPath}\"\n";
            }

            
            if (chkBash.Checked)
            {
                fragmentSkryptu += $"mv \"{sourcePath}\" \"{destinationPath}\"\n";
            }

            
            if (!string.IsNullOrEmpty(fragmentSkryptu))
            {
                txtGeneratedScript.AppendText(fragmentSkryptu + "\n");
            }
        }


        private void btnWyczyscKod_Click(object sender, EventArgs e)
        {
            
            txtGeneratedScript.Clear();
        }

    }
}
