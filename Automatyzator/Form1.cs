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
using ClosedXML.Excel;
using System.Diagnostics;

namespace Automatyzator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtRemoteHost.Visible = false;
            txtRemoteUser.Visible = false;
            txtRemotePassword.Visible = false;
            btnDodajHost.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            lstRemoteHosts.Visible = false;
            btnUsunHost.Visible = false;
            btnImport.Visible = false;
            btnExecuteRemoteScript.Visible = false;
            chkWykonajZdalnie.CheckedChanged += chkWykonajZdalnie_CheckedChanged;
            btnUsunHost.Click += btnUsunHost_Click;
        }

        private void chkWykonajZdalnie_CheckedChanged(object sender, EventArgs e)
        {
            bool isRemote = chkWykonajZdalnie.Checked;

            txtRemoteHost.Visible = isRemote;
            txtRemoteUser.Visible = isRemote;
            btnDodajHost.Visible = (isRemote);
            label1.Visible = isRemote;
            label2.Visible = isRemote;
            label3.Visible = isRemote;
            txtRemotePassword.Visible = isRemote;
            lstRemoteHosts.Visible = (isRemote);
            btnUsunHost.Visible = (isRemote);
            btnImport.Visible = (isRemote);
            btnExecuteRemoteScript.Visible =(isRemote);
        }

        private void btnPrzenoszeniePliku_Click(object sender, EventArgs e)
        {

            using (MoveFileForm moveFileForm = new MoveFileForm())
            {
                if (chkWykonajZdalnie.Checked)
                {
                    using (RemoteMoveFileForm remoteMoveFileForm = new RemoteMoveFileForm())
                    {
                        if (remoteMoveFileForm.ShowDialog() == DialogResult.OK)
                        {
                            string fragmentSkryptu = "";

                            string remoteUser = txtRemoteUser.Text;           
                            string remotePassword = txtRemotePassword.Text;   
                            var remoteHosts = lstRemoteHosts.Items;           

                            string sourcePath = remoteMoveFileForm.SourcePath;
                            string destinationPath = remoteMoveFileForm.DestinationPath;

                            foreach (string remoteHost in remoteHosts)
                            {
                                if (chkBatch.Checked)
                                {

                                    if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                                    {
                                        
                                        fragmentSkryptu += $"psexec \\\\{remoteHost} cmd /c move \"{sourcePath}\" \"{destinationPath}\"\n";
                                    }
                                    else
                                    {
                                        
                                        fragmentSkryptu += $"psexec \\\\{remoteHost} -u {remoteUser} -p {remotePassword} cmd /c move \"{sourcePath}\" \"{destinationPath}\"\n";
                                    }


                                }

                                if (chkPowerShell.Checked)
                                {

                                    if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                                    {
                                        
                                        fragmentSkryptu += $"Invoke-Command -ComputerName \"{remoteHost}\" -ScriptBlock {{ Move-Item -Path \"{sourcePath}\" -Destination \"{destinationPath}\" }}\n";
                                    }
                                    else
                                    {
                                        
                                        fragmentSkryptu += $"$securePassword = ConvertTo-SecureString \"{remotePassword}\" -AsPlainText -Force;\n";
                                        fragmentSkryptu += $"$credential = New-Object System.Management.Automation.PSCredential(\"{remoteUser}\", $securePassword);\n";
                                        fragmentSkryptu += $"Invoke-Command -ComputerName \"{remoteHost}\" -Credential $credential -ScriptBlock {{ Move-Item -Path \"{sourcePath}\" -Destination \"{destinationPath}\" }}\n";
                                    }
                                }

                                if (chkBash.Checked)
                                {

                                    if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                                    {
                                        
                                        fragmentSkryptu += $"scp \"{sourcePath}\" {remoteHost}:\"{destinationPath}\"\n";
                                    }
                                    else
                                    {
                                        
                                        fragmentSkryptu += $"sshpass -p \"{remotePassword}\" scp \"{sourcePath}\" {remoteUser}@{remoteHost}:\"{destinationPath}\"\n";
                                    }
                                }
                            }

                            
                            if (!string.IsNullOrEmpty(fragmentSkryptu))
                            {
                                txtGeneratedScript.AppendText(fragmentSkryptu + "\n");
                            }
                        }
                    }
                }
                else
                {
                    moveFileForm.OnMoveFileConfirmed += MoveFileForm_OnMoveFileConfirmed;


                    if (moveFileForm.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }
        }

        private void btnKopiowaniePliku_Click(object sender, EventArgs e)
        {
            if (chkWykonajZdalnie.Checked)
            {
                
                using (RemoteCopyFileForm remoteCopyFileForm = new RemoteCopyFileForm())
                {
                    if (remoteCopyFileForm.ShowDialog() == DialogResult.OK)
                    {
                        
                        string remoteUser = txtRemoteUser.Text;
                        string remotePassword = txtRemotePassword.Text;

                        foreach (string remoteHost in lstRemoteHosts.Items) 
                        {
                            string fragmentSkryptu = "";

                            
                            if (chkPowerShell.Checked)
                            {
                                if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                                {
                                    
                                    fragmentSkryptu += $"Invoke-Command -ComputerName \"{remoteHost}\" -ScriptBlock {{ Copy-Item -Path \"{remoteCopyFileForm.SourcePath}\" -Destination \"{remoteCopyFileForm.DestinationPath}\" -Force }}\n";
                                }
                                else
                                {
                                    
                                    fragmentSkryptu += $"$securePassword = ConvertTo-SecureString \"{remotePassword}\" -AsPlainText -Force;\n";
                                    fragmentSkryptu += $"$credential = New-Object System.Management.Automation.PSCredential(\"{remoteUser}\", $securePassword);\n";
                                    fragmentSkryptu += $"Invoke-Command -ComputerName \"{remoteHost}\" -Credential $credential -ScriptBlock {{ Copy-Item -Path \"{remoteCopyFileForm.SourcePath}\" -Destination \"{remoteCopyFileForm.DestinationPath}\" -Force }}\n";
                                }
                            }
                            else if (chkBash.Checked)
                            {
                                if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                                {
                                    
                                    fragmentSkryptu += $"scp \"{remoteCopyFileForm.SourcePath}\" {remoteHost}:\"{remoteCopyFileForm.DestinationPath}\"\n";
                                }
                                else
                                {
                                    
                                    fragmentSkryptu += $"sshpass -p \"{remotePassword}\" scp \"{remoteCopyFileForm.SourcePath}\" {remoteUser}@{remoteHost}:\"{remoteCopyFileForm.DestinationPath}\"\n";
                                }
                            }
                            else if (chkBatch.Checked)
                            {
                                if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                                {
                                    
                                    fragmentSkryptu += $"psexec \\\\{remoteHost} cmd /c copy \"{remoteCopyFileForm.SourcePath}\" \"{remoteCopyFileForm.DestinationPath}\"\n";
                                }
                                else
                                {
                                    
                                    fragmentSkryptu += $"psexec \\\\{remoteHost} -u {remoteUser} -p {remotePassword} cmd /c copy \"{remoteCopyFileForm.SourcePath}\" \"{remoteCopyFileForm.DestinationPath}\"\n";
                                }
                            }

                            
                            txtGeneratedScript.AppendText(fragmentSkryptu + "\n");
                        }
                    }
                }
            }
            else
            {
                
                using (CopyFileForm CopyFileForm = new CopyFileForm())
                {
                    if (CopyFileForm.ShowDialog() == DialogResult.OK)
                    {
                        
                        string fragmentSkryptu = "";

                        if (chkPowerShell.Checked)
                        {
                            fragmentSkryptu += $"Copy-Item -Path \"{CopyFileForm.SourcePath}\" -Destination \"{CopyFileForm.DestinationPath}\" -Force\n";
                        }
                        else if (chkBash.Checked)
                        {
                            fragmentSkryptu += $"cp \"{CopyFileForm.SourcePath}\" \"{CopyFileForm.DestinationPath}\"\n";
                        }
                        else if (chkBatch.Checked)
                        {
                            fragmentSkryptu += $"copy \"{CopyFileForm.SourcePath}\" \"{CopyFileForm.DestinationPath}\"\n";
                        }

                        
                        txtGeneratedScript.AppendText(fragmentSkryptu + "\n");
                    }
                }
            }

        }

        private void btnUsuwaniePliku_Click(object sender, EventArgs e)
        {

            if (chkWykonajZdalnie.Checked)
            {
                
                using (RemoteDeleteFileForm remoteDeleteFileForm = new RemoteDeleteFileForm())
                {
                    string remoteUser = txtRemoteUser.Text;
                    string remotePassword = txtRemotePassword.Text;
                    var remoteHosts = lstRemoteHosts.Items;
                    if (remoteDeleteFileForm.ShowDialog() == DialogResult.OK)
                    {
                        
                        foreach (string remoteHost in lstRemoteHosts.Items) 
                        {
                            string fragmentSkryptu = "";

                            if (chkPowerShell.Checked)
                            {
                                if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                                {
                                    
                                    fragmentSkryptu += $"Invoke-Command -ComputerName \"{remoteHost}\" -ScriptBlock {{ Remove-Item -Path \"{remoteDeleteFileForm.FilePath}\" -Force }}\n";
                                }
                                else
                                {
                                    
                                    fragmentSkryptu += $"$securePassword = ConvertTo-SecureString \"{remotePassword}\" -AsPlainText -Force;\n";
                                    fragmentSkryptu += $"$credential = New-Object System.Management.Automation.PSCredential(\"{remoteUser}\", $securePassword);\n";
                                    fragmentSkryptu += $"Invoke-Command -ComputerName \"{remoteHost}\" -Credential $credential -ScriptBlock {{ Remove-Item -Path \"{remoteDeleteFileForm.FilePath}\" -Force }}\n";
                                }
                            }
                            else if (chkBash.Checked)
                            {
                                if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                                {
                                    
                                    fragmentSkryptu += $"ssh {remoteHost} \"rm -f \\\"{remoteDeleteFileForm.FilePath}\\\"\"\n";
                                }
                                else
                                {
                                   
                                    fragmentSkryptu += $"sshpass -p \"{remotePassword}\" ssh {remoteUser}@{remoteHost} \"rm -f \\\"{remoteDeleteFileForm.FilePath}\\\"\"\n";
                                }
                            }
                            else if (chkBatch.Checked)
                            {
                                if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                                {
                                    
                                    fragmentSkryptu += $"psexec \\\\{remoteHost} cmd /c del \"{remoteDeleteFileForm.FilePath}\"\n";
                                }
                                else
                                {
                                    
                                    fragmentSkryptu += $"psexec \\\\{remoteHost} -u {remoteUser} -p {remotePassword} cmd /c del \"{remoteDeleteFileForm.FilePath}\"\n";
                                }
                            }

                            
                            txtGeneratedScript.AppendText(fragmentSkryptu + "\n");
                        }
                    }
                }
            }
            else
            {
                
                using (DeleteFileForm deleteFileForm = new DeleteFileForm())
                {
                    if (deleteFileForm.ShowDialog() == DialogResult.OK)
                    {
                        
                        string fragmentSkryptu = "";

                        if (chkPowerShell.Checked)
                        {
                            fragmentSkryptu += $"Remove-Item -Path \"{deleteFileForm.FilePath}\" -Force\n";
                        }
                        else if (chkBash.Checked)
                        {
                            fragmentSkryptu += $"rm -f \"{deleteFileForm.FilePath}\"\n";
                        }
                        else if (chkBatch.Checked)
                        {
                            fragmentSkryptu += $"del \"{deleteFileForm.FilePath}\"\n"; ;
                        }

                        
                        txtGeneratedScript.AppendText(fragmentSkryptu + "\n");
                    }
                }
            }
        }

        private void btnTworzenieKatalogu_Click(object sender, EventArgs e)
        {
            string remoteUser = txtRemoteUser.Text;
            string remotePassword = txtRemotePassword.Text;
            var remoteHosts = lstRemoteHosts.Items;
            if (chkWykonajZdalnie.Checked)
            {
                
                using (RemoteCreateDirectoryForm remoteCreateDirectoryForm = new RemoteCreateDirectoryForm())
                {
                    if (remoteCreateDirectoryForm.ShowDialog() == DialogResult.OK)
                    {
                        
                        foreach (string remoteHost in lstRemoteHosts.Items) 
                        {
                            string fragmentSkryptu = "";

                            
                            if (chkPowerShell.Checked)
                            {
                                if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                                {
                                    
                                    fragmentSkryptu += $"Invoke-Command -ComputerName \"{remoteHost}\" -ScriptBlock {{ New-Item -Path \"{remoteCreateDirectoryForm.DirectoryPath}\\{remoteCreateDirectoryForm.DirectoryName}\" -ItemType Directory }}\n";
                                }
                                else
                                {
                                    
                                    fragmentSkryptu += $"$securePassword = ConvertTo-SecureString \"{remotePassword}\" -AsPlainText -Force;\n";
                                    fragmentSkryptu += $"$credential = New-Object System.Management.Automation.PSCredential(\"{remoteUser}\", $securePassword);\n";
                                    fragmentSkryptu += $"Invoke-Command -ComputerName \"{remoteHost}\" -Credential $credential -ScriptBlock {{ New-Item -Path \"{remoteCreateDirectoryForm.DirectoryPath}\\{remoteCreateDirectoryForm.DirectoryName}\" -ItemType Directory }}\n";
                                }
                            }
                            else if (chkBash.Checked)
                            {
                                if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                                {
                                    
                                    fragmentSkryptu += $"ssh {remoteHost} \"mkdir -p \\\"{remoteCreateDirectoryForm.DirectoryPath}/{remoteCreateDirectoryForm.DirectoryName}\\\"\"\n";
                                }
                                else
                                {
                                    
                                    fragmentSkryptu += $"sshpass -p \"{remotePassword}\" ssh {remoteUser}@{remoteHost} \"mkdir -p \\\"{remoteCreateDirectoryForm.DirectoryPath}/{remoteCreateDirectoryForm.DirectoryName}\\\"\"\n";
                                }
                            }
                            else if (chkBatch.Checked)
                            {
                                if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                                {
                                    
                                    fragmentSkryptu += $"psexec \\\\{remoteHost} cmd /c mkdir \"{remoteCreateDirectoryForm.DirectoryPath}\\{remoteCreateDirectoryForm.DirectoryName}\"\n";
                                }
                                else
                                {
                                    
                                    fragmentSkryptu += $"psexec \\\\{remoteHost} -u {remoteUser} -p {remotePassword} cmd /c mkdir \"{remoteCreateDirectoryForm.DirectoryPath}\\{remoteCreateDirectoryForm.DirectoryName}\"\n";
                                }
                            }

                            
                            txtGeneratedScript.AppendText(fragmentSkryptu + "\n");
                        }
                    }
                }
            }
            else
            {
                
                using (CreateDirectoryForm CreateDirectoryForm = new CreateDirectoryForm())
                {
                    if (CreateDirectoryForm.ShowDialog() == DialogResult.OK)
                    {
                        
                        string fragmentSkryptu = "";

                        if (chkPowerShell.Checked)
                        {
                            fragmentSkryptu += $"New-Item -Path \"{CreateDirectoryForm.DirectoryPath}\\{CreateDirectoryForm.DirectoryName}\" -ItemType Directory\n";
                        }
                        else if (chkBash.Checked)
                        {
                            fragmentSkryptu += $"mkdir -p \"{CreateDirectoryForm.DirectoryPath}/{CreateDirectoryForm.DirectoryName}\"\n";
                        }
                        else if (chkBatch.Checked)
                        {
                            fragmentSkryptu += $"mkdir \"{CreateDirectoryForm.DirectoryPath}\\{CreateDirectoryForm.DirectoryName}\"\n";
                        }

                        
                        txtGeneratedScript.AppendText(fragmentSkryptu + "\n");
                    }
                }
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

        private void btnPrzenoszenieFolderu_Click(object sender, EventArgs e)
        {
            if (chkWykonajZdalnie.Checked)
            {
                using (RemoteMoveFolderForm remoteMoveFolderForm = new RemoteMoveFolderForm())
                {
                    if (remoteMoveFolderForm.ShowDialog() == DialogResult.OK)
                    {
                        string remoteUser = txtRemoteUser.Text;
                        string remotePassword = txtRemotePassword.Text;

                        foreach (string remoteHost in lstRemoteHosts.Items) 
                        {
                            string fragmentSkryptu = "";

                            if (chkPowerShell.Checked)
                            {
                                if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                                {
                                    fragmentSkryptu += $"Invoke-Command -ComputerName \"{remoteHost}\" -ScriptBlock {{ Move-Item -Path \"{remoteMoveFolderForm.SourcePath}\" -Destination \"{remoteMoveFolderForm.DestinationPath}\" -Force }}\n";
                                }
                                else
                                {
                                   
                                    fragmentSkryptu += $"$securePassword = ConvertTo-SecureString \"{remotePassword}\" -AsPlainText -Force;\n";
                                    fragmentSkryptu += $"$credential = New-Object System.Management.Automation.PSCredential(\"{remoteUser}\", $securePassword);\n";
                                    fragmentSkryptu += $"Invoke-Command -ComputerName \"{remoteHost}\" -Credential $credential -ScriptBlock {{ Move-Item -Path \"{remoteMoveFolderForm.SourcePath}\" -Destination \"{remoteMoveFolderForm.DestinationPath}\" -Force }}\n";
                                }
                            }
                            else if (chkBash.Checked)
                            {
                                if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                                {
                                    
                                    fragmentSkryptu += $"ssh {remoteHost} \"mv \\\"{remoteMoveFolderForm.SourcePath}\\\" \\\"{remoteMoveFolderForm.DestinationPath}\\\"\"\n";
                                }
                                else
                                {
                                    fragmentSkryptu += $"sshpass -p \"{remotePassword}\" ssh {remoteUser}@{remoteHost} \"mv \\\"{remoteMoveFolderForm.SourcePath}\\\" \\\"{remoteMoveFolderForm.DestinationPath}\\\"\"\n";
                                }
                            }
                            else if (chkBatch.Checked)
                            {
                                if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                                {
                                    
                                    fragmentSkryptu += $"psexec \\\\{remoteHost} cmd /c move \"{remoteMoveFolderForm.SourcePath}\" \"{remoteMoveFolderForm.DestinationPath}\"\n";
                                }
                                else
                                {
                                    
                                    fragmentSkryptu += $"psexec \\\\{remoteHost} -u {remoteUser} -p {remotePassword} cmd /c move \"{remoteMoveFolderForm.SourcePath}\" \"{remoteMoveFolderForm.DestinationPath}\"\n";
                                }
                            }

                           
                            txtGeneratedScript.AppendText(fragmentSkryptu + "\n");
                        }
                    }
                }
            }
            else
            {
                
                using (MoveFolderForm MoveFolderForm = new MoveFolderForm())
                {
                    if (MoveFolderForm.ShowDialog() == DialogResult.OK)
                    {
                        
                        string fragmentSkryptu = "";

                        if (chkPowerShell.Checked)
                        {
                            fragmentSkryptu += $"Move-Item -Path \"{MoveFolderForm.SourcePath}\" -Destination \"{MoveFolderForm.DestinationPath}\" -Force\n";
                        }
                        else if (chkBash.Checked)
                        {
                            fragmentSkryptu += $"mv \"{MoveFolderForm.SourcePath}\" \"{MoveFolderForm.DestinationPath}\"\n";
                        }
                        else if (chkBatch.Checked)
                        {
                            fragmentSkryptu += $"move \"{MoveFolderForm.SourcePath}\" \"{MoveFolderForm.DestinationPath}\"\n";
                        }

                        
                        txtGeneratedScript.AppendText(fragmentSkryptu + "\n");
                    }
                }
            }
        }

        private void btnDodajHost_Click(object sender, EventArgs e)
        {

            string newHost = txtRemoteHost.Text.Trim();

            if (!string.IsNullOrEmpty(newHost))
            {
                if (!lstRemoteHosts.Items.Contains(newHost)) //teaa
                {
                    lstRemoteHosts.Items.Add(newHost);
                    txtRemoteHost.Clear();
                }
                else
                {
                    MessageBox.Show("Ten host jest już dodany.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Proszę wpisać adres IP lub nazwę hosta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsunHost_Click(object sender, EventArgs e)
        {

            if (lstRemoteHosts.SelectedIndex != -1)
            {

                lstRemoteHosts.Items.RemoveAt(lstRemoteHosts.SelectedIndex);
            }
            else
            {

            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx";
                openFileDialog.Title = "Wybierz plik Excel do importu";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        using (var workbook = new XLWorkbook(filePath))
                        {
                            var worksheet = workbook.Worksheet(1); 
                            foreach (var row in worksheet.RowsUsed())
                            {
                                var cellValue = row.Cell(1).GetValue<string>().Trim(); 
                                if (!string.IsNullOrEmpty(cellValue) && !lstRemoteHosts.Items.Contains(cellValue))
                                {
                                    lstRemoteHosts.Items.Add(cellValue); 
                                }
                            }
                        }

                        MessageBox.Show("Import zakończony pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Błąd podczas importu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExecuteRemoteScript_Click(object sender, EventArgs e)
        {
            string remoteUser = txtRemoteUser.Text;
            string remotePassword = txtRemotePassword.Text;

            if (string.IsNullOrEmpty(txtGeneratedScript.Text))
            {
                MessageBox.Show("Nie wygenerowano skryptu do uruchomienia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string remoteScriptPath = "";

            StringBuilder generatedScript = new StringBuilder();

            foreach (string remoteHost in lstRemoteHosts.Items) 
            {
                string executeCommand = "";

                if (chkPowerShell.Checked)
                {
                    remoteScriptPath = $"C$\\Temp\\remote_script.ps1"; 
                    if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                    {
                        executeCommand = $"Invoke-Command -ComputerName \"{remoteHost}\" -FilePath \"{remoteScriptPath}\"";
                    }
                    else
                    {
                        executeCommand = $"$securePassword = ConvertTo-SecureString \"{remotePassword}\" -AsPlainText -Force;\n";
                        executeCommand += $"$credential = New-Object System.Management.Automation.PSCredential(\"{remoteUser}\", $securePassword);\n";
                        executeCommand += $"Invoke-Command -ComputerName \"{remoteHost}\" -FilePath \"{remoteScriptPath}\" -Credential $credential";
                    }
                }
                else if (chkBash.Checked)
                {
                    remoteScriptPath = "/tmp/remote_script.sh"; 
                    if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                    {
                        executeCommand = $"ssh {remoteHost} \"bash {remoteScriptPath}\"";
                    }
                    else
                    {
                        executeCommand = $"sshpass -p \"{remotePassword}\" ssh {remoteUser}@{remoteHost} \"bash {remoteScriptPath}\"";
                    }
                }
                else if (chkBatch.Checked)
                {
                    remoteScriptPath = $"C:\\Temp\\remote_script.bat"; 
                    if (string.IsNullOrEmpty(remoteUser) || string.IsNullOrEmpty(remotePassword))
                    {
                        executeCommand = $"psexec \\\\{remoteHost} cmd /c \"{remoteScriptPath}\"";
                    }
                    else
                    {
                        executeCommand = $"psexec \\\\{remoteHost} -u {remoteUser} -p {remotePassword} cmd /c \"{remoteScriptPath}\"";
                    }
                }

                generatedScript.AppendLine(executeCommand);
            }

            
            txtGeneratedScript.AppendText(generatedScript.ToString());
        }

        private void btnTestScript_Click(object sender, EventArgs e)
        {
            // Sprawdzanie, czy użytkownik podał ścieżkę do skryptu
            if (string.IsNullOrEmpty(txtScriptPath.Text))
            {
                // Otwórz okno dialogowe do wyboru pliku
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Wybierz plik skryptu";
                    openFileDialog.Filter = "Pliki skryptów|*.bat;*.ps1;*.sh|Wszystkie pliki|*.*";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Ustawienie wybranej ścieżki w polu tekstowym
                        txtScriptPath.Text = openFileDialog.FileName;
                    }
                    else
                    {
                        // Jeśli użytkownik anulował, przerwij wykonanie
                        MessageBox.Show("Nie wybrano pliku skryptu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            // Logika zależna od zaznaczonego checkboxa
            if (chkBatch.Checked)
            {
                TestBatchScript(txtScriptPath.Text);
            }
            else if (chkPowerShell.Checked)
            {
                TestPowerShellScript(txtScriptPath.Text);
            }
            else if (chkBash.Checked)
            {
                TestBashScript(txtScriptPath.Text);
            }
            else
            {
                MessageBox.Show("Proszę wybrać środowisko skryptu (Batch, PowerShell lub Bash).", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private bool IsWslInstalled()
        {
            try
            {
                // Uruchomienie komendy "wsl --list" i sprawdzenie wyniku
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c wsl --list";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                // Jeśli brak błędów i jest jakaś lista dystrybucji, to WSL jest zainstalowany
                if (!string.IsNullOrEmpty(output) && !output.Contains("is not recognized"))
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                // Obsługa błędów - zakładamy brak WSL
                MessageBox.Show($"Wystąpił problem podczas sprawdzania WSL: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (!IsWslInstalled())
            {
               
                    MessageBox.Show("Aplikacja wymaga WSL do działania. Zainstaluj go ręcznie, aby kontynuować uruchom powershell jako administrator wprowadz komende wsl --install .",
                                    "Brak WSL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                MessageBox.Show("WSL jest zainstalowany. Możesz korzystać z funkcji aplikacji.",
                                "WSL Zainstalowany", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TestBatchScript(string scriptPath)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/c {scriptPath}";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                string log = string.IsNullOrEmpty(error) ? $"[INFO] {output}" : $"[ERROR] {error}";
                MessageBox.Show(log, "Test Batch Script", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[EXCEPTION] {ex.Message}", "Błąd Testu Batch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TestPowerShellScript(string scriptPath)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "powershell.exe";
                process.StartInfo.Arguments = $"-File \"{scriptPath}\"";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                string log = string.IsNullOrEmpty(error) ? $"[INFO] {output}" : $"[ERROR] {error}";
                MessageBox.Show(log, "Test PowerShell Script", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[EXCEPTION] {ex.Message}", "Błąd Testu PowerShell", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TestBashScript(string scriptPath)
        {
            try
            {
                // Konwersja ścieżki Windows na WSL
                string wslPath = ConvertPathToWsl(scriptPath);

                Process process = new Process();
                process.StartInfo.FileName = "wsl.exe";
                process.StartInfo.Arguments = $"bash {wslPath}";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                string log = string.IsNullOrEmpty(error) ? $"[INFO] {output}" : $"[ERROR] {error}";
                MessageBox.Show(log, "Test Bash Script", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[EXCEPTION] {ex.Message}", "Błąd Testu Bash", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Funkcja konwertująca ścieżkę Windows na WSL
        private string ConvertPathToWsl(string windowsPath)
        {
            return windowsPath.Replace("C:\\", "/mnt/c/").Replace("\\", "/");
        }

    }
}
