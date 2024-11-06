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
            this.groupBox1.Location = new System.Drawing.Point(1024, 12);
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
            this.chkBatch.Location = new System.Drawing.Point(7, 19);
            this.chkBatch.Name = "chkBatch";
            this.chkBatch.Size = new System.Drawing.Size(54, 17);
            this.chkBatch.TabIndex = 4;
            this.chkBatch.Text = "Batch";
            this.chkBatch.UseVisualStyleBackColor = true;
            this.chkBatch.CheckedChanged += new System.EventHandler(this.chkBatch_CheckedChanged);
            // 
            // txtPathToSave
            // 
            this.txtPathToSave.Location = new System.Drawing.Point(28, 689);
            this.txtPathToSave.Multiline = true;
            this.txtPathToSave.Name = "txtPathToSave";
            this.txtPathToSave.Size = new System.Drawing.Size(500, 20);
            this.txtPathToSave.TabIndex = 6;
            // 
            // btnPrzenoszeniePliku
            // 
            this.btnPrzenoszeniePliku.Location = new System.Drawing.Point(1031, 105);
            this.btnPrzenoszeniePliku.Name = "btnPrzenoszeniePliku";
            this.btnPrzenoszeniePliku.Size = new System.Drawing.Size(135, 35);
            this.btnPrzenoszeniePliku.TabIndex = 8;
            this.btnPrzenoszeniePliku.Text = "Przenieś Plik";
            this.btnPrzenoszeniePliku.UseVisualStyleBackColor = true;
            this.btnPrzenoszeniePliku.Click += new System.EventHandler(this.btnPrzenoszeniePliku_Click);
            // 
            // btnKopiowaniePliku
            // 
            this.btnKopiowaniePliku.Location = new System.Drawing.Point(1171, 146);
            this.btnKopiowaniePliku.Name = "btnKopiowaniePliku";
            this.btnKopiowaniePliku.Size = new System.Drawing.Size(135, 35);
            this.btnKopiowaniePliku.TabIndex = 9;
            this.btnKopiowaniePliku.Text = "Kopiuj Plik";
            this.btnKopiowaniePliku.UseVisualStyleBackColor = true;
            this.btnKopiowaniePliku.Click += new System.EventHandler(this.btnKopiowaniePliku_Click);
            // 
            // btnUsuwaniePliku
            // 
            this.btnUsuwaniePliku.Location = new System.Drawing.Point(1172, 105);
            this.btnUsuwaniePliku.Name = "btnUsuwaniePliku";
            this.btnUsuwaniePliku.Size = new System.Drawing.Size(135, 35);
            this.btnUsuwaniePliku.TabIndex = 10;
            this.btnUsuwaniePliku.Text = "Usuń Plik";
            this.btnUsuwaniePliku.UseVisualStyleBackColor = true;
            this.btnUsuwaniePliku.Click += new System.EventHandler(this.btnUsuwaniePliku_Click);
            // 
            // btnTworzenieKatalogu
            // 
            this.btnTworzenieKatalogu.Location = new System.Drawing.Point(1030, 146);
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
            this.txtGeneratedScript.Size = new System.Drawing.Size(1006, 610);
            this.txtGeneratedScript.TabIndex = 12;
            // 
            // btnWybierzLokalizacje
            // 
            this.btnWybierzLokalizacje.Location = new System.Drawing.Point(544, 685);
            this.btnWybierzLokalizacje.Name = "btnWybierzLokalizacje";
            this.btnWybierzLokalizacje.Size = new System.Drawing.Size(150, 23);
            this.btnWybierzLokalizacje.TabIndex = 13;
            this.btnWybierzLokalizacje.Text = "Wybierz Lokalizację";
            this.btnWybierzLokalizacje.UseVisualStyleBackColor = true;
            this.btnWybierzLokalizacje.Click += new System.EventHandler(this.btnWybierzLokalizacje_Click);
            // 
            // btnGenerujSkrypt
            // 
            this.btnGenerujSkrypt.Location = new System.Drawing.Point(393, 628);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 836);
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
    }
}

