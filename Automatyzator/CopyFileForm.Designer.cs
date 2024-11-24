namespace Automatyzator
{
    partial class CopyFileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnChooseDestinationFolder = new System.Windows.Forms.Button();
            this.btnChooseSourceFolder = new System.Windows.Forms.Button();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(103, 97);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 35);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnChooseDestinationFolder
            // 
            this.btnChooseDestinationFolder.Location = new System.Drawing.Point(295, 70);
            this.btnChooseDestinationFolder.Name = "btnChooseDestinationFolder";
            this.btnChooseDestinationFolder.Size = new System.Drawing.Size(135, 35);
            this.btnChooseDestinationFolder.TabIndex = 13;
            this.btnChooseDestinationFolder.Text = "Wybierz Lokalizację";
            this.btnChooseDestinationFolder.UseVisualStyleBackColor = true;
            this.btnChooseDestinationFolder.Click += new System.EventHandler(this.btnChooseDestinationFolder_Click);
            // 
            // btnChooseSourceFolder
            // 
            this.btnChooseSourceFolder.Location = new System.Drawing.Point(295, 10);
            this.btnChooseSourceFolder.Name = "btnChooseSourceFolder";
            this.btnChooseSourceFolder.Size = new System.Drawing.Size(135, 35);
            this.btnChooseSourceFolder.TabIndex = 12;
            this.btnChooseSourceFolder.Text = "Wybierz Plik";
            this.btnChooseSourceFolder.UseVisualStyleBackColor = true;
            this.btnChooseSourceFolder.Click += new System.EventHandler(this.btnChooseSourceFolder_Click);
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(3, 70);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.Size = new System.Drawing.Size(286, 20);
            this.txtDestinationPath.TabIndex = 11;
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(3, 12);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(286, 20);
            this.txtSourcePath.TabIndex = 10;
            // 
            // CopyFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 144);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnChooseDestinationFolder);
            this.Controls.Add(this.btnChooseSourceFolder);
            this.Controls.Add(this.txtDestinationPath);
            this.Controls.Add(this.txtSourcePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CopyFileForm";
            this.Text = "Kopiowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnChooseDestinationFolder;
        private System.Windows.Forms.Button btnChooseSourceFolder;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.TextBox txtSourcePath;
    }
}