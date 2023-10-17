namespace DatoveTypy
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
            this.lblProm1 = new System.Windows.Forms.Label();
            this.lblProm2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVysl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "První proměnná ";
            // 
            // lblProm1
            // 
            this.lblProm1.AutoSize = true;
            this.lblProm1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProm1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProm1.Location = new System.Drawing.Point(134, 29);
            this.lblProm1.Name = "lblProm1";
            this.lblProm1.Size = new System.Drawing.Size(84, 19);
            this.lblProm1.TabIndex = 1;
            this.lblProm1.Text = " - hodnota -";
            this.lblProm1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProm2
            // 
            this.lblProm2.AutoSize = true;
            this.lblProm2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProm2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProm2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProm2.Location = new System.Drawing.Point(134, 60);
            this.lblProm2.Name = "lblProm2";
            this.lblProm2.Size = new System.Drawing.Size(84, 19);
            this.lblProm2.TabIndex = 3;
            this.lblProm2.Text = " - hodnota -";
            this.lblProm2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Druhá proměnná ";
            // 
            // lblVysl
            // 
            this.lblVysl.AutoSize = true;
            this.lblVysl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVysl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVysl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVysl.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblVysl.Location = new System.Drawing.Point(134, 109);
            this.lblVysl.Name = "lblVysl";
            this.lblVysl.Size = new System.Drawing.Size(84, 19);
            this.lblVysl.TabIndex = 5;
            this.lblVysl.Text = " - hodnota -";
            this.lblVysl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVysl.Click += new System.EventHandler(this.lblVysl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Výsledek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 189);
            this.Controls.Add(this.lblVysl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblProm2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProm1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(380, 200);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datové typy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProm1;
        private System.Windows.Forms.Label lblProm2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVysl;
        private System.Windows.Forms.Label label6;
    }
}

