namespace Cifrario_cesare
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_parola1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_risultato = new System.Windows.Forms.Label();
            this.btn_invio1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_invio2 = new System.Windows.Forms.Button();
            this.txt_parola2 = new System.Windows.Forms.TextBox();
            this.lbl_risultato2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_chiave1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_chiave2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_parola1
            // 
            this.txt_parola1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parola1.Location = new System.Drawing.Point(112, 85);
            this.txt_parola1.Name = "txt_parola1";
            this.txt_parola1.Size = new System.Drawing.Size(148, 26);
            this.txt_parola1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cifrario di Cesare ";
            // 
            // lbl_risultato
            // 
            this.lbl_risultato.AutoSize = true;
            this.lbl_risultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_risultato.Location = new System.Drawing.Point(-3, 274);
            this.lbl_risultato.Name = "lbl_risultato";
            this.lbl_risultato.Size = new System.Drawing.Size(81, 20);
            this.lbl_risultato.TabIndex = 2;
            this.lbl_risultato.Text = "Risultato";
            // 
            // btn_invio1
            // 
            this.btn_invio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invio1.Location = new System.Drawing.Point(112, 233);
            this.btn_invio1.Name = "btn_invio1";
            this.btn_invio1.Size = new System.Drawing.Size(148, 31);
            this.btn_invio1.TabIndex = 3;
            this.btn_invio1.Text = "Invio";
            this.btn_invio1.UseVisualStyleBackColor = true;
            this.btn_invio1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cifrare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Decifrare";
            // 
            // btn_invio2
            // 
            this.btn_invio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invio2.Location = new System.Drawing.Point(435, 228);
            this.btn_invio2.Name = "btn_invio2";
            this.btn_invio2.Size = new System.Drawing.Size(148, 31);
            this.btn_invio2.TabIndex = 8;
            this.btn_invio2.Text = "Invio";
            this.btn_invio2.UseVisualStyleBackColor = true;
            this.btn_invio2.Click += new System.EventHandler(this.btn_n2_Click);
            // 
            // txt_parola2
            // 
            this.txt_parola2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parola2.Location = new System.Drawing.Point(435, 85);
            this.txt_parola2.Name = "txt_parola2";
            this.txt_parola2.Size = new System.Drawing.Size(148, 26);
            this.txt_parola2.TabIndex = 5;
            // 
            // lbl_risultato2
            // 
            this.lbl_risultato2.AutoSize = true;
            this.lbl_risultato2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_risultato2.Location = new System.Drawing.Point(321, 274);
            this.lbl_risultato2.Name = "lbl_risultato2";
            this.lbl_risultato2.Size = new System.Drawing.Size(81, 20);
            this.lbl_risultato2.TabIndex = 10;
            this.lbl_risultato2.Text = "Risultato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 33);
            this.label6.TabIndex = 11;
            this.label6.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "|";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(276, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 33);
            this.label7.TabIndex = 13;
            this.label7.Text = "|";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 33);
            this.label8.TabIndex = 14;
            this.label8.Text = "|";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(276, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 33);
            this.label9.TabIndex = 15;
            this.label9.Text = "|";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(276, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 33);
            this.label10.TabIndex = 16;
            this.label10.Text = "|";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(276, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 33);
            this.label11.TabIndex = 17;
            this.label11.Text = "|";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(276, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 33);
            this.label12.TabIndex = 18;
            this.label12.Text = "|";
            // 
            // txt_chiave1
            // 
            this.txt_chiave1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chiave1.Location = new System.Drawing.Point(112, 172);
            this.txt_chiave1.Name = "txt_chiave1";
            this.txt_chiave1.Size = new System.Drawing.Size(148, 26);
            this.txt_chiave1.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(-2, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Inserire parola";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(-2, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Inserire chiave";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(321, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "Inserire chiave";
            // 
            // txt_chiave2
            // 
            this.txt_chiave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chiave2.Location = new System.Drawing.Point(435, 168);
            this.txt_chiave2.Name = "txt_chiave2";
            this.txt_chiave2.Size = new System.Drawing.Size(148, 26);
            this.txt_chiave2.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(322, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 16);
            this.label16.TabIndex = 24;
            this.label16.Text = "Inserire parola";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(595, 300);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_chiave2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_chiave1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_risultato2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_invio2);
            this.Controls.Add(this.txt_parola2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_invio1);
            this.Controls.Add(this.lbl_risultato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_parola1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_parola1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_risultato;
        private System.Windows.Forms.Button btn_invio1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_invio2;
        private System.Windows.Forms.TextBox txt_parola2;
        private System.Windows.Forms.Label lbl_risultato2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_chiave1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_chiave2;
        private System.Windows.Forms.Label label16;
    }
}

