namespace EmlakOtomasyonManisa
{
    partial class evEkleDuzenle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_emlakTipi = new System.Windows.Forms.ComboBox();
            this.combo_odaSayisi1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_odaSayisi2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numaric_Alan = new System.Windows.Forms.NumericUpDown();
            this.numaric_BinaYasi = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numaric_BinaKatSayisi = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numaric_BulunduguKat = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numaric_DaireKatSayisi = new System.Windows.Forms.NumericUpDown();
            this.combo_isitma = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numaric_BanyoSayisi = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.combo_Esyali = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.combo_SitedeMi = new System.Windows.Forms.ComboBox();
            this.numaric_Aidat = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numaric_Fiyat = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_ilanLinki = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_evAdresi = new System.Windows.Forms.TextBox();
            this.txt_daireNotu = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.combo_kisiler = new System.Windows.Forms.ComboBox();
            this.btn_yeniCariEkle = new System.Windows.Forms.Button();
            this.btn_cariyiAta = new System.Windows.Forms.Button();
            this.link_evSahibi = new System.Windows.Forms.LinkLabel();
            this.btn_evSahibiDegistir = new System.Windows.Forms.Button();
            this.lbl_guncellenenID = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.combo_kisiler2 = new System.Windows.Forms.ComboBox();
            this.btn_yeniCariEkle2 = new System.Windows.Forms.Button();
            this.btn_cariyiAta2 = new System.Windows.Forms.Button();
            this.lbl_kirayaVer = new System.Windows.Forms.Label();
            this.link_eviKiralayan = new System.Windows.Forms.LinkLabel();
            this.btn_evKiraciDegistir = new System.Windows.Forms.Button();
            this.btn_eviSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numaric_Alan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaric_BinaYasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaric_BinaKatSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaric_BulunduguKat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaric_DaireKatSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaric_BanyoSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaric_Aidat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaric_Fiyat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oda Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Emlak Türü :";
            // 
            // combo_emlakTipi
            // 
            this.combo_emlakTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_emlakTipi.FormattingEnabled = true;
            this.combo_emlakTipi.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık"});
            this.combo_emlakTipi.Location = new System.Drawing.Point(225, 19);
            this.combo_emlakTipi.Name = "combo_emlakTipi";
            this.combo_emlakTipi.Size = new System.Drawing.Size(77, 23);
            this.combo_emlakTipi.TabIndex = 0;
            this.combo_emlakTipi.SelectedIndexChanged += new System.EventHandler(this.combo_emlakTipi_SelectedIndexChanged);
            // 
            // combo_odaSayisi1
            // 
            this.combo_odaSayisi1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_odaSayisi1.FormattingEnabled = true;
            this.combo_odaSayisi1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.combo_odaSayisi1.Location = new System.Drawing.Point(124, 15);
            this.combo_odaSayisi1.Name = "combo_odaSayisi1";
            this.combo_odaSayisi1.Size = new System.Drawing.Size(31, 23);
            this.combo_odaSayisi1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "+";
            // 
            // combo_odaSayisi2
            // 
            this.combo_odaSayisi2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_odaSayisi2.FormattingEnabled = true;
            this.combo_odaSayisi2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.combo_odaSayisi2.Location = new System.Drawing.Point(170, 15);
            this.combo_odaSayisi2.Name = "combo_odaSayisi2";
            this.combo_odaSayisi2.Size = new System.Drawing.Size(31, 23);
            this.combo_odaSayisi2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Alan :";
            // 
            // numaric_Alan
            // 
            this.numaric_Alan.Location = new System.Drawing.Point(124, 78);
            this.numaric_Alan.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numaric_Alan.Name = "numaric_Alan";
            this.numaric_Alan.Size = new System.Drawing.Size(77, 23);
            this.numaric_Alan.TabIndex = 4;
            // 
            // numaric_BinaYasi
            // 
            this.numaric_BinaYasi.Location = new System.Drawing.Point(124, 16);
            this.numaric_BinaYasi.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numaric_BinaYasi.Name = "numaric_BinaYasi";
            this.numaric_BinaYasi.Size = new System.Drawing.Size(77, 23);
            this.numaric_BinaYasi.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bina Yaşı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bina Kat Sayısı :";
            // 
            // numaric_BinaKatSayisi
            // 
            this.numaric_BinaKatSayisi.Location = new System.Drawing.Point(124, 47);
            this.numaric_BinaKatSayisi.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numaric_BinaKatSayisi.Name = "numaric_BinaKatSayisi";
            this.numaric_BinaKatSayisi.Size = new System.Drawing.Size(77, 23);
            this.numaric_BinaKatSayisi.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bulunduğu Kat :";
            // 
            // numaric_BulunduguKat
            // 
            this.numaric_BulunduguKat.Location = new System.Drawing.Point(124, 78);
            this.numaric_BulunduguKat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numaric_BulunduguKat.Name = "numaric_BulunduguKat";
            this.numaric_BulunduguKat.Size = new System.Drawing.Size(77, 23);
            this.numaric_BulunduguKat.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dairenin Kat Sayısı :";
            // 
            // numaric_DaireKatSayisi
            // 
            this.numaric_DaireKatSayisi.Location = new System.Drawing.Point(124, 107);
            this.numaric_DaireKatSayisi.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numaric_DaireKatSayisi.Name = "numaric_DaireKatSayisi";
            this.numaric_DaireKatSayisi.Size = new System.Drawing.Size(77, 23);
            this.numaric_DaireKatSayisi.TabIndex = 5;
            // 
            // combo_isitma
            // 
            this.combo_isitma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_isitma.FormattingEnabled = true;
            this.combo_isitma.Items.AddRange(new object[] {
            "Girilmedi",
            "Doğalgaz",
            "Soba",
            "Klima"});
            this.combo_isitma.Location = new System.Drawing.Point(360, 232);
            this.combo_isitma.Name = "combo_isitma";
            this.combo_isitma.Size = new System.Drawing.Size(77, 23);
            this.combo_isitma.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Isıtma Türü :";
            // 
            // numaric_BanyoSayisi
            // 
            this.numaric_BanyoSayisi.Location = new System.Drawing.Point(124, 47);
            this.numaric_BanyoSayisi.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numaric_BanyoSayisi.Name = "numaric_BanyoSayisi";
            this.numaric_BanyoSayisi.Size = new System.Drawing.Size(77, 23);
            this.numaric_BanyoSayisi.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Banyo Sayısı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Eşyalı :";
            // 
            // combo_Esyali
            // 
            this.combo_Esyali.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Esyali.FormattingEnabled = true;
            this.combo_Esyali.Items.AddRange(new object[] {
            "Girilmedi",
            "Evet",
            "Hayır"});
            this.combo_Esyali.Location = new System.Drawing.Point(147, 232);
            this.combo_Esyali.Name = "combo_Esyali";
            this.combo_Esyali.Size = new System.Drawing.Size(77, 23);
            this.combo_Esyali.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Site İçerisinde Mi :";
            // 
            // combo_SitedeMi
            // 
            this.combo_SitedeMi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_SitedeMi.FormattingEnabled = true;
            this.combo_SitedeMi.Items.AddRange(new object[] {
            "Girilmedi",
            "Evet",
            "Hayır"});
            this.combo_SitedeMi.Location = new System.Drawing.Point(124, 106);
            this.combo_SitedeMi.Name = "combo_SitedeMi";
            this.combo_SitedeMi.Size = new System.Drawing.Size(77, 23);
            this.combo_SitedeMi.TabIndex = 11;
            // 
            // numaric_Aidat
            // 
            this.numaric_Aidat.Location = new System.Drawing.Point(124, 135);
            this.numaric_Aidat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numaric_Aidat.Name = "numaric_Aidat";
            this.numaric_Aidat.Size = new System.Drawing.Size(77, 23);
            this.numaric_Aidat.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Aidat :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(79, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "Fiyat :";
            // 
            // numaric_Fiyat
            // 
            this.numaric_Fiyat.Location = new System.Drawing.Point(124, 135);
            this.numaric_Fiyat.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numaric_Fiyat.Name = "numaric_Fiyat";
            this.numaric_Fiyat.Size = new System.Drawing.Size(77, 23);
            this.numaric_Fiyat.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 15);
            this.label15.TabIndex = 13;
            this.label15.Text = "İlan Linki :";
            // 
            // txt_ilanLinki
            // 
            this.txt_ilanLinki.Location = new System.Drawing.Point(88, 264);
            this.txt_ilanLinki.Name = "txt_ilanLinki";
            this.txt_ilanLinki.Size = new System.Drawing.Size(355, 23);
            this.txt_ilanLinki.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 295);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 15);
            this.label16.TabIndex = 13;
            this.label16.Text = "Evin Adresi :";
            // 
            // txt_evAdresi
            // 
            this.txt_evAdresi.Location = new System.Drawing.Point(88, 292);
            this.txt_evAdresi.Multiline = true;
            this.txt_evAdresi.Name = "txt_evAdresi";
            this.txt_evAdresi.Size = new System.Drawing.Size(355, 83);
            this.txt_evAdresi.TabIndex = 16;
            // 
            // txt_daireNotu
            // 
            this.txt_daireNotu.Location = new System.Drawing.Point(88, 381);
            this.txt_daireNotu.Multiline = true;
            this.txt_daireNotu.Name = "txt_daireNotu";
            this.txt_daireNotu.Size = new System.Drawing.Size(355, 83);
            this.txt_daireNotu.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 384);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 15);
            this.label17.TabIndex = 16;
            this.label17.Text = "Daire Notu :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numaric_Aidat);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combo_SitedeMi);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numaric_BulunduguKat);
            this.groupBox1.Controls.Add(this.numaric_BinaKatSayisi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numaric_BinaYasi);
            this.groupBox1.Location = new System.Drawing.Point(236, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 164);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apartman Özellikleri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numaric_Fiyat);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.combo_odaSayisi1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.combo_odaSayisi2);
            this.groupBox2.Controls.Add(this.numaric_Alan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numaric_DaireKatSayisi);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.numaric_BanyoSayisi);
            this.groupBox2.Location = new System.Drawing.Point(23, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daire Özellikleri";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(12, 574);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(431, 39);
            this.btn_kaydet.TabIndex = 24;
            this.btn_kaydet.Text = "Yeni Evi Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 489);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 15);
            this.label18.TabIndex = 21;
            this.label18.Text = "Ev Sahibi :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.combo_kisiler);
            this.groupBox3.Controls.Add(this.btn_yeniCariEkle);
            this.groupBox3.Controls.Add(this.btn_cariyiAta);
            this.groupBox3.Location = new System.Drawing.Point(88, 472);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 45);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // combo_kisiler
            // 
            this.combo_kisiler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_kisiler.FormattingEnabled = true;
            this.combo_kisiler.Location = new System.Drawing.Point(6, 14);
            this.combo_kisiler.Name = "combo_kisiler";
            this.combo_kisiler.Size = new System.Drawing.Size(148, 23);
            this.combo_kisiler.TabIndex = 18;
            // 
            // btn_yeniCariEkle
            // 
            this.btn_yeniCariEkle.Location = new System.Drawing.Point(254, 14);
            this.btn_yeniCariEkle.Name = "btn_yeniCariEkle";
            this.btn_yeniCariEkle.Size = new System.Drawing.Size(95, 23);
            this.btn_yeniCariEkle.TabIndex = 20;
            this.btn_yeniCariEkle.Text = "Yeni Cari Ekle";
            this.btn_yeniCariEkle.UseVisualStyleBackColor = true;
            this.btn_yeniCariEkle.Click += new System.EventHandler(this.btn_yeniCariEkle_Click);
            // 
            // btn_cariyiAta
            // 
            this.btn_cariyiAta.Location = new System.Drawing.Point(160, 14);
            this.btn_cariyiAta.Name = "btn_cariyiAta";
            this.btn_cariyiAta.Size = new System.Drawing.Size(75, 23);
            this.btn_cariyiAta.TabIndex = 0;
            this.btn_cariyiAta.Text = "Seç";
            this.btn_cariyiAta.UseVisualStyleBackColor = true;
            this.btn_cariyiAta.Click += new System.EventHandler(this.btn_cariyiAta_Click);
            // 
            // link_evSahibi
            // 
            this.link_evSahibi.AutoSize = true;
            this.link_evSahibi.Location = new System.Drawing.Point(90, 489);
            this.link_evSahibi.Name = "link_evSahibi";
            this.link_evSahibi.Size = new System.Drawing.Size(58, 15);
            this.link_evSahibi.TabIndex = 18;
            this.link_evSahibi.TabStop = true;
            this.link_evSahibi.Text = "linkLabel1";
            this.link_evSahibi.Visible = false;
            this.link_evSahibi.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // btn_evSahibiDegistir
            // 
            this.btn_evSahibiDegistir.Location = new System.Drawing.Point(251, 486);
            this.btn_evSahibiDegistir.Name = "btn_evSahibiDegistir";
            this.btn_evSahibiDegistir.Size = new System.Drawing.Size(75, 23);
            this.btn_evSahibiDegistir.TabIndex = 19;
            this.btn_evSahibiDegistir.Text = "Değiştir";
            this.btn_evSahibiDegistir.UseVisualStyleBackColor = true;
            this.btn_evSahibiDegistir.Visible = false;
            this.btn_evSahibiDegistir.Click += new System.EventHandler(this.btn_evSahibiDegistir_Click);
            // 
            // lbl_guncellenenID
            // 
            this.lbl_guncellenenID.AutoSize = true;
            this.lbl_guncellenenID.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_guncellenenID.Location = new System.Drawing.Point(27, 22);
            this.lbl_guncellenenID.Name = "lbl_guncellenenID";
            this.lbl_guncellenenID.Size = new System.Drawing.Size(81, 15);
            this.lbl_guncellenenID.TabIndex = 25;
            this.lbl_guncellenenID.Text = "guncellenenID";
            this.lbl_guncellenenID.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.combo_kisiler2);
            this.groupBox4.Controls.Add(this.btn_yeniCariEkle2);
            this.groupBox4.Controls.Add(this.btn_cariyiAta2);
            this.groupBox4.Location = new System.Drawing.Point(88, 518);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 45);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // combo_kisiler2
            // 
            this.combo_kisiler2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_kisiler2.FormattingEnabled = true;
            this.combo_kisiler2.Location = new System.Drawing.Point(6, 14);
            this.combo_kisiler2.Name = "combo_kisiler2";
            this.combo_kisiler2.Size = new System.Drawing.Size(148, 23);
            this.combo_kisiler2.TabIndex = 21;
            // 
            // btn_yeniCariEkle2
            // 
            this.btn_yeniCariEkle2.Location = new System.Drawing.Point(254, 14);
            this.btn_yeniCariEkle2.Name = "btn_yeniCariEkle2";
            this.btn_yeniCariEkle2.Size = new System.Drawing.Size(95, 23);
            this.btn_yeniCariEkle2.TabIndex = 23;
            this.btn_yeniCariEkle2.Text = "Yeni Cari Ekle";
            this.btn_yeniCariEkle2.UseVisualStyleBackColor = true;
            this.btn_yeniCariEkle2.Click += new System.EventHandler(this.btn_yeniCariEkle2_Click);
            // 
            // btn_cariyiAta2
            // 
            this.btn_cariyiAta2.Location = new System.Drawing.Point(160, 14);
            this.btn_cariyiAta2.Name = "btn_cariyiAta2";
            this.btn_cariyiAta2.Size = new System.Drawing.Size(75, 23);
            this.btn_cariyiAta2.TabIndex = 0;
            this.btn_cariyiAta2.Text = "Seç";
            this.btn_cariyiAta2.UseVisualStyleBackColor = true;
            this.btn_cariyiAta2.Click += new System.EventHandler(this.btn_cariyiAta2_Click);
            // 
            // lbl_kirayaVer
            // 
            this.lbl_kirayaVer.AutoSize = true;
            this.lbl_kirayaVer.Location = new System.Drawing.Point(37, 535);
            this.lbl_kirayaVer.Name = "lbl_kirayaVer";
            this.lbl_kirayaVer.Size = new System.Drawing.Size(45, 15);
            this.lbl_kirayaVer.TabIndex = 21;
            this.lbl_kirayaVer.Text = "Kiracı :";
            this.lbl_kirayaVer.Visible = false;
            // 
            // link_eviKiralayan
            // 
            this.link_eviKiralayan.AutoSize = true;
            this.link_eviKiralayan.Location = new System.Drawing.Point(90, 535);
            this.link_eviKiralayan.Name = "link_eviKiralayan";
            this.link_eviKiralayan.Size = new System.Drawing.Size(58, 15);
            this.link_eviKiralayan.TabIndex = 21;
            this.link_eviKiralayan.TabStop = true;
            this.link_eviKiralayan.Text = "linkLabel1";
            this.link_eviKiralayan.Visible = false;
            this.link_eviKiralayan.Click += new System.EventHandler(this.link_eviKiralayan_Click);
            // 
            // btn_evKiraciDegistir
            // 
            this.btn_evKiraciDegistir.Location = new System.Drawing.Point(251, 532);
            this.btn_evKiraciDegistir.Name = "btn_evKiraciDegistir";
            this.btn_evKiraciDegistir.Size = new System.Drawing.Size(75, 23);
            this.btn_evKiraciDegistir.TabIndex = 22;
            this.btn_evKiraciDegistir.Text = "Değiştir";
            this.btn_evKiraciDegistir.UseVisualStyleBackColor = true;
            this.btn_evKiraciDegistir.Visible = false;
            this.btn_evKiraciDegistir.Click += new System.EventHandler(this.btn_evKiraciDegistir_Click);
            // 
            // btn_eviSil
            // 
            this.btn_eviSil.BackColor = System.Drawing.Color.Maroon;
            this.btn_eviSil.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_eviSil.Location = new System.Drawing.Point(368, 10);
            this.btn_eviSil.Name = "btn_eviSil";
            this.btn_eviSil.Size = new System.Drawing.Size(75, 39);
            this.btn_eviSil.TabIndex = 26;
            this.btn_eviSil.Text = "Evi Sil";
            this.btn_eviSil.UseVisualStyleBackColor = false;
            this.btn_eviSil.Visible = false;
            this.btn_eviSil.Click += new System.EventHandler(this.btn_eviSil_Click);
            // 
            // evEkleDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(455, 625);
            this.Controls.Add(this.btn_eviSil);
            this.Controls.Add(this.lbl_guncellenenID);
            this.Controls.Add(this.btn_evKiraciDegistir);
            this.Controls.Add(this.btn_evSahibiDegistir);
            this.Controls.Add(this.link_eviKiralayan);
            this.Controls.Add(this.link_evSahibi);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbl_kirayaVer);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_daireNotu);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_evAdresi);
            this.Controls.Add(this.txt_ilanLinki);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.combo_Esyali);
            this.Controls.Add(this.combo_isitma);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combo_emlakTipi);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "evEkleDuzenle";
            this.Text = "Ev Kayıt";
            this.Load += new System.EventHandler(this.evEkleDuzenle_Load);
            this.LocationChanged += new System.EventHandler(this.evEkleDuzenle_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numaric_Alan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaric_BinaYasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaric_BinaKatSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaric_BulunduguKat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaric_DaireKatSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaric_BanyoSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaric_Aidat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaric_Fiyat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox combo_emlakTipi;
        public System.Windows.Forms.ComboBox combo_odaSayisi1;
        public System.Windows.Forms.ComboBox combo_odaSayisi2;
        public System.Windows.Forms.NumericUpDown numaric_Alan;
        public System.Windows.Forms.NumericUpDown numaric_BinaYasi;
        public System.Windows.Forms.NumericUpDown numaric_BinaKatSayisi;
        public System.Windows.Forms.NumericUpDown numaric_BulunduguKat;
        public System.Windows.Forms.NumericUpDown numaric_DaireKatSayisi;
        public System.Windows.Forms.ComboBox combo_isitma;
        public System.Windows.Forms.NumericUpDown numaric_BanyoSayisi;
        public System.Windows.Forms.ComboBox combo_Esyali;
        public System.Windows.Forms.ComboBox combo_SitedeMi;
        public System.Windows.Forms.NumericUpDown numaric_Aidat;
        public System.Windows.Forms.NumericUpDown numaric_Fiyat;
        public System.Windows.Forms.TextBox txt_ilanLinki;
        public System.Windows.Forms.TextBox txt_evAdresi;
        public System.Windows.Forms.TextBox txt_daireNotu;
        public System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_yeniCariEkle;
        private System.Windows.Forms.Button btn_cariyiAta;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.LinkLabel link_evSahibi;
        public System.Windows.Forms.Button btn_evSahibiDegistir;
        public System.Windows.Forms.ComboBox combo_kisiler;
        private System.Windows.Forms.Label lbl_guncellenenID;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.ComboBox combo_kisiler2;
        private System.Windows.Forms.Button btn_yeniCariEkle2;
        private System.Windows.Forms.Button btn_cariyiAta2;
        private System.Windows.Forms.Label lbl_kirayaVer;
        public System.Windows.Forms.LinkLabel link_eviKiralayan;
        public System.Windows.Forms.Button btn_evKiraciDegistir;
        private System.Windows.Forms.Button btn_eviSil;
    }
}