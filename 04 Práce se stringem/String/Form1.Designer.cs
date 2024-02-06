namespace String
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCeleJmeno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJmeno = new System.Windows.Forms.Label();
            this.lblPrijmeni = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInicial = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAkce = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPocetOsob = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHUH = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno a příjmení";
            // 
            // txtCeleJmeno
            // 
            this.txtCeleJmeno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCeleJmeno.Location = new System.Drawing.Point(126, 48);
            this.txtCeleJmeno.Name = "txtCeleJmeno";
            this.txtCeleJmeno.Size = new System.Drawing.Size(200, 20);
            this.txtCeleJmeno.TabIndex = 1;
            this.txtCeleJmeno.TextChanged += new System.EventHandler(this.txtCeleJmeno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jméno:";
            // 
            // lblJmeno
            // 
            this.lblJmeno.AutoSize = true;
            this.lblJmeno.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblJmeno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJmeno.Location = new System.Drawing.Point(93, 141);
            this.lblJmeno.Name = "lblJmeno";
            this.lblJmeno.Size = new System.Drawing.Size(55, 15);
            this.lblJmeno.TabIndex = 3;
            this.lblJmeno.Text = " - Jméno -";
            // 
            // lblPrijmeni
            // 
            this.lblPrijmeni.AutoSize = true;
            this.lblPrijmeni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrijmeni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrijmeni.Location = new System.Drawing.Point(93, 165);
            this.lblPrijmeni.Name = "lblPrijmeni";
            this.lblPrijmeni.Size = new System.Drawing.Size(55, 15);
            this.lblPrijmeni.TabIndex = 5;
            this.lblPrijmeni.Text = " - Jméno -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Příjmení:";
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInicial.Location = new System.Drawing.Point(93, 191);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(55, 15);
            this.lblInicial.TabIndex = 7;
            this.lblInicial.Text = " - Jméno -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Iniciály:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(251, 183);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(170, 183);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAkce
            // 
            this.btnAkce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAkce.Location = new System.Drawing.Point(126, 89);
            this.btnAkce.Name = "btnAkce";
            this.btnAkce.Size = new System.Drawing.Size(200, 23);
            this.btnAkce.TabIndex = 10;
            this.btnAkce.Text = "Akce";
            this.btnAkce.UseVisualStyleBackColor = true;
            this.btnAkce.Click += new System.EventHandler(this.btnAkce_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblPocetOsob});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(354, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(122, 17);
            this.toolStripStatusLabel1.Text = "Počet zadaných osob:";
            // 
            // lblPocetOsob
            // 
            this.lblPocetOsob.Name = "lblPocetOsob";
            this.lblPocetOsob.Size = new System.Drawing.Size(13, 17);
            this.lblPocetOsob.Text = "0";
            // 
            // lblHUH
            // 
            this.lblHUH.AutoSize = true;
            this.lblHUH.Location = new System.Drawing.Point(217, 142);
            this.lblHUH.Name = "lblHUH";
            this.lblHUH.Size = new System.Drawing.Size(35, 13);
            this.lblHUH.TabIndex = 12;
            this.lblHUH.Text = "label3";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAkce;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(354, 262);
            this.Controls.Add(this.lblHUH);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAkce);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblInicial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPrijmeni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblJmeno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCeleJmeno);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(370, 300);
            this.Name = "Form1";
            this.Text = "String - Split(), Substring()";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCeleJmeno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblJmeno;
        private System.Windows.Forms.Label lblPrijmeni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAkce;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblPocetOsob;
        private System.Windows.Forms.Label lblHUH;
    }
}

