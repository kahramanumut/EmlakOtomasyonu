using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace EmlakOtomasyonManisa
{
    public partial class KullaniciGoruntule : Form
    {
        ContainerForm MdiIcin;
        public KullaniciGoruntule(ContainerForm deneme)
        {
            InitializeComponent();
            MdiIcin = deneme;
        }

        EntityEmlakOtomasyonManisa ctx = new EntityEmlakOtomasyonManisa();
        List<users> kullanicilar = new List<users>();

        public void ListeYenile()
        {
            kullaniciView.Items.Clear();
            List<users> kullanicilar = ctx.users.ToList();

            for (int i = 0; i < kullanicilar.Count; i++)
            {
                string[] dizi = { kullanicilar[i].id.ToString(), kullanicilar[i].adSoyad, kullanicilar[i].userName, kullanicilar[i].sonGirisTarihi.ToString(), kullanicilar[i].girisSayisi.ToString(), kullanicilar[i].yetki.ToString() };
                ListViewItem eklencekSatir = new ListViewItem(dizi);
                kullaniciView.Items.Add(eklencekSatir);
            }

        }

        private void Kullanici_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(170, 5);
            ListeYenile();
        }

        private void Kullanici_LocationChanged(object sender, EventArgs e)
        {
            if (this.Location.X < 156)
                this.Location = new System.Drawing.Point(156, this.Location.Y);
        }

        private void kullaniciView_DoubleClick(object sender, EventArgs e)
        {
            if (kullaniciView.SelectedItems.Count > 0)
                kullanicilariDuzenleFormunuAc();
        }
        void kullanicilariDuzenleFormunuAc()
        {
            KullaniciEkleDuzenle kullaniciForm = new KullaniciEkleDuzenle(MdiIcin, this);
            kullaniciForm.MdiParent = MdiIcin;
            kullaniciForm.Show();
            kullaniciForm.KullaniciBilgileriniDoldur(Convert.ToInt32(kullaniciView.SelectedItems[0].SubItems[0].Text));
        }

        private void btnYeniKullaniciEkle_Click(object sender, EventArgs e)
        {
            KullaniciEkleDuzenle kullaniciForm = new KullaniciEkleDuzenle(MdiIcin, this);
            kullaniciForm.MdiParent = MdiIcin;
            kullaniciForm.Show();
        }

        private void kullaniciView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (kullaniciView.FocusedItem.Bounds.Contains(e.Location) == true)
                    context_sagTikMenu.Show(Cursor.Position);
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullanicilariDuzenleFormunuAc();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KullaniciEkleDuzenle.kullaniciSil(Convert.ToInt32(kullaniciView.SelectedItems[0].SubItems[0].Text)))
                kullaniciView.Items.RemoveAt(kullaniciView.SelectedItems[0].Index);
        }
    }
}
