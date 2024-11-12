
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
            this.components = new System.ComponentModel.Container();
            this.dtPickerPonke = new System.Windows.Forms.DateTimePicker();
            this.txtHod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAkt = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLet = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.txtHodiny = new System.Windows.Forms.TextBox();
            this.txtMinuty = new System.Windows.Forms.TextBox();
            this.txtSekundy = new System.Windows.Forms.TextBox();
            this.txtMilisekundy = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtDny = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtPickerPonke
            // 
            this.dtPickerPonke.Enabled = false;
            this.dtPickerPonke.Location = new System.Drawing.Point(139, 34);
            this.dtPickerPonke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtPickerPonke.Name = "dtPickerPonke";
            this.dtPickerPonke.Size = new System.Drawing.Size(265, 22);
            this.dtPickerPonke.TabIndex = 0;
            this.dtPickerPonke.Value = new System.DateTime(2023, 12, 24, 0, 0, 0, 0);
            // 
            // txtHod
            // 
            this.txtHod.Location = new System.Drawing.Point(131, 170);
            this.txtHod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHod.Name = "txtHod";
            this.txtHod.Size = new System.Drawing.Size(132, 22);
            this.txtHod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datum narození";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(413, 313);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osobní údaje o PONKE";
            // 
            // btnAkt
            // 
            this.btnAkt.Location = new System.Drawing.Point(152, 273);
            this.btnAkt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAkt.Name = "btnAkt";
            this.btnAkt.Size = new System.Drawing.Size(100, 28);
            this.btnAkt.TabIndex = 12;
            this.btnAkt.Text = "Aktualizovat";
            this.btnAkt.UseVisualStyleBackColor = true;
            this.btnAkt.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(272, 242);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 17);
            this.label17.TabIndex = 19;
            this.label17.Text = "sekund";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 242);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 17);
            this.label18.TabIndex = 18;
            this.label18.Text = "Ponke je staré ";
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(131, 234);
            this.txtSec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(132, 22);
            this.txtSec.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(272, 210);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 17);
            this.label16.TabIndex = 16;
            this.label16.Text = "minut";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 210);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "Ponke je staré ";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(131, 202);
            this.txtMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(132, 22);
            this.txtMin.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(272, 178);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "hodin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(272, 150);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "dní";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "měsíců";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "let";
            // 
            // txtLet
            // 
            this.txtLet.Location = new System.Drawing.Point(131, 84);
            this.txtLet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLet.Name = "txtLet";
            this.txtLet.Size = new System.Drawing.Size(132, 22);
            this.txtLet.TabIndex = 9;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(131, 113);
            this.txtMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(132, 22);
            this.txtMes.TabIndex = 8;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(131, 142);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(132, 22);
            this.txtDni.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ponke je staré ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ponke je staré ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ponke je staré ";
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
            this.groupBox2.Location = new System.Drawing.Point(467, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(413, 313);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Osobní údaje o TOBĚ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 238);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 17);
            this.label24.TabIndex = 23;
            this.label24.Text = "Ty jsi starý";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(19, 178);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 17);
            this.label23.TabIndex = 22;
            this.label23.Text = "Ty jsi starý";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 150);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 17);
            this.label22.TabIndex = 21;
            this.label22.Text = "Ty jsi starý";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 210);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Ty jsi starý";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ty jsi starý";
            // 
            // btnAktYou
            // 
            this.btnAktYou.Location = new System.Drawing.Point(152, 273);
            this.btnAktYou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAktYou.Name = "btnAktYou";
            this.btnAktYou.Size = new System.Drawing.Size(100, 28);
            this.btnAktYou.TabIndex = 12;
            this.btnAktYou.Text = "Aktualizovat";
            this.btnAktYou.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "sekund";
            // 
            // txtSecYou
            // 
            this.txtSecYou.Location = new System.Drawing.Point(131, 234);
            this.txtSecYou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSecYou.Name = "txtSecYou";
            this.txtSecYou.Size = new System.Drawing.Size(132, 22);
            this.txtSecYou.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "minut";
            // 
            // txtMinYou
            // 
            this.txtMinYou.Location = new System.Drawing.Point(131, 202);
            this.txtMinYou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMinYou.Name = "txtMinYou";
            this.txtMinYou.Size = new System.Drawing.Size(132, 22);
            this.txtMinYou.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(272, 178);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "hodin";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(272, 150);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 17);
            this.label19.TabIndex = 12;
            this.label19.Text = "dní";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(272, 117);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 17);
            this.label20.TabIndex = 11;
            this.label20.Text = "měsíců";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(272, 89);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 17);
            this.label21.TabIndex = 10;
            this.label21.Text = "let";
            // 
            // txtLetYou
            // 
            this.txtLetYou.Location = new System.Drawing.Point(131, 84);
            this.txtLetYou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLetYou.Name = "txtLetYou";
            this.txtLetYou.Size = new System.Drawing.Size(132, 22);
            this.txtLetYou.TabIndex = 9;
            // 
            // txtMesYou
            // 
            this.txtMesYou.Location = new System.Drawing.Point(131, 113);
            this.txtMesYou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMesYou.Name = "txtMesYou";
            this.txtMesYou.Size = new System.Drawing.Size(132, 22);
            this.txtMesYou.TabIndex = 8;
            // 
            // txtDniYou
            // 
            this.txtDniYou.Location = new System.Drawing.Point(131, 142);
            this.txtDniYou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDniYou.Name = "txtDniYou";
            this.txtDniYou.Size = new System.Drawing.Size(132, 22);
            this.txtDniYou.TabIndex = 7;
            // 
            // txtHodYou
            // 
            this.txtHodYou.Location = new System.Drawing.Point(131, 170);
            this.txtHodYou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHodYou.Name = "txtHodYou";
            this.txtHodYou.Size = new System.Drawing.Size(132, 22);
            this.txtHodYou.TabIndex = 1;
            // 
            // dtPickerYou
            // 
            this.dtPickerYou.Location = new System.Drawing.Point(139, 34);
            this.dtPickerYou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtPickerYou.Name = "dtPickerYou";
            this.dtPickerYou.Size = new System.Drawing.Size(265, 22);
            this.dtPickerYou.TabIndex = 0;
            this.dtPickerYou.Value = new System.DateTime(2024, 10, 10, 0, 0, 0, 0);
            this.dtPickerYou.ValueChanged += new System.EventHandler(this.dtPickerYou_ValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 36);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(108, 17);
            this.label25.TabIndex = 3;
            this.label25.Text = "Datum narození";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(19, 89);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(76, 17);
            this.label26.TabIndex = 4;
            this.label26.Text = "Ty jsi starý";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.tmrStartTime_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(387, 361);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 23);
            this.btnStart.TabIndex = 21;
            this.btnStart.Text = "StartTimer";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // txtHodiny
            // 
            this.txtHodiny.Location = new System.Drawing.Point(387, 413);
            this.txtHodiny.Name = "txtHodiny";
            this.txtHodiny.Size = new System.Drawing.Size(100, 22);
            this.txtHodiny.TabIndex = 22;
            // 
            // txtMinuty
            // 
            this.txtMinuty.Location = new System.Drawing.Point(387, 441);
            this.txtMinuty.Name = "txtMinuty";
            this.txtMinuty.Size = new System.Drawing.Size(100, 22);
            this.txtMinuty.TabIndex = 23;
            // 
            // txtSekundy
            // 
            this.txtSekundy.Location = new System.Drawing.Point(387, 469);
            this.txtSekundy.Name = "txtSekundy";
            this.txtSekundy.Size = new System.Drawing.Size(100, 22);
            this.txtSekundy.TabIndex = 24;
            // 
            // txtMilisekundy
            // 
            this.txtMilisekundy.Location = new System.Drawing.Point(387, 497);
            this.txtMilisekundy.Name = "txtMilisekundy";
            this.txtMilisekundy.Size = new System.Drawing.Size(100, 22);
            this.txtMilisekundy.TabIndex = 25;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(228, 441);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 22);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(228, 497);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(108, 22);
            this.btnStop.TabIndex = 27;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(495, 417);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(16, 17);
            this.label27.TabIndex = 28;
            this.label27.Text = "h";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(495, 446);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(19, 17);
            this.label28.TabIndex = 29;
            this.label28.Text = "m";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(495, 472);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(15, 17);
            this.label29.TabIndex = 30;
            this.label29.Text = "s";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(495, 502);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(26, 17);
            this.label30.TabIndex = 31;
            this.label30.Text = "ms";
            // 
            // txtDny
            // 
            this.txtDny.Location = new System.Drawing.Point(387, 390);
            this.txtDny.Name = "txtDny";
            this.txtDny.Size = new System.Drawing.Size(100, 22);
            this.txtDny.TabIndex = 32;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(493, 390);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(16, 17);
            this.label31.TabIndex = 33;
            this.label31.Text = "d";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.txtDny);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtMilisekundy);
            this.Controls.Add(this.txtSekundy);
            this.Controls.Add(this.txtMinuty);
            this.Controls.Add(this.txtHodiny);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "PONKE JE NEJLEPŠÍ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtHodiny;
        private System.Windows.Forms.TextBox txtMinuty;
        private System.Windows.Forms.TextBox txtSekundy;
        private System.Windows.Forms.TextBox txtMilisekundy;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtDny;
        private System.Windows.Forms.Label label31;
    }
}

