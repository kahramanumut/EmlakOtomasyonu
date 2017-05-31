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
    public partial class ContainerForm : Form
    {
        public ContainerForm()
        {
            InitializeComponent();
        }
        public static users aktifUser;
        private void ContainerForm_Load(object sender, EventArgs e)
        {
            if (login.userID != 0)
            {
                aktifUser = ctx.users.SingleOrDefault(b => b.id == login.userID);
                lbl_kullaniciAdi.Text = aktifUser.userName;
                if (aktifUser.sonGirisTarihi != null)
                    lbl_sonGiris.Text = aktifUser.sonGirisTarihi.ToString();
                btn_bilgilerimiDuzenle.Enabled = true;

            }
            this.ClientSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            groupBox1.Height = Height;
        }

        public void adminOzellikleriAcKapa()
        {
            if (aktifUser.yetki == "Kullanıcı")
            {
                kullanıcılarıAyarlaToolStripMenuItem.Visible = false;
                yetkiliAyarlariToolStripMenuItem.Visible = false;
            }
            else
            {
                kullanıcılarıAyarlaToolStripMenuItem.Visible = true;
                yetkiliAyarlariToolStripMenuItem.Visible = true;
            }
        }

        private void ContainerForm_SizeChanged(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            groupBox1.Height = Height;
        }
        //Container evler butonu
        private void button1_Click(object sender, EventArgs e)
        {
            evlerMenuStrip.Show(Location.X + 80, Location.Y + 130);
        }
        //Container cariler butonu
        private void button2_Click(object sender, EventArgs e)
        {
            carilerMenuStrip.Show(Location.X + 80, Location.Y + 230);
        }

        private void yeniCariEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cariEkleDüzenle yenicari = new cariEkleDüzenle(this);
            yenicari.MdiParent = this;
            yenicari.Show();
        }

        private void ContainerForm_LocationChanged(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.Location = new System.Drawing.Point(-5, -5);
        }
        EntityEmlakOtomasyonManisa ctx = new EntityEmlakOtomasyonManisa();
        private void carileriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carileriGoruntule cg = new carileriGoruntule(this);
            cg.MdiParent = this;
            cg.Show();
        }

        private void yeniEvEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            evEkleDuzenle cg = new evEkleDuzenle(this);
            cg.MdiParent = this;
            cg.Show();
        }

        private void satılıkEvlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvleriGoruntule cg = new EvleriGoruntule(this, "Satılık");
            cg.MdiParent = this;
            cg.Text = "Satılık Evler";
            cg.Show();
        }

        private void kiralıkEvlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvleriGoruntule cg = new EvleriGoruntule(this, "Kiralık");
            cg.MdiParent = this;
            cg.Text = "Kiralık Evler";
            cg.Show();
        }
        //Kullanıcı ayarlarının açıldığı bölüm @hopehero3
        private void kullanıcılarıAyarlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciGoruntule kullanici = new KullaniciGoruntule(this);
            kullanici.MdiParent = this;
            kullanici.Show();
        }

       void rastageleDoldur()
        {
            Random rnd = new Random();
            //Kiralık 2 , Satılık 1.. VT'de bool tipinde tanımlı
            evler yeniEv = new evler();
            yeniEv.emlakTipi = 1;
            yeniEv.alan = rnd.Next(40, 240);
            yeniEv.odaSayisi = rnd.Next(1, 6) + "+" + rnd.Next(1, 3);
            yeniEv.binaYasi = rnd.Next(1, 25);
            yeniEv.binaKatSayisi = rnd.Next(5, 16);
            yeniEv.bulunduguKat = rnd.Next(1, 6);
            yeniEv.daireKacKatli = rnd.Next(1, 4);
            yeniEv.isitma = "Doğalgaz";
            yeniEv.banyoSayisi = rnd.Next(1, 3);
            yeniEv.esyalı = false;
            yeniEv.siteIcerisinde = true;
            yeniEv.aidat = rnd.Next(0, 151);
            yeniEv.fiyat = rnd.Next(400, 999);
            yeniEv.ilanLinki = "";
            yeniEv.adres = "";
            yeniEv.daireNotu = "";
            yeniEv.evSahibiCariID = rnd.Next(1, 21);

            ctx.evler.Add(yeniEv);
            ctx.SaveChanges();
        }
        void evleriSil(int id)
        {
            List<evler> silinicekEvler = ctx.evler.Where(x => x.id > id).ToList();
            for (int i = 0; i < silinicekEvler.Count; i++)
                ctx.evler.Remove(silinicekEvler[i]);
            ctx.SaveChanges();
        }

        private void programAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YetkiliAyarlar Ayarlar = new YetkiliAyarlar(this);
            Ayarlar.MdiParent = this;
            Ayarlar.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
                rastageleDoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            evleriSil(1009);
        }

        private void ContainerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            aktifUser.sonGirisTarihi = DateTime.Now;
            if (aktifUser.girisSayisi != null)
                aktifUser.girisSayisi++;
            else
                aktifUser.girisSayisi = 1;

            try//giriş yapılan kullanıcı silindi ise hata vermesin diye
            {
                ctx.SaveChanges();
            }
            catch (Exception)
            {
            }
        }

        private void btn_bilgilerimiDuzenle_Click(object sender, EventArgs e)
        {
            KullaniciEkleDuzenle ked = new KullaniciEkleDuzenle(this);
            ked.KullaniciBilgileriniDoldur(aktifUser.id);
            ked.MdiParent = this;
            ked.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
