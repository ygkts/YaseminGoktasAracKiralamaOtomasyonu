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
    public partial class FormMusteriIslem : Form
    {
        RentACarDBEntities db = new RentACarDBEntities();
        ImageConverter converter = new ImageConverter();
        Image img;
        MemoryStream ms;
        Musteri m;
        int secilenID;
        public FormMusteriIslem()
        {
            InitializeComponent();
        }
        private void Doldur()
        {
            var musteriList = db.Musteri.Select(x => new
            {
                x.ID,
                x.TCNo,
                x.Ad,
                x.Soyad,
                x.DTarih,
                x.Meslek,
                x.CepNo,
                x.EvIsTelNo,
                x.EPosta,
                x.Adres,
                x.EhliyetNo,
                x.EhliyetTur,
                x.Notlar,
                x.Resim
            }).OrderBy(x => x.Ad).ToList();
            dataGridViewMusteriListe.DataSource = musteriList;
            dataGridViewMusteriListe.Columns[0].Visible = false;
        }

        private void FormMusteriIslem_Load(object sender, EventArgs e)
        {
            Doldur();

            img = pictureBox4.Image;
            ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
        }

        private void dataGridViewMusteriListe_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = Convert.ToInt32(dataGridViewMusteriListe.CurrentRow.Cells[0].Value);
            m = db.Musteri.Where(x => x.ID == secilenID).FirstOrDefault();
            textBoxTCNo.Text = m.TCNo;
            textBoxIsim.Text = m.Ad;
            textBoxSoyIsim.Text = m.Soyad;
            dateTimePickerDogumTarih.Value = (DateTime)m.DTarih;
            textBoxMeslek.Text = m.Meslek;
            maskedTextBoxCepTel.Text = m.CepNo;
            maskedTextBoxEvIsTel.Text = m.EvIsTelNo;
            textBoxEmail.Text = m.EPosta;
            textBoxAdres.Text = m.Adres;
            textBoxEhliyetNo.Text = m.EhliyetNo.ToString();
            textBoxEhliyetTur.Text = m.EhliyetTur;
            textBoxNotlar.Text = m.Notlar;
            if (m.Resim != null)
            {
                pictureBox4.Image = (Image)converter.ConvertFrom(m.Resim);
                img = pictureBox4.Image;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void buttonResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(fileDialog.FileName);
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);

                pictureBox4.Image = (Image)converter.ConvertFrom(ms.ToArray());
            }
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            m = new Musteri();

            m.TCNo = textBoxTCNo.Text;
            m.Ad = textBoxIsim.Text;
            m.Soyad = textBoxSoyIsim.Text;
            m.DTarih = dateTimePickerDogumTarih.Value;
            m.Meslek = textBoxMeslek.Text;
            m.CepNo = maskedTextBoxCepTel.Text;
            m.EvIsTelNo = maskedTextBoxEvIsTel.Text;
            m.EPosta = textBoxEmail.Text;
            m.Adres = textBoxAdres.Text;
            m.EhliyetNo = Convert.ToInt32(textBoxEhliyetNo.Text);
            m.EhliyetTur = textBoxEhliyetTur.Text;
            m.Notlar = textBoxNotlar.Text;
            m.Resim = ms.ToArray();

            db.Musteri.Add(m);
            db.SaveChanges();
            MessageBox.Show("Kayıt Gerçekleşti... ☻");
            Doldur();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            m = db.Musteri.Find(secilenID);

            m.TCNo = textBoxTCNo.Text;
            m.Ad = textBoxIsim.Text;
            m.Soyad = textBoxSoyIsim.Text;
            m.DTarih = dateTimePickerDogumTarih.Value;
            m.Meslek = textBoxMeslek.Text;
            m.CepNo = maskedTextBoxCepTel.Text;
            m.EvIsTelNo = maskedTextBoxEvIsTel.Text;
            m.EPosta = textBoxEmail.Text;
            m.Adres = textBoxAdres.Text;
            m.EhliyetNo = Convert.ToInt32(textBoxEhliyetNo.Text);
            m.EhliyetTur = textBoxEhliyetTur.Text;
            m.Notlar = textBoxNotlar.Text;
            m.Resim = ms.ToArray();
            
            db.SaveChanges();
            MessageBox.Show("Güncelleme Gerçekleşti... ☻");
            Doldur();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            m = db.Musteri.Find(secilenID);
            db.Musteri.Remove(m);
            db.SaveChanges();
            MessageBox.Show("Silme Gerçekleşti... ☻");
            Doldur();
        }

        private void textBoxTcNoAra_TextChanged(object sender, EventArgs e)
        {
            var mList = db.Musteri.Select(x => new
            {
                x.ID,
                x.TCNo,
                x.Ad,
                x.Soyad,
                x.DTarih,
                x.Meslek,
                x.CepNo,
                x.EvIsTelNo,
                x.EPosta,
                x.Adres,
                x.EhliyetNo,
                x.EhliyetTur,
                x.Notlar,
                x.Resim
            }).Where(x => x.TCNo.Contains(textBoxTcNoAra.Text)).OrderBy(x => x.TCNo).ToList();    // contains = içerisinde ara demektir
            dataGridViewMusteriListe.DataSource = mList;
            dataGridViewMusteriListe.Columns[0].Visible = false;
        }

        private void textBoxIsimAra_TextChanged(object sender, EventArgs e)
        {
            var mList = db.Musteri.Select(x => new
            {
                x.ID,
                x.TCNo,
                x.Ad,
                x.Soyad,
                x.DTarih,
                x.Meslek,
                x.CepNo,
                x.EvIsTelNo,
                x.EPosta,
                x.Adres,
                x.EhliyetNo,
                x.EhliyetTur,
                x.Notlar,
                x.Resim
            }).Where(x => x.Ad.Contains(textBoxIsimAra.Text)).OrderBy(x => x.Ad).ToList();    // contains = içerisinde ara demektir
            dataGridViewMusteriListe.DataSource = mList;
            dataGridViewMusteriListe.Columns[0].Visible = false;
        }

        private void textBoxEmailAra_TextChanged(object sender, EventArgs e)
        {
            var mList = db.Musteri.Select(x => new
            {
                x.ID,
                x.TCNo,
                x.Ad,
                x.Soyad,
                x.DTarih,
                x.Meslek,
                x.CepNo,
                x.EvIsTelNo,
                x.EPosta,
                x.Adres,
                x.EhliyetNo,
                x.EhliyetTur,
                x.Notlar,
                x.Resim
            }).Where(x => x.EPosta.Contains(textBoxEmailAra.Text)).OrderBy(x => x.EPosta).ToList();    // contains = içerisinde ara demektir
            dataGridViewMusteriListe.DataSource = mList;
            dataGridViewMusteriListe.Columns[0].Visible = false;
        }
    }
}
