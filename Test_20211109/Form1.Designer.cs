namespace Test_20211109
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
            this.label3_jmeno = new System.Windows.Forms.Label();
            this.label3_stavPenez = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1_vlozit = new System.Windows.Forms.Button();
            this.button1_vybrat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_platba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(549, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(534, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stav účtu:";
            // 
            // label3_jmeno
            // 
            this.label3_jmeno.AutoSize = true;
            this.label3_jmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3_jmeno.Location = new System.Drawing.Point(597, 92);
            this.label3_jmeno.Name = "label3_jmeno";
            this.label3_jmeno.Size = new System.Drawing.Size(13, 16);
            this.label3_jmeno.TabIndex = 2;
            this.label3_jmeno.Text = "-";
            // 
            // label3_stavPenez
            // 
            this.label3_stavPenez.AutoSize = true;
            this.label3_stavPenez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3_stavPenez.Location = new System.Drawing.Point(597, 123);
            this.label3_stavPenez.Name = "label3_stavPenez";
            this.label3_stavPenez.Size = new System.Drawing.Size(13, 16);
            this.label3_stavPenez.TabIndex = 3;
            this.label3_stavPenez.Text = "-";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(600, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(554, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Akce:";
            // 
            // button1_vlozit
            // 
            this.button1_vlozit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1_vlozit.Location = new System.Drawing.Point(624, 196);
            this.button1_vlozit.Name = "button1_vlozit";
            this.button1_vlozit.Size = new System.Drawing.Size(76, 47);
            this.button1_vlozit.TabIndex = 6;
            this.button1_vlozit.Text = "Vložit";
            this.button1_vlozit.UseVisualStyleBackColor = false;
            this.button1_vlozit.Click += new System.EventHandler(this.button1_vlozit_Click);
            // 
            // button1_vybrat
            // 
            this.button1_vybrat.BackColor = System.Drawing.Color.Coral;
            this.button1_vybrat.Location = new System.Drawing.Point(534, 196);
            this.button1_vybrat.Name = "button1_vybrat";
            this.button1_vybrat.Size = new System.Drawing.Size(78, 47);
            this.button1_vybrat.TabIndex = 7;
            this.button1_vybrat.Text = "Vybrat";
            this.button1_vybrat.UseVisualStyleBackColor = false;
            this.button1_vybrat.Click += new System.EventHandler(this.button1_vybrat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(736, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Platba";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(726, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // button_platba
            // 
            this.button_platba.Location = new System.Drawing.Point(726, 186);
            this.button_platba.Name = "button_platba";
            this.button_platba.Size = new System.Drawing.Size(100, 57);
            this.button_platba.TabIndex = 10;
            this.button_platba.Text = "Zaplatit Platbu";
            this.button_platba.UseVisualStyleBackColor = true;
            this.button_platba.Click += new System.EventHandler(this.button_platba_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.button_platba);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1_vybrat);
            this.Controls.Add(this.button1_vlozit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3_stavPenez);
            this.Controls.Add(this.label3_jmeno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3_jmeno;
        private System.Windows.Forms.Label label3_stavPenez;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1_vlozit;
        private System.Windows.Forms.Button button1_vybrat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_platba;
    }
}

