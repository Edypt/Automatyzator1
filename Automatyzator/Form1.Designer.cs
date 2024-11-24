namespace Automatyzator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkPowerShell = new System.Windows.Forms.CheckBox();
            this.chkBash = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBatch = new System.Windows.Forms.CheckBox();
            this.txtPathToSave = new System.Windows.Forms.TextBox();
            this.btnPrzenoszeniePliku = new System.Windows.Forms.Button();
            this.btnKopiowaniePliku = new System.Windows.Forms.Button();
            this.btnUsuwaniePliku = new System.Windows.Forms.Button();
            this.btnTworzenieKatalogu = new System.Windows.Forms.Button();
            this.txtGeneratedScript = new System.Windows.Forms.TextBox();
            this.btnWybierzLokalizacje = new System.Windows.Forms.Button();
            this.btnGenerujSkrypt = new System.Windows.Forms.Button();
            this.btnWyczyscKod = new System.Windows.Forms.Button();
            this.btnPrzenoszenieFolderu = new System.Windows.Forms.Button();
            this.chkWykonajZdalnie = new System.Windows.Forms.CheckBox();
            this.txtRemoteUser = new System.Windows.Forms.TextBox();
            this.txtRemotePassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemoteHost = new System.Windows.Forms.TextBox();
            this.btnDodajHost = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstRemoteHosts = new System.Windows.Forms.ListBox();
            this.btnUsunHost = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExecuteRemoteScript = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkPowerShell
            // 
            this.chkPowerShell.AutoSize = true;
            this.chkPowerShell.Location = new System.Drawing.Point(66, 19);
            this.chkPowerShell.Name = "chkPowerShell";
            this.chkPowerShell.Size = new System.Drawing.Size(79, 17);
            this.chkPowerShell.TabIndex = 2;
            this.chkPowerShell.Text = "PowerShell";
            this.chkPowerShell.UseVisualStyleBackColor = true;
            this.chkPowerShell.CheckedChanged += new System.EventHandler(this.chkPowerShell_CheckedChanged);
            // 
            // chkBash
            // 
            this.chkBash.AutoSize = true;
            this.chkBash.Location = new System.Drawing.Point(151, 19);
            this.chkBash.Name = "chkBash";
            this.chkBash.Size = new System.Drawing.Size(50, 17);
            this.chkBash.TabIndex = 3;
            this.chkBash.Text = "Bash";
            this.chkBash.UseVisualStyleBackColor = true;
            this.chkBash.CheckedChanged += new System.EventHandler(this.chkBash_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBatch);
            this.groupBox1.Controls.Add(this.chkBash);
            this.groupBox1.Controls.Add(this.chkPowerShell);
            this.groupBox1.Location = new System.Drawing.Point(1011, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz język skryptu:";
            // 
            // chkBatch
            // 
            this.chkBatch.AutoSize = true;
            this.chkBatch.Checked = true;
            this.chkBatch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBatch.Location = new System.Drawing.Point(6, 19);
            this.chkBatch.Name = "chkBatch";
            this.chkBatch.Size = new System.Drawing.Size(54, 17);
            this.chkBatch.TabIndex = 4;
            this.chkBatch.Text = "Batch";
            this.chkBatch.UseVisualStyleBackColor = true;
            this.chkBatch.CheckedChanged += new System.EventHandler(this.chkBatch_CheckedChanged);
            // 
            // txtPathToSave
            // 
            this.txtPathToSave.Location = new System.Drawing.Point(285, 664);
            this.txtPathToSave.Multiline = true;
            this.txtPathToSave.Name = "txtPathToSave";
            this.txtPathToSave.Size = new System.Drawing.Size(500, 20);
            this.txtPathToSave.TabIndex = 6;
            // 
            // btnPrzenoszeniePliku
            // 
            this.btnPrzenoszeniePliku.Location = new System.Drawing.Point(1021, 65);
            this.btnPrzenoszeniePliku.Name = "btnPrzenoszeniePliku";
            this.btnPrzenoszeniePliku.Size = new System.Drawing.Size(135, 35);
            this.btnPrzenoszeniePliku.TabIndex = 8;
            this.btnPrzenoszeniePliku.Text = "Przenieś Plik";
            this.btnPrzenoszeniePliku.UseVisualStyleBackColor = true;
            this.btnPrzenoszeniePliku.Click += new System.EventHandler(this.btnPrzenoszeniePliku_Click);
            // 
            // btnKopiowaniePliku
            // 
            this.btnKopiowaniePliku.Location = new System.Drawing.Point(1174, 106);
            this.btnKopiowaniePliku.Name = "btnKopiowaniePliku";
            this.btnKopiowaniePliku.Size = new System.Drawing.Size(135, 35);
            this.btnKopiowaniePliku.TabIndex = 9;
            this.btnKopiowaniePliku.Text = "Kopiuj Plik";
            this.btnKopiowaniePliku.UseVisualStyleBackColor = true;
            this.btnKopiowaniePliku.Click += new System.EventHandler(this.btnKopiowaniePliku_Click);
            // 
            // btnUsuwaniePliku
            // 
            this.btnUsuwaniePliku.Location = new System.Drawing.Point(1175, 65);
            this.btnUsuwaniePliku.Name = "btnUsuwaniePliku";
            this.btnUsuwaniePliku.Size = new System.Drawing.Size(135, 35);
            this.btnUsuwaniePliku.TabIndex = 10;
            this.btnUsuwaniePliku.Text = "Usuń Plik";
            this.btnUsuwaniePliku.UseVisualStyleBackColor = true;
            this.btnUsuwaniePliku.Click += new System.EventHandler(this.btnUsuwaniePliku_Click);
            // 
            // btnTworzenieKatalogu
            // 
            this.btnTworzenieKatalogu.Location = new System.Drawing.Point(1020, 106);
            this.btnTworzenieKatalogu.Name = "btnTworzenieKatalogu";
            this.btnTworzenieKatalogu.Size = new System.Drawing.Size(135, 35);
            this.btnTworzenieKatalogu.TabIndex = 11;
            this.btnTworzenieKatalogu.Text = "Utwórz Katalog";
            this.btnTworzenieKatalogu.UseVisualStyleBackColor = true;
            this.btnTworzenieKatalogu.Click += new System.EventHandler(this.btnTworzenieKatalogu_Click);
            // 
            // txtGeneratedScript
            // 
            this.txtGeneratedScript.Location = new System.Drawing.Point(12, 12);
            this.txtGeneratedScript.Multiline = true;
            this.txtGeneratedScript.Name = "txtGeneratedScript";
            this.txtGeneratedScript.Size = new System.Drawing.Size(993, 605);
            this.txtGeneratedScript.TabIndex = 12;
            // 
            // btnWybierzLokalizacje
            // 
            this.btnWybierzLokalizacje.Location = new System.Drawing.Point(791, 662);
            this.btnWybierzLokalizacje.Name = "btnWybierzLokalizacje";
            this.btnWybierzLokalizacje.Size = new System.Drawing.Size(150, 23);
            this.btnWybierzLokalizacje.TabIndex = 13;
            this.btnWybierzLokalizacje.Text = "Wybierz Lokalizację";
            this.btnWybierzLokalizacje.UseVisualStyleBackColor = true;
            this.btnWybierzLokalizacje.Click += new System.EventHandler(this.btnWybierzLokalizacje_Click);
            // 
            // btnGenerujSkrypt
            // 
            this.btnGenerujSkrypt.Location = new System.Drawing.Point(458, 623);
            this.btnGenerujSkrypt.Name = "btnGenerujSkrypt";
            this.btnGenerujSkrypt.Size = new System.Drawing.Size(135, 35);
            this.btnGenerujSkrypt.TabIndex = 14;
            this.btnGenerujSkrypt.Text = "Generuj";
            this.btnGenerujSkrypt.UseVisualStyleBackColor = true;
            this.btnGenerujSkrypt.Click += new System.EventHandler(this.btnGenerujSkrypt_Click);
            // 
            // btnWyczyscKod
            // 
            this.btnWyczyscKod.Location = new System.Drawing.Point(1241, 21);
            this.btnWyczyscKod.Name = "btnWyczyscKod";
            this.btnWyczyscKod.Size = new System.Drawing.Size(135, 35);
            this.btnWyczyscKod.TabIndex = 15;
            this.btnWyczyscKod.Text = "Wyczyść Kod";
            this.btnWyczyscKod.UseVisualStyleBackColor = true;
            this.btnWyczyscKod.Click += new System.EventHandler(this.btnWyczyscKod_Click);
            // 
            // btnPrzenoszenieFolderu
            // 
            this.btnPrzenoszenieFolderu.Location = new System.Drawing.Point(1021, 147);
            this.btnPrzenoszenieFolderu.Name = "btnPrzenoszenieFolderu";
            this.btnPrzenoszenieFolderu.Size = new System.Drawing.Size(135, 35);
            this.btnPrzenoszenieFolderu.TabIndex = 16;
            this.btnPrzenoszenieFolderu.Text = "Przenieś Folder";
            this.btnPrzenoszenieFolderu.UseVisualStyleBackColor = true;
            this.btnPrzenoszenieFolderu.Click += new System.EventHandler(this.btnPrzenoszenieFolderu_Click);
            // 
            // chkWykonajZdalnie
            // 
            this.chkWykonajZdalnie.AutoSize = true;
            this.chkWykonajZdalnie.Location = new System.Drawing.Point(1031, 188);
            this.chkWykonajZdalnie.Name = "chkWykonajZdalnie";
            this.chkWykonajZdalnie.Size = new System.Drawing.Size(152, 17);
            this.chkWykonajZdalnie.TabIndex = 17;
            this.chkWykonajZdalnie.Text = "Wykonaj Operację Zdalnie";
            this.chkWykonajZdalnie.UseVisualStyleBackColor = true;
            // 
            // txtRemoteUser
            // 
            this.txtRemoteUser.Location = new System.Drawing.Point(1205, 208);
            this.txtRemoteUser.Name = "txtRemoteUser";
            this.txtRemoteUser.Size = new System.Drawing.Size(100, 20);
            this.txtRemoteUser.TabIndex = 18;
            // 
            // txtRemotePassword
            // 
            this.txtRemotePassword.Location = new System.Drawing.Point(1205, 234);
            this.txtRemotePassword.Name = "txtRemotePassword";
            this.txtRemotePassword.PasswordChar = '*';
            this.txtRemotePassword.Size = new System.Drawing.Size(100, 20);
            this.txtRemotePassword.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1024, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nazwa wykonawcy (opcjonalnie)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1024, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hasło wykonawcy (opcjonalnie)";
            // 
            // txtRemoteHost
            // 
            this.txtRemoteHost.Location = new System.Drawing.Point(1205, 260);
            this.txtRemoteHost.Name = "txtRemoteHost";
            this.txtRemoteHost.Size = new System.Drawing.Size(100, 20);
            this.txtRemoteHost.TabIndex = 22;
            // 
            // btnDodajHost
            // 
            this.btnDodajHost.Location = new System.Drawing.Point(1170, 286);
            this.btnDodajHost.Name = "btnDodajHost";
            this.btnDodajHost.Size = new System.Drawing.Size(135, 35);
            this.btnDodajHost.TabIndex = 23;
            this.btnDodajHost.Text = "Dodaj";
            this.btnDodajHost.UseVisualStyleBackColor = true;
            this.btnDodajHost.Click += new System.EventHandler(this.btnDodajHost_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1024, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Wpisz adres IP / nazwę domenową";
            // 
            // lstRemoteHosts
            // 
            this.lstRemoteHosts.FormattingEnabled = true;
            this.lstRemoteHosts.Location = new System.Drawing.Point(1020, 286);
            this.lstRemoteHosts.Name = "lstRemoteHosts";
            this.lstRemoteHosts.Size = new System.Drawing.Size(148, 82);
            this.lstRemoteHosts.TabIndex = 25;
            // 
            // btnUsunHost
            // 
            this.btnUsunHost.Location = new System.Drawing.Point(1170, 333);
            this.btnUsunHost.Name = "btnUsunHost";
            this.btnUsunHost.Size = new System.Drawing.Size(135, 35);
            this.btnUsunHost.TabIndex = 26;
            this.btnUsunHost.Text = "Usuń";
            this.btnUsunHost.UseVisualStyleBackColor = true;
            this.btnUsunHost.Click += new System.EventHandler(this.btnUsunHost_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(1024, 374);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(135, 35);
            this.btnImport.TabIndex = 27;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExecuteRemoteScript
            // 
            this.btnExecuteRemoteScript.Location = new System.Drawing.Point(1174, 147);
            this.btnExecuteRemoteScript.Name = "btnExecuteRemoteScript";
            this.btnExecuteRemoteScript.Size = new System.Drawing.Size(135, 35);
            this.btnExecuteRemoteScript.TabIndex = 28;
            this.btnExecuteRemoteScript.Text = "Uruchom Skrypt Zdalnie";
            this.btnExecuteRemoteScript.UseVisualStyleBackColor = true;
            this.btnExecuteRemoteScript.Click += new System.EventHandler(this.btnExecuteRemoteScript_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 697);
            this.Controls.Add(this.btnExecuteRemoteScript);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnUsunHost);
            this.Controls.Add(this.lstRemoteHosts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodajHost);
            this.Controls.Add(this.txtRemoteHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRemotePassword);
            this.Controls.Add(this.txtRemoteUser);
            this.Controls.Add(this.chkWykonajZdalnie);
            this.Controls.Add(this.btnPrzenoszenieFolderu);
            this.Controls.Add(this.btnWyczyscKod);
            this.Controls.Add(this.btnGenerujSkrypt);
            this.Controls.Add(this.btnWybierzLokalizacje);
            this.Controls.Add(this.txtGeneratedScript);
            this.Controls.Add(this.btnTworzenieKatalogu);
            this.Controls.Add(this.btnUsuwaniePliku);
            this.Controls.Add(this.btnKopiowaniePliku);
            this.Controls.Add(this.btnPrzenoszeniePliku);
            this.Controls.Add(this.txtPathToSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Automat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkPowerShell;
        private System.Windows.Forms.CheckBox chkBash;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPathToSave;
        private System.Windows.Forms.Button btnPrzenoszeniePliku;
        private System.Windows.Forms.Button btnKopiowaniePliku;
        private System.Windows.Forms.Button btnUsuwaniePliku;
        private System.Windows.Forms.Button btnTworzenieKatalogu;
        private System.Windows.Forms.CheckBox chkBatch;
        private System.Windows.Forms.TextBox txtGeneratedScript;
        private System.Windows.Forms.Button btnWybierzLokalizacje;
        private System.Windows.Forms.Button btnGenerujSkrypt;
        private System.Windows.Forms.Button btnWyczyscKod;
        private System.Windows.Forms.Button btnPrzenoszenieFolderu;
        private System.Windows.Forms.CheckBox chkWykonajZdalnie;
        private System.Windows.Forms.TextBox txtRemoteUser;
        private System.Windows.Forms.TextBox txtRemotePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemoteHost;
        private System.Windows.Forms.Button btnDodajHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstRemoteHosts;
        private System.Windows.Forms.Button btnUsunHost;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExecuteRemoteScript;
    }
}

