namespace EmlakOtomasyonManisa
{
    partial class KullaniciEkleDuzenle
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
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btn_sifreleriGosterGizle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_adSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ePostaAdresi = new System.Windows.Forms.TextBox();
            this.combo_yetki = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_guncellenenID = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(95, 34);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(141, 23);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(95, 63);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(141, 23);
            this.txtSifre.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(368, 107);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(228, 41);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Kullanıcı Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btn_sifreleriGosterGizle
            // 
            this.btn_sifreleriGosterGizle.BackColor = System.Drawing.Color.White;
            this.btn_sifreleriGosterGizle.FlatAppearance.BorderSize = 0;
            this.btn_sifreleriGosterGizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifreleriGosterGizle.Image = global::EmlakOtomasyonManisa.Properties.Resources._1491005284_icon_22_eye;
            this.btn_sifreleriGosterGizle.Location = new System.Drawing.Point(212, 64);
            this.btn_sifreleriGosterGizle.Name = "btn_sifreleriGosterGizle";
            this.btn_sifreleriGosterGizle.Size = new System.Drawing.Size(23, 21);
            this.btn_sifreleriGosterGizle.TabIndex = 7;
            this.btn_sifreleriGosterGizle.UseVisualStyleBackColor = false;
            this.btn_sifreleriGosterGizle.Click += new System.EventHandler(this.btn_sifreleriGosterGizle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ad Soyad :";
            // 
            // txt_adSoyad
            // 
            this.txt_adSoyad.Location = new System.Drawing.Point(119, 23);
            this.txt_adSoyad.Name = "txt_adSoyad";
            this.txt_adSoyad.Size = new System.Drawing.Size(157, 23);
            this.txt_adSoyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "E-Posta Adresi :";
            // 
            // txt_ePostaAdresi
            // 
            this.txt_ePostaAdresi.Location = new System.Drawing.Point(119, 52);
            this.txt_ePostaAdresi.Name = "txt_ePostaAdresi";
            this.txt_ePostaAdresi.Size = new System.Drawing.Size(157, 23);
            this.txt_ePostaAdresi.TabIndex = 2;
            // 
            // combo_yetki
            // 
            this.combo_yetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_yetki.FormattingEnabled = true;
            this.combo_yetki.Items.AddRange(new object[] {
            "Kullanıcı",
            "Admin"});
            this.combo_yetki.Location = new System.Drawing.Point(95, 92);
            this.combo_yetki.Name = "combo_yetki";
            this.combo_yetki.Size = new System.Drawing.Size(141, 23);
            this.combo_yetki.TabIndex = 8;
            this.combo_yetki.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yetki :";
            this.label6.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ePostaAdresi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_adSoyad);
            this.groupBox1.Location = new System.Drawing.Point(293, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 89);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_guncellenenID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.combo_yetki);
            this.groupBox2.Controls.Add(this.txtKullaniciAdi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_sifreleriGosterGizle);
            this.groupBox2.Controls.Add(this.txtSifre);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 136);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesap Bilgileri";
            // 
            // lbl_guncellenenID
            // 
            this.lbl_guncellenenID.AutoSize = true;
            this.lbl_guncellenenID.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_guncellenenID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_guncellenenID.Location = new System.Drawing.Point(10, 17);
            this.lbl_guncellenenID.Name = "lbl_guncellenenID";
            this.lbl_guncellenenID.Size = new System.Drawing.Size(79, 13);
            this.lbl_guncellenenID.TabIndex = 11;
            this.lbl_guncellenenID.Text = "Güncellenen ID :";
            this.lbl_guncellenenID.Visible = false;
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Maroon;
            this.btn_sil.Location = new System.Drawing.Point(293, 107);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(69, 41);
            this.btn_sil.TabIndex = 11;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Visible = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // KullaniciEkleDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(609, 159);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KullaniciEkleDuzenle";
            this.Text = "Kullanıcı Kayıt";
            this.Load += new System.EventHandler(this.KullaniciEkleDuzenle_Load);
            this.LocationChanged += new System.EventHandler(this.KullaniciEkleDuzenle_LocationChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btn_sifreleriGosterGizle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_adSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ePostaAdresi;
        private System.Windows.Forms.ComboBox combo_yetki;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_guncellenenID;
        private System.Windows.Forms.Button btn_sil;
    }
}