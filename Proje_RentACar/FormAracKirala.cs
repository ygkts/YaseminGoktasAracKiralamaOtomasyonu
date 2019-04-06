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
    public partial class FormAracKirala : Form
    {
        public FormAracKirala()
        {
            InitializeComponent();
        }
        RentACarDBEntities db = new RentACarDBEntities();
        MusaitAraclar mA;
        KiradakiAraclar kA;
        int secilenID;
        private void DoldurKiradakiAraclar()
        {
            var aracList = db.KiradakiAraclar.Select(x => new
            {
                x.ID,
                x.AracID,
                x.AracPlaka,
                x.AracMarka,
                x.AracModel,
                x.AracYil,
                x.MusteriID,
                x.MusteriAd,
                x.MusteriSoyad,
                x.AlisTarih,
                x.VerisTarih,
                x.TcNo,
                x.Telefon,
                x.ToplamTutar
            }).OrderBy(x => x.AracPlaka).ToList();
            dataGridViewKiradakiAraclar.DataSource = aracList;
            dataGridViewKiradakiAraclar.Columns[0].Visible = false;
            dataGridViewKiradakiAraclar.Columns[1].Visible = false;
            dataGridViewKiradakiAraclar.Columns[3].Visible = false;
            dataGridViewKiradakiAraclar.Columns[4].Visible = false;
            dataGridViewKiradakiAraclar.Columns[5].Visible = false;
            dataGridViewKiradakiAraclar.Columns[6].Visible = false;
            dataGridViewKiradakiAraclar.Columns[11].Visible = false;
        }
        private void DoldurMusaitAraclar()
        {
            var aracList = db.MusaitAraclar.Select(x => new
            {
                x.ID,
                x.AracID,
                x.AracPlaka,
                x.Marka,
                x.Model,
                x.Yil
            }).OrderBy(x => x.AracPlaka).ToList();
            dataGridViewMusaitAraclar.DataSource = aracList;
            dataGridViewMusaitAraclar.Columns[0].Visible = false;
            dataGridViewMusaitAraclar.Columns[1].Visible = false;
        }
        private void ComboPlakaDoldur()
        {
            var plakaList = db.MusaitAraclar.Select(x => new
            {
                x.ID,
                x.AracPlaka
            }).ToList();
            comboBoxPlaka.DisplayMember = "AracPlaka";
            comboBoxPlaka.ValueMember = "ID";
            comboBoxPlaka.DataSource = plakaList;
        }
        private void ComboTcNoDoldur()
        {
            var tcNoList = db.Musteri.Select(x => new
            {
                x.ID,
                x.TCNo
            }).ToList();
            comboBoxTcNo.DisplayMember = "TCNo";
            comboBoxTcNo.ValueMember = "ID";
            comboBoxTcNo.DataSource = tcNoList;
        }
        private void FormAracKirala_Load(object sender, EventArgs e)
        {
            DoldurMusaitAraclar();
            DoldurKiradakiAraclar();
            ComboPlakaDoldur();
            ComboTcNoDoldur();

        }

        private void dataGridViewKiradakiAraclar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = Convert.ToInt32(dataGridViewKiradakiAraclar.CurrentRow.Cells[0].Value);
            kA = db.KiradakiAraclar.Where(x => x.ID == secilenID).FirstOrDefault();
            comboBoxPlaka.Text = kA.AracPlaka;
            comboBoxTcNo.Text = kA.TcNo;
            numericUpDownTutar.Value = Convert.ToDecimal(kA.ToplamTutar);
            dateTimePickerAlis.Value = (DateTime)kA.AlisTarih;
            dateTimePickerVeris.Value = (DateTime)kA.VerisTarih;
        }

        private void dataGridViewMusaitAraclar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = Convert.ToInt32(dataGridViewMusaitAraclar.CurrentRow.Cells[0].Value);
            mA = db.MusaitAraclar.Where(x => x.ID == secilenID).FirstOrDefault();
            comboBoxPlaka.Text = mA.AracPlaka;

            comboBoxTcNo.Text = "";
            numericUpDownTutar.Value = 0;
            dateTimePickerAlis.Value = DateTime.Now;
            dateTimePickerVeris.Value = DateTime.Now;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            // seçilen araç müsait araçlar veritabanından silinip kiradaki araçlar veri tabanına eklenmektedir.
            mA = new MusaitAraclar();
            kA = new KiradakiAraclar();

            kA.TcNo = comboBoxTcNo.Text;
            kA.AracPlaka = comboBoxPlaka.Text;
            kA.ToplamTutar = numericUpDownTutar.Value;
            kA.AlisTarih = dateTimePickerAlis.Value;
            kA.VerisTarih = dateTimePickerVeris.Value;

            // datagridde olmayan ve değiştirilmeyem alanlar boş eklenmesin diye gerekli tablolardan where koşuluyla alınıyor :
            kA.MusteriAd = db.Musteri.Where(x => x.TCNo == comboBoxTcNo.Text).Select(x => x.Ad).FirstOrDefault();
            kA.MusteriSoyad = db.Musteri.Where(x => x.TCNo == comboBoxTcNo.Text).Select(x => x.Soyad).FirstOrDefault();
            kA.Telefon = db.Musteri.Where(x => x.TCNo == comboBoxTcNo.Text).Select(x => x.CepNo).FirstOrDefault();
            kA.MusteriID = db.Musteri.Where(x => x.TCNo == comboBoxTcNo.Text).Select(x => x.ID).FirstOrDefault();
            kA.AracID = db.Araclar.Where(x => x.Plaka == comboBoxPlaka.Text).Select(x => x.ID).FirstOrDefault();
            kA.AracMarka = db.Araclar.Where(x => x.Plaka == comboBoxPlaka.Text).Select(x => x.Marka).FirstOrDefault();
            kA.AracModel = db.Araclar.Where(x => x.Plaka == comboBoxPlaka.Text).Select(x => x.Model).FirstOrDefault();
            kA.AracYil = db.Araclar.Where(x => x.Plaka == comboBoxPlaka.Text).Select(x => x.Yıl).FirstOrDefault();

            secilenID = db.MusaitAraclar.Where(x => x.AracPlaka == comboBoxPlaka.Text).Select(x => x.ID).FirstOrDefault();

            mA = db.MusaitAraclar.Find(secilenID);
            db.MusaitAraclar.Remove(mA);
            db.KiradakiAraclar.Add(kA);
            db.SaveChanges();

            MessageBox.Show("Kayıt Gerçekleşti... ☻");
            DoldurKiradakiAraclar();
            DoldurMusaitAraclar();

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            kA = db.KiradakiAraclar.Find(secilenID);

            kA.AracPlaka = comboBoxPlaka.Text;
            kA.TcNo = comboBoxTcNo.Text;
            kA.ToplamTutar = numericUpDownTutar.Value;
            kA.AlisTarih = dateTimePickerAlis.Value;
            kA.VerisTarih = dateTimePickerVeris.Value;

            // datagridde olmayan ve değiştirilmeyem alanlar boş eklenmesin diye gerekli tablolardan where koşuluyla alınıyor :
            kA.MusteriAd = db.Musteri.Where(x => x.TCNo == comboBoxTcNo.Text).Select(x => x.Ad).FirstOrDefault();
            kA.MusteriSoyad = db.Musteri.Where(x => x.TCNo == comboBoxTcNo.Text).Select(x => x.Soyad).FirstOrDefault();
            kA.Telefon = db.Musteri.Where(x => x.TCNo == comboBoxTcNo.Text).Select(x => x.CepNo).FirstOrDefault();
            kA.MusteriID = db.Musteri.Where(x => x.TCNo == comboBoxTcNo.Text).Select(x => x.ID).FirstOrDefault();
            kA.AracID = db.Araclar.Where(x => x.Plaka == comboBoxPlaka.Text).Select(x => x.ID).FirstOrDefault();
            kA.AracMarka = db.Araclar.Where(x => x.Plaka == comboBoxPlaka.Text).Select(x => x.Marka).FirstOrDefault();
            kA.AracModel = db.Araclar.Where(x => x.Plaka == comboBoxPlaka.Text).Select(x => x.Model).FirstOrDefault();
            kA.AracYil = db.Araclar.Where(x => x.Plaka == comboBoxPlaka.Text).Select(x => x.Yıl).FirstOrDefault();

            db.SaveChanges();
            MessageBox.Show("Güncelleme Gerçekleşti... ☻");
            DoldurKiradakiAraclar();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            kA = db.KiradakiAraclar.Find(secilenID);
            db.KiradakiAraclar.Remove(kA);
            secilenID = db.MusaitAraclar.Where(x => x.AracPlaka == comboBoxPlaka.Text).Select(x => x.ID).FirstOrDefault();
            mA = db.MusaitAraclar.Find(secilenID);
            db.MusaitAraclar.Add(mA);
            db.SaveChanges();
            MessageBox.Show("Silme Gerçekleşti... ☻");
            DoldurKiradakiAraclar();
        }
        
    }
}
