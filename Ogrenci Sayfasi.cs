using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BoyaliEller
{
    public partial class Ogrenci_Sayfasi : Form
    {
        public Ogrenci_Sayfasi()
        {
            InitializeComponent();
        }
       
     public   linkDataContext cont;
      
        Ana_Sayfa ana = new Ana_Sayfa();

        private void Ogrenci_Sayfasi_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'boyaliEllerDS.Ogrenciler' table. You can move, or remove it, as needed.
            this.ogrencilerTableAdapter.Fill(this.boyaliEllerDS.Ogrenciler);
           
            cont = new linkDataContext();
          
          //ogretmenler combobox doldurma
            cmbOgretmen.DataSource = cont.Ogretmenlers.ToList();
            cmbOgretmen.DisplayMember = "OgretmenAdi";
            cmbOgretmen.ValueMember = "OgretmenID";

            //veliler combobox doldurma
            cmbVeli.DataSource = cont.Velilers.ToList();
            cmbVeli.DisplayMember = "VeliAdi";
            cmbVeli.ValueMember = "VeliID";

            #region     toplam erkek kız ogrenci sayilarını goster
            cont = new linkDataContext();
            var listeErkek = (from ogr in cont.Ogrencilers
                              where ogr.OgrenciCinsiyet == "erkek"
                              select ogr).Count();
            lblToplamErkek.Text = listeErkek.ToString();

            var listeKiz = (from ogr in cont.Ogrencilers
                            where ogr.OgrenciCinsiyet == "kız"
                            select ogr
                          ).Count();
            lblToplamKiz.Text = listeKiz.ToString();
            var listeToplam = (from ogr in cont.Ogrencilers
                               select ogr).Count();
            lblToplam.Text = listeToplam.ToString();
            #endregion

            //DataGridView Doldurma
            guncelle();

            //ID sütunu
            ogrenciDataGrid.Columns[0].Width = 25;
            //AdSoy Sütunu
            ogrenciDataGrid.Columns[1].Width = 125;
            //yas sütunu
            ogrenciDataGrid.Columns[2].Width = 40;
            //cinsiyet sütunu
            ogrenciDataGrid.Columns[3].Width = 60;
            //TC sütunu
            ogrenciDataGrid.Columns[4].Width = 85;
            //Öğretmen sütunu
            ogrenciDataGrid.Columns[6].Width = 85;
            //Veli Sütunu
            ogrenciDataGrid.Columns[7].Width = 85;
            //Adres sütunu
            ogrenciDataGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           
        }

        private void Ogrenci_Sayfasi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Ana_Sayfa sayfa = new Ana_Sayfa();
            sayfa.Show();
        }

      
        public string cinsiyet;
        private void button1_Click_1(object sender, EventArgs e)
        {
               //secilen cinsiyetin degiskene atanmasi
            if (rdbKiz.Checked)
            {
                cinsiyet = rdbKiz.Text;
            }
            else cinsiyet = rdbErkek.Text;



            //ekleme islemi metod ile
            cont = new linkDataContext();
            ekle ek = new ekle(txtAdi.Text, txtSoyadi.Text, Convert.ToInt32(cmbYas.SelectedItem), cinsiyet, txttc.Text, txtAdres.Text, Convert.ToInt32(cmbOgretmen.SelectedValue), Convert.ToInt32(cmbVeli.SelectedValue));


            //datasource verileri guncelleme
            guncelle();


            //ekleme islemi yaptiktan sonra textbox ve comboların temizlenmesi 
          

            temizle();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //combobox'ta secilen isleme göre filtreleme
            cont = new linkDataContext();
          
            #region ada göre filtreleme
            if (comboBox1.SelectedIndex == 0)
            {
                var deneme = (
               from ogr in cont.Ogrencilers
               join ogrt in cont.Ogretmenlers
               on ogr.OgretmenID equals ogrt.OgretmenID
               join vel in cont.Velilers
               on ogr.VeliID equals vel.VeliID
               where ogr.OgrenciAdi.Contains(txtFilter.Text)
               select new
               {
                   ID = ogr.OgrenciID,
                   ADSOY = ogr.OgrenciAdi + " " + ogr.OgrenciSoyadi,
                   YAŞI = ogr.OgrenciYasi,
                   CİNSİYET = ogr.OgrenciCinsiyet,
                   TC = ogr.OgrenciTC,
                   ADRES = ogr.OgrenciAdres,
                   ÖĞRETMEN = ogrt.OgretmenAdi,
                   VELİ = vel.VeliAdi
               }

               );
                ogrenciDataGrid.DataSource = deneme;

            }
            #endregion
          
            #region Öğretmene göre filtreleme
            if (comboBox1.SelectedIndex==1)
            {
                var sorgu = (from ogr in cont.Ogrencilers
                             join ogrt in cont.Ogretmenlers
                             on ogr.OgretmenID equals ogrt.OgretmenID
                             join vel in cont.Velilers
                             on ogr.VeliID equals vel.VeliID
                             where ogrt.OgretmenAdi.Contains(txtFilter.Text)
                             select new
                             {
                                 ID = ogr.OgrenciID,
                                 ADSOY = ogr.OgrenciAdi + " " + ogr.OgrenciSoyadi,
                                 YAŞI = ogr.OgrenciYasi,
                                 CİNSİYET = ogr.OgrenciCinsiyet,
                                 TC = ogr.OgrenciTC,
                                 ADRES = ogr.OgrenciAdres,
                                 ÖĞRETMEN = ogrt.OgretmenAdi,
                                 VELİ = vel.VeliAdi


                             }).ToList();
                ogrenciDataGrid.DataSource = sorgu;

            }
            #endregion
           
            #region            Veliye göre filtreleme

            if (comboBox1.SelectedIndex==2)
            {
                var sorgu = (from ogr in cont.Ogrencilers
                             join ogrt in cont.Ogretmenlers
                              on ogr.OgretmenID equals ogrt.OgretmenID
                             join vel in cont.Velilers
                             on ogr.VeliID equals vel.VeliID
                             where vel.VeliAdi.Contains(txtFilter.Text)
                             select new
                             {
                                 ID = ogr.OgrenciID,
                                 ADSOY = ogr.OgrenciAdi + " " + ogr.OgrenciSoyadi,
                                 YAŞI = ogr.OgrenciYasi,
                                 CİNSİYET = ogr.OgrenciCinsiyet,
                                 TC = ogr.OgrenciTC,
                                 ADRES = ogr.OgrenciAdres,
                                 ÖĞRETMEN = ogrt.OgretmenAdi,
                                 VELİ = vel.VeliAdi


                             }).ToList();
                ogrenciDataGrid.DataSource = sorgu;


            }
            #endregion

        }

        private void btnSil_Click(object sender, EventArgs e)
        {           
        }


        //datasource'da goruntulemek icin veriler
        public void guncelle()
        {
            linkDataContext cx = new linkDataContext();
            var deneme = (from ogr1 in cx.Ogrencilers
                          join ogrt in cx.Ogretmenlers
                           on ogr1.OgretmenID equals ogrt.OgretmenID
                          join vel in cx.Velilers
                          on ogr1.VeliID equals vel.VeliID
                          select new
                          {
                              ID=ogr1.OgrenciID,
                              ADSOY = ogr1.OgrenciAdi + " " + ogr1.OgrenciSoyadi,
                              YAŞI = ogr1.OgrenciYasi,
                              CİNSİYET = ogr1.OgrenciCinsiyet,
                              TC = ogr1.OgrenciTC,
                              ADRES = ogr1.OgrenciAdres,
                              ÖĞRETMEN = ogrt.OgretmenAdi,
                              VELİ = vel.VeliAdi
                          }).ToList();
            
            ogrenciDataGrid.DataSource = deneme;
        }
      
        //işlemlerden sonra groupbox icindeki verilerin temizlenmesi
        public void temizle()
        {
            foreach (Control item in this.groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = (TextBox)item;
                    tb.Clear();
                }
                if (item is ComboBox)
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.SelectedIndex = 0;
                }
            }
            rdbKiz.Checked = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region EKLE
            if (cmbOgrenciSecim.SelectedIndex==0)
            {
                //secilen cinsiyetin degiskene atanmasi
                if (rdbKiz.Checked)
                {
                    cinsiyet = rdbKiz.Text;
                }
                else cinsiyet = rdbErkek.Text;



                //ekleme islemi metod ile
                cont = new linkDataContext();
                ekle ek = new ekle(txtAdi.Text, txtSoyadi.Text, Convert.ToInt32(cmbYas.SelectedItem), cinsiyet, txttc.Text, txtAdres.Text, Convert.ToInt32(cmbOgretmen.SelectedValue), Convert.ToInt32(cmbVeli.SelectedValue));


                //datasource verileri guncelleme
                guncelle();


                //ekleme islemi yaptiktan sonra textbox ve comboların temizlenmesi 
                foreach (Control item in this.groupBox1.Controls)
                {

                    if (item is TextBox)
                    {
                        TextBox tb = (TextBox)item;
                        tb.Clear();
                    }
                    if (item is ComboBox)
                    {
                        ComboBox cmb = (ComboBox)item;
                        cmb.SelectedIndex = 0;
                    }

                }
                rdbKiz.Checked = true;
            }
            #endregion

            #region SIL
            if (cmbOgrenciSecim.SelectedIndex==1)
            {
                if (cbOnay.Checked)
                {
                    MessageBox.Show("Silme islemi gerceklestiriliyor");
                    int boyut = (int)ogrenciDataGrid.SelectedRows.Count;
                    cont = new linkDataContext();

                    for (int i = 0; i < boyut; i++)
                    {
                        int id = Convert.ToInt32(ogrenciDataGrid.SelectedRows[i].Cells[0].Value);
                        Ogrenciler tb = cont.Ogrencilers.SingleOrDefault(del => del.OgrenciID == id);
                        cont.Ogrencilers.DeleteOnSubmit(tb);
                    }
                    cont.SubmitChanges();
                    guncelle();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Islemi onaylamadınız");
                    
                }

            }
            #endregion

            #region GUNCELLE
            if (cmbOgrenciSecim.SelectedIndex==2)
            {

                if (cbOnay.Checked)
                {
                    cont = new linkDataContext();

                    //guncellenecek veriler girilir ve guncellenir
                    int id = Convert.ToInt32(txtAdi.Tag);
                    Ogrenciler ogr = cont.Ogrencilers.SingleOrDefault(x => x.OgrenciID == id);
                    ogr.OgrenciAdi = txtAdi.Text;
                    ogr.OgrenciSoyadi = txtSoyadi.Text;
                    if (rdbKiz.Checked)
                    {
                        cinsiyet = rdbKiz.Text;
                    }
                    else cinsiyet = rdbErkek.Text;
                    ogr.OgrenciCinsiyet = cinsiyet;
                    ogr.OgrenciYasi = Convert.ToInt32(cmbYas.SelectedItem);
                    ogr.OgrenciTC = txttc.Text;
                    ogr.OgrenciAdres = txtAdres.Text;
                    ogr.OgretmenID = Convert.ToInt32(cmbOgretmen.SelectedValue);
                    ogr.VeliID = Convert.ToInt32(cmbVeli.SelectedValue);



                    cont.SubmitChanges();
                    //datagrik guncellenir
                    guncelle();
                    //grupbox ogeleri temizlendi
                    temizle();
                }
                  
                 else
                {
                    MessageBox.Show("Islemi onaylamadınız");

                }
            }
             
                

            
            #endregion

        }

        private void ogrenciDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cont = new linkDataContext();
            DataGridViewRow satirBilgisi = ogrenciDataGrid.CurrentRow;
            //txtAdi.Text = satirBilgisi.Cells["ADSOY"].Value.ToString();
            txtAdi.Tag= satirBilgisi.Cells["ID"].Value;
            int id = Convert.ToInt32(txtAdi.Tag);

            Ogrenciler ogr = cont.Ogrencilers.SingleOrDefault(x => x.OgrenciID == id);

            txtAdi.Text = ogr.OgrenciAdi.ToString();
            txtSoyadi.Text = ogr.OgrenciSoyadi;

            cmbYas.Text = "";
            cmbYas.SelectedText = satirBilgisi.Cells["YAŞI"].Value.ToString();
           
            if (ogr.OgrenciCinsiyet == "erkek")
            {
                rdbErkek.Checked = true;
            }
            else rdbKiz.Checked = true;
            txttc.Text = ogr.OgrenciTC;
            txtAdres.Text = ogr.OgrenciAdres;

            cmbOgretmen.SelectedValue = ogr.OgretmenID;
            cmbVeli.SelectedValue = ogr.VeliID;


        }
       
        public bool degisken = true;
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (cmbOrder.SelectedIndex==0)
            {
                if (degisken)
                {
                    cont = new linkDataContext();

                    var sorgu = (from ogr in cont.Ogrencilers
                                 join ogrt in cont.Ogretmenlers
                                 on ogr.OgretmenID equals ogrt.OgretmenID
                                 join vel in cont.Velilers
                                 on ogr.VeliID equals vel.VeliID
                                 orderby ogr.OgrenciAdi ascending

                                 select new
                                 {
                                     ID = ogr.OgrenciID,
                                     ADSOY = ogr.OgrenciAdi + " " + ogr.OgrenciSoyadi,
                                     YAŞI = ogr.OgrenciYasi,
                                     CINSIYET = ogr.OgrenciCinsiyet,
                                     TC = ogr.OgrenciTC,
                                     ADRES = ogr.OgrenciAdres,
                                     VELI = vel.VeliAdi,
                                     ÖĞRETMEN = ogrt.OgretmenAdi

                                 }).ToList();
                    cont.SubmitChanges();
                    ogrenciDataGrid.DataSource = sorgu;

                    degisken = !degisken;
                }
                else if (!degisken)
                {
                    cont = new linkDataContext();

                    var sorgu = (from ogr in cont.Ogrencilers
                                 join ogrt in cont.Ogretmenlers
                                 on ogr.OgretmenID equals ogrt.OgretmenID
                                 join vel in cont.Velilers
                                 on ogr.VeliID equals vel.VeliID
                                 orderby ogr.OgrenciAdi descending

                                 select new
                                 {
                                     ID = ogr.OgrenciID,
                                     ADSOY = ogr.OgrenciAdi + " " + ogr.OgrenciSoyadi,
                                     YAŞI = ogr.OgrenciYasi,
                                     CINSIYET = ogr.OgrenciCinsiyet,
                                     TC = ogr.OgrenciTC,
                                     ADRES = ogr.OgrenciAdres,
                                     VELI = vel.VeliAdi,
                                     ÖĞRETMEN = ogrt.OgretmenAdi

                                 }).ToList();
                    cont.SubmitChanges();
                    ogrenciDataGrid.DataSource = sorgu;
                    degisken = !degisken;

                }
            }
            if (cmbOrder.SelectedIndex==1)
            {

                if (degisken)
                {
                    cont = new linkDataContext();

                    var sorgu = (from ogr in cont.Ogrencilers
                                 join ogrt in cont.Ogretmenlers
                                 on ogr.OgretmenID equals ogrt.OgretmenID
                                 join vel in cont.Velilers
                                 on ogr.VeliID equals vel.VeliID
                                 orderby ogrt.OgretmenAdi ascending

                                 select new
                                 {
                                     ID = ogr.OgrenciID,
                                     ADSOY = ogr.OgrenciAdi + " " + ogr.OgrenciSoyadi,
                                     YAŞI = ogr.OgrenciYasi,
                                     CINSIYET = ogr.OgrenciCinsiyet,
                                     TC = ogr.OgrenciTC,
                                     ADRES = ogr.OgrenciAdres,
                                     VELI = vel.VeliAdi,
                                     ÖĞRETMEN = ogrt.OgretmenAdi

                                 }).ToList();
                    cont.SubmitChanges();
                    ogrenciDataGrid.DataSource = sorgu;

                    degisken = !degisken;

                }
                else if (!degisken)
                {
                    cont = new linkDataContext();

                    var sorgu = (from ogr in cont.Ogrencilers
                                 join ogrt in cont.Ogretmenlers
                                 on ogr.OgretmenID equals ogrt.OgretmenID
                                 join vel in cont.Velilers
                                 on ogr.VeliID equals vel.VeliID
                                 orderby ogrt.OgretmenAdi descending

                                 select new
                                 {
                                     ID = ogr.OgrenciID,
                                     ADSOY = ogr.OgrenciAdi + " " + ogr.OgrenciSoyadi,
                                     YAŞI = ogr.OgrenciYasi,
                                     CINSIYET = ogr.OgrenciCinsiyet,
                                     TC = ogr.OgrenciTC,
                                     ADRES = ogr.OgrenciAdres,
                                     VELI = vel.VeliAdi,
                                     ÖĞRETMEN = ogrt.OgretmenAdi

                                 }).ToList();
                    cont.SubmitChanges();
                    ogrenciDataGrid.DataSource = sorgu;
                    degisken = !degisken;

                }
            }
            if (cmbOrder.SelectedIndex==2)
            {

                if (degisken)
                {
                    
                        cont = new linkDataContext();

                        var sorgu = (from ogr in cont.Ogrencilers
                                     join ogrt in cont.Ogretmenlers
                                     on ogr.OgretmenID equals ogrt.OgretmenID
                                     join vel in cont.Velilers
                                     on ogr.VeliID equals vel.VeliID
                                     orderby ogr.OgrenciYasi ascending

                                     select new
                                     {
                                         ID = ogr.OgrenciID,
                                         ADSOY = ogr.OgrenciAdi + " " + ogr.OgrenciSoyadi,
                                         YAŞI = ogr.OgrenciYasi,
                                         CINSIYET = ogr.OgrenciCinsiyet,
                                         TC = ogr.OgrenciTC,
                                         ADRES = ogr.OgrenciAdres,
                                         VELI = vel.VeliAdi,
                                         ÖĞRETMEN = ogrt.OgretmenAdi

                                     }).ToList();
                        cont.SubmitChanges();
                        ogrenciDataGrid.DataSource = sorgu;

                        degisken = !degisken;      
                }

                else if (!degisken)
                {
                    cont = new linkDataContext();

                    var sorgu = (from ogr in cont.Ogrencilers
                                 join ogrt in cont.Ogretmenlers
                                 on ogr.OgretmenID equals ogrt.OgretmenID
                                 join vel in cont.Velilers
                                 on ogr.VeliID equals vel.VeliID
                                 orderby ogr.OgrenciYasi descending

                                 select new
                                 {
                                     ID = ogr.OgrenciID,
                                     ADSOY = ogr.OgrenciAdi + " " + ogr.OgrenciSoyadi,
                                     YAŞI = ogr.OgrenciYasi,
                                     CINSIYET = ogr.OgrenciCinsiyet,
                                     TC = ogr.OgrenciTC,
                                     ADRES = ogr.OgrenciAdres,
                                     VELI = vel.VeliAdi,
                                     ÖĞRETMEN = ogrt.OgretmenAdi

                                 }).ToList();
                    cont.SubmitChanges();
                    ogrenciDataGrid.DataSource = sorgu;
                    degisken = !degisken;

                }
            }
        }

        private void btnStream_Click(object sender, EventArgs e)
        {
            //txt dosyaya yazdırma
            cont = new linkDataContext();
            StreamWriter sw = new StreamWriter("OgrenciBilgileri.txt");
           
            foreach (DataGridViewRow item in ogrenciDataGrid.SelectedRows)
            {
                int id = Convert.ToInt32(item.Cells[0].Value);
                var sorgu = (from ogr in cont.Ogrencilers
                             where ogr.OgrenciID == id
                             select ogr).ToList();
                var a = sorgu.Select(x => x.OgrenciID + "," + x.OgrenciAdi + "," + x.OgrenciSoyadi + "," + x.OgrenciYasi + "," + x.OgrenciCinsiyet + "," + x.OgrenciTC + "," + x.OgrenciAdres );

                foreach (var item2 in a)
                {
                    string s = item2.ToString();
                    sw.WriteLine(s);
                }
            }

            sw.Close();

        }

        private void txtAdi_KeyDown(object sender, KeyEventArgs e)
        {
            //ekle butonunun görevini textbocların enter özelliğine de ekledim
            #region EKLE
            if (e.KeyCode == Keys.Enter)
            {


               
                if (cmbOgrenciSecim.SelectedIndex == 0)
                {
                    //secilen cinsiyetin degiskene atanmasi
                    if (rdbKiz.Checked)
                    {
                        cinsiyet = rdbKiz.Text;
                    }
                    else cinsiyet = rdbErkek.Text;



                    //ekleme islemi metod ile
                    cont = new linkDataContext();
                    ekle ek = new ekle(txtAdi.Text, txtSoyadi.Text, Convert.ToInt32(cmbYas.SelectedItem), cinsiyet, txttc.Text, txtAdres.Text, Convert.ToInt32(cmbOgretmen.SelectedValue), Convert.ToInt32(cmbVeli.SelectedValue));


                    //datasource verileri guncelleme
                    guncelle();


                    //ekleme islemi yaptiktan sonra textbox ve comboların temizlenmesi 
                    foreach (Control item in this.groupBox1.Controls)
                    {

                        if (item is TextBox)
                        {
                            TextBox tb = (TextBox)item;
                            tb.Clear();
                        }
                        if (item is ComboBox)
                        {
                            ComboBox cmb = (ComboBox)item;
                            cmb.SelectedIndex = 0;
                        }

                    }
                    rdbKiz.Checked = true;
                }
            }
            #endregion
        }

        private void txtSoyadi_KeyDown(object sender, KeyEventArgs e)
        {
            //ekle butonunun görevini textbocların enter özelliğine de ekledim
            #region EKLE
            if (e.KeyCode == Keys.Enter)
            {



                if (cmbOgrenciSecim.SelectedIndex == 0)
                {
                    //secilen cinsiyetin degiskene atanmasi
                    if (rdbKiz.Checked)
                    {
                        cinsiyet = rdbKiz.Text;
                    }
                    else cinsiyet = rdbErkek.Text;



                    //ekleme islemi metod ile
                    cont = new linkDataContext();
                    ekle ek = new ekle(txtAdi.Text, txtSoyadi.Text, Convert.ToInt32(cmbYas.SelectedItem), cinsiyet, txttc.Text, txtAdres.Text, Convert.ToInt32(cmbOgretmen.SelectedValue), Convert.ToInt32(cmbVeli.SelectedValue));


                    //datasource verileri guncelleme
                    guncelle();


                    //ekleme islemi yaptiktan sonra textbox ve comboların temizlenmesi 
                    foreach (Control item in this.groupBox1.Controls)
                    {

                        if (item is TextBox)
                        {
                            TextBox tb = (TextBox)item;
                            tb.Clear();
                        }
                        if (item is ComboBox)
                        {
                            ComboBox cmb = (ComboBox)item;
                            cmb.SelectedIndex = 0;
                        }

                    }
                    rdbKiz.Checked = true;
                }
            }
            #endregion

        }

        private void txttc_KeyDown(object sender, KeyEventArgs e)
        {
            //ekle butonunun görevini textbocların enter özelliğine de ekledim
            #region EKLE
            if (e.KeyCode == Keys.Enter)
            {



                if (cmbOgrenciSecim.SelectedIndex == 0)
                {
                    //secilen cinsiyetin degiskene atanmasi
                    if (rdbKiz.Checked)
                    {
                        cinsiyet = rdbKiz.Text;
                    }
                    else cinsiyet = rdbErkek.Text;



                    //ekleme islemi metod ile
                    cont = new linkDataContext();
                    ekle ek = new ekle(txtAdi.Text, txtSoyadi.Text, Convert.ToInt32(cmbYas.SelectedItem), cinsiyet, txttc.Text, txtAdres.Text, Convert.ToInt32(cmbOgretmen.SelectedValue), Convert.ToInt32(cmbVeli.SelectedValue));


                    //datasource verileri guncelleme
                    guncelle();


                    //ekleme islemi yaptiktan sonra textbox ve comboların temizlenmesi 
                    foreach (Control item in this.groupBox1.Controls)
                    {

                        if (item is TextBox)
                        {
                            TextBox tb = (TextBox)item;
                            tb.Clear();
                        }
                        if (item is ComboBox)
                        {
                            ComboBox cmb = (ComboBox)item;
                            cmb.SelectedIndex = 0;
                        }

                    }
                    rdbKiz.Checked = true;
                }
            }
            #endregion
        }

        private void txtAdres_KeyDown(object sender, KeyEventArgs e)
        {
            //ekle butonunun görevini textbocların enter özelliğine de ekledim
            #region EKLE
            if (e.KeyCode == Keys.Enter)
            {



                if (cmbOgrenciSecim.SelectedIndex == 0)
                {
                    //secilen cinsiyetin degiskene atanmasi
                    if (rdbKiz.Checked)
                    {
                        cinsiyet = rdbKiz.Text;
                    }
                    else cinsiyet = rdbErkek.Text;



                    //ekleme islemi metod ile
                    cont = new linkDataContext();
                    ekle ek = new ekle(txtAdi.Text, txtSoyadi.Text, Convert.ToInt32(cmbYas.SelectedItem), cinsiyet, txttc.Text, txtAdres.Text, Convert.ToInt32(cmbOgretmen.SelectedValue), Convert.ToInt32(cmbVeli.SelectedValue));


                    //datasource verileri guncelleme
                    guncelle();


                    //ekleme islemi yaptiktan sonra textbox ve comboların temizlenmesi 
                    foreach (Control item in this.groupBox1.Controls)
                    {

                        if (item is TextBox)
                        {
                            TextBox tb = (TextBox)item;
                            tb.Clear();
                        }
                        if (item is ComboBox)
                        {
                            ComboBox cmb = (ComboBox)item;
                            cmb.SelectedIndex = 0;
                        }

                    }
                    rdbKiz.Checked = true;
                }
            }
            #endregion
        }
    }
}
