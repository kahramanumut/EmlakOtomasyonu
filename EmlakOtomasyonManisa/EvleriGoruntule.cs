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
    public partial class EvleriGoruntule : Form
    {
        IniOkuYaz iniOY = new IniOkuYaz();
        ContainerForm mdiIcın;
        string emlakTuru;
        public EvleriGoruntule(ContainerForm mdiIcın, string emlakTuru)
        {
            InitializeComponent();
            this.mdiIcın = mdiIcın;
            this.emlakTuru = emlakTuru;
        }
        private void satilikEvleriGoruntule_LocationChanged(object sender, EventArgs e)
        {
            if (this.Location.X < 156)
                this.Location = new Point(156, this.Location.Y);
        }
        
        EntityEmlakOtomasyonManisa ctx = new EntityEmlakOtomasyonManisa();
        List<evler> butunEvler;
        private void satilikEvleriGoruntule_Load(object sender, EventArgs e)
        {
            this.Location = new Point(170, 5);
            butunEvler = listeRefresh(emlakTuru);
            listView1.Location = new Point(1, 50);
            this.Size = new Size(1288, 525);

            combo_odaSayisi1.SelectedIndex = 2;
            combo_odaSayisi2.SelectedIndex = 1;
            combo_Esyali.SelectedIndex = 0;
            combo_isitma.SelectedIndex = 0;
            combo_SitedeMi.SelectedIndex = 0;
            checkBox1.Checked = Convert.ToBoolean(iniOY.Oku("Detayli arama", "CB"));
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                evDuzenlemeFormunuAc();
        }
        void evDuzenlemeFormunuAc()
        {
            evEkleDuzenle evDuzenle = new evEkleDuzenle(mdiIcın, this);
            evDuzenle.MdiParent = mdiIcın;
            evDuzenle.Show();
            evDuzenle.evBilgileriniDoldur(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
        }

        public List<evler> listeRefresh(string emlakTipi)
        {
            this.Text = emlakTipi + " Evler";
            listView1.Items.Clear();
            ctx = new EntityEmlakOtomasyonManisa();
            int emlakBool = 2;
            //Kiralık 2 , Satılık 1.. VT'de bool tipinde tanımlı
            //Olum nasıl kod yazmışın la kiralık evlerle satılık evler Refreshi aynı listede :D  
            if (emlakTipi == "Satılık")
                emlakBool = 1;
            else
                emlakBool = 2;
            List<evler> satilikEvler = ctx.evler.Where(x => x.emlakTipi == emlakBool).ToList();
            for (int i = 0; i < satilikEvler.Count; i++)
            {
                string[] dizi = { satilikEvler[i].id.ToString(), satilikEvler[i].cariler.ad, satilikEvler[i].odaSayisi, satilikEvler[i].alan.ToString(), satilikEvler[i].isitma, satilikEvler[i].fiyat.ToString(), satilikEvler[i].aidat.ToString(), satilikEvler[i].daireNotu, satilikEvler[i].adres };
                ListViewItem eklencekSatir = new ListViewItem(dizi);
                listView1.Items.Add(eklencekSatir);
            }
            return satilikEvler;
        }
        private void btn_detayliAramaAcKapa_Click(object sender, EventArgs e)
        {
            if (btn_detayliAramaAcKapa.Text == "vvv   DETAYLI ARAMAYI AÇ   vvv")
                detayliAramaAc();
            else
                detayliAramaKapa();
        }

        void detayliAramaAc()
        {
            btn_detayliAramaAcKapa.Text = "^^^   DETAYLI ARAMAYI KAPAT   ^^^";
            groupBox1.Visible = true;
            listView1.Location = new System.Drawing.Point(1, 330);
            this.Size = new System.Drawing.Size(1288, 800);
        }
        void detayliAramaKapa()
        {
            btn_detayliAramaAcKapa.Text = "vvv   DETAYLI ARAMAYI AÇ   vvv";
            groupBox1.Visible = false;
            listView1.Location = new System.Drawing.Point(1, 50);
            this.Size = new System.Drawing.Size(1288, 525);
        }

        List<Label> filtreler = new List<Label>();
        void filtreEkle(string etiketAdi)
        {
            Label labelcik = new Label();
            labelcik.BorderStyle = BorderStyle.FixedSingle;
            labelcik.Cursor = Cursors.Hand;
            labelcik.Image = Properties.Resources.delete;
            labelcik.ImageAlign = ContentAlignment.MiddleRight;
            if (filtreler.Count == 0)
            {
                labelcik.Location = new Point(10, 20);
                labelcik.Name = "label-0";
            }
            else
            {
                labelcik.Location = new Point(filtreler[filtreler.Count - 1].Location.X + filtreler[filtreler.Count - 1].Size.Width + 20, filtreler[filtreler.Count - 1].Location.Y);
                labelcik.Name = "label-" + filtreler.Count;
            }
            labelcik.AutoSize = true;

            labelcik.Text = etiketAdi;

            this.Controls.Add(labelcik);
            grup_aramaEtikletleri.Controls.Add(labelcik);
            int uzunluk = labelcik.Size.Width;
            labelcik.AutoSize = false;
            labelcik.Size = new Size(uzunluk + 23, 18);
            if (labelcik.Location.X > 1100)
                labelcik.Location = new Point(10, filtreler[filtreler.Count - 1].Location.Y + 30);
            labelcik.TabIndex = 0;
            labelcik.Click += new System.EventHandler(this.etiketler_Click);
            filtreler.Add(labelcik);
        }

        private void etiketler_Click(object sender, EventArgs e)//silmek için etikete basıldığında
        {
            string[] indexBul = ((Label)sender).Name.Split('-');
            int silincekIndex = Convert.ToInt32(indexBul[1]);

            grup_aramaEtikletleri.Controls.Remove((Label)sender);
            filtreler.RemoveAt(silincekIndex);

            //silmek için basıldığında silinenden sonrakileri kaydırma kısmı
            for (int i = 0; i < filtreler.Count - silincekIndex; i++)
            {
                filtreler[silincekIndex + i].Name = "label-" + (silincekIndex + i);

                if (silincekIndex == 0 && i == 0)
                    filtreler[silincekIndex + i].Location = new Point(10, 20);
                else
                {
                    if (filtreler[silincekIndex - 1 + i].Location.Y != filtreler[silincekIndex + i].Location.Y && filtreler[silincekIndex - 1 + i].Location.X + filtreler[silincekIndex - 1 + i].Size.Width + 20 + filtreler[silincekIndex + i].Size.Width < 1225)//bir önceki yukarda kendisi aşağıda ise
                        filtreler[silincekIndex + i].Location = new Point(filtreler[silincekIndex - 1 + i].Location.X + filtreler[silincekIndex - 1 + i].Size.Width + 20, filtreler[silincekIndex - 1 + i].Location.Y);
                    else
                    {
                        if (filtreler[silincekIndex - 1 + i].Location.Y != filtreler[silincekIndex + i].Location.Y)
                            filtreler[silincekIndex + i].Location = new Point(10, filtreler[silincekIndex - 1 + i].Location.Y + 30);
                        else
                            filtreler[silincekIndex + i].Location = new Point(filtreler[silincekIndex - 1 + i].Location.X + filtreler[silincekIndex - 1 + i].Size.Width + 20, filtreler[silincekIndex - 1 + i].Location.Y);
                    }
                }
            }
            //silmek için basıldığında silinenden sonrakileri kaydırma kısmı
        }

        List<List<evler>> filtrelenmisEvler = new List<List<evler>>();
        private void btn_odaSayisiEkle_Click(object sender, EventArgs e)//eklemek için etikete basıldığında
        {
            List<evler> gecici = new List<evler>();
            Button btn_basilan = (Button)sender;
            if (btn_basilan.Name == "btn_odaSayisiEkle")
            {
                filtrelenmisEvler.Add(butunEvler.Where(b => b.odaSayisi == combo_odaSayisi1.Text + "+" + combo_odaSayisi2.Text).ToList());
                filtreEkle("Oda sayısı: " + combo_odaSayisi1.Text + "+" + combo_odaSayisi2.Text);
            }
            else if (btn_basilan.Name == "btn_banyoSayisiEkle")
            {
                filtrelenmisEvler.Add(butunEvler.Where(b => b.banyoSayisi == (int)numaric_BanyoSayisi.Value).ToList());
                filtreEkle("Banyo sayısı: " + numaric_BanyoSayisi.Value);
            }
            else if (btn_basilan.Name == "btn_alanEkle")
            {
                filtrelenmisEvler.Add(butunEvler.Where(b => b.alan >= Convert.ToInt32(txt_alan1.Text)&& b.alan <= Convert.ToInt32(txt_alan2.Text)).ToList());
                filtreEkle("Alan(m2): " + txt_alan1.Text + "-" + txt_alan2.Text);
            }
            else if (btn_basilan.Name == "btn_daireKatSayisiEkle")
            {
                filtrelenmisEvler.Add(butunEvler.Where(b => b.daireKacKatli >= Convert.ToInt32(txt_katSayisi1.Text) && b.daireKacKatli <= Convert.ToInt32(txt_katSayisi2.Text)).ToList());
                filtreEkle("Daire kat sayısı: " + txt_katSayisi1.Text + "-" + txt_katSayisi2.Text);
            }
            else if (btn_basilan.Name == "btn_fiyatEkle")
            {
                filtrelenmisEvler.Add(butunEvler.Where(b => b.fiyat >= Convert.ToInt32(txt_fiyat1.Text) && b.fiyat <= Convert.ToInt32(txt_fiyat2.Text)).ToList());
                filtreEkle("Fiyat: " + txt_fiyat1.Text + "-" + txt_fiyat2.Text);
            }
            else if (btn_basilan.Name == "btn_binaYasiEkle")
            {
                filtrelenmisEvler.Add(butunEvler.Where(b => b.binaYasi >= Convert.ToInt32(txt_binaYasi1.Text) && b.binaYasi <= Convert.ToInt32(txt_binaYasi2.Text)).ToList());
                filtreEkle("Bina Yaşı: " + txt_binaYasi1.Text + "-" + txt_binaYasi2.Text);
            }
            else if (btn_basilan.Name == "btn_binaKatSayisiEkle")
            {
                filtrelenmisEvler.Add(butunEvler.Where(b => b.binaKatSayisi >= Convert.ToInt32(txt_binaKatSayisi1.Text) && b.binaKatSayisi <= Convert.ToInt32(txt_binaKatSayisi2.Text)).ToList());
                filtreEkle("Bina kat sayısı: " + txt_binaKatSayisi1.Text + "-" + txt_binaKatSayisi2.Text);
            }
            else if (btn_basilan.Name == "btn_bulunduguKatEkle")
            {
                filtrelenmisEvler.Add(butunEvler.Where(b => b.bulunduguKat >= Convert.ToInt32(txt_bulunduguKat1.Text) && b.bulunduguKat <= Convert.ToInt32(txt_bulunduguKat2.Text)).ToList());
                filtreEkle("Bulunduğu kat: " + txt_bulunduguKat1.Text + "-" + txt_bulunduguKat2.Text);
            }
            else if (btn_basilan.Name == "btn_siteIciEkle")
            {
                filtreEkle("Site içinde mi: " + combo_SitedeMi.Text);
            }
            else if (btn_basilan.Name == "btn_aidatEkle")
            {
                filtreEkle("Aidat(TL): " + txt_aidat1.Text + "-" + txt_aidat2.Text);
            }
            else if (btn_basilan.Name == "btn_esyaliEkle")
            {
                filtreEkle("Eşyalı mı: " + combo_Esyali.Text);
            }
            else if (btn_basilan.Name == "btn_isitmaTuruEkle")
            {
                filtreEkle("Isıtma türü: " + combo_isitma.Text);
            }
            else if (btn_basilan.Name == "btn_adresEkle")
            {
                filtreEkle("Adres: " + txt_adres.Text);
            }
        }

        private void txt_hizliArama_KeyUp(object sender, KeyEventArgs e)
        {
            string[] arananKelimeler = txt_hizliArama.Text.Split(',');
            bool butunKelimelerVarMi = true;
            List<evler> gecici = new List<evler>();
            for (int i = 0; i < butunEvler.Count; i++)
            {
                for (int j = 0; j < arananKelimeler.Length; j++)
                    if (!(butunEvler[i].adres.ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                           butunEvler[i].aidat.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                           butunEvler[i].alan.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                           butunEvler[i].banyoSayisi.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                           butunEvler[i].binaKatSayisi.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                           butunEvler[i].binaYasi.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                           butunEvler[i].bulunduguKat.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                           butunEvler[i].cariler.ad.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                           butunEvler[i].daireKacKatli.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                           butunEvler[i].daireNotu.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                           butunEvler[i].esyalı.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                           butunEvler[i].fiyat.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                           butunEvler[i].ilanLinki.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                           butunEvler[i].isitma.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                           butunEvler[i].odaSayisi.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                           butunEvler[i].siteIcerisinde.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1))
                        butunKelimelerVarMi = false;
                if (butunKelimelerVarMi)
                    gecici.Add(butunEvler[i]);
                butunKelimelerVarMi = true;
            }
            listView1.Items.Clear();
            ctx = new EntityEmlakOtomasyonManisa();
            for (int i = 0; i < gecici.Count; i++)
            {
                string[] dizi = { gecici[i].id.ToString(), gecici[i].cariler.ad, gecici[i].odaSayisi, gecici[i].alan.ToString(), gecici[i].isitma, gecici[i].fiyat.ToString(), gecici[i].aidat.ToString(), gecici[i].daireNotu, gecici[i].adres };
                ListViewItem eklencekSatir = new ListViewItem(dizi);
                listView1.Items.Add(eklencekSatir);
            }
        }

        private void btn_sonuclariListele_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            iniOY.Yaz("Detayli arama", "CB", checkBox1.Checked.ToString());
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                    context_sagTikMenu.Show(Cursor.Position);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bu evi kalıcı olarak silmek istediğinizden emin misiniz?", "Ev Sil", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                ctx.evler.Remove(ctx.evler.SingleOrDefault(b => b.id == id));
                ctx.SaveChanges();
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            evDuzenlemeFormunuAc();
        }
    }
}
