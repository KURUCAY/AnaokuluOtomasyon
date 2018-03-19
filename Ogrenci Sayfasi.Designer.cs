namespace BoyaliEller
{
    partial class Ogrenci_Sayfasi
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
            this.components = new System.ComponentModel.Container();
            this.ogrenciDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbVeli = new System.Windows.Forms.ComboBox();
            this.velilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boyaliEllerDS = new BoyaliEller.BoyaliEllerDS();
            this.lblOgretmen = new System.Windows.Forms.Label();
            this.lblVeli = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbOgretmen = new System.Windows.Forms.ComboBox();
            this.ogretmenlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSil = new System.Windows.Forms.Button();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbYas = new System.Windows.Forms.ComboBox();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.rdbKiz = new System.Windows.Forms.RadioButton();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.velilerTableAdapter = new BoyaliEller.BoyaliEllerDSTableAdapters.VelilerTableAdapter();
            this.ogretmenlerTableAdapter = new BoyaliEller.BoyaliEllerDSTableAdapters.OgretmenlerTableAdapter();
            this.ogretmenlerOgrencilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrencilerTableAdapter = new BoyaliEller.BoyaliEllerDSTableAdapters.OgrencilerTableAdapter();
            this.lblErkek = new System.Windows.Forms.Label();
            this.lblToplamErkek = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamKiz = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbOgrenciSecim = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbOnay = new System.Windows.Forms.CheckBox();
            this.btnSirala = new System.Windows.Forms.Button();
            this.btnStream = new System.Windows.Forms.Button();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.velilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boyaliEllerDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenlerOgrencilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenciDataGrid
            // 
            this.ogrenciDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenciDataGrid.Location = new System.Drawing.Point(12, 308);
            this.ogrenciDataGrid.Name = "ogrenciDataGrid";
            this.ogrenciDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ogrenciDataGrid.Size = new System.Drawing.Size(761, 242);
            this.ogrenciDataGrid.TabIndex = 0;
            this.ogrenciDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ogrenciDataGrid_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(28)))));
            this.groupBox1.Controls.Add(this.cmbVeli);
            this.groupBox1.Controls.Add(this.lblOgretmen);
            this.groupBox1.Controls.Add(this.lblVeli);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.cmbOgretmen);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.lblAdres);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.lblCinsiyet);
            this.groupBox1.Controls.Add(this.lblYas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbYas);
            this.groupBox1.Controls.Add(this.rdbErkek);
            this.groupBox1.Controls.Add(this.rdbKiz);
            this.groupBox1.Controls.Add(this.txttc);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayit Bilgileri";
            // 
            // cmbVeli
            // 
            this.cmbVeli.DataSource = this.velilerBindingSource;
            this.cmbVeli.DisplayMember = "VeliAdi";
            this.cmbVeli.FormattingEnabled = true;
            this.cmbVeli.Location = new System.Drawing.Point(356, 43);
            this.cmbVeli.Name = "cmbVeli";
            this.cmbVeli.Size = new System.Drawing.Size(114, 21);
            this.cmbVeli.TabIndex = 12;
            this.cmbVeli.ValueMember = "VeliID";
            // 
            // velilerBindingSource
            // 
            this.velilerBindingSource.DataMember = "Veliler";
            this.velilerBindingSource.DataSource = this.boyaliEllerDS;
            // 
            // boyaliEllerDS
            // 
            this.boyaliEllerDS.DataSetName = "BoyaliEllerDS";
            this.boyaliEllerDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblOgretmen
            // 
            this.lblOgretmen.AutoSize = true;
            this.lblOgretmen.Location = new System.Drawing.Point(271, 78);
            this.lblOgretmen.Name = "lblOgretmen";
            this.lblOgretmen.Size = new System.Drawing.Size(53, 13);
            this.lblOgretmen.TabIndex = 11;
            this.lblOgretmen.Text = "Ogretmen";
            // 
            // lblVeli
            // 
            this.lblVeli.AutoSize = true;
            this.lblVeli.Location = new System.Drawing.Point(271, 52);
            this.lblVeli.Name = "lblVeli";
            this.lblVeli.Size = new System.Drawing.Size(24, 13);
            this.lblVeli.TabIndex = 10;
            this.lblVeli.Text = "Veli";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(642, 135);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbOgretmen
            // 
            this.cmbOgretmen.DataSource = this.ogretmenlerBindingSource;
            this.cmbOgretmen.DisplayMember = "OgretmenAdi";
            this.cmbOgretmen.FormattingEnabled = true;
            this.cmbOgretmen.Location = new System.Drawing.Point(356, 70);
            this.cmbOgretmen.Name = "cmbOgretmen";
            this.cmbOgretmen.Size = new System.Drawing.Size(114, 21);
            this.cmbOgretmen.TabIndex = 8;
            this.cmbOgretmen.ValueMember = "OgretmenID";
            // 
            // ogretmenlerBindingSource
            // 
            this.ogretmenlerBindingSource.DataMember = "Ogretmenler";
            this.ogretmenlerBindingSource.DataSource = this.boyaliEllerDS;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(561, 135);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(271, 26);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 7;
            this.lblAdres.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(356, 18);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(114, 20);
            this.txtAdres.TabIndex = 6;
            this.txtAdres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdres_KeyDown);
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(22, 129);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(43, 13);
            this.lblCinsiyet.TabIndex = 4;
            this.lblCinsiyet.Text = "Cinsiyet";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(22, 79);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(25, 13);
            this.lblYas.TabIndex = 3;
            this.lblYas.Text = "Yas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "TCno";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            // 
            // cmbYas
            // 
            this.cmbYas.FormattingEnabled = true;
            this.cmbYas.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.cmbYas.Location = new System.Drawing.Point(110, 71);
            this.cmbYas.Name = "cmbYas";
            this.cmbYas.Size = new System.Drawing.Size(114, 21);
            this.cmbYas.TabIndex = 2;
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Location = new System.Drawing.Point(172, 125);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(52, 17);
            this.rdbErkek.TabIndex = 5;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // rdbKiz
            // 
            this.rdbKiz.AutoSize = true;
            this.rdbKiz.Location = new System.Drawing.Point(110, 125);
            this.rdbKiz.Name = "rdbKiz";
            this.rdbKiz.Size = new System.Drawing.Size(38, 17);
            this.rdbKiz.TabIndex = 4;
            this.rdbKiz.TabStop = true;
            this.rdbKiz.Text = "kiz";
            this.rdbKiz.UseVisualStyleBackColor = true;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(110, 99);
            this.txttc.MaxLength = 11;
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(114, 20);
            this.txttc.TabIndex = 3;
            this.txttc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttc_KeyDown);
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(110, 45);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(114, 20);
            this.txtSoyadi.TabIndex = 1;
            this.txtSoyadi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoyadi_KeyDown);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(110, 19);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(114, 20);
            this.txtAdi.TabIndex = 0;
            this.txtAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdi_KeyDown);
            // 
            // velilerTableAdapter
            // 
            this.velilerTableAdapter.ClearBeforeFill = true;
            // 
            // ogretmenlerTableAdapter
            // 
            this.ogretmenlerTableAdapter.ClearBeforeFill = true;
            // 
            // ogretmenlerOgrencilerBindingSource
            // 
            this.ogretmenlerOgrencilerBindingSource.DataMember = "Ogretmenler_Ogrenciler";
            this.ogretmenlerOgrencilerBindingSource.DataSource = this.ogretmenlerBindingSource;
            // 
            // ogrencilerTableAdapter
            // 
            this.ogrencilerTableAdapter.ClearBeforeFill = true;
            // 
            // lblErkek
            // 
            this.lblErkek.AutoSize = true;
            this.lblErkek.Location = new System.Drawing.Point(12, 244);
            this.lblErkek.Name = "lblErkek";
            this.lblErkek.Size = new System.Drawing.Size(109, 13);
            this.lblErkek.TabIndex = 7;
            this.lblErkek.Text = "toplam erkek ogrenci:";
            // 
            // lblToplamErkek
            // 
            this.lblToplamErkek.AutoSize = true;
            this.lblToplamErkek.Location = new System.Drawing.Point(127, 244);
            this.lblToplamErkek.Name = "lblToplamErkek";
            this.lblToplamErkek.Size = new System.Drawing.Size(10, 13);
            this.lblToplamErkek.TabIndex = 8;
            this.lblToplamErkek.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "toplam kiz ogrenci:";
            // 
            // lblToplamKiz
            // 
            this.lblToplamKiz.AutoSize = true;
            this.lblToplamKiz.Location = new System.Drawing.Point(127, 265);
            this.lblToplamKiz.Name = "lblToplamKiz";
            this.lblToplamKiz.Size = new System.Drawing.Size(10, 13);
            this.lblToplamKiz.TabIndex = 10;
            this.lblToplamKiz.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "toplam ogrenci:";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(127, 287);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(10, 13);
            this.lblToplam.TabIndex = 12;
            this.lblToplam.Text = ".";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(574, 279);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 15;
            this.txtFilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Filtrele";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ad",
            "Öğretmen",
            "Veli"});
            this.comboBox1.Location = new System.Drawing.Point(574, 253);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Filtre Seciniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(554, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 179);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // cmbOgrenciSecim
            // 
            this.cmbOgrenciSecim.FormattingEnabled = true;
            this.cmbOgrenciSecim.Items.AddRange(new object[] {
            "EKLE",
            "SIL",
            "GUNCELLE"});
            this.cmbOgrenciSecim.Location = new System.Drawing.Point(249, 253);
            this.cmbOgrenciSecim.Name = "cmbOgrenciSecim";
            this.cmbOgrenciSecim.Size = new System.Drawing.Size(100, 21);
            this.cmbOgrenciSecim.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 21);
            this.button2.TabIndex = 23;
            this.button2.Text = "Islemi Yap";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Islem Seciniz";
            // 
            // cbOnay
            // 
            this.cbOnay.AutoSize = true;
            this.cbOnay.Location = new System.Drawing.Point(178, 285);
            this.cbOnay.Name = "cbOnay";
            this.cbOnay.Size = new System.Drawing.Size(49, 17);
            this.cbOnay.TabIndex = 25;
            this.cbOnay.Text = "onay";
            this.cbOnay.UseVisualStyleBackColor = true;
            // 
            // btnSirala
            // 
            this.btnSirala.Location = new System.Drawing.Point(383, 279);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(100, 21);
            this.btnSirala.TabIndex = 26;
            this.btnSirala.Text = "Sırala";
            this.btnSirala.UseVisualStyleBackColor = true;
            this.btnSirala.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnStream
            // 
            this.btnStream.Location = new System.Drawing.Point(697, 281);
            this.btnStream.Name = "btnStream";
            this.btnStream.Size = new System.Drawing.Size(75, 23);
            this.btnStream.TabIndex = 27;
            this.btnStream.Text = "dışa aktar";
            this.btnStream.UseVisualStyleBackColor = true;
            this.btnStream.Click += new System.EventHandler(this.btnStream_Click);
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Items.AddRange(new object[] {
            "Ad\'a Göre",
            "Öğretmen\'e Göre",
            "Yaş\'a Göre"});
            this.cmbOrder.Location = new System.Drawing.Point(383, 253);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(100, 21);
            this.cmbOrder.TabIndex = 28;
            // 
            // Ogrenci_Sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblErkek);
            this.Controls.Add(this.lblToplamErkek);
            this.Controls.Add(this.cmbOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStream);
            this.Controls.Add(this.lblToplamKiz);
            this.Controls.Add(this.btnSirala);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbOnay);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbOgrenciSecim);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ogrenciDataGrid);
            this.KeyPreview = true;
            this.Name = "Ogrenci_Sayfasi";
            this.Text = "Ogrenci_Sayfasi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ogrenci_Sayfasi_FormClosed);
            this.Load += new System.EventHandler(this.Ogrenci_Sayfasi_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.velilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boyaliEllerDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenlerOgrencilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOgretmen;
        private System.Windows.Forms.Label lblVeli;
        private System.Windows.Forms.ComboBox cmbOgretmen;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYas;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.RadioButton rdbKiz;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private BoyaliEllerDS boyaliEllerDS;
        private System.Windows.Forms.BindingSource velilerBindingSource;
        private BoyaliEllerDSTableAdapters.VelilerTableAdapter velilerTableAdapter;
        private System.Windows.Forms.BindingSource ogretmenlerBindingSource;
        private BoyaliEllerDSTableAdapters.OgretmenlerTableAdapter ogretmenlerTableAdapter;
        private System.Windows.Forms.BindingSource ogretmenlerOgrencilerBindingSource;
        private BoyaliEllerDSTableAdapters.OgrencilerTableAdapter ogrencilerTableAdapter;
        private System.Windows.Forms.ComboBox cmbVeli;
        public System.Windows.Forms.DataGridView ogrenciDataGrid;
        private System.Windows.Forms.Label lblErkek;
        private System.Windows.Forms.Label lblToplamErkek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamKiz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbOgrenciSecim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbOnay;
        private System.Windows.Forms.Button btnSirala;
        private System.Windows.Forms.Button btnStream;
        private System.Windows.Forms.ComboBox cmbOrder;
    }
}