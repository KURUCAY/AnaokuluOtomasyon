namespace BoyaliEller
{
    partial class Form1
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
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.lblKAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblDogrula = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Coral;
            this.btnGiris.Location = new System.Drawing.Point(190, 182);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(100, 23);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "GIRIS";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(190, 62);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdi.TabIndex = 0;
            this.txtKullaniciAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKullaniciAdi_KeyDown);
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(190, 100);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciSifre.TabIndex = 1;
            this.txtKullaniciSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKullaniciSifre_KeyDown);
            // 
            // lblKAdi
            // 
            this.lblKAdi.AutoSize = true;
            this.lblKAdi.BackColor = System.Drawing.Color.Linen;
            this.lblKAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKAdi.Location = new System.Drawing.Point(91, 63);
            this.lblKAdi.Name = "lblKAdi";
            this.lblKAdi.Size = new System.Drawing.Size(84, 17);
            this.lblKAdi.TabIndex = 4;
            this.lblKAdi.Text = "Kullanici Adi";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Linen;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(92, 100);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(37, 17);
            this.lblSifre.TabIndex = 5;
            this.lblSifre.Text = "Sifre";
            // 
            // lblDogrula
            // 
            this.lblDogrula.AutoSize = true;
            this.lblDogrula.BackColor = System.Drawing.Color.Transparent;
            this.lblDogrula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogrula.Location = new System.Drawing.Point(91, 136);
            this.lblDogrula.Name = "lblDogrula";
            this.lblDogrula.Size = new System.Drawing.Size(21, 20);
            this.lblDogrula.TabIndex = 6;
            this.lblDogrula.Text = "...";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImage = global::BoyaliEller.Properties.Resources.kilit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(347, 289);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDogrula);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKAdi);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.btnGiris);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Giris Ekrani";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.Label lblKAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblDogrula;
        private System.Windows.Forms.TextBox textBox1;
    }
}

