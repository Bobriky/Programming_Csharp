
namespace KalkulaceZ
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nmL = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nmR = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nmC = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSRO = new System.Windows.Forms.RadioButton();
            this.btnPRO = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstView = new System.Windows.Forms.ListView();
            this.index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.odporR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.indukcnostL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kapacitaC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reaktanceL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reaktanceC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.impedanceZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.admitanceY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fazovyPosun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rezozancniFrekvence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbRezF = new System.Windows.Forms.ComboBox();
            this.cmbP = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nmRezF = new System.Windows.Forms.NumericUpDown();
            this.nmP = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbY = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmY = new System.Windows.Forms.NumericUpDown();
            this.cmbZ = new System.Windows.Forms.ComboBox();
            this.cmbXC = new System.Windows.Forms.ComboBox();
            this.cmbXL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmZ = new System.Windows.Forms.NumericUpDown();
            this.nmXC = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nmXL = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbF = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nmF = new System.Windows.Forms.NumericUpDown();
            this.cmbC = new System.Windows.Forms.ComboBox();
            this.cmbL = new System.Windows.Forms.ComboBox();
            this.cmbR = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmRezF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmXC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmXL)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmF)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // nmL
            // 
            this.nmL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmL.DecimalPlaces = 4;
            this.nmL.Location = new System.Drawing.Point(189, 53);
            this.nmL.Margin = new System.Windows.Forms.Padding(4);
            this.nmL.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmL.Name = "nmL";
            this.nmL.Size = new System.Drawing.Size(212, 22);
            this.nmL.TabIndex = 21;
            this.nmL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmL.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Indukčnost L";
            // 
            // nmR
            // 
            this.nmR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmR.DecimalPlaces = 4;
            this.nmR.Location = new System.Drawing.Point(189, 22);
            this.nmR.Margin = new System.Windows.Forms.Padding(4);
            this.nmR.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmR.Name = "nmR";
            this.nmR.Size = new System.Drawing.Size(212, 22);
            this.nmR.TabIndex = 24;
            this.nmR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmR.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Odpor R";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(21, 235);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(220, 28);
            this.btnCalculate.TabIndex = 27;
            this.btnCalculate.Text = "Dopočítat rezonanční prvky";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nmC
            // 
            this.nmC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmC.DecimalPlaces = 4;
            this.nmC.Location = new System.Drawing.Point(189, 82);
            this.nmC.Margin = new System.Windows.Forms.Padding(4);
            this.nmC.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmC.Name = "nmC";
            this.nmC.Size = new System.Drawing.Size(212, 22);
            this.nmC.TabIndex = 29;
            this.nmC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmC.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Kapacita C";
            // 
            // btnSRO
            // 
            this.btnSRO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSRO.AutoSize = true;
            this.btnSRO.Checked = true;
            this.btnSRO.Location = new System.Drawing.Point(251, 144);
            this.btnSRO.Margin = new System.Windows.Forms.Padding(4);
            this.btnSRO.Name = "btnSRO";
            this.btnSRO.Size = new System.Drawing.Size(193, 21);
            this.btnSRO.TabIndex = 30;
            this.btnSRO.TabStop = true;
            this.btnSRO.Text = "Sériový rezonanční obvod";
            this.btnSRO.UseVisualStyleBackColor = true;
            this.btnSRO.CheckedChanged += new System.EventHandler(this.btnSRO_CheckedChanged);
            // 
            // btnPRO
            // 
            this.btnPRO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPRO.AutoSize = true;
            this.btnPRO.Location = new System.Drawing.Point(251, 170);
            this.btnPRO.Margin = new System.Windows.Forms.Padding(4);
            this.btnPRO.Name = "btnPRO";
            this.btnPRO.Size = new System.Drawing.Size(201, 21);
            this.btnPRO.TabIndex = 31;
            this.btnPRO.Text = "Paralelní rezonanční obvod";
            this.btnPRO.UseVisualStyleBackColor = true;
            this.btnPRO.CheckedChanged += new System.EventHandler(this.btnSRO_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lstView);
            this.groupBox1.Location = new System.Drawing.Point(538, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(871, 492);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabulka zaznamenaných výpočtů";
            // 
            // lstView
            // 
            this.lstView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.index,
            this.odporR,
            this.indukcnostL,
            this.kapacitaC,
            this.reaktanceL,
            this.reaktanceC,
            this.impedanceZ,
            this.admitanceY,
            this.fazovyPosun,
            this.rezozancniFrekvence});
            this.lstView.HideSelection = false;
            this.lstView.Location = new System.Drawing.Point(7, 21);
            this.lstView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(857, 463);
            this.lstView.TabIndex = 0;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            this.lstView.ItemActivate += new System.EventHandler(this.lstView_ItemActivate);
            // 
            // index
            // 
            this.index.Text = "Rez. graf";
            this.index.Width = 85;
            // 
            // odporR
            // 
            this.odporR.Text = "R[Ω]";
            this.odporR.Width = 85;
            // 
            // indukcnostL
            // 
            this.indukcnostL.Text = "L[H]";
            this.indukcnostL.Width = 85;
            // 
            // kapacitaC
            // 
            this.kapacitaC.Text = "C[F]";
            this.kapacitaC.Width = 85;
            // 
            // reaktanceL
            // 
            this.reaktanceL.Text = "XL[Ω]";
            this.reaktanceL.Width = 85;
            // 
            // reaktanceC
            // 
            this.reaktanceC.Text = "XC[Ω]";
            this.reaktanceC.Width = 85;
            // 
            // impedanceZ
            // 
            this.impedanceZ.Text = "Z[Ω]";
            this.impedanceZ.Width = 85;
            // 
            // admitanceY
            // 
            this.admitanceY.Text = "Y[Ω]";
            this.admitanceY.Width = 85;
            // 
            // fazovyPosun
            // 
            this.fazovyPosun.Text = "φ[°]";
            this.fazovyPosun.Width = 85;
            // 
            // rezozancniFrekvence
            // 
            this.rezozancniFrekvence.Text = "f0[Hz]";
            this.rezozancniFrekvence.Width = 85;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddLine);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnCalculate);
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(519, 492);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informace o obvodu";
            // 
            // btnAddLine
            // 
            this.btnAddLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLine.Location = new System.Drawing.Point(249, 235);
            this.btnAddLine.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(251, 28);
            this.btnAddLine.TabIndex = 39;
            this.btnAddLine.Text = "Vložit do tabulky";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbRezF);
            this.groupBox4.Controls.Add(this.cmbP);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.nmRezF);
            this.groupBox4.Controls.Add(this.nmP);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.cmbY);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.nmY);
            this.groupBox4.Controls.Add(this.cmbZ);
            this.groupBox4.Controls.Add(this.cmbXC);
            this.groupBox4.Controls.Add(this.cmbXL);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.nmZ);
            this.groupBox4.Controls.Add(this.nmXC);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.nmXL);
            this.groupBox4.Location = new System.Drawing.Point(21, 270);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(479, 208);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rezonanční prvky";
            // 
            // cmbRezF
            // 
            this.cmbRezF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRezF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRezF.FormattingEnabled = true;
            this.cmbRezF.Items.AddRange(new object[] {
            "THz",
            "GHz",
            "MHz",
            "kHz",
            "Hz",
            "mHz",
            "µHz",
            "nHz",
            "pHz"});
            this.cmbRezF.Location = new System.Drawing.Point(408, 172);
            this.cmbRezF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRezF.Name = "cmbRezF";
            this.cmbRezF.Size = new System.Drawing.Size(59, 24);
            this.cmbRezF.TabIndex = 46;
            this.cmbRezF.Tag = "10";
            this.cmbRezF.SelectedIndexChanged += new System.EventHandler(this.cmbRezF_SelectedIndexChanged);
            this.cmbRezF.Click += new System.EventHandler(this.cmbR_Click);
            // 
            // cmbP
            // 
            this.cmbP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbP.FormattingEnabled = true;
            this.cmbP.Items.AddRange(new object[] {
            "°",
            "rad"});
            this.cmbP.Location = new System.Drawing.Point(408, 142);
            this.cmbP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbP.Name = "cmbP";
            this.cmbP.Size = new System.Drawing.Size(59, 24);
            this.cmbP.TabIndex = 45;
            this.cmbP.Tag = "9";
            this.cmbP.SelectedIndexChanged += new System.EventHandler(this.cmbRezF_SelectedIndexChanged);
            this.cmbP.Click += new System.EventHandler(this.cmbR_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Rezonanční frekvence f0";
            // 
            // nmRezF
            // 
            this.nmRezF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmRezF.DecimalPlaces = 6;
            this.nmRezF.Location = new System.Drawing.Point(189, 174);
            this.nmRezF.Margin = new System.Windows.Forms.Padding(4);
            this.nmRezF.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmRezF.Name = "nmRezF";
            this.nmRezF.Size = new System.Drawing.Size(212, 22);
            this.nmRezF.TabIndex = 44;
            this.nmRezF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmRezF.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // nmP
            // 
            this.nmP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmP.DecimalPlaces = 6;
            this.nmP.Location = new System.Drawing.Point(189, 143);
            this.nmP.Margin = new System.Windows.Forms.Padding(4);
            this.nmP.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmP.Name = "nmP";
            this.nmP.Size = new System.Drawing.Size(212, 22);
            this.nmP.TabIndex = 42;
            this.nmP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmP.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 145);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "Fázový posun φ";
            // 
            // cmbY
            // 
            this.cmbY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbY.FormattingEnabled = true;
            this.cmbY.Items.AddRange(new object[] {
            "TS",
            "GS",
            "MS",
            "kS",
            "S",
            "mS",
            "µS",
            "nS",
            "pS"});
            this.cmbY.Location = new System.Drawing.Point(408, 112);
            this.cmbY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbY.Name = "cmbY";
            this.cmbY.Size = new System.Drawing.Size(59, 24);
            this.cmbY.TabIndex = 40;
            this.cmbY.Tag = "8";
            this.cmbY.SelectedIndexChanged += new System.EventHandler(this.cmbRezF_SelectedIndexChanged);
            this.cmbY.Click += new System.EventHandler(this.cmbR_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Admitance Y";
            // 
            // nmY
            // 
            this.nmY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmY.DecimalPlaces = 6;
            this.nmY.Location = new System.Drawing.Point(189, 113);
            this.nmY.Margin = new System.Windows.Forms.Padding(4);
            this.nmY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmY.Name = "nmY";
            this.nmY.Size = new System.Drawing.Size(212, 22);
            this.nmY.TabIndex = 39;
            this.nmY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmY.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // cmbZ
            // 
            this.cmbZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZ.FormattingEnabled = true;
            this.cmbZ.Items.AddRange(new object[] {
            "TΩ",
            "GΩ",
            "MΩ",
            "kΩ",
            "Ω",
            "mΩ",
            "µΩ",
            "nΩ",
            "pΩ"});
            this.cmbZ.Location = new System.Drawing.Point(408, 82);
            this.cmbZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbZ.Name = "cmbZ";
            this.cmbZ.Size = new System.Drawing.Size(59, 24);
            this.cmbZ.TabIndex = 37;
            this.cmbZ.Tag = "7";
            this.cmbZ.SelectedIndexChanged += new System.EventHandler(this.cmbRezF_SelectedIndexChanged);
            this.cmbZ.Click += new System.EventHandler(this.cmbR_Click);
            // 
            // cmbXC
            // 
            this.cmbXC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbXC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXC.FormattingEnabled = true;
            this.cmbXC.Items.AddRange(new object[] {
            "TΩ",
            "GΩ",
            "MΩ",
            "kΩ",
            "Ω",
            "mΩ",
            "µΩ",
            "nΩ",
            "pΩ"});
            this.cmbXC.Location = new System.Drawing.Point(408, 52);
            this.cmbXC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbXC.Name = "cmbXC";
            this.cmbXC.Size = new System.Drawing.Size(59, 24);
            this.cmbXC.TabIndex = 36;
            this.cmbXC.Tag = "6";
            this.cmbXC.SelectedIndexChanged += new System.EventHandler(this.cmbRezF_SelectedIndexChanged);
            this.cmbXC.Click += new System.EventHandler(this.cmbR_Click);
            // 
            // cmbXL
            // 
            this.cmbXL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbXL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXL.FormattingEnabled = true;
            this.cmbXL.Items.AddRange(new object[] {
            "TΩ",
            "GΩ",
            "MΩ",
            "kΩ",
            "Ω",
            "mΩ",
            "µΩ",
            "nΩ",
            "pΩ"});
            this.cmbXL.Location = new System.Drawing.Point(408, 21);
            this.cmbXL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbXL.Name = "cmbXL";
            this.cmbXL.Size = new System.Drawing.Size(59, 24);
            this.cmbXL.TabIndex = 35;
            this.cmbXL.Tag = "5";
            this.cmbXL.SelectedIndexChanged += new System.EventHandler(this.cmbRezF_SelectedIndexChanged);
            this.cmbXL.Click += new System.EventHandler(this.cmbR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Indukční reaktance XL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Impedance Z";
            // 
            // nmZ
            // 
            this.nmZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmZ.DecimalPlaces = 6;
            this.nmZ.Location = new System.Drawing.Point(189, 82);
            this.nmZ.Margin = new System.Windows.Forms.Padding(4);
            this.nmZ.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmZ.Name = "nmZ";
            this.nmZ.Size = new System.Drawing.Size(212, 22);
            this.nmZ.TabIndex = 29;
            this.nmZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmZ.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // nmXC
            // 
            this.nmXC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmXC.DecimalPlaces = 6;
            this.nmXC.Location = new System.Drawing.Point(189, 53);
            this.nmXC.Margin = new System.Windows.Forms.Padding(4);
            this.nmXC.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmXC.Name = "nmXC";
            this.nmXC.Size = new System.Drawing.Size(212, 22);
            this.nmXC.TabIndex = 21;
            this.nmXC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmXC.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kapacitní reaktance XC";
            // 
            // nmXL
            // 
            this.nmXL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmXL.DecimalPlaces = 6;
            this.nmXL.Location = new System.Drawing.Point(189, 22);
            this.nmXL.Margin = new System.Windows.Forms.Padding(4);
            this.nmXL.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmXL.Name = "nmXL";
            this.nmXL.Size = new System.Drawing.Size(212, 22);
            this.nmXL.TabIndex = 24;
            this.nmXL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmXL.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cmbF);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.nmF);
            this.groupBox3.Controls.Add(this.cmbC);
            this.groupBox3.Controls.Add(this.cmbL);
            this.groupBox3.Controls.Add(this.btnPRO);
            this.groupBox3.Controls.Add(this.cmbR);
            this.groupBox3.Controls.Add(this.btnSRO);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.nmC);
            this.groupBox3.Controls.Add(this.nmL);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.nmR);
            this.groupBox3.Location = new System.Drawing.Point(21, 21);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(479, 202);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Základní informace";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(119, 146);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "Vyber typ obvodu:";
            // 
            // cmbF
            // 
            this.cmbF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbF.FormattingEnabled = true;
            this.cmbF.Items.AddRange(new object[] {
            "THz",
            "GHz",
            "MHz",
            "kHz",
            "Hz",
            "mHz",
            "µHz",
            "nHz",
            "pHz"});
            this.cmbF.Location = new System.Drawing.Point(408, 112);
            this.cmbF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbF.Name = "cmbF";
            this.cmbF.Size = new System.Drawing.Size(59, 24);
            this.cmbF.TabIndex = 40;
            this.cmbF.Tag = "4";
            this.cmbF.SelectedIndexChanged += new System.EventHandler(this.cmbRezF_SelectedIndexChanged);
            this.cmbF.Click += new System.EventHandler(this.cmbR_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 114);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "frekvence f";
            // 
            // nmF
            // 
            this.nmF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmF.DecimalPlaces = 4;
            this.nmF.Location = new System.Drawing.Point(189, 113);
            this.nmF.Margin = new System.Windows.Forms.Padding(4);
            this.nmF.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmF.Name = "nmF";
            this.nmF.Size = new System.Drawing.Size(212, 22);
            this.nmF.TabIndex = 39;
            this.nmF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmF.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nmF.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // cmbC
            // 
            this.cmbC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbC.FormattingEnabled = true;
            this.cmbC.Items.AddRange(new object[] {
            "TF",
            "GF",
            "MF",
            "kF",
            "F",
            "mF",
            "µF",
            "nF",
            "pF"});
            this.cmbC.Location = new System.Drawing.Point(408, 82);
            this.cmbC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbC.Name = "cmbC";
            this.cmbC.Size = new System.Drawing.Size(59, 24);
            this.cmbC.TabIndex = 37;
            this.cmbC.Tag = "3";
            this.cmbC.SelectedIndexChanged += new System.EventHandler(this.cmbRezF_SelectedIndexChanged);
            this.cmbC.Click += new System.EventHandler(this.cmbR_Click);
            // 
            // cmbL
            // 
            this.cmbL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbL.FormattingEnabled = true;
            this.cmbL.Items.AddRange(new object[] {
            "TH",
            "GH",
            "MH",
            "kH",
            "H",
            "mH",
            "µH",
            "nH",
            "pH"});
            this.cmbL.Location = new System.Drawing.Point(408, 52);
            this.cmbL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbL.Name = "cmbL";
            this.cmbL.Size = new System.Drawing.Size(59, 24);
            this.cmbL.TabIndex = 36;
            this.cmbL.Tag = "2";
            this.cmbL.SelectedIndexChanged += new System.EventHandler(this.cmbRezF_SelectedIndexChanged);
            this.cmbL.Click += new System.EventHandler(this.cmbR_Click);
            // 
            // cmbR
            // 
            this.cmbR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbR.FormattingEnabled = true;
            this.cmbR.Items.AddRange(new object[] {
            "TΩ",
            "GΩ",
            "MΩ",
            "kΩ",
            "Ω",
            "mΩ",
            "µΩ",
            "nΩ",
            "pΩ"});
            this.cmbR.Location = new System.Drawing.Point(408, 21);
            this.cmbR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbR.Name = "cmbR";
            this.cmbR.Size = new System.Drawing.Size(59, 24);
            this.cmbR.TabIndex = 35;
            this.cmbR.Tag = "1";
            this.cmbR.SelectedIndexChanged += new System.EventHandler(this.cmbRezF_SelectedIndexChanged);
            this.cmbR.Click += new System.EventHandler(this.cmbR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1440, 560);
            this.Name = "Form1";
            this.Text = "Kalkulace REZONANCE";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nmL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmRezF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmXC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmXL)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NumericUpDown nmL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown nmC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton btnSRO;
        private System.Windows.Forms.RadioButton btnPRO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbR;
        private System.Windows.Forms.ComboBox cmbC;
        private System.Windows.Forms.ComboBox cmbL;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbZ;
        private System.Windows.Forms.ComboBox cmbXL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmZ;
        private System.Windows.Forms.NumericUpDown nmXC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmXL;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.ColumnHeader index;
        private System.Windows.Forms.ColumnHeader odporR;
        private System.Windows.Forms.ColumnHeader indukcnostL;
        private System.Windows.Forms.ColumnHeader kapacitaC;
        private System.Windows.Forms.ColumnHeader reaktanceL;
        private System.Windows.Forms.ColumnHeader reaktanceC;
        private System.Windows.Forms.ColumnHeader impedanceZ;
        private System.Windows.Forms.ColumnHeader admitanceY;
        private System.Windows.Forms.ColumnHeader fazovyPosun;
        private System.Windows.Forms.ColumnHeader rezozancniFrekvence;
        private System.Windows.Forms.ComboBox cmbRezF;
        private System.Windows.Forms.ComboBox cmbP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nmRezF;
        private System.Windows.Forms.NumericUpDown nmP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmY;
        private System.Windows.Forms.ComboBox cmbF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmF;
        private System.Windows.Forms.ComboBox cmbXC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddLine;
    }
}

