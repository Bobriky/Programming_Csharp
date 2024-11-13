namespace OsobaUdalosti
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNar = new System.Windows.Forms.DateTimePicker();
            this.dtMat = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.txtProm = new System.Windows.Forms.TextBox();
            this.dtProm = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSvat = new System.Windows.Forms.TextBox();
            this.dtSvat = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDuch = new System.Windows.Forms.TextBox();
            this.dtDuch = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUmrt = new System.Windows.Forms.TextBox();
            this.dtUmrt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDnes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtDnesD = new System.Windows.Forms.TextBox();
            this.txtUmrtD = new System.Windows.Forms.TextBox();
            this.txtDuchD = new System.Windows.Forms.TextBox();
            this.txtSvatD = new System.Windows.Forms.TextBox();
            this.txtPromD = new System.Windows.Forms.TextBox();
            this.txtMatD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Narození";
            // 
            // dtNar
            // 
            this.dtNar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNar.Location = new System.Drawing.Point(98, 40);
            this.dtNar.Name = "dtNar";
            this.dtNar.Size = new System.Drawing.Size(210, 20);
            this.dtNar.TabIndex = 1;
            this.dtNar.ValueChanged += new System.EventHandler(this.dtMat_ValueChanged);
            // 
            // dtMat
            // 
            this.dtMat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtMat.Location = new System.Drawing.Point(98, 76);
            this.dtMat.Name = "dtMat";
            this.dtMat.Size = new System.Drawing.Size(210, 20);
            this.dtMat.TabIndex = 3;
            this.dtMat.ValueChanged += new System.EventHandler(this.dtMat_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maturita";
            // 
            // txtMat
            // 
            this.txtMat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMat.Location = new System.Drawing.Point(324, 77);
            this.txtMat.Name = "txtMat";
            this.txtMat.ReadOnly = true;
            this.txtMat.Size = new System.Drawing.Size(56, 20);
            this.txtMat.TabIndex = 6;
            this.txtMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProm
            // 
            this.txtProm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtProm.Location = new System.Drawing.Point(324, 113);
            this.txtProm.Name = "txtProm";
            this.txtProm.ReadOnly = true;
            this.txtProm.Size = new System.Drawing.Size(56, 20);
            this.txtProm.TabIndex = 9;
            this.txtProm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtProm
            // 
            this.dtProm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtProm.Location = new System.Drawing.Point(98, 112);
            this.dtProm.Name = "dtProm";
            this.dtProm.Size = new System.Drawing.Size(210, 20);
            this.dtProm.TabIndex = 8;
            this.dtProm.ValueChanged += new System.EventHandler(this.dtMat_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Promoce";
            // 
            // txtSvat
            // 
            this.txtSvat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSvat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSvat.Location = new System.Drawing.Point(324, 149);
            this.txtSvat.Name = "txtSvat";
            this.txtSvat.ReadOnly = true;
            this.txtSvat.Size = new System.Drawing.Size(56, 20);
            this.txtSvat.TabIndex = 12;
            this.txtSvat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtSvat
            // 
            this.dtSvat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtSvat.Location = new System.Drawing.Point(98, 148);
            this.dtSvat.Name = "dtSvat";
            this.dtSvat.Size = new System.Drawing.Size(210, 20);
            this.dtSvat.TabIndex = 11;
            this.dtSvat.ValueChanged += new System.EventHandler(this.dtMat_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Svatba";
            // 
            // txtDuch
            // 
            this.txtDuch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDuch.Location = new System.Drawing.Point(324, 185);
            this.txtDuch.Name = "txtDuch";
            this.txtDuch.ReadOnly = true;
            this.txtDuch.Size = new System.Drawing.Size(56, 20);
            this.txtDuch.TabIndex = 15;
            this.txtDuch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtDuch
            // 
            this.dtDuch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDuch.Location = new System.Drawing.Point(98, 184);
            this.dtDuch.Name = "dtDuch";
            this.dtDuch.Size = new System.Drawing.Size(210, 20);
            this.dtDuch.TabIndex = 14;
            this.dtDuch.ValueChanged += new System.EventHandler(this.dtMat_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Důchod";
            // 
            // txtUmrt
            // 
            this.txtUmrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUmrt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUmrt.Location = new System.Drawing.Point(324, 221);
            this.txtUmrt.Name = "txtUmrt";
            this.txtUmrt.ReadOnly = true;
            this.txtUmrt.Size = new System.Drawing.Size(56, 20);
            this.txtUmrt.TabIndex = 18;
            this.txtUmrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtUmrt
            // 
            this.dtUmrt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtUmrt.Location = new System.Drawing.Point(98, 220);
            this.dtUmrt.Name = "dtUmrt";
            this.dtUmrt.Size = new System.Drawing.Size(210, 20);
            this.dtUmrt.TabIndex = 17;
            this.dtUmrt.ValueChanged += new System.EventHandler(this.dtMat_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Úmrtí";
            // 
            // txtDnes
            // 
            this.txtDnes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDnes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDnes.Location = new System.Drawing.Point(324, 40);
            this.txtDnes.Name = "txtDnes";
            this.txtDnes.ReadOnly = true;
            this.txtDnes.Size = new System.Drawing.Size(56, 20);
            this.txtDnes.TabIndex = 19;
            this.txtDnes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Dnes roků";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 275);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(459, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 17);
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 17);
            this.lblTime.Text = "Time";
            // 
            // txtDnesD
            // 
            this.txtDnesD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDnesD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDnesD.Location = new System.Drawing.Point(386, 40);
            this.txtDnesD.Name = "txtDnesD";
            this.txtDnesD.ReadOnly = true;
            this.txtDnesD.Size = new System.Drawing.Size(53, 20);
            this.txtDnesD.TabIndex = 27;
            this.txtDnesD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUmrtD
            // 
            this.txtUmrtD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUmrtD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUmrtD.Location = new System.Drawing.Point(386, 221);
            this.txtUmrtD.Name = "txtUmrtD";
            this.txtUmrtD.ReadOnly = true;
            this.txtUmrtD.Size = new System.Drawing.Size(53, 20);
            this.txtUmrtD.TabIndex = 26;
            this.txtUmrtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDuchD
            // 
            this.txtDuchD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuchD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDuchD.Location = new System.Drawing.Point(386, 185);
            this.txtDuchD.Name = "txtDuchD";
            this.txtDuchD.ReadOnly = true;
            this.txtDuchD.Size = new System.Drawing.Size(53, 20);
            this.txtDuchD.TabIndex = 25;
            this.txtDuchD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSvatD
            // 
            this.txtSvatD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSvatD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSvatD.Location = new System.Drawing.Point(386, 149);
            this.txtSvatD.Name = "txtSvatD";
            this.txtSvatD.ReadOnly = true;
            this.txtSvatD.Size = new System.Drawing.Size(53, 20);
            this.txtSvatD.TabIndex = 24;
            this.txtSvatD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPromD
            // 
            this.txtPromD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPromD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPromD.Location = new System.Drawing.Point(386, 113);
            this.txtPromD.Name = "txtPromD";
            this.txtPromD.ReadOnly = true;
            this.txtPromD.Size = new System.Drawing.Size(53, 20);
            this.txtPromD.TabIndex = 23;
            this.txtPromD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMatD
            // 
            this.txtMatD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMatD.Location = new System.Drawing.Point(386, 77);
            this.txtMatD.Name = "txtMatD";
            this.txtMatD.ReadOnly = true;
            this.txtMatD.Size = new System.Drawing.Size(53, 20);
            this.txtMatD.TabIndex = 22;
            this.txtMatD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Dní";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 297);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDnesD);
            this.Controls.Add(this.txtUmrtD);
            this.Controls.Add(this.txtDuchD);
            this.Controls.Add(this.txtSvatD);
            this.Controls.Add(this.txtPromD);
            this.Controls.Add(this.txtMatD);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDnes);
            this.Controls.Add(this.txtUmrt);
            this.Controls.Add(this.dtUmrt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDuch);
            this.Controls.Add(this.dtDuch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSvat);
            this.Controls.Add(this.dtSvat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProm);
            this.Controls.Add(this.dtProm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.dtMat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtNar);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(416, 336);
            this.Name = "Form1";
            this.Text = "Životní události osoby";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNar;
        private System.Windows.Forms.DateTimePicker dtMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.TextBox txtProm;
        private System.Windows.Forms.DateTimePicker dtProm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSvat;
        private System.Windows.Forms.DateTimePicker dtSvat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDuch;
        private System.Windows.Forms.DateTimePicker dtDuch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUmrt;
        private System.Windows.Forms.DateTimePicker dtUmrt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDnes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.TextBox txtDnesD;
        private System.Windows.Forms.TextBox txtUmrtD;
        private System.Windows.Forms.TextBox txtDuchD;
        private System.Windows.Forms.TextBox txtSvatD;
        private System.Windows.Forms.TextBox txtPromD;
        private System.Windows.Forms.TextBox txtMatD;
        private System.Windows.Forms.Label label9;
    }
}

