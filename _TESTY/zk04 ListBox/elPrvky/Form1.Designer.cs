
namespace elPrvky
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.načístToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nováTvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smazatTvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbllbllbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPocet = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmCena = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPopis = new System.Windows.Forms.TextBox();
            this.cmbDruh = new System.Windows.Forms.ComboBox();
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSeznamDel = new System.Windows.Forms.Button();
            this.btnSeznamSave = new System.Windows.Forms.Button();
            this.btnSeznamRead = new System.Windows.Forms.Button();
            this.btnSmazat = new System.Windows.Forms.Button();
            this.btnPridat = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCena)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "&Soubor";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.načístToolStripMenuItem,
            this.uložitToolStripMenuItem,
            this.toolStripSeparator1,
            this.konecToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "&Soubor";
            // 
            // načístToolStripMenuItem
            // 
            this.načístToolStripMenuItem.Name = "načístToolStripMenuItem";
            this.načístToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.načístToolStripMenuItem.Text = "Načíst";
            // 
            // uložitToolStripMenuItem
            // 
            this.uložitToolStripMenuItem.Name = "uložitToolStripMenuItem";
            this.uložitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.uložitToolStripMenuItem.Text = "Uložit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.konecToolStripMenuItem.Text = "&Konec";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nováTvToolStripMenuItem,
            this.smazatTvToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // nováTvToolStripMenuItem
            // 
            this.nováTvToolStripMenuItem.Name = "nováTvToolStripMenuItem";
            this.nováTvToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.nováTvToolStripMenuItem.Text = "Nový prvek";
            // 
            // smazatTvToolStripMenuItem
            // 
            this.smazatTvToolStripMenuItem.Name = "smazatTvToolStripMenuItem";
            this.smazatTvToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.smazatTvToolStripMenuItem.Text = "Smazat prvek";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbllbllbl,
            this.lblPocet});
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(559, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbllbllbl
            // 
            this.lbllbllbl.Name = "lbllbllbl";
            this.lbllbllbl.Size = new System.Drawing.Size(76, 17);
            this.lbllbllbl.Text = "Počet prvků: ";
            // 
            // lblPocet
            // 
            this.lblPocet.Name = "lblPocet";
            this.lblPocet.Size = new System.Drawing.Size(13, 17);
            this.lblPocet.Text = "0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(22, 42);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(511, 325);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 18;
            // 
            // lstBox1
            // 
            this.lstBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBox1.FormattingEnabled = true;
            this.lstBox1.Location = new System.Drawing.Point(0, 0);
            this.lstBox1.Name = "lstBox1";
            this.lstBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBox1.Size = new System.Drawing.Size(170, 325);
            this.lstBox1.TabIndex = 0;
            this.lstBox1.SelectedIndexChanged += new System.EventHandler(this.lstBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nmCena);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPopis);
            this.groupBox1.Controls.Add(this.cmbDruh);
            this.groupBox1.Controls.Add(this.txtTyp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elektronický prvek";
            // 
            // nmCena
            // 
            this.nmCena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmCena.DecimalPlaces = 2;
            this.nmCena.Location = new System.Drawing.Point(83, 120);
            this.nmCena.Name = "nmCena";
            this.nmCena.Size = new System.Drawing.Size(216, 20);
            this.nmCena.TabIndex = 27;
            this.nmCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cena";
            // 
            // txtPopis
            // 
            this.txtPopis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPopis.Location = new System.Drawing.Point(83, 94);
            this.txtPopis.Name = "txtPopis";
            this.txtPopis.Size = new System.Drawing.Size(216, 20);
            this.txtPopis.TabIndex = 25;
            this.txtPopis.TextChanged += new System.EventHandler(this.txtPopis_TextChanged);
            // 
            // cmbDruh
            // 
            this.cmbDruh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDruh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDruh.FormattingEnabled = true;
            this.cmbDruh.Items.AddRange(new object[] {
            "Rezistor",
            "Kondenzátor",
            "Cívka",
            "Transformátor",
            "Dioda",
            "Tranzistor",
            "Tyristor",
            "Triak",
            "Diak",
            "Termistor",
            "Varistor",
            ""});
            this.cmbDruh.Location = new System.Drawing.Point(83, 30);
            this.cmbDruh.Name = "cmbDruh";
            this.cmbDruh.Size = new System.Drawing.Size(216, 21);
            this.cmbDruh.TabIndex = 24;
            this.cmbDruh.TextChanged += new System.EventHandler(this.txtPopis_TextChanged);
            // 
            // txtTyp
            // 
            this.txtTyp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTyp.Location = new System.Drawing.Point(83, 62);
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.Size = new System.Drawing.Size(216, 20);
            this.txtTyp.TabIndex = 21;
            this.txtTyp.TextChanged += new System.EventHandler(this.txtPopis_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Typ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Popis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Druh";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSeznamDel);
            this.groupBox2.Controls.Add(this.btnSeznamSave);
            this.groupBox2.Controls.Add(this.btnSeznamRead);
            this.groupBox2.Controls.Add(this.btnSmazat);
            this.groupBox2.Controls.Add(this.btnPridat);
            this.groupBox2.Location = new System.Drawing.Point(9, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // btnSeznamDel
            // 
            this.btnSeznamDel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeznamDel.Enabled = false;
            this.btnSeznamDel.Location = new System.Drawing.Point(49, 77);
            this.btnSeznamDel.Name = "btnSeznamDel";
            this.btnSeznamDel.Size = new System.Drawing.Size(236, 23);
            this.btnSeznamDel.TabIndex = 28;
            this.btnSeznamDel.Text = "Smazat seznam";
            this.btnSeznamDel.UseVisualStyleBackColor = true;
            this.btnSeznamDel.Click += new System.EventHandler(this.btnSeznamDel_Click);
            // 
            // btnSeznamSave
            // 
            this.btnSeznamSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeznamSave.Enabled = false;
            this.btnSeznamSave.Location = new System.Drawing.Point(166, 106);
            this.btnSeznamSave.Name = "btnSeznamSave";
            this.btnSeznamSave.Size = new System.Drawing.Size(119, 23);
            this.btnSeznamSave.TabIndex = 27;
            this.btnSeznamSave.Text = "Uložit seznam";
            this.btnSeznamSave.UseVisualStyleBackColor = true;
            this.btnSeznamSave.Click += new System.EventHandler(this.btnSeznamSave_Click);
            // 
            // btnSeznamRead
            // 
            this.btnSeznamRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSeznamRead.Location = new System.Drawing.Point(49, 106);
            this.btnSeznamRead.Name = "btnSeznamRead";
            this.btnSeznamRead.Size = new System.Drawing.Size(111, 23);
            this.btnSeznamRead.TabIndex = 26;
            this.btnSeznamRead.Text = "Načíst seznam";
            this.btnSeznamRead.UseVisualStyleBackColor = true;
            this.btnSeznamRead.Click += new System.EventHandler(this.btnSeznamRead_Click);
            // 
            // btnSmazat
            // 
            this.btnSmazat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSmazat.Enabled = false;
            this.btnSmazat.Location = new System.Drawing.Point(166, 34);
            this.btnSmazat.Name = "btnSmazat";
            this.btnSmazat.Size = new System.Drawing.Size(119, 23);
            this.btnSmazat.TabIndex = 15;
            this.btnSmazat.Text = "Smazat";
            this.btnSmazat.UseVisualStyleBackColor = true;
            this.btnSmazat.Click += new System.EventHandler(this.btnSmazat_Click);
            // 
            // btnPridat
            // 
            this.btnPridat.Enabled = false;
            this.btnPridat.Location = new System.Drawing.Point(49, 34);
            this.btnPridat.Name = "btnPridat";
            this.btnPridat.Size = new System.Drawing.Size(107, 23);
            this.btnPridat.TabIndex = 14;
            this.btnPridat.Text = "Přidat";
            this.btnPridat.UseVisualStyleBackColor = true;
            this.btnPridat.Click += new System.EventHandler(this.btnPridat_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Textové soubory (*.txt)|*.txt|CSV soubory (*.csv)|*.csv\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 416);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(575, 455);
            this.Name = "Form1";
            this.Text = "Elektronické prvky";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCena)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem načístToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nováTvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smazatTvToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbllbllbl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPopis;
        private System.Windows.Forms.ComboBox cmbDruh;
        private System.Windows.Forms.TextBox txtTyp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSeznamDel;
        private System.Windows.Forms.Button btnSeznamSave;
        private System.Windows.Forms.Button btnSeznamRead;
        private System.Windows.Forms.Button btnSmazat;
        private System.Windows.Forms.Button btnPridat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmCena;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel lblPocet;
    }
}

