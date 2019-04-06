using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_RentACar
{
    public partial class FormAdminAyarlari : Form
    {
        public FormAdminAyarlari()
        {
            InitializeComponent();
        }
        RentACarDBEntities db;
        ImageConverter converter = new ImageConverter();
        Image img;
        MemoryStream ms;
        Kullanicilar k;
        int secilenID;
        
        private void Doldur()
        {
            db = new RentACarDBEntities();
            var kulList = db.Kullanicilar.Select(x => new
            {
                x.ID,
                x.Ad,
                x.Soyad,
                x.EPosta,
                x.Sifre,
                x.Telefon,
                x.Resim,
                x.YetkiDuzeyi
            }).OrderBy(x => x.Ad).ToList();
            dataGridView1.DataSource = kulList;
            dataGridView1.Columns[0].Visible = false;
        }

        private void FormAdminAyarlari_Load(object sender, EventArgs e)
        {
            Doldur();

            img = pictureBoxSecilenResim.Image;
            ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            k = db.Kullanicilar.Where(x => x.ID == secilenID).FirstOrDefault();
            txtAd.Text = k.Ad;
            txtSoyad.Text = k.Soyad;
            txtEposta.Text = k.EPosta;
            txtSifre.Text = k.Sifre;
            txtTel.Text = k.Telefon;
            if (k.Resim != null)
            {
                pictureBoxSecilenResim.Image = (Image)converter.ConvertFrom(k.Resim);
                img = pictureBoxSecilenResim.Image;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }           
            comboBoxYetkiDuzeyi.Text = k.YetkiDuzeyi.ToString();
        }

        private void btnResimSeç_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdl = new OpenFileDialog();
            if (fdl.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(fdl.FileName);
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);

                pictureBoxSecilenResim.Image = (Image)converter.ConvertFrom(ms.ToArray());
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            db = new RentACarDBEntities();
            k = new Kullanicilar();
            k.Ad = txtAd.Text;
            k.Soyad = txtSoyad.Text;
            k.EPosta = txtEposta.Text;
            k.Sifre = txtSifre.Text;
            k.Telefon = txtTel.Text;

            k.Resim = ms.ToArray();
            k.YetkiDuzeyi = Convert.ToInt32(comboBoxYetkiDuzeyi.Text);
            db.Kullanicilar.Add(k);
            db.SaveChanges();
            MessageBox.Show("Kayıt Gerçekleşti... ☻");
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            k = db.Kullanicilar.Find(secilenID);
                        
            k.Ad = txtAd.Text;
            k.Soyad = txtSoyad.Text;
            k.EPosta = txtEposta.Text;
            k.Sifre = txtSifre.Text;
            k.Telefon = txtTel.Text;

            k.Resim = ms.ToArray();
            k.YetkiDuzeyi = Convert.ToInt32(comboBoxYetkiDuzeyi.Text);
            db.SaveChanges();
            MessageBox.Show("Güncelleme Gerçekleşti... ☻");
            Doldur();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            db = new RentACarDBEntities();
            k = db.Kullanicilar.Find(secilenID);
            db.Kullanicilar.Remove(k);
            db.SaveChanges();
            MessageBox.Show("Silme Gerçekleşti... ☻");
            Doldur();

        }
    }
}