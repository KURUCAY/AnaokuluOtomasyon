using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoyaliEller
{
    class ekle
    {
        public ekle(string ad,string soyad,int yas,string cins,string tcc,string adres,int ogretmen, int veli)
        {
            try
            {
                Ogrenci_Sayfasi syf = new Ogrenci_Sayfasi();
                linkDataContext cont = new linkDataContext();
                Ogrenciler ogr = new Ogrenciler();
                ogr.OgrenciAdi = ad;
                ogr.OgrenciSoyadi = soyad;
                ogr.OgrenciYasi = yas;
                ogr.OgrenciCinsiyet = cins;
                ogr.OgrenciTC = tcc;
                ogr.OgrenciAdres = adres;
                ogr.OgretmenID = ogretmen;
                ogr.VeliID = veli;
                cont.Ogrencilers.InsertOnSubmit(ogr);
                cont.SubmitChanges();

               
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Lütfen Alanların Doğruluğunu Kontrol ediniz");
            }
            
        }


       

        
        
    }
}
