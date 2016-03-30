namespace loto
{
    partial class FrmLoto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxUplaceni = new System.Windows.Forms.GroupBox();
            this.txtUplaceniBrojX = new System.Windows.Forms.TextBox();
            this.btnUplati = new System.Windows.Forms.Button();
            this.groupBoxDobitni = new System.Windows.Forms.GroupBox();
            this.txtDobitniBrojX = new System.Windows.Forms.TextBox();
            this.btnOdigraj = new System.Windows.Forms.Button();
            this.lblNatpis = new System.Windows.Forms.Label();
            this.lblBrojPogodaka = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.groupBoxUplaceni.SuspendLayout();
            this.groupBoxDobitni.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUplaceni
            // 
            this.groupBoxUplaceni.Controls.Add(this.textBox6);
            this.groupBoxUplaceni.Controls.Add(this.textBox5);
            this.groupBoxUplaceni.Controls.Add(this.textBox4);
            this.groupBoxUplaceni.Controls.Add(this.textBox3);
            this.groupBoxUplaceni.Controls.Add(this.textBox2);
            this.groupBoxUplaceni.Controls.Add(this.textBox1);
            this.groupBoxUplaceni.Controls.Add(this.txtUplaceniBrojX);
            this.groupBoxUplaceni.Controls.Add(this.btnUplati);
            this.groupBoxUplaceni.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUplaceni.Name = "groupBoxUplaceni";
            this.groupBoxUplaceni.Size = new System.Drawing.Size(340, 96);
            this.groupBoxUplaceni.TabIndex = 0;
            this.groupBoxUplaceni.TabStop = false;
            this.groupBoxUplaceni.Text = "Uplaćena kombinacija";
            this.groupBoxUplaceni.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtUplaceniBrojX
            // 
            this.txtUplaceniBrojX.Location = new System.Drawing.Point(13, 31);
            this.txtUplaceniBrojX.Name = "txtUplaceniBrojX";
            this.txtUplaceniBrojX.Size = new System.Drawing.Size(40, 20);
            this.txtUplaceniBrojX.TabIndex = 1;
            // 
            // btnUplati
            // 
            this.btnUplati.Location = new System.Drawing.Point(259, 67);
            this.btnUplati.Name = "btnUplati";
            this.btnUplati.Size = new System.Drawing.Size(75, 23);
            this.btnUplati.TabIndex = 1;
            this.btnUplati.Text = "Uplati";
            this.btnUplati.UseVisualStyleBackColor = true;
            // 
            // groupBoxDobitni
            // 
            this.groupBoxDobitni.Controls.Add(this.textBox13);
            this.groupBoxDobitni.Controls.Add(this.textBox12);
            this.groupBoxDobitni.Controls.Add(this.textBox11);
            this.groupBoxDobitni.Controls.Add(this.textBox9);
            this.groupBoxDobitni.Controls.Add(this.textBox8);
            this.groupBoxDobitni.Controls.Add(this.textBox7);
            this.groupBoxDobitni.Controls.Add(this.btnOdigraj);
            this.groupBoxDobitni.Controls.Add(this.txtDobitniBrojX);
            this.groupBoxDobitni.Location = new System.Drawing.Point(12, 123);
            this.groupBoxDobitni.Name = "groupBoxDobitni";
            this.groupBoxDobitni.Size = new System.Drawing.Size(340, 84);
            this.groupBoxDobitni.TabIndex = 2;
            this.groupBoxDobitni.TabStop = false;
            this.groupBoxDobitni.Text = "Dobitna Kombinacija";
            // 
            // txtDobitniBrojX
            // 
            this.txtDobitniBrojX.Location = new System.Drawing.Point(13, 28);
            this.txtDobitniBrojX.Name = "txtDobitniBrojX";
            this.txtDobitniBrojX.ReadOnly = true;
            this.txtDobitniBrojX.Size = new System.Drawing.Size(40, 20);
            this.txtDobitniBrojX.TabIndex = 3;
            // 
            // btnOdigraj
            // 
            this.btnOdigraj.Location = new System.Drawing.Point(259, 55);
            this.btnOdigraj.Name = "btnOdigraj";
            this.btnOdigraj.Size = new System.Drawing.Size(75, 23);
            this.btnOdigraj.TabIndex = 4;
            this.btnOdigraj.Text = "Odigraj";
            this.btnOdigraj.UseVisualStyleBackColor = true;
            // 
            // lblNatpis
            // 
            this.lblNatpis.AutoSize = true;
            this.lblNatpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNatpis.Location = new System.Drawing.Point(15, 233);
            this.lblNatpis.Name = "lblNatpis";
            this.lblNatpis.Size = new System.Drawing.Size(93, 13);
            this.lblNatpis.TabIndex = 3;
            this.lblNatpis.Text = "Broj pogodaka:";
            // 
            // lblBrojPogodaka
            // 
            this.lblBrojPogodaka.AutoSize = true;
            this.lblBrojPogodaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojPogodaka.Location = new System.Drawing.Point(114, 233);
            this.lblBrojPogodaka.Name = "lblBrojPogodaka";
            this.lblBrojPogodaka.Size = new System.Drawing.Size(14, 13);
            this.lblBrojPogodaka.TabIndex = 4;
            this.lblBrojPogodaka.Text = "0";
            this.lblBrojPogodaka.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(40, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(197, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(40, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(243, 31);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(40, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(289, 31);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(40, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(151, 28);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(40, 20);
            this.textBox7.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(243, 29);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(40, 20);
            this.textBox8.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(197, 28);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(40, 20);
            this.textBox9.TabIndex = 7;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(289, 28);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(40, 20);
            this.textBox11.TabIndex = 9;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(105, 28);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(40, 20);
            this.textBox12.TabIndex = 10;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(59, 28);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(40, 20);
            this.textBox13.TabIndex = 11;
            // 
            // FrmLoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 281);
            this.Controls.Add(this.lblBrojPogodaka);
            this.Controls.Add(this.lblNatpis);
            this.Controls.Add(this.groupBoxDobitni);
            this.Controls.Add(this.groupBoxUplaceni);
            this.Name = "FrmLoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loto 7/39";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxUplaceni.ResumeLayout(false);
            this.groupBoxUplaceni.PerformLayout();
            this.groupBoxDobitni.ResumeLayout(false);
            this.groupBoxDobitni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUplaceni;
        private System.Windows.Forms.TextBox txtUplaceniBrojX;
        private System.Windows.Forms.Button btnUplati;
        private System.Windows.Forms.GroupBox groupBoxDobitni;
        private System.Windows.Forms.Button btnOdigraj;
        private System.Windows.Forms.TextBox txtDobitniBrojX;
        private System.Windows.Forms.Label lblNatpis;
        private System.Windows.Forms.Label lblBrojPogodaka;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
    }
}

