namespace Scitacka
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.btnKonec = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnReset = new System.Windows.Forms.Button();
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
            this.nápovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obsahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hledatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.oproduktuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVyraz
            // 
            this.lblVyraz.AutoSize = true;
            this.lblVyraz.Location = new System.Drawing.Point(21, 145);
            this.lblVyraz.Name = "lblVyraz";
            this.lblVyraz.Size = new System.Drawing.Size(33, 13);
            this.lblVyraz.TabIndex = 61;
            this.lblVyraz.Text = "Výraz";
            // 
            // txtVyraz
            // 
            this.txtVyraz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVyraz.Location = new System.Drawing.Point(60, 142);
            this.txtVyraz.Name = "txtVyraz";
            this.txtVyraz.ReadOnly = true;
            this.txtVyraz.Size = new System.Drawing.Size(263, 20);
            this.txtVyraz.TabIndex = 62;
            this.txtVyraz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCislo2
            // 
            this.txtCislo2.Location = new System.Drawing.Point(116, 89);
            this.txtCislo2.Name = "txtCislo2";
            this.txtCislo2.Size = new System.Drawing.Size(66, 20);
            this.txtCislo2.TabIndex = 60;
            this.txtCislo2.Text = "1";
            this.txtCislo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCislo2.TextChanged += new System.EventHandler(this.txtCislo_TextChanged);
            // 
            // txtCislo1
            // 
            this.txtCislo1.Location = new System.Drawing.Point(25, 89);
            this.txtCislo1.Name = "txtCislo1";
            this.txtCislo1.Size = new System.Drawing.Size(66, 20);
            this.txtCislo1.TabIndex = 59;
            this.txtCislo1.Text = "1";
            this.txtCislo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCislo1.TextChanged += new System.EventHandler(this.txtCislo_TextChanged);
            // 
            // lblOperace
            // 
            this.lblOperace.AutoSize = true;
            this.lblOperace.Location = new System.Drawing.Point(97, 93);
            this.lblOperace.Name = "lblOperace";
            this.lblOperace.Size = new System.Drawing.Size(13, 13);
            this.lblOperace.TabIndex = 58;
            this.lblOperace.Text = "+";
            this.lblOperace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVysledek
            // 
            this.txtVysledek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVysledek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVysledek.Location = new System.Drawing.Point(261, 87);
            this.txtVysledek.Name = "txtVysledek";
            this.txtVysledek.Size = new System.Drawing.Size(62, 20);
            this.txtVysledek.TabIndex = 57;
            this.txtVysledek.TabStop = false;
            this.txtVysledek.Text = "0";
            this.txtVysledek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVysledek
            // 
            this.lblVysledek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVysledek.AutoSize = true;
            this.lblVysledek.Location = new System.Drawing.Point(267, 71);
            this.lblVysledek.Name = "lblVysledek";
            this.lblVysledek.Size = new System.Drawing.Size(50, 13);
            this.lblVysledek.TabIndex = 56;
            this.lblVysledek.Text = "Výsledek";
            // 
            // lblCsilo2
            // 
            this.lblCsilo2.AutoSize = true;
            this.lblCsilo2.Location = new System.Drawing.Point(129, 71);
            this.lblCsilo2.Name = "lblCsilo2";
            this.lblCsilo2.Size = new System.Drawing.Size(40, 13);
            this.lblCsilo2.TabIndex = 55;
            this.lblCsilo2.Text = "Číslo 2";
            // 
            // lblCislo1
            // 
            this.lblCislo1.AutoSize = true;
            this.lblCislo1.Location = new System.Drawing.Point(39, 71);
            this.lblCislo1.Name = "lblCislo1";
            this.lblCislo1.Size = new System.Drawing.Size(38, 13);
            this.lblCislo1.TabIndex = 54;
            this.lblCislo1.Text = "Čislo 1";
            // 
            // btnRovnase
            // 
            this.btnRovnase.Location = new System.Drawing.Point(190, 89);
            this.btnRovnase.Name = "btnRovnase";
            this.btnRovnase.Size = new System.Drawing.Size(57, 21);
            this.btnRovnase.TabIndex = 53;
            this.btnRovnase.Text = "=";
            this.btnRovnase.UseVisualStyleBackColor = true;
            this.btnRovnase.Click += new System.EventHandler(this.btnRovnase_Click);
            // 
            // btnKonec
            // 
            this.btnKonec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKonec.Location = new System.Drawing.Point(261, 208);
            this.btnKonec.Name = "btnKonec";
            this.btnKonec.Size = new System.Drawing.Size(62, 21);
            this.btnKonec.TabIndex = 63;
            this.btnKonec.Text = "Konec";
            this.btnKonec.UseVisualStyleBackColor = true;
            this.btnKonec.Click += new System.EventHandler(this.btnKonec_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblPocetZadani});
            this.statusStrip1.Location = new System.Drawing.Point(0, 260);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(355, 22);
            this.statusStrip1.TabIndex = 64;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(185, 208);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(62, 21);
            this.btnReset.TabIndex = 65;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.nápovědaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(355, 24);
            this.menuStrip1.TabIndex = 66;
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
            this.novýToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.novýToolStripMenuItem.Text = "&Nový";
            // 
            // otevřítToolStripMenuItem
            // 
            this.otevřítToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("otevřítToolStripMenuItem.Image")));
            this.otevřítToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otevřítToolStripMenuItem.Name = "otevřítToolStripMenuItem";
            this.otevřítToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otevřítToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.otevřítToolStripMenuItem.Text = "&Otevřít";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // uložitToolStripMenuItem
            // 
            this.uložitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uložitToolStripMenuItem.Image")));
            this.uložitToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uložitToolStripMenuItem.Name = "uložitToolStripMenuItem";
            this.uložitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.uložitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.uložitToolStripMenuItem.Text = "&Uložit";
            // 
            // uložitjakoToolStripMenuItem
            // 
            this.uložitjakoToolStripMenuItem.Name = "uložitjakoToolStripMenuItem";
            this.uložitjakoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.uložitjakoToolStripMenuItem.Text = "Uložit j&ako";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // tiskToolStripMenuItem
            // 
            this.tiskToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tiskToolStripMenuItem.Image")));
            this.tiskToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tiskToolStripMenuItem.Name = "tiskToolStripMenuItem";
            this.tiskToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tiskToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.tiskToolStripMenuItem.Text = "&Tisk";
            // 
            // náhledToolStripMenuItem
            // 
            this.náhledToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("náhledToolStripMenuItem.Image")));
            this.náhledToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.náhledToolStripMenuItem.Name = "náhledToolStripMenuItem";
            this.náhledToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.náhledToolStripMenuItem.Text = "&Náhled";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // ukončitToolStripMenuItem
            // 
            this.ukončitToolStripMenuItem.Name = "ukončitToolStripMenuItem";
            this.ukončitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.ukončitToolStripMenuItem.Text = "U&končit";
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obsahToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.hledatToolStripMenuItem,
            this.toolStripSeparator5,
            this.oproduktuToolStripMenuItem});
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            this.nápovědaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.nápovědaToolStripMenuItem.Text = "&Nápověda";
            // 
            // obsahToolStripMenuItem
            // 
            this.obsahToolStripMenuItem.Name = "obsahToolStripMenuItem";
            this.obsahToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.obsahToolStripMenuItem.Text = "&Obsah";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // hledatToolStripMenuItem
            // 
            this.hledatToolStripMenuItem.Name = "hledatToolStripMenuItem";
            this.hledatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hledatToolStripMenuItem.Text = "&Hledat";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // oproduktuToolStripMenuItem
            // 
            this.oproduktuToolStripMenuItem.Name = "oproduktuToolStripMenuItem";
            this.oproduktuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oproduktuToolStripMenuItem.Text = "&O produktu...";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnRovnase;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKonec;
            this.ClientSize = new System.Drawing.Size(355, 282);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
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
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(370, 320);
            this.Name = "Form1";
            this.Text = "Sčítačka";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnKonec;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblPocetZadani;
        private System.Windows.Forms.Button btnReset;
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
        private System.Windows.Forms.ToolStripMenuItem nápovědaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obsahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hledatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem oproduktuToolStripMenuItem;
    }
}

