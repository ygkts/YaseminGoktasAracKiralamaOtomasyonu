namespace Proje_RentACar
{
    partial class FormAracKirala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAracKirala));
            this.groupBoxKiralama = new System.Windows.Forms.GroupBox();
            this.numericUpDownTutar = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerVeris = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAlis = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTcNo = new System.Windows.Forms.ComboBox();
            this.comboBoxPlaka = new System.Windows.Forms.ComboBox();
            this.groupBoxMusaitAraclar = new System.Windows.Forms.GroupBox();
            this.dataGridViewMusaitAraclar = new System.Windows.Forms.DataGridView();
            this.groupBoxKiradakiAraclar = new System.Windows.Forms.GroupBox();
            this.dataGridViewKiradakiAraclar = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.groupBoxKiralama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTutar)).BeginInit();
            this.groupBoxMusaitAraclar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusaitAraclar)).BeginInit();
            this.groupBoxKiradakiAraclar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKiradakiAraclar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKiralama
            // 
            this.groupBoxKiralama.Controls.Add(this.numericUpDownTutar);
            this.groupBoxKiralama.Controls.Add(this.dateTimePickerVeris);
            this.groupBoxKiralama.Controls.Add(this.dateTimePickerAlis);
            this.groupBoxKiralama.Controls.Add(this.label6);
            this.groupBoxKiralama.Controls.Add(this.label5);
            this.groupBoxKiralama.Controls.Add(this.label4);
            this.groupBoxKiralama.Controls.Add(this.label3);
            this.groupBoxKiralama.Controls.Add(this.label2);
            this.groupBoxKiralama.Controls.Add(this.comboBoxTcNo);
            this.groupBoxKiralama.Controls.Add(this.comboBoxPlaka);
            this.groupBoxKiralama.Location = new System.Drawing.Point(367, 32);
            this.groupBoxKiralama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxKiralama.Name = "groupBoxKiralama";
            this.groupBoxKiralama.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxKiralama.Size = new System.Drawing.Size(992, 258);
            this.groupBoxKiralama.TabIndex = 12;
            this.groupBoxKiralama.TabStop = false;
            this.groupBoxKiralama.Text = "Araç Kiralama İşlemleri";
            // 
            // numericUpDownTutar
            // 
            this.numericUpDownTutar.Location = new System.Drawing.Point(172, 179);
            this.numericUpDownTutar.Name = "numericUpDownTutar";
            this.numericUpDownTutar.Size = new System.Drawing.Size(270, 22);
            this.numericUpDownTutar.TabIndex = 3;
            // 
            // dateTimePickerVeris
            // 
            this.dateTimePickerVeris.Location = new System.Drawing.Point(684, 179);
            this.dateTimePickerVeris.Name = "dateTimePickerVeris";
            this.dateTimePickerVeris.Size = new System.Drawing.Size(270, 22);
            this.dateTimePickerVeris.TabIndex = 2;
            // 
            // dateTimePickerAlis
            // 
            this.dateTimePickerAlis.Location = new System.Drawing.Point(684, 124);
            this.dateTimePickerAlis.Name = "dateTimePickerAlis";
            this.dateTimePickerAlis.Size = new System.Drawing.Size(270, 22);
            this.dateTimePickerAlis.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(570, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Veriş Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Alış Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Toplam Tutar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plaka :";
            // 
            // comboBoxTcNo
            // 
            this.comboBoxTcNo.FormattingEnabled = true;
            this.comboBoxTcNo.Location = new System.Drawing.Point(396, 41);
            this.comboBoxTcNo.Name = "comboBoxTcNo";
            this.comboBoxTcNo.Size = new System.Drawing.Size(328, 24);
            this.comboBoxTcNo.TabIndex = 0;
            // 
            // comboBoxPlaka
            // 
            this.comboBoxPlaka.FormattingEnabled = true;
            this.comboBoxPlaka.Location = new System.Drawing.Point(172, 121);
            this.comboBoxPlaka.Name = "comboBoxPlaka";
            this.comboBoxPlaka.Size = new System.Drawing.Size(270, 24);
            this.comboBoxPlaka.TabIndex = 0;
            // 
            // groupBoxMusaitAraclar
            // 
            this.groupBoxMusaitAraclar.Controls.Add(this.dataGridViewMusaitAraclar);
            this.groupBoxMusaitAraclar.Location = new System.Drawing.Point(38, 307);
            this.groupBoxMusaitAraclar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMusaitAraclar.Name = "groupBoxMusaitAraclar";
            this.groupBoxMusaitAraclar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMusaitAraclar.Size = new System.Drawing.Size(663, 322);
            this.groupBoxMusaitAraclar.TabIndex = 13;
            this.groupBoxMusaitAraclar.TabStop = false;
            this.groupBoxMusaitAraclar.Text = "Müsait Olan Araçlar Lİstesi";
            // 
            // dataGridViewMusaitAraclar
            // 
            this.dataGridViewMusaitAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusaitAraclar.Location = new System.Drawing.Point(15, 28);
            this.dataGridViewMusaitAraclar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMusaitAraclar.Name = "dataGridViewMusaitAraclar";
            this.dataGridViewMusaitAraclar.RowTemplate.Height = 24;
            this.dataGridViewMusaitAraclar.Size = new System.Drawing.Size(627, 278);
            this.dataGridViewMusaitAraclar.TabIndex = 0;
            this.dataGridViewMusaitAraclar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMusaitAraclar_CellMouseClick);
            // 
            // groupBoxKiradakiAraclar
            // 
            this.groupBoxKiradakiAraclar.Controls.Add(this.dataGridViewKiradakiAraclar);
            this.groupBoxKiradakiAraclar.Location = new System.Drawing.Point(715, 307);
            this.groupBoxKiradakiAraclar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxKiradakiAraclar.Name = "groupBoxKiradakiAraclar";
            this.groupBoxKiradakiAraclar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxKiradakiAraclar.Size = new System.Drawing.Size(644, 322);
            this.groupBoxKiradakiAraclar.TabIndex = 14;
            this.groupBoxKiradakiAraclar.TabStop = false;
            this.groupBoxKiradakiAraclar.Text = "Kirada Olan Araçlar Listesi";
            // 
            // dataGridViewKiradakiAraclar
            // 
            this.dataGridViewKiradakiAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKiradakiAraclar.Location = new System.Drawing.Point(11, 27);
            this.dataGridViewKiradakiAraclar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewKiradakiAraclar.Name = "dataGridViewKiradakiAraclar";
            this.dataGridViewKiradakiAraclar.RowTemplate.Height = 24;
            this.dataGridViewKiradakiAraclar.Size = new System.Drawing.Size(615, 278);
            this.dataGridViewKiradakiAraclar.TabIndex = 0;
            this.dataGridViewKiradakiAraclar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewKiradakiAraclar_CellMouseClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSil);
            this.groupBox4.Controls.Add(this.buttonGuncelle);
            this.groupBox4.Controls.Add(this.buttonKaydet);
            this.groupBox4.Location = new System.Drawing.Point(36, 32);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(266, 258);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlem Menüsü";
            // 
            // buttonSil
            // 
            this.buttonSil.Image = global::Proje_RentACar.Properties.Resources.iconfinder_free_27_616650;
            this.buttonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSil.Location = new System.Drawing.Point(33, 179);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(156, 63);
            this.buttonSil.TabIndex = 9;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Image = global::Proje_RentACar.Properties.Resources.iconfinder_refresh_reload_update_2_2571204;
            this.buttonGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuncelle.Location = new System.Drawing.Point(33, 101);
            this.buttonGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(156, 63);
            this.buttonGuncelle.TabIndex = 8;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Image = global::Proje_RentACar.Properties.Resources.Custom_Icon_Design_Flatastic_9_Save;
            this.buttonKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKaydet.Location = new System.Drawing.Point(33, 21);
            this.buttonKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(156, 63);
            this.buttonKaydet.TabIndex = 7;
            this.buttonKaydet.Text = "      KİRALA";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // FormAracKirala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1397, 702);
            this.Controls.Add(this.groupBoxKiralama);
            this.Controls.Add(this.groupBoxMusaitAraclar);
            this.Controls.Add(this.groupBoxKiradakiAraclar);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAracKirala";
            this.Text = "Arac Kiralama";
            this.Load += new System.EventHandler(this.FormAracKirala_Load);
            this.groupBoxKiralama.ResumeLayout(false);
            this.groupBoxKiralama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTutar)).EndInit();
            this.groupBoxMusaitAraclar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusaitAraclar)).EndInit();
            this.groupBoxKiradakiAraclar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKiradakiAraclar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewMusaitAraclar;
        private System.Windows.Forms.DataGridView dataGridViewKiradakiAraclar;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Button buttonSil;
        public System.Windows.Forms.Button buttonGuncelle;
        public System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.NumericUpDown numericUpDownTutar;
        private System.Windows.Forms.DateTimePicker dateTimePickerVeris;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTcNo;
        private System.Windows.Forms.ComboBox comboBoxPlaka;
        public System.Windows.Forms.GroupBox groupBoxKiralama;
        public System.Windows.Forms.GroupBox groupBoxMusaitAraclar;
        public System.Windows.Forms.GroupBox groupBoxKiradakiAraclar;
    }
}