
namespace Rezistory
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxValue1 = new System.Windows.Forms.TextBox();
            this.txtBoxValue2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxParalelně = new System.Windows.Forms.TextBox();
            this.txtBoxSeriove = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVypočítat = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnKonec = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezistor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rezistor 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxValue2);
            this.groupBox1.Controls.Add(this.txtBoxValue1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametry rezistorů";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Program na rezistorky";
            // 
            // txtBoxValue1
            // 
            this.txtBoxValue1.Location = new System.Drawing.Point(99, 24);
            this.txtBoxValue1.Name = "txtBoxValue1";
            this.txtBoxValue1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValue1.TabIndex = 0;
            this.txtBoxValue1.Text = "1";
            this.txtBoxValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxValue1.TextChanged += new System.EventHandler(this.txtBoxValue1_TextChanged);
            // 
            // txtBoxValue2
            // 
            this.txtBoxValue2.Location = new System.Drawing.Point(99, 57);
            this.txtBoxValue2.Name = "txtBoxValue2";
            this.txtBoxValue2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValue2.TabIndex = 1;
            this.txtBoxValue2.Text = "1";
            this.txtBoxValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxValue2.TextChanged += new System.EventHandler(this.txtBoxValue1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ohm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ohm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBoxParalelně);
            this.groupBox2.Controls.Add(this.txtBoxSeriove);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(24, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 90);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Výpočet typů zapojení";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ohm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ohm";
            // 
            // txtBoxParalelně
            // 
            this.txtBoxParalelně.Location = new System.Drawing.Point(99, 57);
            this.txtBoxParalelně.Name = "txtBoxParalelně";
            this.txtBoxParalelně.ReadOnly = true;
            this.txtBoxParalelně.Size = new System.Drawing.Size(100, 20);
            this.txtBoxParalelně.TabIndex = 3;
            this.txtBoxParalelně.TabStop = false;
            this.txtBoxParalelně.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxSeriove
            // 
            this.txtBoxSeriove.Location = new System.Drawing.Point(99, 24);
            this.txtBoxSeriove.Name = "txtBoxSeriove";
            this.txtBoxSeriove.ReadOnly = true;
            this.txtBoxSeriove.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSeriove.TabIndex = 2;
            this.txtBoxSeriove.TabStop = false;
            this.txtBoxSeriove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sériové";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Paralelní";
            // 
            // btnVypočítat
            // 
            this.btnVypočítat.Location = new System.Drawing.Point(105, 167);
            this.btnVypočítat.Name = "btnVypočítat";
            this.btnVypočítat.Size = new System.Drawing.Size(123, 39);
            this.btnVypočítat.TabIndex = 0;
            this.btnVypočítat.Text = "Vypočítat";
            this.btnVypočítat.UseVisualStyleBackColor = true;
            this.btnVypočítat.Click += new System.EventHandler(this.btnVypočítat_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(148, 357);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnKonec
            // 
            this.btnKonec.Location = new System.Drawing.Point(234, 357);
            this.btnKonec.Name = "btnKonec";
            this.btnKonec.Size = new System.Drawing.Size(75, 23);
            this.btnKonec.TabIndex = 2;
            this.btnKonec.Text = "Konec";
            this.btnKonec.UseVisualStyleBackColor = true;
            this.btnKonec.Click += new System.EventHandler(this.btnKonec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 401);
            this.Controls.Add(this.btnKonec);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnVypočítat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(343, 440);
            this.MinimumSize = new System.Drawing.Size(343, 440);
            this.Name = "Form1";
            this.Text = "Rezistory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxValue2;
        private System.Windows.Forms.TextBox txtBoxValue1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxParalelně;
        private System.Windows.Forms.TextBox txtBoxSeriove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVypočítat;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnKonec;
    }
}

