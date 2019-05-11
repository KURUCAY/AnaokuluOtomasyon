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
namespace BoyaliEller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        


        public Random rnd;
        public int tut=0;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            

            if ((kullaniciGirisi(txtKullaniciAdi.Text,txtKullaniciSifre.Text))&&textBox1.Text==lblDogrula.Text)
            {
                Ana_Sayfa syf = new Ana_Sayfa();
                syf.Show();
                this.Hide();
                MessageBox.Show("Başarılı Giriş");
            }
            else
            {
                tut = rnd.Next(10000, 99999);
                lblDogrula.Text = tut.ToString();
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void txtKullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if ((kullaniciGirisi(txtKullaniciAdi.Text, txtKullaniciSifre.Text)) && textBox1.Text == lblDogrula.Text)
                {
                    Ana_Sayfa syf = new Ana_Sayfa();
                    syf.Show();
                    this.Hide();
                }
                else
                {
                    tut = rnd.Next(10000, 99999);
                    lblDogrula.Text = tut.ToString();
                }

            }
         
        }

        private void txtKullaniciSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((kullaniciGirisi(txtKullaniciAdi.Text, txtKullaniciSifre.Text)) && textBox1.Text == lblDogrula.Text)
                {
                    Ana_Sayfa syf = new Ana_Sayfa();
                    syf.Show();
                    this.Hide();
                }
                else
                {
                    tut = rnd.Next(10000, 99999);
                    lblDogrula.Text = tut.ToString();
                }

            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((kullaniciGirisi(txtKullaniciAdi.Text, txtKullaniciSifre.Text)) && textBox1.Text == lblDogrula.Text)
                {
                    Ana_Sayfa syf = new Ana_Sayfa();
                    syf.Show();
                    this.Hide();
                }
                else
                {
                    tut = rnd.Next(10000, 99999);
                    lblDogrula.Text = tut.ToString();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
            tut = rnd.Next(10000, 99999);
            lblDogrula.Text = tut.ToString();

        }
       
        public bool kullaniciGirisi(string kullanici, string sifre)
        {
            linkDataContext cont = new linkDataContext();
            var sorgu =( from giris in cont.KullaniciGiris
                        where giris.KullaniciAdi == kullanici && giris.KullaniciSifre == sifre
                        select giris).ToList();
            if (sorgu.Any())
            {
                return true;
               
            }
            else
            {
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox tx = (TextBox)item;
                        tx.Clear();
                    }
                }
                return false;


            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtKullaniciSifre.PasswordChar = '*';

            }
            else
            {
                txtKullaniciSifre.PasswordChar = '\0';
            }
        }


    }
}
