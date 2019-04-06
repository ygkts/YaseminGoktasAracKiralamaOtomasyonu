using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;    // MemoryStream için gerekli kütüphane
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_RentACar
{
    public partial class FormAracIslem : Form
    {
        RentACarDBEntities db;
        ImageConverter converter = new ImageConverter();
        Image img;
        MemoryStream ms;
        Araclar a;
        MusaitAraclar mA;
        int secilenID;
        int secilenID2;
        public FormAracIslem()
        {
            InitializeComponent();
        }
        private void Doldur()
        {
            db = new RentACarDBEntities();
            var aracList = db.Araclar.Select(x => new
            {
                x.ID,
                x.Plaka,
                x.Marka,
                x.Model,
                x.Yıl,
                x.Vites,
                x.SonKilometre,
                x.MotorCesidi,
                x.Resim,
                x.Cekis,
                x.Kapi,
                x.KasaTipi,
                x.Renk,
                x.Hasar,
                x.Yakit

            }).OrderBy(x => x.Marka).ToList();
            dataGridView1.DataSource = aracList;
            dataGridView1.Columns[0].Visible = false;
        }

        private void FormAracIslem_Load(object sender, EventArgs e)
        {
            Doldur();

            img = pictureBoxSecilenResim.Image;
            ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            a = db.Araclar.Where(x=>x.ID == secilenID).FirstOrDefault();
            textBoxPlaka.Text = a.Plaka;
            textBoxMarka.Text = a.Marka;
            textBoxModel.Text = a.Model;
            textBoxYil.Text = a.Yıl.ToString();
            comboBoxVites.Text = a.Vites;
            comboBoxYakit.Text = a.Yakit;
            numericUpDownSonKM.Value = Convert.ToDecimal(a.SonKilometre);
            comboBoxMotorGucu.Text = a.MotorCesidi;
            if (a.Resim != null)
            {
                pictureBoxSecilenResim.Image = (Image)converter.ConvertFrom(a.Resim);
                img = pictureBoxSecilenResim.Image;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
            comboBoxCekis.Text = a.Cekis;
            comboBoxKapi.Text = a.Kapi.ToString();
            comboBoxKasaTipi.Text = a.KasaTipi;
            comboBoxRenk.Text = a.Renk;
            if (a.Hasar == 1)
            {
                radioButtonVar.Checked = true;
                radioButtonYok.Checked = false;
            }
            else if (a.Hasar == 0)
            {
                radioButtonVar.Checked = false;
                radioButtonYok.Checked = true;
            }
            
        }

        private void buttonresimSec_Click(object sender, EventArgs e)
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

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            db = new RentACarDBEntities();
            a = new Araclar();
            a.Plaka = textBoxPlaka.Text;
            a.Marka = textBoxMarka.Text;
            a.Model = textBoxModel.Text;
            a.Yakit = comboBoxYakit.Text;
            a.Yıl = Convert.ToInt32(textBoxYil.Text);
            a.Vites = comboBoxVites.Text;
            a.SonKilometre = Convert.ToInt32(numericUpDownSonKM.Value);
            a.MotorCesidi = comboBoxMotorGucu.Text;
            a.Resim = ms.ToArray();
            a.Cekis = comboBoxCekis.Text;
            a.Kapi = Convert.ToInt32(comboBoxKapi.Text);
            a.KasaTipi = comboBoxKasaTipi.Text;
            a.Renk = comboBoxRenk.Text;
            if (radioButtonVar.Checked == true)
            {
                a.Hasar = 1;
            }
            else if (radioButtonYok.Checked == true)
            {
                a.Hasar = 0;
            }
            db.Araclar.Add(a);
            db.SaveChanges();
            //  Eklenen bir araç aynı zamanda müsait araçlar tablosuna da eklenmelidir :
            mA = new MusaitAraclar();
            mA.AracPlaka = textBoxPlaka.Text;
            mA.AracID = db.Araclar.Where(x => x.Plaka == textBoxPlaka.Text).Select(x => x.ID).FirstOrDefault();
            mA.Marka = textBoxMarka.Text;
            mA.Model = textBoxModel.Text;
            mA.Yil = Convert.ToInt32(textBoxYil.Text);

            db.MusaitAraclar.Add(mA);
            db.SaveChanges();
            MessageBox.Show("Kayıt Gerçekleşti... ☻");
            Doldur();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            db = new RentACarDBEntities();
            a = db.Araclar.Find(secilenID);

            a.Plaka = textBoxPlaka.Text;
            a.Marka = textBoxMarka.Text;
            a.Model = textBoxModel.Text;
            a.Yıl = Convert.ToInt32(textBoxYil.Text);
            a.Vites = comboBoxVites.Text;
            a.SonKilometre = Convert.ToInt32(numericUpDownSonKM.Value);
            a.MotorCesidi = comboBoxMotorGucu.Text;
            a.Resim = ms.ToArray();
            a.Cekis = comboBoxCekis.Text;
            a.Kapi = Convert.ToInt32(comboBoxKapi.Text);
            a.KasaTipi = comboBoxKasaTipi.Text;
            a.Renk = comboBoxRenk.Text;
            a.Yakit = comboBoxYakit.Text;

            if (radioButtonVar.Checked == true && radioButtonYok.Checked == false)
            {
                a.Hasar = 1;
            }
            else if (radioButtonYok.Checked == true && radioButtonVar.Checked == false)
            {
                a.Hasar = 0;
            }
            db.SaveChanges();
            
            secilenID2 = db.MusaitAraclar.Where(x => x.AracID == secilenID).Select(x => x.ID).FirstOrDefault();
            mA = db.MusaitAraclar.Find(secilenID2);
            mA.AracPlaka = textBoxPlaka.Text;
            mA.AracID = db.Araclar.Where(x => x.Plaka == textBoxPlaka.Text).Select(x => x.ID).FirstOrDefault();
            mA.Marka = textBoxMarka.Text;
            mA.Model = textBoxModel.Text;
            mA.Yil = Convert.ToInt32(textBoxYil.Text);
            
            db.SaveChanges();

            MessageBox.Show("Güncelleme Gerçekleşti... ☻");
            Doldur();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            a = db.Araclar.Find(secilenID);
            db.Araclar.Remove(a);
            db.SaveChanges();
            MessageBox.Show("Silme Gerçekleşti... ☻");
            Doldur();
        }
    }
}
