namespace Kalkulacka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnKonec = new System.Windows.Forms.Button();
            this.lblVyraz = new System.Windows.Forms.Label();
            this.txtVyraz = new System.Windows.Forms.TextBox();
            this.txtCislo2 = new System.Windows.Forms.TextBox();
            this.txtCislo1 = new System.Windows.Forms.TextBox();
            this.lblOperace = new System.Windows.Forms.Label();
            this.txtVysledek = new System.Windows.Forms.TextBox();
            this.lblVysledek = new System.Windows.Forms.Label();
            this.lblCsilo2 = new System.Windows.Forms.Label();
            this.lblCislo1 = new System.Windows.Forms.Label();
            this.btnRovnase = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPocetZadani = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otevřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.uložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitjakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.náhledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ukončitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.souborToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novýToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.otevřítToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.uložitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitjakoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tiskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.náhledToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.ukončitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grpOperace = new System.Windows.Forms.GroupBox();
            this.rdBtnPodil = new System.Windows.Forms.RadioButton();
            this.rdBtnSoucin = new System.Windows.Forms.RadioButton();
            this.rdBtnRozdil = new System.Windows.Forms.RadioButton();
            this.rdBtnSoucet = new System.Windows.Forms.RadioButton();
            this.grpNastaveni = new System.Windows.Forms.GroupBox();
            this.chkBarvy = new System.Windows.Forms.CheckBox();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.chkOperace = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpOperace.SuspendLayout();
            this.grpNastaveni.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(427, 493);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(62, 21);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnKonec
            // 
            this.btnKonec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKonec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKonec.Location = new System.Drawing.Point(502, 493);
            this.btnKonec.Name = "btnKonec";
            this.btnKonec.Size = new System.Drawing.Size(62, 21);
            this.btnKonec.TabIndex = 3;
            this.btnKonec.Text = "Konec";
            this.btnKonec.UseVisualStyleBackColor = true;
            this.btnKonec.Click += new System.EventHandler(this.btnKonec_Click);
            // 
            // lblVyraz
            // 
            this.lblVyraz.AutoSize = true;
            this.lblVyraz.Location = new System.Drawing.Point(38, 148);
            this.lblVyraz.Name = "lblVyraz";
            this.lblVyraz.Size = new System.Drawing.Size(33, 13);
            this.lblVyraz.TabIndex = 6;
            this.lblVyraz.Text = "Výraz";
            // 
            // txtVyraz
            // 
            this.txtVyraz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVyraz.Location = new System.Drawing.Point(77, 145);
            this.txtVyraz.Name = "txtVyraz";
            this.txtVyraz.ReadOnly = true;
            this.txtVyraz.Size = new System.Drawing.Size(487, 20);
            this.txtVyraz.TabIndex = 5;
            this.txtVyraz.TabStop = false;
            this.txtVyraz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCislo2
            // 
            this.txtCislo2.Location = new System.Drawing.Point(133, 92);
            this.txtCislo2.Name = "txtCislo2";
            this.txtCislo2.Size = new System.Drawing.Size(66, 20);
            this.txtCislo2.TabIndex = 10;
            this.txtCislo2.Text = "1";
            this.txtCislo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCislo1
            // 
            this.txtCislo1.Location = new System.Drawing.Point(42, 92);
            this.txtCislo1.Name = "txtCislo1";
            this.txtCislo1.Size = new System.Drawing.Size(66, 20);
            this.txtCislo1.TabIndex = 7;
            this.txtCislo1.Text = "1";
            this.txtCislo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOperace
            // 
            this.lblOperace.AutoSize = true;
            this.lblOperace.Location = new System.Drawing.Point(114, 96);
            this.lblOperace.Name = "lblOperace";
            this.lblOperace.Size = new System.Drawing.Size(13, 13);
            this.lblOperace.TabIndex = 9;
            this.lblOperace.Text = "+";
            this.lblOperace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVysledek
            // 
            this.txtVysledek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVysledek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVysledek.Location = new System.Drawing.Point(287, 93);
            this.txtVysledek.Name = "txtVysledek";
            this.txtVysledek.Size = new System.Drawing.Size(277, 20);
            this.txtVysledek.TabIndex = 13;
            this.txtVysledek.TabStop = false;
            this.txtVysledek.Text = "0";
            this.txtVysledek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVysledek
            // 
            this.lblVysledek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVysledek.AutoSize = true;
            this.lblVysledek.Location = new System.Drawing.Point(309, 74);
            this.lblVysledek.Name = "lblVysledek";
            this.lblVysledek.Size = new System.Drawing.Size(50, 13);
            this.lblVysledek.TabIndex = 14;
            this.lblVysledek.Text = "Výsledek";
            // 
            // lblCsilo2
            // 
            this.lblCsilo2.AutoSize = true;
            this.lblCsilo2.Location = new System.Drawing.Point(146, 74);
            this.lblCsilo2.Name = "lblCsilo2";
            this.lblCsilo2.Size = new System.Drawing.Size(40, 13);
            this.lblCsilo2.TabIndex = 11;
            this.lblCsilo2.Text = "Číslo 2";
            // 
            // lblCislo1
            // 
            this.lblCislo1.AutoSize = true;
            this.lblCislo1.Location = new System.Drawing.Point(56, 74);
            this.lblCislo1.Name = "lblCislo1";
            this.lblCislo1.Size = new System.Drawing.Size(38, 13);
            this.lblCislo1.TabIndex = 8;
            this.lblCislo1.Text = "Čislo 1";
            // 
            // btnRovnase
            // 
            this.btnRovnase.Location = new System.Drawing.Point(214, 92);
            this.btnRovnase.Name = "btnRovnase";
            this.btnRovnase.Size = new System.Drawing.Size(57, 21);
            this.btnRovnase.TabIndex = 12;
            this.btnRovnase.Text = "=";
            this.btnRovnase.UseVisualStyleBackColor = true;
            this.btnRovnase.Click += new System.EventHandler(this.btnRovnase_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblPocetZadani});
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(576, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "Počet zadání: ";
            // 
            // lblPocetZadani
            // 
            this.lblPocetZadani.Name = "lblPocetZadani";
            this.lblPocetZadani.Size = new System.Drawing.Size(13, 17);
            this.lblPocetZadani.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.souborToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novýToolStripMenuItem,
            this.otevřítToolStripMenuItem,
            this.toolStripSeparator,
            this.uložitToolStripMenuItem,
            this.uložitjakoToolStripMenuItem,
            this.toolStripSeparator1,
            this.tiskToolStripMenuItem,
            this.náhledToolStripMenuItem,
            this.toolStripSeparator2,
            this.ukončitToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "&Soubor";
            // 
            // novýToolStripMenuItem
            // 
            this.novýToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novýToolStripMenuItem.Image")));
            this.novýToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novýToolStripMenuItem.Name = "novýToolStripMenuItem";
            this.novýToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novýToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.novýToolStripMenuItem.Text = "&Nový";
            // 
            // otevřítToolStripMenuItem
            // 
            this.otevřítToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("otevřítToolStripMenuItem.Image")));
            this.otevřítToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otevřítToolStripMenuItem.Name = "otevřítToolStripMenuItem";
            this.otevřítToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otevřítToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.otevřítToolStripMenuItem.Text = "&Otevřít";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(150, 6);
            // 
            // uložitToolStripMenuItem
            // 
            this.uložitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uložitToolStripMenuItem.Image")));
            this.uložitToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uložitToolStripMenuItem.Name = "uložitToolStripMenuItem";
            this.uložitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.uložitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.uložitToolStripMenuItem.Text = "&Uložit";
            // 
            // uložitjakoToolStripMenuItem
            // 
            this.uložitjakoToolStripMenuItem.Name = "uložitjakoToolStripMenuItem";
            this.uložitjakoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.uložitjakoToolStripMenuItem.Text = "Uložit j&ako";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // tiskToolStripMenuItem
            // 
            this.tiskToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tiskToolStripMenuItem.Image")));
            this.tiskToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tiskToolStripMenuItem.Name = "tiskToolStripMenuItem";
            this.tiskToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tiskToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tiskToolStripMenuItem.Text = "&Tisk";
            // 
            // náhledToolStripMenuItem
            // 
            this.náhledToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("náhledToolStripMenuItem.Image")));
            this.náhledToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.náhledToolStripMenuItem.Name = "náhledToolStripMenuItem";
            this.náhledToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.náhledToolStripMenuItem.Text = "&Náhled";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // ukončitToolStripMenuItem
            // 
            this.ukončitToolStripMenuItem.Name = "ukončitToolStripMenuItem";
            this.ukončitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ukončitToolStripMenuItem.Text = "U&končit";
            // 
            // souborToolStripMenuItem1
            // 
            this.souborToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novýToolStripMenuItem1,
            this.otevřítToolStripMenuItem1,
            this.toolStripSeparator6,
            this.uložitToolStripMenuItem1,
            this.uložitjakoToolStripMenuItem1,
            this.toolStripSeparator7,
            this.tiskToolStripMenuItem1,
            this.náhledToolStripMenuItem1,
            this.toolStripSeparator8,
            this.ukončitToolStripMenuItem1});
            this.souborToolStripMenuItem1.Name = "souborToolStripMenuItem1";
            this.souborToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem1.Text = "&Soubor";
            // 
            // novýToolStripMenuItem1
            // 
            this.novýToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("novýToolStripMenuItem1.Image")));
            this.novýToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novýToolStripMenuItem1.Name = "novýToolStripMenuItem1";
            this.novýToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.novýToolStripMenuItem1.Text = "&Nový";
            // 
            // otevřítToolStripMenuItem1
            // 
            this.otevřítToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("otevřítToolStripMenuItem1.Image")));
            this.otevřítToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otevřítToolStripMenuItem1.Name = "otevřítToolStripMenuItem1";
            this.otevřítToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.otevřítToolStripMenuItem1.Text = "&Otevřít";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(126, 6);
            // 
            // uložitToolStripMenuItem1
            // 
            this.uložitToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("uložitToolStripMenuItem1.Image")));
            this.uložitToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uložitToolStripMenuItem1.Name = "uložitToolStripMenuItem1";
            this.uložitToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.uložitToolStripMenuItem1.Text = "&Uložit";
            // 
            // uložitjakoToolStripMenuItem1
            // 
            this.uložitjakoToolStripMenuItem1.Name = "uložitjakoToolStripMenuItem1";
            this.uložitjakoToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.uložitjakoToolStripMenuItem1.Text = "Uložit j&ako";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(126, 6);
            // 
            // tiskToolStripMenuItem1
            // 
            this.tiskToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("tiskToolStripMenuItem1.Image")));
            this.tiskToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tiskToolStripMenuItem1.Name = "tiskToolStripMenuItem1";
            this.tiskToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.tiskToolStripMenuItem1.Text = "&Tisk";
            // 
            // náhledToolStripMenuItem1
            // 
            this.náhledToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("náhledToolStripMenuItem1.Image")));
            this.náhledToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.náhledToolStripMenuItem1.Name = "náhledToolStripMenuItem1";
            this.náhledToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.náhledToolStripMenuItem1.Text = "&Náhled";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(126, 6);
            // 
            // ukončitToolStripMenuItem1
            // 
            this.ukončitToolStripMenuItem1.Name = "ukončitToolStripMenuItem1";
            this.ukončitToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.ukončitToolStripMenuItem1.Text = "U&končit";
            // 
            // grpOperace
            // 
            this.grpOperace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOperace.Controls.Add(this.rdBtnPodil);
            this.grpOperace.Controls.Add(this.rdBtnSoucin);
            this.grpOperace.Controls.Add(this.rdBtnRozdil);
            this.grpOperace.Controls.Add(this.rdBtnSoucet);
            this.grpOperace.Location = new System.Drawing.Point(41, 189);
            this.grpOperace.Name = "grpOperace";
            this.grpOperace.Size = new System.Drawing.Size(523, 68);
            this.grpOperace.TabIndex = 4;
            this.grpOperace.TabStop = false;
            this.grpOperace.Text = "Operace";
            // 
            // rdBtnPodil
            // 
            this.rdBtnPodil.AutoSize = true;
            this.rdBtnPodil.Location = new System.Drawing.Point(271, 29);
            this.rdBtnPodil.Name = "rdBtnPodil";
            this.rdBtnPodil.Size = new System.Drawing.Size(30, 17);
            this.rdBtnPodil.TabIndex = 0;
            this.rdBtnPodil.Text = "/";
            this.rdBtnPodil.UseVisualStyleBackColor = true;
            this.rdBtnPodil.CheckedChanged += new System.EventHandler(this.chkOperace_CheckedChanged);
            // 
            // rdBtnSoucin
            // 
            this.rdBtnSoucin.AutoSize = true;
            this.rdBtnSoucin.Location = new System.Drawing.Point(191, 29);
            this.rdBtnSoucin.Name = "rdBtnSoucin";
            this.rdBtnSoucin.Size = new System.Drawing.Size(29, 17);
            this.rdBtnSoucin.TabIndex = 1;
            this.rdBtnSoucin.Text = "*";
            this.rdBtnSoucin.UseVisualStyleBackColor = true;
            this.rdBtnSoucin.CheckedChanged += new System.EventHandler(this.chkOperace_CheckedChanged);
            // 
            // rdBtnRozdil
            // 
            this.rdBtnRozdil.AutoSize = true;
            this.rdBtnRozdil.Location = new System.Drawing.Point(112, 29);
            this.rdBtnRozdil.Name = "rdBtnRozdil";
            this.rdBtnRozdil.Size = new System.Drawing.Size(28, 17);
            this.rdBtnRozdil.TabIndex = 2;
            this.rdBtnRozdil.Text = "-";
            this.rdBtnRozdil.UseVisualStyleBackColor = true;
            this.rdBtnRozdil.CheckedChanged += new System.EventHandler(this.chkOperace_CheckedChanged);
            // 
            // rdBtnSoucet
            // 
            this.rdBtnSoucet.AutoSize = true;
            this.rdBtnSoucet.Checked = true;
            this.rdBtnSoucet.Location = new System.Drawing.Point(30, 29);
            this.rdBtnSoucet.Name = "rdBtnSoucet";
            this.rdBtnSoucet.Size = new System.Drawing.Size(31, 17);
            this.rdBtnSoucet.TabIndex = 3;
            this.rdBtnSoucet.TabStop = true;
            this.rdBtnSoucet.Text = "+";
            this.rdBtnSoucet.UseVisualStyleBackColor = true;
            this.rdBtnSoucet.CheckedChanged += new System.EventHandler(this.chkOperace_CheckedChanged);
            // 
            // grpNastaveni
            // 
            this.grpNastaveni.Controls.Add(this.chkBarvy);
            this.grpNastaveni.Controls.Add(this.chkReadOnly);
            this.grpNastaveni.Controls.Add(this.chkOperace);
            this.grpNastaveni.Location = new System.Drawing.Point(42, 275);
            this.grpNastaveni.Name = "grpNastaveni";
            this.grpNastaveni.Size = new System.Drawing.Size(344, 57);
            this.grpNastaveni.TabIndex = 0;
            this.grpNastaveni.TabStop = false;
            this.grpNastaveni.Text = "Nastavení";
            // 
            // chkBarvy
            // 
            this.chkBarvy.AutoSize = true;
            this.chkBarvy.Location = new System.Drawing.Point(246, 26);
            this.chkBarvy.Name = "chkBarvy";
            this.chkBarvy.Size = new System.Drawing.Size(53, 17);
            this.chkBarvy.TabIndex = 2;
            this.chkBarvy.Text = "Barvy";
            this.chkBarvy.UseVisualStyleBackColor = true;
            this.chkBarvy.CheckedChanged += new System.EventHandler(this.chkBarvy_CheckedChanged);
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Checked = true;
            this.chkReadOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReadOnly.Location = new System.Drawing.Point(132, 26);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(73, 17);
            this.chkReadOnly.TabIndex = 1;
            this.chkReadOnly.Text = "ReadOnly";
            this.chkReadOnly.UseVisualStyleBackColor = true;
            this.chkReadOnly.CheckedChanged += new System.EventHandler(this.chkReadOnly_CheckedChanged);
            // 
            // chkOperace
            // 
            this.chkOperace.AutoSize = true;
            this.chkOperace.Checked = true;
            this.chkOperace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOperace.Location = new System.Drawing.Point(18, 26);
            this.chkOperace.Name = "chkOperace";
            this.chkOperace.Size = new System.Drawing.Size(67, 17);
            this.chkOperace.TabIndex = 0;
            this.chkOperace.Text = "Operace";
            this.chkOperace.UseVisualStyleBackColor = true;
            this.chkOperace.CheckedChanged += new System.EventHandler(this.chkOperace_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Location = new System.Drawing.Point(71, 363);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 101);
            this.textBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnRovnase;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKonec;
            this.ClientSize = new System.Drawing.Size(576, 557);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grpNastaveni);
            this.Controls.Add(this.grpOperace);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnKonec);
            this.Controls.Add(this.lblVyraz);
            this.Controls.Add(this.txtVyraz);
            this.Controls.Add(this.txtCislo2);
            this.Controls.Add(this.txtCislo1);
            this.Controls.Add(this.lblOperace);
            this.Controls.Add(this.txtVysledek);
            this.Controls.Add(this.lblVysledek);
            this.Controls.Add(this.lblCsilo2);
            this.Controls.Add(this.lblCislo1);
            this.Controls.Add(this.btnRovnase);
            this.MinimumSize = new System.Drawing.Size(465, 478);
            this.Name = "Form1";
            this.Text = "Matematické operace";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpOperace.ResumeLayout(false);
            this.grpOperace.PerformLayout();
            this.grpNastaveni.ResumeLayout(false);
            this.grpNastaveni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnKonec;
        private System.Windows.Forms.Label lblVyraz;
        private System.Windows.Forms.TextBox txtVyraz;
        private System.Windows.Forms.TextBox txtCislo2;
        private System.Windows.Forms.TextBox txtCislo1;
        private System.Windows.Forms.Label lblOperace;
        private System.Windows.Forms.TextBox txtVysledek;
        private System.Windows.Forms.Label lblVysledek;
        private System.Windows.Forms.Label lblCsilo2;
        private System.Windows.Forms.Label lblCislo1;
        private System.Windows.Forms.Button btnRovnase;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblPocetZadani;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otevřítToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem uložitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitjakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem náhledToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ukončitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpOperace;
        private System.Windows.Forms.RadioButton rdBtnPodil;
        private System.Windows.Forms.RadioButton rdBtnSoucin;
        private System.Windows.Forms.RadioButton rdBtnRozdil;
        private System.Windows.Forms.RadioButton rdBtnSoucet;
        private System.Windows.Forms.GroupBox grpNastaveni;
        private System.Windows.Forms.CheckBox chkBarvy;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.CheckBox chkOperace;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novýToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem otevřítToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem uložitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uložitjakoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tiskToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem náhledToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem ukončitToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

