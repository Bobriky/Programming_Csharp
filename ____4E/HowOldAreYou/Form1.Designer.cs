
namespace HowOldAreYou
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
            this.dtPickerPonke = new System.Windows.Forms.DateTimePicker();
            this.txtHod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtLet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.btnAkt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAktYou = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecYou = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinYou = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtLetYou = new System.Windows.Forms.TextBox();
            this.txtMesYou = new System.Windows.Forms.TextBox();
            this.txtDniYou = new System.Windows.Forms.TextBox();
            this.txtHodYou = new System.Windows.Forms.TextBox();
            this.dtPickerYou = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtPickerPonke
            // 
            this.dtPickerPonke.Enabled = false;
            this.dtPickerPonke.Location = new System.Drawing.Point(104, 28);
            this.dtPickerPonke.Name = "dtPickerPonke";
            this.dtPickerPonke.Size = new System.Drawing.Size(200, 20);
            this.dtPickerPonke.TabIndex = 0;
            this.dtPickerPonke.Value = new System.DateTime(2023, 12, 24, 0, 0, 0, 0);
            // 
            // txtHod
            // 
            this.txtHod.Location = new System.Drawing.Point(98, 138);
            this.txtHod.Name = "txtHod";
            this.txtHod.Size = new System.Drawing.Size(100, 20);
            this.txtHod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datum narození";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ponke je staré ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAkt);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtSec);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtLet);
            this.groupBox1.Controls.Add(this.txtMes);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHod);
            this.groupBox1.Controls.Add(this.dtPickerPonke);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 254);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osobní údaje o PONKE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ponke je staré ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ponke je staré ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ponke je staré ";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(98, 115);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 7;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(98, 92);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 8;
            // 
            // txtLet
            // 
            this.txtLet.Location = new System.Drawing.Point(98, 68);
            this.txtLet.Name = "txtLet";
            this.txtLet.Size = new System.Drawing.Size(100, 20);
            this.txtLet.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "let";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "měsíců";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "dní";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(204, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "hodin";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(98, 164);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 20);
            this.txtMin.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Ponke je staré ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(204, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "minut";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(204, 197);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "sekund";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 197);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Ponke je staré ";
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(98, 190);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(100, 20);
            this.txtSec.TabIndex = 17;
            // 
            // btnAkt
            // 
            this.btnAkt.Location = new System.Drawing.Point(114, 222);
            this.btnAkt.Name = "btnAkt";
            this.btnAkt.Size = new System.Drawing.Size(75, 23);
            this.btnAkt.TabIndex = 12;
            this.btnAkt.Text = "Aktualizovat";
            this.btnAkt.UseVisualStyleBackColor = true;
            this.btnAkt.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnAktYou);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSecYou);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMinYou);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtLetYou);
            this.groupBox2.Controls.Add(this.txtMesYou);
            this.groupBox2.Controls.Add(this.txtDniYou);
            this.groupBox2.Controls.Add(this.txtHodYou);
            this.groupBox2.Controls.Add(this.dtPickerYou);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Location = new System.Drawing.Point(350, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 254);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Osobní údaje o TOBĚ";
            // 
            // btnAktYou
            // 
            this.btnAktYou.Location = new System.Drawing.Point(114, 222);
            this.btnAktYou.Name = "btnAktYou";
            this.btnAktYou.Size = new System.Drawing.Size(75, 23);
            this.btnAktYou.TabIndex = 12;
            this.btnAktYou.Text = "Aktualizovat";
            this.btnAktYou.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "sekund";
            // 
            // txtSecYou
            // 
            this.txtSecYou.Location = new System.Drawing.Point(98, 190);
            this.txtSecYou.Name = "txtSecYou";
            this.txtSecYou.Size = new System.Drawing.Size(100, 20);
            this.txtSecYou.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "minut";
            // 
            // txtMinYou
            // 
            this.txtMinYou.Location = new System.Drawing.Point(98, 164);
            this.txtMinYou.Name = "txtMinYou";
            this.txtMinYou.Size = new System.Drawing.Size(100, 20);
            this.txtMinYou.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(204, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "hodin";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(204, 122);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "dní";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(204, 95);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "měsíců";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(204, 72);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 13);
            this.label21.TabIndex = 10;
            this.label21.Text = "let";
            // 
            // txtLetYou
            // 
            this.txtLetYou.Location = new System.Drawing.Point(98, 68);
            this.txtLetYou.Name = "txtLetYou";
            this.txtLetYou.Size = new System.Drawing.Size(100, 20);
            this.txtLetYou.TabIndex = 9;
            // 
            // txtMesYou
            // 
            this.txtMesYou.Location = new System.Drawing.Point(98, 92);
            this.txtMesYou.Name = "txtMesYou";
            this.txtMesYou.Size = new System.Drawing.Size(100, 20);
            this.txtMesYou.TabIndex = 8;
            // 
            // txtDniYou
            // 
            this.txtDniYou.Location = new System.Drawing.Point(98, 115);
            this.txtDniYou.Name = "txtDniYou";
            this.txtDniYou.Size = new System.Drawing.Size(100, 20);
            this.txtDniYou.TabIndex = 7;
            // 
            // txtHodYou
            // 
            this.txtHodYou.Location = new System.Drawing.Point(98, 138);
            this.txtHodYou.Name = "txtHodYou";
            this.txtHodYou.Size = new System.Drawing.Size(100, 20);
            this.txtHodYou.TabIndex = 1;
            // 
            // dtPickerYou
            // 
            this.dtPickerYou.Location = new System.Drawing.Point(104, 28);
            this.dtPickerYou.Name = "dtPickerYou";
            this.dtPickerYou.Size = new System.Drawing.Size(200, 20);
            this.dtPickerYou.TabIndex = 0;
            this.dtPickerYou.Value = new System.DateTime(2024, 10, 10, 0, 0, 0, 0);
            this.dtPickerYou.ValueChanged += new System.EventHandler(this.dtPickerYou_ValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 29);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 13);
            this.label25.TabIndex = 3;
            this.label25.Text = "Datum narození";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(14, 72);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 13);
            this.label26.TabIndex = 4;
            this.label26.Text = "Ty jsi starý";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ty jsi starý";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Ty jsi starý";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 122);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "Ty jsi starý";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 145);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "Ty jsi starý";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(14, 193);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 13);
            this.label24.TabIndex = 23;
            this.label24.Text = "Ty jsi starý";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "PONKE JE NEJLEPŠÍ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPickerPonke;
        private System.Windows.Forms.TextBox txtHod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLet;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAkt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAktYou;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecYou;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinYou;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtLetYou;
        private System.Windows.Forms.TextBox txtMesYou;
        private System.Windows.Forms.TextBox txtDniYou;
        private System.Windows.Forms.TextBox txtHodYou;
        private System.Windows.Forms.DateTimePicker dtPickerYou;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
    }
}

