namespace Proje_RentACar
{
    partial class FormRaporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRaporlar));
            this.groupBoxRaporlar = new System.Windows.Forms.GroupBox();
            this.dataGridViewRaporlar = new System.Windows.Forms.DataGridView();
            this.groupBoxRaporGiris = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAriza = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPlaka = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.groupBoxIslemler = new System.Windows.Forms.GroupBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.comboBoxTCno = new System.Windows.Forms.ComboBox();
            this.numericUpDownMasraf = new System.Windows.Forms.NumericUpDown();
            this.groupBoxRaporlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaporlar)).BeginInit();
            this.groupBoxRaporGiris.SuspendLayout();
            this.groupBoxIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMasraf)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRaporlar
            // 
            this.groupBoxRaporlar.Controls.Add(this.dataGridViewRaporlar);
            this.groupBoxRaporlar.Location = new System.Drawing.Point(31, 268);
            this.groupBoxRaporlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRaporlar.Name = "groupBoxRaporlar";
            this.groupBoxRaporlar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRaporlar.Size = new System.Drawing.Size(953, 454);
            this.groupBoxRaporlar.TabIndex = 11;
            this.groupBoxRaporlar.TabStop = false;
            this.groupBoxRaporlar.Text = "Tüm Raporlar";
            // 
            // dataGridViewRaporlar
            // 
            this.dataGridViewRaporlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaporlar.Location = new System.Drawing.Point(21, 33);
            this.dataGridViewRaporlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRaporlar.Name = "dataGridViewRaporlar";
            this.dataGridViewRaporlar.RowTemplate.Height = 24;
            this.dataGridViewRaporlar.Size = new System.Drawing.Size(915, 404);
            this.dataGridViewRaporlar.TabIndex = 0;
            this.dataGridViewRaporlar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRaporlar_CellMouseClick);
            // 
            // groupBoxRaporGiris
            // 
            this.groupBoxRaporGiris.Controls.Add(this.numericUpDownMasraf);
            this.groupBoxRaporGiris.Controls.Add(this.comboBoxTCno);
            this.groupBoxRaporGiris.Controls.Add(this.label1);
            this.groupBoxRaporGiris.Controls.Add(this.label2);
            this.groupBoxRaporGiris.Controls.Add(this.label4);
            this.groupBoxRaporGiris.Controls.Add(this.textBoxAriza);
            this.groupBoxRaporGiris.Controls.Add(this.label6);
            this.groupBoxRaporGiris.Controls.Add(this.label3);
            this.groupBoxRaporGiris.Controls.Add(this.comboBoxPlaka);
            this.groupBoxRaporGiris.Controls.Add(this.dateTimePickerTarih);
            this.groupBoxRaporGiris.Location = new System.Drawing.Point(29, 31);
            this.groupBoxRaporGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRaporGiris.Name = "groupBoxRaporGiris";
            this.groupBoxRaporGiris.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRaporGiris.Size = new System.Drawing.Size(639, 231);
            this.groupBoxRaporGiris.TabIndex = 9;
            this.groupBoxRaporGiris.TabStop = false;
            this.groupBoxRaporGiris.Text = "Rapor Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plaka :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masraf :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "TC No :";
            // 
            // textBoxAriza
            // 
            this.textBoxAriza.Location = new System.Drawing.Point(392, 84);
            this.textBoxAriza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAriza.Multiline = true;
            this.textBoxAriza.Name = "textBoxAriza";
            this.textBoxAriza.Size = new System.Drawing.Size(208, 98);
            this.textBoxAriza.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Arıza :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tarih :";
            // 
            // comboBoxPlaka
            // 
            this.comboBoxPlaka.FormattingEnabled = true;
            this.comboBoxPlaka.Location = new System.Drawing.Point(104, 45);
            this.comboBoxPlaka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPlaka.Name = "comboBoxPlaka";
            this.comboBoxPlaka.Size = new System.Drawing.Size(188, 24);
            this.comboBoxPlaka.TabIndex = 2;
            this.comboBoxPlaka.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlaka_SelectedIndexChanged);
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(104, 107);
            this.dateTimePickerTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(188, 22);
            this.dateTimePickerTarih.TabIndex = 3;
            // 
            // groupBoxIslemler
            // 
            this.groupBoxIslemler.Controls.Add(this.buttonSil);
            this.groupBoxIslemler.Controls.Add(this.buttonGuncelle);
            this.groupBoxIslemler.Controls.Add(this.buttonKaydet);
            this.groupBoxIslemler.Location = new System.Drawing.Point(701, 31);
            this.groupBoxIslemler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxIslemler.Name = "groupBoxIslemler";
            this.groupBoxIslemler.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxIslemler.Size = new System.Drawing.Size(283, 232);
            this.groupBoxIslemler.TabIndex = 10;
            this.groupBoxIslemler.TabStop = false;
            this.groupBoxIslemler.Text = "İşlemler";
            // 
            // buttonSil
            // 
            this.buttonSil.Image = global::Proje_RentACar.Properties.Resources.iconfinder_free_27_616650;
            this.buttonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSil.Location = new System.Drawing.Point(179, 43);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(87, 75);
            this.buttonSil.TabIndex = 9;
            this.buttonSil.Text = "SİL";
            this.buttonSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Image = global::Proje_RentACar.Properties.Resources.iconfinder_refresh_reload_update_2_2571204;
            this.buttonGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuncelle.Location = new System.Drawing.Point(24, 133);
            this.buttonGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(241, 65);
            this.buttonGuncelle.TabIndex = 8;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Image = global::Proje_RentACar.Properties.Resources.Custom_Icon_Design_Flatastic_9_Save;
            this.buttonKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKaydet.Location = new System.Drawing.Point(24, 43);
            this.buttonKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(124, 76);
            this.buttonKaydet.TabIndex = 7;
            this.buttonKaydet.Text = " KAYDET";
            this.buttonKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // comboBoxTCno
            // 
            this.comboBoxTCno.FormattingEnabled = true;
            this.comboBoxTCno.Location = new System.Drawing.Point(104, 158);
            this.comboBoxTCno.Name = "comboBoxTCno";
            this.comboBoxTCno.Size = new System.Drawing.Size(188, 24);
            this.comboBoxTCno.TabIndex = 5;
            // 
            // numericUpDownMasraf
            // 
            this.numericUpDownMasraf.Location = new System.Drawing.Point(392, 43);
            this.numericUpDownMasraf.Name = "numericUpDownMasraf";
            this.numericUpDownMasraf.Size = new System.Drawing.Size(208, 22);
            this.numericUpDownMasraf.TabIndex = 6;
            // 
            // FormRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1018, 747);
            this.Controls.Add(this.groupBoxRaporlar);
            this.Controls.Add(this.groupBoxRaporGiris);
            this.Controls.Add(this.groupBoxIslemler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRaporlar";
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.FormRaporlar_Load);
            this.groupBoxRaporlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaporlar)).EndInit();
            this.groupBoxRaporGiris.ResumeLayout(false);
            this.groupBoxRaporGiris.PerformLayout();
            this.groupBoxIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMasraf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRaporlar;
        private System.Windows.Forms.DataGridView dataGridViewRaporlar;
        private System.Windows.Forms.GroupBox groupBoxRaporGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAriza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPlaka;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.GroupBox groupBoxIslemler;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.ComboBox comboBoxTCno;
        private System.Windows.Forms.NumericUpDown numericUpDownMasraf;
    }
}