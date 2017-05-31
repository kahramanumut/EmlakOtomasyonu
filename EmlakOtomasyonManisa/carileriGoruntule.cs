using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace EmlakOtomasyonManisa
{
    public partial class carileriGoruntule : Form
    {
        ContainerForm mdiIcın;
        public carileriGoruntule(ContainerForm deneme)
        {
            InitializeComponent();
            mdiIcın = deneme;
        }
        EntityEmlakOtomasyonManisa ctx = new EntityEmlakOtomasyonManisa();
        List<cariler> butunCariler = new List<cariler>();

        
        private void carileriGoruntule_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(170, 5);
            listeRefresh();
        }

        private void carileriGoruntule_LocationChanged(object sender, EventArgs e)
        {
            if (this.Location.X < 156)
                this.Location = new System.Drawing.Point(156, this.Location.Y);
        }

 
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                duzenlemeFormunuAc();
        }
        void duzenlemeFormunuAc()
        {
            cariEkleDüzenle cariform = new cariEkleDüzenle(mdiIcın, this);
            cariform.MdiParent = mdiIcın;
            cariform.Show();
           // cariform.cariBilgileriniDoldur(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
            cariform.cariBilgileriniDoldur(Convert.ToInt32(gridView1.GetFocusedRowCellValue("id").ToString().Trim()));
        }
        public void listeRefresh()
        {
            gridView1.Columns.Clear();
            ctx.cariler.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                carilerBindingSource.DataSource = ctx.cariler.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

           /*listView1.Items.Clear();
            ctx = new EntityEmlakOtomasyonManisa();
            butunCariler = ctx.cariler.ToList();
            for (int i = 0; i < butunCariler.Count; i++)
            {
                string[] dizi = { butunCariler[i].id.ToString(), butunCariler[i].ad, butunCariler[i].yas.ToString(), butunCariler[i].tel1, butunCariler[i].tel2, butunCariler[i].cariNotu };
                ListViewItem eklencekSatir = new ListViewItem(dizi);
                listView1.Items.Add(eklencekSatir);
            }*/
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string[] arananKelimeler = txt_hizliArama.Text.Split(',');
            bool butunKelimelerVarMi = true;
            List<cariler> gecici = new List<cariler>();
            for (int i = 0; i < butunCariler.Count; i++)
            {
                for (int j = 0; j < arananKelimeler.Length; j++)
                {
                    if (!(butunCariler[i].adres.ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                        butunCariler[i].ad.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                        butunCariler[i].cariNotu.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                        butunCariler[i].cinsiyet.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                        butunCariler[i].tel1.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                        butunCariler[i].tel2.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1 ||
                        butunCariler[i].yas.ToString().ToLower().IndexOf(arananKelimeler[j]) != -1))
                    {
                        butunKelimelerVarMi = false;
                    }
                }
                if (butunKelimelerVarMi)
                    gecici.Add(butunCariler[i]);
                butunKelimelerVarMi = true;
            }
            listView1.Items.Clear();
            for (int i = 0; i < gecici.Count; i++)
            {
                string[] dizi = { gecici[i].id.ToString(), gecici[i].ad, gecici[i].yas.ToString(), gecici[i].tel1, gecici[i].tel2, gecici[i].cariNotu };
                ListViewItem eklencekSatir = new ListViewItem(dizi);
                listView1.Items.Add(eklencekSatir);
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                    context_sagTikMenu.Show(Cursor.Position);
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            duzenlemeFormunuAc();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bu cariyi kalıcı olarak silmek istediğinizden emin misiniz?", "Cari Sil", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id").ToString().Trim());
                //int id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                ctx.cariler.Remove(ctx.cariler.SingleOrDefault(b => b.id == id));
                ctx.SaveChanges();
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                //listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount>0)
                duzenlemeFormunuAc();
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
               // if (gridView1.FocusedRowHandle==(e.Location)
                    context_sagTikMenu.Show(Cursor.Position);
        }
    }
}
