namespace OknoGrafiky
{
    partial class fOknoGrafiky
    {
        /// <summary>
        /// Vyžadovaná proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolnit všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by měl být spravovaný prostředek odstraněn, jinak false.</param>
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
        /// Metoda vyžadovaná pro podporu návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radBtnCara = new System.Windows.Forms.RadioButton();
            this.radBtnCtverec = new System.Windows.Forms.RadioButton();
            this.radBtnObdelnik = new System.Windows.Forms.RadioButton();
            this.radBtnElipsa = new System.Windows.Forms.RadioButton();
            this.radBtnKruznice = new System.Windows.Forms.RadioButton();
            this.radBtnTrojuhelnik = new System.Windows.Forms.RadioButton();
            this.radBtnDomecek = new System.Windows.Forms.RadioButton();
            this.radBtnObrazek = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numH = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numW = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numW)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(25, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 338);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radBtnCara);
            this.flowLayoutPanel1.Controls.Add(this.radBtnCtverec);
            this.flowLayoutPanel1.Controls.Add(this.radBtnObdelnik);
            this.flowLayoutPanel1.Controls.Add(this.radBtnElipsa);
            this.flowLayoutPanel1.Controls.Add(this.radBtnKruznice);
            this.flowLayoutPanel1.Controls.Add(this.radBtnTrojuhelnik);
            this.flowLayoutPanel1.Controls.Add(this.radBtnDomecek);
            this.flowLayoutPanel1.Controls.Add(this.radBtnObrazek);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 385);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(366, 66);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // radBtnCara
            // 
            this.radBtnCara.Location = new System.Drawing.Point(3, 3);
            this.radBtnCara.Name = "radBtnCara";
            this.radBtnCara.Size = new System.Drawing.Size(80, 24);
            this.radBtnCara.TabIndex = 0;
            this.radBtnCara.TabStop = true;
            this.radBtnCara.Text = "Čára";
            this.radBtnCara.UseVisualStyleBackColor = true;
            this.radBtnCara.CheckedChanged += new System.EventHandler(this.radBtnOrazec_CheckedChanged);
            // 
            // radBtnCtverec
            // 
            this.radBtnCtverec.Location = new System.Drawing.Point(89, 3);
            this.radBtnCtverec.Name = "radBtnCtverec";
            this.radBtnCtverec.Size = new System.Drawing.Size(80, 24);
            this.radBtnCtverec.TabIndex = 1;
            this.radBtnCtverec.TabStop = true;
            this.radBtnCtverec.Text = "Čtverec";
            this.radBtnCtverec.UseVisualStyleBackColor = true;
            this.radBtnCtverec.CheckedChanged += new System.EventHandler(this.radBtnOrazec_CheckedChanged);
            // 
            // radBtnObdelnik
            // 
            this.radBtnObdelnik.Location = new System.Drawing.Point(175, 3);
            this.radBtnObdelnik.Name = "radBtnObdelnik";
            this.radBtnObdelnik.Size = new System.Drawing.Size(80, 24);
            this.radBtnObdelnik.TabIndex = 2;
            this.radBtnObdelnik.TabStop = true;
            this.radBtnObdelnik.Text = "Obdélník";
            this.radBtnObdelnik.UseVisualStyleBackColor = true;
            this.radBtnObdelnik.CheckedChanged += new System.EventHandler(this.radBtnOrazec_CheckedChanged);
            // 
            // radBtnElipsa
            // 
            this.radBtnElipsa.Location = new System.Drawing.Point(261, 3);
            this.radBtnElipsa.Name = "radBtnElipsa";
            this.radBtnElipsa.Size = new System.Drawing.Size(80, 24);
            this.radBtnElipsa.TabIndex = 3;
            this.radBtnElipsa.TabStop = true;
            this.radBtnElipsa.Text = "Elipsa";
            this.radBtnElipsa.UseVisualStyleBackColor = true;
            this.radBtnElipsa.CheckedChanged += new System.EventHandler(this.radBtnOrazec_CheckedChanged);
            // 
            // radBtnKruznice
            // 
            this.radBtnKruznice.Location = new System.Drawing.Point(3, 33);
            this.radBtnKruznice.Name = "radBtnKruznice";
            this.radBtnKruznice.Size = new System.Drawing.Size(80, 24);
            this.radBtnKruznice.TabIndex = 4;
            this.radBtnKruznice.TabStop = true;
            this.radBtnKruznice.Text = "Kružnice";
            this.radBtnKruznice.UseVisualStyleBackColor = true;
            this.radBtnKruznice.CheckedChanged += new System.EventHandler(this.radBtnOrazec_CheckedChanged);
            // 
            // radBtnTrojuhelnik
            // 
            this.radBtnTrojuhelnik.Location = new System.Drawing.Point(89, 33);
            this.radBtnTrojuhelnik.Name = "radBtnTrojuhelnik";
            this.radBtnTrojuhelnik.Size = new System.Drawing.Size(80, 24);
            this.radBtnTrojuhelnik.TabIndex = 5;
            this.radBtnTrojuhelnik.TabStop = true;
            this.radBtnTrojuhelnik.Text = "Trojúhelník";
            this.radBtnTrojuhelnik.UseVisualStyleBackColor = true;
            this.radBtnTrojuhelnik.CheckedChanged += new System.EventHandler(this.radBtnOrazec_CheckedChanged);
            // 
            // radBtnDomecek
            // 
            this.radBtnDomecek.Location = new System.Drawing.Point(175, 33);
            this.radBtnDomecek.Name = "radBtnDomecek";
            this.radBtnDomecek.Size = new System.Drawing.Size(80, 24);
            this.radBtnDomecek.TabIndex = 6;
            this.radBtnDomecek.TabStop = true;
            this.radBtnDomecek.Text = "Domeček";
            this.radBtnDomecek.UseVisualStyleBackColor = true;
            this.radBtnDomecek.CheckedChanged += new System.EventHandler(this.radBtnOrazec_CheckedChanged);
            // 
            // radBtnObrazek
            // 
            this.radBtnObrazek.Location = new System.Drawing.Point(261, 33);
            this.radBtnObrazek.Name = "radBtnObrazek";
            this.radBtnObrazek.Size = new System.Drawing.Size(80, 24);
            this.radBtnObrazek.TabIndex = 7;
            this.radBtnObrazek.TabStop = true;
            this.radBtnObrazek.Text = "Obrázek";
            this.radBtnObrazek.UseVisualStyleBackColor = true;
            this.radBtnObrazek.CheckedChanged += new System.EventHandler(this.radBtnOrazec_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numX);
            this.groupBox1.Location = new System.Drawing.Point(412, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pozice X,Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "pozice Y";
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(254, 30);
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(77, 20);
            this.numY.TabIndex = 2;
            this.numY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numY.ValueChanged += new System.EventHandler(this.numXY_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "pozice X";
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(79, 30);
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(77, 20);
            this.numX.TabIndex = 0;
            this.numX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numX.ValueChanged += new System.EventHandler(this.numXY_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numH);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numW);
            this.groupBox2.Location = new System.Drawing.Point(412, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 65);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rozmery W,H";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "výška H";
            // 
            // numH
            // 
            this.numH.Location = new System.Drawing.Point(254, 30);
            this.numH.Name = "numH";
            this.numH.Size = new System.Drawing.Size(77, 20);
            this.numH.TabIndex = 2;
            this.numH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numH.ValueChanged += new System.EventHandler(this.numWH_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "šířka W";
            // 
            // numW
            // 
            this.numW.Location = new System.Drawing.Point(79, 30);
            this.numW.Name = "numW";
            this.numW.Size = new System.Drawing.Size(77, 20);
            this.numW.TabIndex = 0;
            this.numW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numW.ValueChanged += new System.EventHandler(this.numWH_ValueChanged);
            // 
            // fOknoGrafiky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "fOknoGrafiky";
            this.Text = "Okno Grafiky";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radBtnCara;
        private System.Windows.Forms.RadioButton radBtnCtverec;
        private System.Windows.Forms.RadioButton radBtnObdelnik;
        private System.Windows.Forms.RadioButton radBtnElipsa;
        private System.Windows.Forms.RadioButton radBtnKruznice;
        private System.Windows.Forms.RadioButton radBtnTrojuhelnik;
        private System.Windows.Forms.RadioButton radBtnDomecek;
        private System.Windows.Forms.RadioButton radBtnObrazek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numW;
    }
}

