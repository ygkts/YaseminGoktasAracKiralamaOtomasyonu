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
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }
        public int yetki = 0;
        private void musteriIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMusteriIslem frm = new FormMusteriIslem();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aracIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAracIslem frm = new FormAracIslem();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aracKiralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAracKirala frm = new FormAracKirala();
            frm.buttonSil.Enabled = false;
            frm.Text = "ARAÇ KİRALAMA VE GÜNCELLEME İŞLEMLERİ";
            frm.groupBoxMusaitAraclar.Enabled = false;
            frm.MdiParent = this;
            frm.Show();
        }

        private void kiradanAracAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAracKirala frm = new FormAracKirala();
            frm.buttonKaydet.Enabled = false;
            frm.buttonGuncelle.Enabled = false;
            frm.groupBoxMusaitAraclar.Enabled = false;
            frm.Text = "ARAÇ SİLME İŞLEMİ";
            frm.MdiParent = this;
            frm.Show();
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRaporlar frm = new FormRaporlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHakkinda frm = new FormHakkinda();
            frm.MdiParent = this;
            frm.Show();
        }

        private void adminAyarlariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminAyarlari frm = new FormAdminAyarlari();
            
            if (yetki >= 5)
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else if (yetki < 5)
            {
                MessageBox.Show("Bu Alandaki İşlemler İçin Yetkiniz Yoktur.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            DialogResult mesaj = MessageBox.Show("Geliştiricinin Facebook Sayfasına Yönlendiriliyorsunuz!", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (mesaj == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/");
            }
        }

        private void pictureBoxGithub_Click(object sender, EventArgs e)
        {
            DialogResult mesaj = MessageBox.Show("Geliştiricinin Github Sayfasına Yönlendiriliyorsunuz!", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (mesaj == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://github.com/ygkts");
            }
        }

        private void pictureBoxLinkedin_Click(object sender, EventArgs e)
        {
            DialogResult mesaj = MessageBox.Show("Geliştiricinin Linkedin Sayfasına Yönlendiriliyorsunuz!", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (mesaj == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://www.linkedin.com/in/yasemin-g%C3%B6kta%C5%9F-07b892127/");
            }
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            DialogResult sor = MessageBox.Show("Sayın "+labelKulAd.Text +" "+ labelKulSoyad.Text+" Çıkmak İstediğinize Emin Misiniz?", "DİKKAT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sor == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
