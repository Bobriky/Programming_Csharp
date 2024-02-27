
namespace DatoveKolekce
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
            this.txtCisla = new System.Windows.Forms.TextBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCislicePocet = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAbecedaPocet = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPozdravyPocet = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtAbeceda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPozdrav = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCislice = new System.Windows.Forms.Button();
            this.btnLicha = new System.Windows.Forms.Button();
            this.btnSuda = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnRada = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHeslo = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPozdrav = new System.Windows.Forms.Button();
            this.nmMax = new System.Windows.Forms.NumericUpDown();
            this.StatusStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMax)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celá čísla";
            // 
            // txtCisla
            // 
            this.txtCisla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCisla.Location = new System.Drawing.Point(28, 54);
            this.txtCisla.Margin = new System.Windows.Forms.Padding(2);
            this.txtCisla.Name = "txtCisla";
            this.txtCisla.Size = new System.Drawing.Size(660, 20);
            this.txtCisla.TabIndex = 1;
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.lblCislicePocet,
            this.toolStripStatusLabel2,
            this.lblAbecedaPocet,
            this.toolStripStatusLabel1,
            this.lblPozdravyPocet});
            this.StatusStrip.Location = new System.Drawing.Point(0, 396);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.StatusStrip.Size = new System.Drawing.Size(714, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(91, 17);
            this.toolStripStatusLabel4.Text = "Cislice.Count = ";
            // 
            // lblCislicePocet
            // 
            this.lblCislicePocet.Name = "lblCislicePocet";
            this.lblCislicePocet.Size = new System.Drawing.Size(13, 17);
            this.lblCislicePocet.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(124, 17);
            this.toolStripStatusLabel2.Text = "       Abeceda.Count = ";
            // 
            // lblAbecedaPocet
            // 
            this.lblAbecedaPocet.Name = "lblAbecedaPocet";
            this.lblAbecedaPocet.Size = new System.Drawing.Size(13, 17);
            this.lblAbecedaPocet.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(129, 17);
            this.toolStripStatusLabel1.Text = "       Pozdravy.Count =  ";
            // 
            // lblPozdravyPocet
            // 
            this.lblPozdravyPocet.Name = "lblPozdravyPocet";
            this.lblPozdravyPocet.Size = new System.Drawing.Size(13, 17);
            this.lblPozdravyPocet.Text = "0";
            // 
            // txtAbeceda
            // 
            this.txtAbeceda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAbeceda.Location = new System.Drawing.Point(31, 162);
            this.txtAbeceda.Margin = new System.Windows.Forms.Padding(2);
            this.txtAbeceda.Name = "txtAbeceda";
            this.txtAbeceda.Size = new System.Drawing.Size(660, 20);
            this.txtAbeceda.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Abeceda";
            // 
            // txtPozdrav
            // 
            this.txtPozdrav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPozdrav.Location = new System.Drawing.Point(28, 262);
            this.txtPozdrav.Margin = new System.Windows.Forms.Padding(2);
            this.txtPozdrav.Name = "txtPozdrav";
            this.txtPozdrav.Size = new System.Drawing.Size(660, 20);
            this.txtPozdrav.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pozdravy";
            // 
            // btnCislice
            // 
            this.btnCislice.Location = new System.Drawing.Point(2, 2);
            this.btnCislice.Margin = new System.Windows.Forms.Padding(2);
            this.btnCislice.Name = "btnCislice";
            this.btnCislice.Size = new System.Drawing.Size(70, 34);
            this.btnCislice.TabIndex = 7;
            this.btnCislice.Text = " 0 , 1, 2, ... ";
            this.btnCislice.UseVisualStyleBackColor = true;
            this.btnCislice.Click += new System.EventHandler(this.btnCislice_Click);
            // 
            // btnLicha
            // 
            this.btnLicha.Location = new System.Drawing.Point(76, 2);
            this.btnLicha.Margin = new System.Windows.Forms.Padding(2);
            this.btnLicha.Name = "btnLicha";
            this.btnLicha.Size = new System.Drawing.Size(80, 34);
            this.btnLicha.TabIndex = 8;
            this.btnLicha.Text = "Lichá čísla";
            this.btnLicha.UseVisualStyleBackColor = true;
            this.btnLicha.Click += new System.EventHandler(this.btnLicha_Click);
            // 
            // btnSuda
            // 
            this.btnSuda.Location = new System.Drawing.Point(160, 2);
            this.btnSuda.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuda.Name = "btnSuda";
            this.btnSuda.Size = new System.Drawing.Size(80, 34);
            this.btnSuda.TabIndex = 9;
            this.btnSuda.Text = "Sudá čísla";
            this.btnSuda.UseVisualStyleBackColor = true;
            this.btnSuda.Click += new System.EventHandler(this.btnSuda_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnCislice);
            this.flowLayoutPanel1.Controls.Add(this.btnLicha);
            this.flowLayoutPanel1.Controls.Add(this.btnSuda);
            this.flowLayoutPanel1.Controls.Add(this.btnRandom);
            this.flowLayoutPanel1.Controls.Add(this.btnRada);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 81);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(659, 37);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(244, 2);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(2);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(80, 34);
            this.btnRandom.TabIndex = 10;
            this.btnRandom.Text = "Náhodná čísla";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnRada
            // 
            this.btnRada.Location = new System.Drawing.Point(328, 2);
            this.btnRada.Margin = new System.Windows.Forms.Padding(2);
            this.btnRada.Name = "btnRada";
            this.btnRada.Size = new System.Drawing.Size(80, 34);
            this.btnRada.TabIndex = 11;
            this.btnRada.Text = " 10, 20, ... ";
            this.btnRada.UseVisualStyleBackColor = true;
            this.btnRada.Click += new System.EventHandler(this.btnRada_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.btnHeslo);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(28, 189);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(659, 32);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // btnHeslo
            // 
            this.btnHeslo.Location = new System.Drawing.Point(2, 2);
            this.btnHeslo.Margin = new System.Windows.Forms.Padding(2);
            this.btnHeslo.Name = "btnHeslo";
            this.btnHeslo.Size = new System.Drawing.Size(64, 29);
            this.btnHeslo.TabIndex = 0;
            this.btnHeslo.Text = "Heslo";
            this.btnHeslo.UseVisualStyleBackColor = true;
            this.btnHeslo.Click += new System.EventHandler(this.btnHeslo_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Controls.Add(this.btnPozdrav);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(28, 285);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(659, 32);
            this.flowLayoutPanel3.TabIndex = 12;
            // 
            // btnPozdrav
            // 
            this.btnPozdrav.Location = new System.Drawing.Point(2, 2);
            this.btnPozdrav.Margin = new System.Windows.Forms.Padding(2);
            this.btnPozdrav.Name = "btnPozdrav";
            this.btnPozdrav.Size = new System.Drawing.Size(64, 29);
            this.btnPozdrav.TabIndex = 0;
            this.btnPozdrav.Text = "Show";
            this.btnPozdrav.UseVisualStyleBackColor = true;
            // 
            // nmMax
            // 
            this.nmMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmMax.Location = new System.Drawing.Point(520, 25);
            this.nmMax.Margin = new System.Windows.Forms.Padding(2);
            this.nmMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmMax.Name = "nmMax";
            this.nmMax.Size = new System.Drawing.Size(53, 20);
            this.nmMax.TabIndex = 12;
            this.nmMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 418);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtPozdrav);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmMax);
            this.Controls.Add(this.txtAbeceda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.txtCisla);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(600, 390);
            this.Name = "Form1";
            this.Text = "List<>";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCisla;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lblCislicePocet;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblAbecedaPocet;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblPozdravyPocet;
        private System.Windows.Forms.TextBox txtAbeceda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPozdrav;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCislice;
        private System.Windows.Forms.Button btnLicha;
        private System.Windows.Forms.Button btnSuda;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnRada;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnHeslo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnPozdrav;
        private System.Windows.Forms.NumericUpDown nmMax;
    }
}

