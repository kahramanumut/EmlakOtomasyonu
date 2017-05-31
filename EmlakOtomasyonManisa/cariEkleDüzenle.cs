using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyonManisa
{
    //umut
    public partial class cariEkleD�zenle : Form
    {
        carileriGoruntule tabloyuGuncelle;
        ContainerForm mdiIcin;
        evEkleDuzenle evSahibiYap;
        public int guncellenicekID = -1;
        string islemTuru;
        public cariEkleD�zenle(ContainerForm mdiIcin, evEkleDuzenle evSahibiYap, string islemTuru)
        {
            InitializeComponent();
            this.evSahibiYap = evSahibiYap;
            this.mdiIcin = mdiIcin;
            this.islemTuru = islemTuru;
        }
        public cariEkleD�zenle(ContainerForm mdiIcin)
        {
            InitializeComponent();
            this.mdiIcin = mdiIcin;
        }
        public cariEkleD�zenle(ContainerForm mdiIcin, carileriGoruntule tabloyuGuncelle)
        {
            InitializeComponent();
            this.tabloyuGuncelle = tabloyuGuncelle;
            this.mdiIcin = mdiIcin;
        }

        EntityEmlakOtomasyonManisa ctx = new EntityEmlakOtomasyonManisa();
        private void cariEkleD�zenle_Load(object sender, EventArgs e)
        {
            this.Location = new Point(170, 5);
            combo_cinsiyet.SelectedIndex = 0;
        }

        /// ////////////////////////////////////////////////////////////////////////////////////
        public void cariBilgileriniDoldur(int id)
        {
            guncellenicekID = id;

            lbl_guncellenenID.Visible = true;
            lbl_guncellenenID.Text = "Cari ID : " + guncellenicekID;

            cariler kay�tl�Cari = new cariler();
            kay�tl�Cari = ctx.cariler.SingleOrDefault(x => x.id == guncellenicekID);
            txt_Ad.Text = kay�tl�Cari.ad;
            //Bay=0 , bayan=1 , gay && lezbiyen yok aksjdnasjkd
            if (kay�tl�Cari.cinsiyet == false)
                combo_cinsiyet.Text = "Bay";
            else
                combo_cinsiyet.Text = "Bayan";
            numarik_yas.Value = (int)kay�tl�Cari.yas;
            /*
                        if (kay�tl�Cari.resim1 != null)
                        {
                            MemoryStream ms = new MemoryStream(kay�tl�Cari.resim1);
                            resim = (Bitmap)Image.FromStream(ms);
                            pictureBox1.Image = (Bitmap)resim.Clone(); ;
                        }*/

            txt_tel1.Text = kay�tl�Cari.tel1;
            txt_tel2.Text = kay�tl�Cari.tel2;
            txt_adres.Text = kay�tl�Cari.adres;
            txt_not.Text = kay�tl�Cari.cariNotu;
            btn_kayit.Text = "Cariyi G�ncelle";
            btn_sil.Visible = true;

            SattigiEvler();
            KiraladigiEvLER();
            KiralananEvler();
        }
        /// ////////////////////////////////////////////////////////////////////////////////////

        //Kiral�k 0 , Sat�l�k 1.. VT'de bool tipinde tan�ml�
        void SattigiEvler()
        {
            List<evler> sattigiEvler = ctx.evler.Where(x => x.emlakTipi == 1 && x.evSahibiCariID == guncellenicekID).ToList();
            List<LinkLabel> linkler = new List<LinkLabel>();
            for (int i = 0; i < sattigiEvler.Count; i++)
                if (i == 0)
                {
                    link_satilikEv.Text = sattigiEvler[i].id.ToString();
                    linkler.Add(link_satilikEv);
                    link_satilikEv.Visible = true;
                }
                else
                {
                    LinkLabel yeniSatilicakEvLink = new LinkLabel();
                    yeniSatilicakEvLink.Text = sattigiEvler[i].id.ToString();
                    yeniSatilicakEvLink.AutoSize = true;
                    yeniSatilicakEvLink.Click += new System.EventHandler(this.link_satilikEv_Click);
                    this.Controls.Add(yeniSatilicakEvLink);
                    linkler.Add(yeniSatilicakEvLink);

                    Label virg�l = new Label();
                    virg�l.AutoSize = true;
                    this.Controls.Add(virg�l);
                    virg�l.Text = ",";
                    virg�l.Location = new System.Drawing.Point(linkler[linkler.Count - 2].Location.X + linkler[linkler.Count - 2].Size.Width, 428);

                    yeniSatilicakEvLink.Location = new System.Drawing.Point(linkler[linkler.Count - 2].Location.X + linkler[linkler.Count - 2].Size.Width + 10, 428);
                }
        }
        //Kiral�k 2 , Sat�l�k 1.. VT'de tan�ml�
        void KiraladigiEvLER()
        {
            List<evler> sattigiEvler = ctx.evler.Where(x => x.emlakTipi == 2 && x.evSahibiCariID == guncellenicekID).ToList();
            List<LinkLabel> linkler = new List<LinkLabel>();
            for (int i = 0; i < sattigiEvler.Count; i++)
                if (i == 0)
                {
                    link_kiralikEv.Text = sattigiEvler[i].id.ToString();
                    linkler.Add(link_kiralikEv);
                    link_kiralikEv.Visible = true;
                }
                else
                {
                    LinkLabel yeniSatilicakEvLink = new LinkLabel();
                    yeniSatilicakEvLink.Text = sattigiEvler[i].id.ToString();
                    yeniSatilicakEvLink.AutoSize = true;
                    yeniSatilicakEvLink.Click += new System.EventHandler(this.link_satilikEv_Click);
                    this.Controls.Add(yeniSatilicakEvLink);
                    linkler.Add(yeniSatilicakEvLink);

                    Label virg�l = new Label();
                    virg�l.AutoSize = true;
                    this.Controls.Add(virg�l);
                    virg�l.Text = ",";
                    virg�l.Location = new System.Drawing.Point(linkler[linkler.Count - 2].Location.X + linkler[linkler.Count - 2].Size.Width, 462);

                    yeniSatilicakEvLink.Location = new System.Drawing.Point(linkler[linkler.Count - 2].Location.X + linkler[linkler.Count - 2].Size.Width + 10, 462);
                }
        }
        void KiralananEvler()
        {
            List<evler> sattigiEvler = ctx.evler.Where(x => x.emlakTipi == 2 && x.eviKiralayanCariID == guncellenicekID).ToList();
            List<LinkLabel> linkler = new List<LinkLabel>();
            for (int i = 0; i < sattigiEvler.Count; i++)
                if (i == 0)
                {
                    link_kiralananEv.Text = sattigiEvler[i].id.ToString();
                    linkler.Add(link_kiralananEv);
                    link_kiralananEv.Visible = true;
                }
                else
                {
                    LinkLabel yeniSatilicakEvLink = new LinkLabel();
                    yeniSatilicakEvLink.Text = sattigiEvler[i].id.ToString();
                    yeniSatilicakEvLink.AutoSize = true;
                    yeniSatilicakEvLink.Click += new System.EventHandler(this.link_satilikEv_Click);
                    this.Controls.Add(yeniSatilicakEvLink);
                    linkler.Add(yeniSatilicakEvLink);

                    Label virg�l = new Label();
                    virg�l.AutoSize = true;
                    this.Controls.Add(virg�l);
                    virg�l.Text = ",";
                    virg�l.Location = new System.Drawing.Point(linkler[linkler.Count - 2].Location.X + linkler[linkler.Count - 2].Size.Width, 496);

                    yeniSatilicakEvLink.Location = new System.Drawing.Point(linkler[linkler.Count - 2].Location.X + linkler[linkler.Count - 2].Size.Width + 10, 496);
                }
        }

        private void cariEkleD�zenle_LocationChanged(object sender, EventArgs e)
        {
            if (this.Location.X < 156)
                this.Location = new System.Drawing.Point(156, this.Location.Y);
        }

        private void link_satilikEv_Click(object sender, EventArgs e)
        {
            evEkleDuzenle evDuzenle = new evEkleDuzenle(mdiIcin);
            evDuzenle.MdiParent = mdiIcin;
            evDuzenle.Show();
            evDuzenle.evBilgileriniDoldur(Convert.ToInt32(((LinkLabel)sender).Text));
        }

        private void button1_Click(object sender, EventArgs e)//cari ekle
        {
            if (!bosTxtKontrol())
            {
                cariler yeniCari = new cariler();
                if (btn_kayit.Text == "Cari Ekle")
                {
                    yeniCari.ad = txt_Ad.Text;
                    yeniCari.adres = txt_adres.Text;
                    yeniCari.cariNotu = txt_not.Text;
                    //Bay=0 , bayan=1 
                    if (combo_cinsiyet.Text=="Bay")
                        yeniCari.cinsiyet = false;
                    else
                        yeniCari.cinsiyet = true;
                    yeniCari.tel1 = txt_tel1.Text;
                    yeniCari.tel2 = txt_tel2.Text;
                    yeniCari.yas = (int)numarik_yas.Value;
                    if (pictureBox1.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                        //yeniCari.resim1 = ms.ToArray();
                    }
                    else
                        //yeniCari.resim1 = null;

                    ctx.cariler.Add(yeniCari);
                    ctx.SaveChanges();
                    if (evSahibiYap != null)
                    {
                        if (islemTuru == "Kirac�")
                        {
                            evSahibiYap.link_eviKiralayan.Visible = true;
                            List<cariler> cariler2 = ctx.cariler.ToList();
                            evSahibiYap.link_eviKiralayan.Text = cariler2[cariler2.Count - 1].id + "-" + cariler2[cariler2.Count - 1].ad;
                            evSahibiYap.btn_evKiraciDegistir.Visible = true;

                            evSahibiYap.combo_kisiler.Items.Add(cariler2[cariler2.Count - 1].id + "-" + cariler2[cariler2.Count - 1].ad);
                            evSahibiYap.combo_kisiler2.Items.Add(cariler2[cariler2.Count - 1].id + "-" + cariler2[cariler2.Count - 1].ad);
                            evSahibiYap.groupBox4.Visible = false;
                        }
                        else if (islemTuru == "evSahibi")
                        {
                            evSahibiYap.link_evSahibi.Visible = true;
                            List<cariler> cariler2 = ctx.cariler.ToList();
                            evSahibiYap.link_evSahibi.Text = cariler2[cariler2.Count - 1].id + "-" + cariler2[cariler2.Count - 1].ad;
                            evSahibiYap.btn_evSahibiDegistir.Visible = true;

                            evSahibiYap.combo_kisiler.Items.Add(cariler2[cariler2.Count - 1].id + "-" + cariler2[cariler2.Count - 1].ad);
                            evSahibiYap.combo_kisiler2.Items.Add(cariler2[cariler2.Count - 1].id + "-" + cariler2[cariler2.Count - 1].ad);
                            evSahibiYap.groupBox3.Visible = false;
                        }
                    }
                    MessageBox.Show("Cari Kaydedildi.");
                }
                else
                {
                    yeniCari = ctx.cariler.SingleOrDefault(x => x.id == guncellenicekID);
                    if (pictureBox1.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                        //yeniCari.resim1 = ms.ToArray();
                    }
                    else
                       // yeniCari.resim1 = null;

                    yeniCari.ad = txt_Ad.Text;
                    yeniCari.adres = txt_adres.Text;
                    yeniCari.cariNotu = txt_not.Text;
                    //Bay=0 , bayan=1 
                    if (combo_cinsiyet.Text == "Bay")
                        yeniCari.cinsiyet = false;
                    else
                        yeniCari.cinsiyet = true;
                    yeniCari.tel1 = txt_tel1.Text;
                    yeniCari.tel2 = txt_tel2.Text;
                    yeniCari.yas = (int)numarik_yas.Value;
                    ctx.SaveChanges();
                    MessageBox.Show("Cari Ba�ar�yla G�ncellendi.");

                    if (tabloyuGuncelle != null)
                        tabloyuGuncelle.listeRefresh();
                }
                this.Close();
            }
        }
        ErrorProvider hataMesaji = new ErrorProvider();
        bool bosTxtKontrol()
        {
            hataMesaji.Clear();
            bool eksikBilgiVarMi = false;
            hataMesaji.BlinkRate = 40;
            string hataMesaj� = "Bu alan bo� b�rak�lamaz";
            if (txt_Ad.Text == "")
            {
                hataMesaji.SetError(txt_Ad, hataMesaj�);
                eksikBilgiVarMi = true;
            }
            if (txt_tel1.Text == "")
            {
                hataMesaji.SetError(txt_tel1, hataMesaj�);
                eksikBilgiVarMi = true;
            }
            return eksikBilgiVarMi;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bu cariyi kal�c� olarak silmek istedi�inizden emin misiniz?", "Cari Sil", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string[] gecici = lbl_guncellenenID.Text.Split(' ');
                int id = Convert.ToInt32(gecici[3]);
                ctx.cariler.Remove(ctx.cariler.SingleOrDefault(b => b.id == id));
                ctx.SaveChanges();
                tabloyuGuncelle.listeRefresh();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = openFileDialog1.FileName;
                string DosyaAdi = openFileDialog1.SafeFileName;
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    resim = pictureBox1.Image;
                    Image img = Image.FromFile(DosyaYolu);
                    double fileWidth = img.Width;
                    double fileheigth = img.Height;
                    double fileByte = (((fileWidth) * (fileheigth)) / 1024);
                    MessageBox.Show("Image Size: " + fileByte.ToString() + " KB");
                }
                catch (Exception)
                {
                    MessageBox.Show("Se�ilen resim ge�erli de�il.");
                }

            }
        }
        Image resim = null;
        private void button1_Click_1(object sender, EventArgs e)//d�nd�rme tu�u
        {
            if (pictureBox1.Image != null)
                resim = resmiDondur(resim);
            pictureBox1.Image = resim;
        }
        Bitmap resmiDondur(Image img)
        {
            Bitmap doncekResim = (Bitmap)img;
            Bitmap donmusResim = new Bitmap(doncekResim.Height, doncekResim.Width);
            for (int i = 0; i < donmusResim.Height; i++)
                for (int j = 0; j < donmusResim.Width; j++)
                {
                    Color okunanRenk = doncekResim.GetPixel(i, doncekResim.Height - j - 1);
                    donmusResim.SetPixel(j, i, okunanRenk);
                }
            return donmusResim;
        }

        private void pictureBox1_Click(object sender, EventArgs e)//resme bas�ld���nda
        {
            if (pictureBox1.Image != null)
            {
                string[] gecici = lbl_guncellenenID.Text.Split(' ');
                int id;
                try
                {
                    id = Convert.ToInt32(gecici[3]);
                }
                catch (Exception)
                {
                    id = 0;
                }
                resmiGoster rg = new resmiGoster(pictureBox1.Image, id);
                rg.MdiParent = mdiIcin;
                rg.Show();
            }
        }
    }
}
