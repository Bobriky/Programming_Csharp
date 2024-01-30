namespace Kalkulacka3
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnLomeno = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnKrat = new System.Windows.Forms.Button();
            this.btnEqauls = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtDisplay);
            this.flowLayoutPanel1.Controls.Add(this.btnNum1);
            this.flowLayoutPanel1.Controls.Add(this.btnNum2);
            this.flowLayoutPanel1.Controls.Add(this.btnNum3);
            this.flowLayoutPanel1.Controls.Add(this.btnPlus);
            this.flowLayoutPanel1.Controls.Add(this.btnNum4);
            this.flowLayoutPanel1.Controls.Add(this.btnNum5);
            this.flowLayoutPanel1.Controls.Add(this.btnNum6);
            this.flowLayoutPanel1.Controls.Add(this.btnMinus);
            this.flowLayoutPanel1.Controls.Add(this.btnNum7);
            this.flowLayoutPanel1.Controls.Add(this.btnNum8);
            this.flowLayoutPanel1.Controls.Add(this.btnNum9);
            this.flowLayoutPanel1.Controls.Add(this.btnLomeno);
            this.flowLayoutPanel1.Controls.Add(this.btnNum0);
            this.flowLayoutPanel1.Controls.Add(this.btnDot);
            this.flowLayoutPanel1.Controls.Add(this.btnKrat);
            this.flowLayoutPanel1.Controls.Add(this.btnEqauls);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(152, 185);
            this.flowLayoutPanel1.TabIndex = 52;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDisplay.Location = new System.Drawing.Point(3, 3);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(146, 27);
            this.txtDisplay.TabIndex = 52;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.WordWrap = false;
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(3, 36);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(32, 24);
            this.btnNum1.TabIndex = 44;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(41, 36);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(32, 24);
            this.btnNum2.TabIndex = 45;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(79, 36);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(32, 24);
            this.btnNum3.TabIndex = 46;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(117, 36);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(32, 24);
            this.btnPlus.TabIndex = 50;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnKrat_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(3, 66);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(32, 24);
            this.btnNum4.TabIndex = 40;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(41, 66);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(32, 24);
            this.btnNum5.TabIndex = 41;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(79, 66);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(32, 24);
            this.btnNum6.TabIndex = 42;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(117, 66);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(32, 24);
            this.btnMinus.TabIndex = 47;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnKrat_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(3, 96);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(32, 24);
            this.btnNum7.TabIndex = 36;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(41, 96);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(32, 24);
            this.btnNum8.TabIndex = 37;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(79, 96);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(32, 24);
            this.btnNum9.TabIndex = 38;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnLomeno
            // 
            this.btnLomeno.Location = new System.Drawing.Point(117, 96);
            this.btnLomeno.Name = "btnLomeno";
            this.btnLomeno.Size = new System.Drawing.Size(32, 24);
            this.btnLomeno.TabIndex = 39;
            this.btnLomeno.Text = "/";
            this.btnLomeno.UseVisualStyleBackColor = true;
            this.btnLomeno.Click += new System.EventHandler(this.btnKrat_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(3, 126);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(70, 24);
            this.btnNum0.TabIndex = 48;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(79, 126);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(32, 24);
            this.btnDot.TabIndex = 49;
            this.btnDot.Text = ",";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnKrat
            // 
            this.btnKrat.Location = new System.Drawing.Point(117, 126);
            this.btnKrat.Name = "btnKrat";
            this.btnKrat.Size = new System.Drawing.Size(32, 24);
            this.btnKrat.TabIndex = 43;
            this.btnKrat.Text = "*";
            this.btnKrat.UseVisualStyleBackColor = true;
            this.btnKrat.Click += new System.EventHandler(this.btnKrat_Click);
            // 
            // btnEqauls
            // 
            this.btnEqauls.Location = new System.Drawing.Point(3, 156);
            this.btnEqauls.Name = "btnEqauls";
            this.btnEqauls.Size = new System.Drawing.Size(108, 23);
            this.btnEqauls.TabIndex = 53;
            this.btnEqauls.Text = "=";
            this.btnEqauls.UseVisualStyleBackColor = true;
            this.btnEqauls.Click += new System.EventHandler(this.btnEqauls_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(117, 156);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(32, 23);
            this.btnClear.TabIndex = 54;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 207);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnLomeno;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnKrat;
        private System.Windows.Forms.Button btnEqauls;
        private System.Windows.Forms.Button btnClear;
    }
}

