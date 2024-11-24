namespace Automatyzator
{
    partial class RemoteDeleteFileForm
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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.chkForceDelete = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(25, 36);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 35);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(286, 20);
            this.txtFilePath.TabIndex = 4;
            // 
            // chkForceDelete
            // 
            this.chkForceDelete.AutoSize = true;
            this.chkForceDelete.Location = new System.Drawing.Point(166, 46);
            this.chkForceDelete.Name = "chkForceDelete";
            this.chkForceDelete.Size = new System.Drawing.Size(109, 17);
            this.chkForceDelete.TabIndex = 7;
            this.chkForceDelete.Text = "Wymuś usunięcie";
            this.chkForceDelete.UseVisualStyleBackColor = true;
            // 
            // RemoteDeleteFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 83);
            this.Controls.Add(this.chkForceDelete);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtFilePath);
            this.Name = "RemoteDeleteFileForm";
            this.Text = "RemoteDeleteFileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.CheckBox chkForceDelete;
    }
}