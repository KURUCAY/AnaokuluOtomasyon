namespace BoyaliEller
{
    partial class Ana_Sayfa
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridGoruntule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGoruntule)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(215, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ögrenci Islemleri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(341, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Öğretmen Islemleri";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(468, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 67);
            this.button3.TabIndex = 3;
            this.button3.Text = "Veli Islemleri";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dataGridGoruntule
            // 
            this.dataGridGoruntule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGoruntule.Location = new System.Drawing.Point(25, 280);
            this.dataGridGoruntule.Name = "dataGridGoruntule";
            this.dataGridGoruntule.Size = new System.Drawing.Size(735, 270);
            this.dataGridGoruntule.TabIndex = 4;
            // 
            // Ana_Sayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BoyaliEller.Properties.Resources.boyalıEllerPNG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dataGridGoruntule);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Ana_Sayfa";
            this.Text = "Ana_Sayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ana_Sayfa_FormClosed);
            this.Load += new System.EventHandler(this.Ana_Sayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGoruntule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridGoruntule;
    }
}