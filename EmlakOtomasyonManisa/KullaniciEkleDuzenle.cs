using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyonManisa
{
    public partial class KullaniciEkleDuzenle : Form
    {
        KullaniciGoruntule tabloyuGuncelle;
        ContainerForm mdiIcin;
        public int guncellenicekID = -1;
        users guncellenicekKullanici;
        public KullaniciEkleDuzenle(ContainerForm mdiIcin, KullaniciGoruntule tabloyuGuncelle)
        {
            InitializeComponent();
            this.tabloyuGuncelle = tabloyuGuncelle;
            this.mdiIcin = mdiIcin;
        }
        public KullaniciEkleDuzenle(ContainerForm mdiIcin)
        {
            InitializeComponent();
            this.mdiIcin = mdiIcin;
        }

        EntityEmlakOtomasyonManisa ctx = new EntityEmlakOtomasyonManisa();

        public void KullaniciBilgileriniDoldur(int id)
        {
            guncellenicekID = id;
            users kayitliKullanici = new users();
            kayitliKullanici = ctx.users.SingleOrDefault(x => x.id == guncellenicekID);
            guncellenicekKullanici = kayitliKullanici;
            txt_adSoyad.Text = kayitliKullanici.adSoyad;
            txt_ePostaAdresi.Text = kayitliKullanici.ePosta;
            if (ContainerForm.aktifUser.yetki == "Admin")
            {
                label6.Visible = true;
                combo_yetki.Visible = true;
                combo_yetki.Text = kayitliKullanici.yetki;
                btn_sil.Visible = true;
            }
            txtKullaniciAdi.Text = kayitliKullanici.userName;
            lbl_guncellenenID.Text = "Güncellenen ID :   " + kayitliKullanici.id.ToString();
            lbl_guncellenenID.Visible = true;
            txtSifre.Text = kayitliKullanici.password;
            btnEkle.Text = "Değişiklikleri Kaydet";
        }

        private void KullaniciEkleDuzenle_Load(object sender, EventArgs e)
        {
            if (btnEkle.Text == "Kullanıcı Ekle")
            {
                combo_yetki.Visible = true;
                label6.Visible = true;
                combo_yetki.SelectedIndex = 0;
            }
            this.Location = new System.Drawing.Point(770, 5);
        }

        //Kullanıcı ekleme
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!bosTxtKontrol())
            {
                users kullanici = new users();
                if (btnEkle.Text == "Kullanıcı Ekle")
                {
                    if (ctx.users.SingleOrDefault(b => b.userName == txtKullaniciAdi.Text) == null)
                    {
                        kullanici.adSoyad = txt_adSoyad.Text;
                        kullanici.userName = txtKullaniciAdi.Text;
                        kullanici.password = txtSifre.Text;
                        kullanici.ePosta = txt_ePostaAdresi.Text;
                        kullanici.yetki = combo_yetki.Text;
                        ctx.users.Add(kullanici);
                        ctx.SaveChanges();
                        tabloyuGuncelle.ListeYenile();
                        MessageBox.Show("Yeni kullanıcı başarıyla eklendi");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Bu kullanıcı adı kullanılmakta lütfen kullanıcı adını değiştiriniz.");
                }
                else
                {
                    kullanici = ctx.users.Single(x => x.id == guncellenicekID);
                    if (guncellenicekKullanici.userName != txtKullaniciAdi.Text && ctx.users.SingleOrDefault(b => b.userName == txtKullaniciAdi.Text) != null)
                        MessageBox.Show("Bu kullanıcı adı kullanılmakta lütfen kullanıcı adını değiştiriniz.");
                    else
                    {
                        kullanici.adSoyad = txt_adSoyad.Text;
                        kullanici.userName = txtKullaniciAdi.Text;
                        kullanici.password = txtSifre.Text;
                        kullanici.ePosta = txt_ePostaAdresi.Text;
                        if (ContainerForm.aktifUser.yetki == "Admin")
                            kullanici.yetki = combo_yetki.Text;
                        ctx.SaveChanges();
                        if (ContainerForm.aktifUser.id == kullanici.id && combo_yetki.Text == "Kullanıcı")
                        {
                            mdiIcin.adminOzellikleriAcKapa();
                            ContainerForm.aktifUser.yetki = combo_yetki.Text;
                        }
                        if (ContainerForm.aktifUser.id == guncellenicekID)
                        {
                            mdiIcin.lbl_kullaniciAdi.Text = txtKullaniciAdi.Text;
                        }
                        if (tabloyuGuncelle != null)
                            tabloyuGuncelle.ListeYenile();
                        MessageBox.Show("Kullanıcı başarıyla güncellendi");
                        this.Close();
                    }
                }
            }
        }
        ErrorProvider hataMesaji = new ErrorProvider();
        bool bosTxtKontrol()
        {
            hataMesaji.Clear();
            bool eksikBilgiVarMi = false;
            hataMesaji.BlinkRate = 40;
            string hataMesajı = "Bu alan boş bırakılamaz";
            if (txtKullaniciAdi.Text == "")
            {
                hataMesaji.SetError(txtKullaniciAdi, hataMesajı);
                eksikBilgiVarMi = true;
            }
            if (txtSifre.Text == "")
            {
                hataMesaji.SetError(txtSifre, hataMesajı);
                eksikBilgiVarMi = true;
            }
            if (txt_ePostaAdresi.Text == "")
            {
                hataMesaji.SetError(txt_ePostaAdresi, hataMesajı);
                eksikBilgiVarMi = true;
            }
            return eksikBilgiVarMi;
        }
        private void KullaniciEkleDuzenle_LocationChanged(object sender, EventArgs e)
        {
            if (this.Location.X < 156)
                this.Location = new System.Drawing.Point(156, this.Location.Y);
        }

        private void btn_sifreleriGosterGizle_Click(object sender, EventArgs e)
        {
            if (txtSifre.PasswordChar == '\0')
            {
                txtSifre.PasswordChar = '*';
                btn_sifreleriGosterGizle.Image = Properties.Resources._1491005284_icon_22_eye;
            }
            else
            {
                txtSifre.PasswordChar = '\0';
                btn_sifreleriGosterGizle.Image = Properties.Resources._1491005267_icon_21_eye_hidden;
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (kullaniciSil(guncellenicekID))
            {
                tabloyuGuncelle.ListeYenile();
                this.Close();
            }
        }
        public static bool kullaniciSil(int id)
        {
            EntityEmlakOtomasyonManisa ctx2 = new EntityEmlakOtomasyonManisa();
            int adminSayisi = ctx2.users.Count(b => b.yetki == "Admin");
            String aktifUserYetki = ContainerForm.aktifUser.yetki;

           

            DialogResult ds;
            if (id == ContainerForm.aktifUser.id)
                ds = MessageBox.Show("Şuan giriş yapmış olduğunuz kullanıcıyı silerseniz program kapatılacaktır.Devam etmek istediğinize emin misiniz?", "Kullanıcı sil", MessageBoxButtons.YesNo);
            else
                ds = MessageBox.Show("Bu kullanıcıyı kalıcı olarak silmek istediğinizden emin misiniz?", "Kullanıcı sil", MessageBoxButtons.YesNo);

            if (ds == DialogResult.Yes)
            {
                ctx2.users.Remove(ctx2.users.SingleOrDefault(b => b.id == id));
                ctx2.SaveChanges();
                MessageBox.Show("Kullanıcı başarıyla silindi.");
                if (id == ContainerForm.aktifUser.id)
                    Application.Restart();
                return true;
            }
                return false;     
        }
    }
}
