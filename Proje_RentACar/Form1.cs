using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_RentACar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirisIslemleri();
        }

        RentACarDBEntities context = new RentACarDBEntities();
        FormAnaSayfa formAna = new FormAnaSayfa();

        public string kulMailAdresi, kulSifre, hata;
        public bool hataDurumu;
        public string kulAd, kulSoyad;
        public int ID;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "yg@gmail.com";
            txtSifre.Text = "123";
        }

        public int sayac = 0;

        private void GirisIslemleri()
        {
            kulMailAdresi = txtEmail.Text;
            kulSifre = txtSifre.Text;

            bool giris = Login(kulMailAdresi, kulSifre);

            if (string.IsNullOrEmpty(kulMailAdresi))
            {
                hata += "Mail adresi alanı hatalı girildi!...\n";
                hataDurumu = true;
            }
            if (string.IsNullOrEmpty(kulSifre))
            {
                hata += "Şifre alanı hatalı girildi!...";
                hataDurumu = true;
            }
            if (hataDurumu)
            {
                MessageBox.Show(hata, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            if (giris == false)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else if (giris == true)
            {
                formAna.ShowDialog();
                this.Hide();
            }
        }
        private bool Login(string kMail, string kSifre)
        {
            var user = (from k in context.Kullanicilar
                        where k.EPosta == kMail && k.Sifre == kSifre
                        select k).FirstOrDefault();

            if (user != null)
            {
                formAna.labelKulAd.Text = (from k in context.Kullanicilar
                                           where k.EPosta == kMail && k.Sifre == kSifre
                                           select k.Ad).FirstOrDefault().ToString();

                formAna.labelKulSoyad.Text = (from k in context.Kullanicilar
                                              where k.EPosta == kMail && k.Sifre == kSifre
                                              select k.Soyad).FirstOrDefault().ToString();

                var yetkiLocal = (from k in context.Kullanicilar
                                  where kulMailAdresi == k.EPosta && kulSifre == k.Sifre
                                  select k.YetkiDuzeyi).FirstOrDefault();
                
                ID = Convert.ToInt32((from k in context.Kullanicilar
                                             where k.EPosta == kMail && k.Sifre == kSifre
                                             select k.ID).FirstOrDefault());
                
                formAna.yetki = Convert.ToInt32(yetkiLocal);
                sayac++;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
