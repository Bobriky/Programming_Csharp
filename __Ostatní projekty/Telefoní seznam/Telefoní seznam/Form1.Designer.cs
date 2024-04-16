
namespace Telefoní_seznam
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
            this.lstBoxSeznam = new System.Windows.Forms.ListBox();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.otevřítToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uložitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.kopírovatToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxExpression = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnDeleteOne = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCountAll = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCountFounded = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCountEliminated = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBoxSeznam
            // 
            this.lstBoxSeznam.Enabled = false;
            this.lstBoxSeznam.FormattingEnabled = true;
            this.lstBoxSeznam.ItemHeight = 16;
            this.lstBoxSeznam.Location = new System.Drawing.Point(263, 68);
            this.lstBoxSeznam.Name = "lstBoxSeznam";
            this.lstBoxSeznam.Size = new System.Drawing.Size(324, 356);
            this.lstBoxSeznam.TabIndex = 0;
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.btn0);
            this.grpBox1.Controls.Add(this.btn9);
            this.grpBox1.Controls.Add(this.btn7);
            this.grpBox1.Controls.Add(this.btn5);
            this.grpBox1.Controls.Add(this.btn8);
            this.grpBox1.Controls.Add(this.btn4);
            this.grpBox1.Controls.Add(this.btn6);
            this.grpBox1.Controls.Add(this.btn1);
            this.grpBox1.Controls.Add(this.btn2);
            this.grpBox1.Controls.Add(this.btn3);
            this.grpBox1.Location = new System.Drawing.Point(15, 68);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(210, 276);
            this.grpBox1.TabIndex = 2;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Tlačítková klávesnice";
            this.grpBox1.MouseHover += new System.EventHandler(this.grpBox1_MouseHover);
            // 
            // btn0
            // 
            this.btn0.Enabled = false;
            this.btn0.Location = new System.Drawing.Point(76, 212);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(59, 56);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "   +     0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.Enabled = false;
            this.btn9.Location = new System.Drawing.Point(141, 150);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(59, 56);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "w x y z 9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn7
            // 
            this.btn7.Enabled = false;
            this.btn7.Location = new System.Drawing.Point(12, 150);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(58, 56);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "p q r s 7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn5
            // 
            this.btn5.Enabled = false;
            this.btn5.Location = new System.Drawing.Point(76, 88);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(59, 56);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "j k l    5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.Enabled = false;
            this.btn8.Location = new System.Drawing.Point(76, 150);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(59, 56);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "t u v   8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn4
            // 
            this.btn4.Enabled = false;
            this.btn4.Location = new System.Drawing.Point(12, 88);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(58, 56);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "g h i  4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn6
            // 
            this.btn6.Enabled = false;
            this.btn6.Location = new System.Drawing.Point(141, 88);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(59, 56);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "m n o 6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn1
            // 
            this.btn1.Enabled = false;
            this.btn1.Location = new System.Drawing.Point(12, 26);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(58, 56);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Enabled = false;
            this.btn2.Location = new System.Drawing.Point(76, 26);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(59, 56);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "a b c    2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Enabled = false;
            this.btn3.Location = new System.Drawing.Point(141, 26);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(59, 56);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "d e f    3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jméno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Příjmení";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hledaný výraz";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otevřítToolStripButton,
            this.uložitToolStripButton,
            this.toolStripSeparator,
            this.kopírovatToolStripButton,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(599, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // otevřítToolStripButton
            // 
            this.otevřítToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.otevřítToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("otevřítToolStripButton.Image")));
            this.otevřítToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otevřítToolStripButton.Name = "otevřítToolStripButton";
            this.otevřítToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.otevřítToolStripButton.Text = "&Otevřít";
            this.otevřítToolStripButton.Click += new System.EventHandler(this.otevřítToolStripButton_Click);
            // 
            // uložitToolStripButton
            // 
            this.uložitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uložitToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("uložitToolStripButton.Image")));
            this.uložitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uložitToolStripButton.Name = "uložitToolStripButton";
            this.uložitToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.uložitToolStripButton.Text = "&Uložit";
            this.uložitToolStripButton.Click += new System.EventHandler(this.uložitToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // kopírovatToolStripButton
            // 
            this.kopírovatToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kopírovatToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("kopírovatToolStripButton.Image")));
            this.kopírovatToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kopírovatToolStripButton.Name = "kopírovatToolStripButton";
            this.kopírovatToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.kopírovatToolStripButton.Text = "&Kopírovat";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblCountAll,
            this.toolStripStatusLabel3,
            this.lblCountFounded,
            this.toolStripStatusLabel5,
            this.lblCountEliminated});
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(599, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefoní číslo";
            // 
            // txtBoxExpression
            // 
            this.txtBoxExpression.Location = new System.Drawing.Point(15, 375);
            this.txtBoxExpression.Name = "txtBoxExpression";
            this.txtBoxExpression.ReadOnly = true;
            this.txtBoxExpression.Size = new System.Drawing.Size(164, 22);
            this.txtBoxExpression.TabIndex = 9;
            this.txtBoxExpression.TextChanged += new System.EventHandler(this.txtBoxExpression_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnDeleteOne
            // 
            this.btnDeleteOne.Enabled = false;
            this.btnDeleteOne.Location = new System.Drawing.Point(185, 375);
            this.btnDeleteOne.Name = "btnDeleteOne";
            this.btnDeleteOne.Size = new System.Drawing.Size(40, 22);
            this.btnDeleteOne.TabIndex = 11;
            this.btnDeleteOne.Text = "<-";
            this.btnDeleteOne.UseVisualStyleBackColor = true;
            this.btnDeleteOne.Click += new System.EventHandler(this.btnDeleteOne_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(88, 20);
            this.toolStripStatusLabel1.Text = "Počet prvků:";
            // 
            // lblCountAll
            // 
            this.lblCountAll.Name = "lblCountAll";
            this.lblCountAll.Size = new System.Drawing.Size(17, 20);
            this.lblCountAll.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(125, 20);
            this.toolStripStatusLabel3.Text = "Počet nalezených:";
            // 
            // lblCountFounded
            // 
            this.lblCountFounded.Name = "lblCountFounded";
            this.lblCountFounded.Size = new System.Drawing.Size(17, 20);
            this.lblCountFounded.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(124, 20);
            this.toolStripStatusLabel5.Text = "Počet vyřazených:";
            // 
            // lblCountEliminated
            // 
            this.lblCountEliminated.Name = "lblCountEliminated";
            this.lblCountEliminated.Size = new System.Drawing.Size(17, 20);
            this.lblCountEliminated.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 459);
            this.Controls.Add(this.btnDeleteOne);
            this.Controls.Add(this.txtBoxExpression);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBox1);
            this.Controls.Add(this.lstBoxSeznam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxSeznam;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton otevřítToolStripButton;
        private System.Windows.Forms.ToolStripButton uložitToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.ToolStripButton kopírovatToolStripButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxExpression;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnDeleteOne;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCountAll;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblCountFounded;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblCountEliminated;
    }
}

