
namespace LIstBox
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmUpDownID = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrijmeni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJmeno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnGG = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDownID)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nmUpDownID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrijmeni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtJmeno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(696, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osoba";
            // 
            // nmUpDownID
            // 
            this.nmUpDownID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmUpDownID.Location = new System.Drawing.Point(125, 36);
            this.nmUpDownID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmUpDownID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmUpDownID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmUpDownID.Name = "nmUpDownID";
            this.nmUpDownID.Size = new System.Drawing.Size(551, 22);
            this.nmUpDownID.TabIndex = 5;
            this.nmUpDownID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmUpDownID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID ";
            // 
            // txtPrijmeni
            // 
            this.txtPrijmeni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrijmeni.Location = new System.Drawing.Point(125, 126);
            this.txtPrijmeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrijmeni.Name = "txtPrijmeni";
            this.txtPrijmeni.Size = new System.Drawing.Size(548, 22);
            this.txtPrijmeni.TabIndex = 3;
            this.txtPrijmeni.Text = "Prijmeni";
            this.txtPrijmeni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Příjmení: ";
            // 
            // txtJmeno
            // 
            this.txtJmeno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJmeno.Location = new System.Drawing.Point(125, 80);
            this.txtJmeno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJmeno.Name = "txtJmeno";
            this.txtJmeno.Size = new System.Drawing.Size(548, 22);
            this.txtJmeno.TabIndex = 1;
            this.txtJmeno.Text = "Jmeno";
            this.txtJmeno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno: ";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(496, 287);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(196, 65);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Změnit";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnGG
            // 
            this.btnGG.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnGG.Location = new System.Drawing.Point(16, 287);
            this.btnGG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGG.Name = "btnGG";
            this.btnGG.Size = new System.Drawing.Size(196, 65);
            this.btnGG.TabIndex = 4;
            this.btnGG.Text = "Zrušit";
            this.btnGG.UseVisualStyleBackColor = true;
            this.btnGG.Click += new System.EventHandler(this.btnGG_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 367);
            this.Controls.Add(this.btnGG);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDownID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnGG;
        public System.Windows.Forms.NumericUpDown nmUpDownID;
        public System.Windows.Forms.TextBox txtPrijmeni;
        public System.Windows.Forms.TextBox txtJmeno;
    }
}