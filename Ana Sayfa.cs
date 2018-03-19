using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoyaliEller
{
    public partial class Ana_Sayfa : Form
    {
        public Ana_Sayfa()
        {
            InitializeComponent();
        }



        public linkDataContext cont;
        private void Ana_Sayfa_Load(object sender, EventArgs e)
        {
            linkDataContext cx = new linkDataContext();
            var deneme = (from ogr1 in cx.Ogrencilers
                          join ogrt in cx.Ogretmenlers
                           on ogr1.OgretmenID equals ogrt.OgretmenID
                          join vel in cx.Velilers
                          on ogr1.VeliID equals vel.VeliID
                          select new
                          {
                              OğrenciAdi = ogr1.OgrenciAdi,
                              OgrenciSoyadi = ogr1.OgrenciSoyadi,
                              OgretmenAdi = ogrt.OgretmenAdi,
                              OGretmenSoyadi = ogrt.OgretmenSoyadi,
                              OgretmenTel = ogrt.OgretmenTelefon,
                              VeliAdi = vel.VeliAdi,
                              VeliTel = vel.VeliTelefon
                          }).ToList();

            dataGridGoruntule.DataSource = deneme;


        }

        private void Ana_Sayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void goruntuleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci_Sayfasi ogr = new Ogrenci_Sayfasi();
            ogr.Show();
            this.Hide();
        }

        
        
    }
}
