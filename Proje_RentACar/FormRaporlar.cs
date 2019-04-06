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
    public partial class FormRaporlar : Form
    {
        RentACarDBEntities db = new RentACarDBEntities();
        KiradakiAraclar kA;
        Raporlar r;
        Araclar a;
        int secilenID;
        private void DoldurRaporlar()
        {
            var aracList = db.Raporlar.Select(x => new
            {
                x.ID,
                x.ArızaliAracID,
                x.Plaka,
                x.MusteriID,
                x.Ariza,
                x.Tarih,
                x.Masraf,
                x.MusteriAd,
                x.MusteriSoyad
            }).OrderBy(x => x.Plaka).ToList();
            dataGridViewRaporlar.DataSource = aracList;
            dataGridViewRaporlar.Columns[0].Visible = false;
            dataGridViewRaporlar.Columns[1].Visible = false;
            dataGridViewRaporlar.Columns[3].Visible = false;
        }
        private void ComboPlakaDoldur()
        {
            var plakaList = db.KiradakiAraclar.Select(x => new
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
            comboBoxTCno.DisplayMember = "TCNo";
            comboBoxTCno.ValueMember = "ID";
            comboBoxTCno.DataSource = tcNoList;
        }
        public FormRaporlar()
        {
            InitializeComponent();
        }

        private void FormRaporlar_Load(object sender, EventArgs e)
        {
            DoldurRaporlar();
            ComboPlakaDoldur();
            ComboTcNoDoldur();
        }
        private void dataGridViewRaporlar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = Convert.ToInt32(dataGridViewRaporlar.CurrentRow.Cells[0].Value);
            r = db.Raporlar.Where(x => x.ID == secilenID).FirstOrDefault();
            comboBoxPlaka.Text = r.Plaka;
            comboBoxTCno.Text = db.Musteri.Where(x => x.ID == r.MusteriID).Select(x => x.TCNo).FirstOrDefault();
            textBoxAriza.Text = r.Ariza;
            numericUpDownMasraf.Value = Convert.ToDecimal(r.Masraf);
            dateTimePickerTarih.Value = (DateTime)r.Tarih;
        }
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            // RAPORLU ARAÇLAR KİRALANAMAZ!
            // seçilen araç müsait araçlar(kiralanır durumda olmadığı için) ve kiradaki araçlar(müşteriden alındığı için) veritabanlarından silinip raporlar veri tabanına eklenmektedir.
            // kiradaki araçlar tablosuna eklenen bir veri zaten müsait araçlardan silindiği için, burada müsait araçlar için bi silme işlemi gerekmez.
            
            kA = new KiradakiAraclar();
            r = new Raporlar();

            r.ArızaliAracID = db.Araclar.Where(x => x.Plaka == comboBoxPlaka.Text).Select(x => x.ID).FirstOrDefault();
            r.Plaka = comboBoxPlaka.Text;
            r.MusteriID = db.Musteri.Where(x => x.TCNo == comboBoxTCno.Text).Select(x => x.ID).FirstOrDefault();
            r.Ariza = textBoxAriza.Text;
            r.Tarih = dateTimePickerTarih.Value;
            r.Masraf = numericUpDownMasraf.Value;
            r.MusteriAd = db.Musteri.Where(x => x.TCNo == comboBoxTCno.Text).Select(x => x.Ad).FirstOrDefault();
            r.MusteriSoyad = db.Musteri.Where(x => x.TCNo == comboBoxTCno.Text).Select(x => x.Soyad).FirstOrDefault();

            //secilenID = db.MusaitAraclar.Where(x => x.AracPlaka == comboBoxPlaka.Text).Select(x => x.ID).FirstOrDefault();
            //mA = db.MusaitAraclar.Find(secilenID);
            //db.MusaitAraclar.Remove(mA);

            secilenID = db.KiradakiAraclar.Where(x => x.AracPlaka == comboBoxPlaka.Text).Select(x => x.ID).FirstOrDefault();
            kA = db.KiradakiAraclar.Find(secilenID);
            db.KiradakiAraclar.Remove(kA);
            db.Raporlar.Add(r);
            db.SaveChanges();
            MessageBox.Show("Kayıt Gerçekleşti... ☻");
            DoldurRaporlar();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            r = db.Raporlar.Find(secilenID);

            r.ArızaliAracID = db.Araclar.Where(x => x.Plaka == comboBoxPlaka.Text).Select(x => x.ID).FirstOrDefault();
            r.Plaka = comboBoxPlaka.Text;
            r.MusteriID = db.Musteri.Where(x => x.TCNo == comboBoxTCno.Text).Select(x => x.ID).FirstOrDefault();
            r.Ariza = textBoxAriza.Text;
            r.Tarih = dateTimePickerTarih.Value;
            r.Masraf = numericUpDownMasraf.Value;
            r.MusteriAd = db.Musteri.Where(x => x.TCNo == comboBoxTCno.Text).Select(x => x.Ad).FirstOrDefault();
            r.MusteriSoyad = db.Musteri.Where(x => x.TCNo == comboBoxTCno.Text).Select(x => x.Soyad).FirstOrDefault();

            db.SaveChanges();
            MessageBox.Show("Güncelleme Gerçekleşti... ☻");
            DoldurRaporlar();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            // bir defa raporlanmış araç onarılsa bile tekrar kiralanamayacağı için müsait araçlar tablosuna eklenmez ve hatta araçlar tablosundan dahi çıkarılır.
            r = db.Raporlar.Find(secilenID);
            db.Raporlar.Remove(r);
            db.SaveChanges();
            secilenID = db.Araclar.Where(x => x.Plaka == comboBoxPlaka.Text).Select(x => x.ID).FirstOrDefault();
            a = db.Araclar.Find(secilenID);
            db.Araclar.Remove(a);
            db.SaveChanges();
            MessageBox.Show("Silme Gerçekleşti... ☻");
            DoldurRaporlar();
        }

        // ALTTAKİ METOD SAYESİNDE, SEÇİLEN PLAKAYA GÖRE KİRADAKİ ARAÇLAR TABLOSUNDAN ARACI KİRALAYAN MÜÜŞTERİNİN PLAKASI COMBOBOXPLAKA'DA OTOMATİK SEÇİLİ GELİR: 
        private void comboBoxPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTCno.Text = db.KiradakiAraclar.Where(x => x.AracPlaka == comboBoxPlaka.Text).Select(x => x.TcNo).FirstOrDefault();
        }
    }
}
