
namespace DirectoryTrain
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDirectory = new System.Windows.Forms.Label();
            this.flgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lstSubfolderInside = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSubfolder = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(18, 20);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(111, 17);
            this.lblDirectory.TabIndex = 0;
            this.lblDirectory.Text = "Aktuální adresář";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(21, 40);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(677, 22);
            this.txtDirectory.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(704, 30);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 43);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Hledat";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lstSubfolderInside
            // 
            this.lstSubfolderInside.FormattingEnabled = true;
            this.lstSubfolderInside.ItemHeight = 16;
            this.lstSubfolderInside.Location = new System.Drawing.Point(403, 112);
            this.lstSubfolderInside.Name = "lstSubfolderInside";
            this.lstSubfolderInside.Size = new System.Drawing.Size(295, 324);
            this.lstSubfolderInside.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Obsah vybráné podsložky";
            // 
            // lstSubfolder
            // 
            this.lstSubfolder.FormattingEnabled = true;
            this.lstSubfolder.ItemHeight = 16;
            this.lstSubfolder.Location = new System.Drawing.Point(21, 112);
            this.lstSubfolder.Name = "lstSubfolder";
            this.lstSubfolder.Size = new System.Drawing.Size(352, 324);
            this.lstSubfolder.TabIndex = 10;
            this.lstSubfolder.SelectedIndexChanged += new System.EventHandler(this.lstSubfolder_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Obsah adresáře";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSubfolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSubfolderInside);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.lblDirectory);
            this.Name = "Form1";
            this.Text = "Hraní si s DirFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.FolderBrowserDialog flgFolder;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ListBox lstSubfolderInside;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSubfolder;
        private System.Windows.Forms.Label label1;
    }
}

