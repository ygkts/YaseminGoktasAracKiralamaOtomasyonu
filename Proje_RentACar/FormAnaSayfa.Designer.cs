namespace Proje_RentACar
{
    partial class FormAnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaSayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.musteriIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aracIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiraIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aracKiralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiradanAracAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminAyarlariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxFacebook = new System.Windows.Forms.PictureBox();
            this.pictureBoxGithub = new System.Windows.Forms.PictureBox();
            this.pictureBoxLinkedin = new System.Windows.Forms.PictureBox();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.labelKulSoyad = new System.Windows.Forms.Label();
            this.labelKulAd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLinkedin)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriIslemleriToolStripMenuItem,
            this.aracIslemleriToolStripMenuItem,
            this.kiraIslemleriToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.hakkindaToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1850, 81);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // musteriIslemleriToolStripMenuItem
            // 
            this.musteriIslemleriToolStripMenuItem.Image = global::Proje_RentACar.Properties.Resources.support;
            this.musteriIslemleriToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musteriIslemleriToolStripMenuItem.Name = "musteriIslemleriToolStripMenuItem";
            this.musteriIslemleriToolStripMenuItem.Size = new System.Drawing.Size(227, 77);
            this.musteriIslemleriToolStripMenuItem.Text = "Musteri Islemleri";
            this.musteriIslemleriToolStripMenuItem.Click += new System.EventHandler(this.musteriIslemleriToolStripMenuItem_Click);
            // 
            // aracIslemleriToolStripMenuItem
            // 
            this.aracIslemleriToolStripMenuItem.Image = global::Proje_RentACar.Properties.Resources.rent_a_car;
            this.aracIslemleriToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aracIslemleriToolStripMenuItem.Name = "aracIslemleriToolStripMenuItem";
            this.aracIslemleriToolStripMenuItem.Size = new System.Drawing.Size(200, 77);
            this.aracIslemleriToolStripMenuItem.Text = "Arac Islemleri";
            this.aracIslemleriToolStripMenuItem.Click += new System.EventHandler(this.aracIslemleriToolStripMenuItem_Click);
            // 
            // kiraIslemleriToolStripMenuItem
            // 
            this.kiraIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aracKiralaToolStripMenuItem,
            this.kiradanAracAlToolStripMenuItem});
            this.kiraIslemleriToolStripMenuItem.Image = global::Proje_RentACar.Properties.Resources.comprar_alugar_um_carro_esportivo_novo_ou_usado_rapido_3446_651;
            this.kiraIslemleriToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kiraIslemleriToolStripMenuItem.Name = "kiraIslemleriToolStripMenuItem";
            this.kiraIslemleriToolStripMenuItem.Size = new System.Drawing.Size(195, 77);
            this.kiraIslemleriToolStripMenuItem.Text = "Kira Islemleri";
            // 
            // aracKiralaToolStripMenuItem
            // 
            this.aracKiralaToolStripMenuItem.Image = global::Proje_RentACar.Properties.Resources.car;
            this.aracKiralaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aracKiralaToolStripMenuItem.Name = "aracKiralaToolStripMenuItem";
            this.aracKiralaToolStripMenuItem.Size = new System.Drawing.Size(264, 66);
            this.aracKiralaToolStripMenuItem.Text = "Arac Kirala";
            this.aracKiralaToolStripMenuItem.Click += new System.EventHandler(this.aracKiralaToolStripMenuItem_Click);
            // 
            // kiradanAracAlToolStripMenuItem
            // 
            this.kiradanAracAlToolStripMenuItem.Image = global::Proje_RentACar.Properties.Resources.key;
            this.kiradanAracAlToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kiradanAracAlToolStripMenuItem.Name = "kiradanAracAlToolStripMenuItem";
            this.kiradanAracAlToolStripMenuItem.Size = new System.Drawing.Size(264, 66);
            this.kiradanAracAlToolStripMenuItem.Text = "Kiradan Arac Al";
            this.kiradanAracAlToolStripMenuItem.Click += new System.EventHandler(this.kiradanAracAlToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Image = global::Proje_RentACar.Properties.Resources.accounting;
            this.raporlarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(159, 77);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            this.raporlarToolStripMenuItem.Click += new System.EventHandler(this.raporlarToolStripMenuItem_Click);
            // 
            // hakkindaToolStripMenuItem
            // 
            this.hakkindaToolStripMenuItem.Image = global::Proje_RentACar.Properties.Resources.info;
            this.hakkindaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hakkindaToolStripMenuItem.Name = "hakkindaToolStripMenuItem";
            this.hakkindaToolStripMenuItem.Size = new System.Drawing.Size(166, 77);
            this.hakkindaToolStripMenuItem.Text = "Hakkinda";
            this.hakkindaToolStripMenuItem.Click += new System.EventHandler(this.hakkindaToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminAyarlariToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Image = global::Proje_RentACar.Properties.Resources.Settings_icon;
            this.ayarlarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(146, 77);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // adminAyarlariToolStripMenuItem
            // 
            this.adminAyarlariToolStripMenuItem.Image = global::Proje_RentACar.Properties.Resources._15843349_settings_icon_glossy_orange_button;
            this.adminAyarlariToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminAyarlariToolStripMenuItem.Name = "adminAyarlariToolStripMenuItem";
            this.adminAyarlariToolStripMenuItem.Size = new System.Drawing.Size(260, 66);
            this.adminAyarlariToolStripMenuItem.Text = "Admin Ayarlari";
            this.adminAyarlariToolStripMenuItem.Click += new System.EventHandler(this.adminAyarlariToolStripMenuItem_Click);
            // 
            // pictureBoxFacebook
            // 
            this.pictureBoxFacebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFacebook.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFacebook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFacebook.BackgroundImage")));
            this.pictureBoxFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFacebook.Image = global::Proje_RentACar.Properties.Resources.iconfinder_facebook_287801;
            this.pictureBoxFacebook.Location = new System.Drawing.Point(1073, 1385);
            this.pictureBoxFacebook.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFacebook.Name = "pictureBoxFacebook";
            this.pictureBoxFacebook.Size = new System.Drawing.Size(88, 66);
            this.pictureBoxFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFacebook.TabIndex = 1;
            this.pictureBoxFacebook.TabStop = false;
            this.pictureBoxFacebook.Click += new System.EventHandler(this.pictureBoxFacebook_Click);
            // 
            // pictureBoxGithub
            // 
            this.pictureBoxGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGithub.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGithub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGithub.BackgroundImage")));
            this.pictureBoxGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGithub.Image = global::Proje_RentACar.Properties.Resources.iconfinder_github_2308116;
            this.pictureBoxGithub.Location = new System.Drawing.Point(1242, 1385);
            this.pictureBoxGithub.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxGithub.Name = "pictureBoxGithub";
            this.pictureBoxGithub.Size = new System.Drawing.Size(88, 66);
            this.pictureBoxGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGithub.TabIndex = 1;
            this.pictureBoxGithub.TabStop = false;
            this.pictureBoxGithub.Click += new System.EventHandler(this.pictureBoxGithub_Click);
            // 
            // pictureBoxLinkedin
            // 
            this.pictureBoxLinkedin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLinkedin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLinkedin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLinkedin.BackgroundImage")));
            this.pictureBoxLinkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLinkedin.Image = global::Proje_RentACar.Properties.Resources.iconfinder_social_media_applications_14_linkedin_4102586;
            this.pictureBoxLinkedin.Location = new System.Drawing.Point(1406, 1385);
            this.pictureBoxLinkedin.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLinkedin.Name = "pictureBoxLinkedin";
            this.pictureBoxLinkedin.Size = new System.Drawing.Size(88, 66);
            this.pictureBoxLinkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLinkedin.TabIndex = 1;
            this.pictureBoxLinkedin.TabStop = false;
            this.pictureBoxLinkedin.Click += new System.EventHandler(this.pictureBoxLinkedin_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisYap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCikisYap.Location = new System.Drawing.Point(1631, 25);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(96, 42);
            this.btnCikisYap.TabIndex = 9;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = false;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // labelKulSoyad
            // 
            this.labelKulSoyad.AutoSize = true;
            this.labelKulSoyad.BackColor = System.Drawing.Color.White;
            this.labelKulSoyad.Location = new System.Drawing.Point(1501, 50);
            this.labelKulSoyad.Name = "labelKulSoyad";
            this.labelKulSoyad.Size = new System.Drawing.Size(20, 17);
            this.labelKulSoyad.TabIndex = 5;
            this.labelKulSoyad.Text = "...";
            // 
            // labelKulAd
            // 
            this.labelKulAd.AutoSize = true;
            this.labelKulAd.BackColor = System.Drawing.Color.White;
            this.labelKulAd.Location = new System.Drawing.Point(1501, 25);
            this.labelKulAd.Name = "labelKulAd";
            this.labelKulAd.Size = new System.Drawing.Size(20, 17);
            this.labelKulAd.TabIndex = 6;
            this.labelKulAd.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1368, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kullanıcı Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1391, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(1459, 8);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(16, 17);
            this.labelID.TabIndex = 11;
            this.labelID.Text = "..";
            this.labelID.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Rent A Car";
            this.notifyIcon1.Visible = true;
            // 
            // FormAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proje_RentACar.Properties.Resources.header_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1850, 1055);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.labelKulSoyad);
            this.Controls.Add(this.labelKulAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxLinkedin);
            this.Controls.Add(this.pictureBoxGithub);
            this.Controls.Add(this.pictureBoxFacebook);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAnaSayfa";
            this.Text = "ARAÇ KİRALAMA OTOMASYONU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLinkedin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem musteriIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aracIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiraIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aracKiralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiradanAracAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkindaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminAyarlariToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxFacebook;
        private System.Windows.Forms.PictureBox pictureBoxGithub;
        private System.Windows.Forms.PictureBox pictureBoxLinkedin;
        private System.Windows.Forms.Button btnCikisYap;
        public System.Windows.Forms.Label labelKulSoyad;
        public System.Windows.Forms.Label labelKulAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelID;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

