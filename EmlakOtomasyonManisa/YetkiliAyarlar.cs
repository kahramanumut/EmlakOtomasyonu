using System;
using System.Linq;
using System.Windows.Forms;

namespace EmlakOtomasyonManisa
{
    public partial class YetkiliAyarlar : Form
    {
        EntityEmlakOtomasyonManisa ctx = new EntityEmlakOtomasyonManisa();
        ContainerForm MdiIcin;
        public YetkiliAyarlar(ContainerForm deneme)
        {
            InitializeComponent();
            MdiIcin = deneme;
        }

        
        private void Ayarlar_LocationChanged(object sender, EventArgs e)
        {
            if (this.Location.X < 156)
                this.Location = new System.Drawing.Point(156, this.Location.Y);
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(370, 5);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            settings ayar = new settings();
            ayar = ctx.settings.SingleOrDefault(x => x.id == 1);
            ayar.isLogin = checkBoxIsLogin.Checked;
            ctx.SaveChanges();

            MessageBox.Show("Ayarlar başarıyla kaydedildi.");
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            checkBoxIsLogin.Checked = false;
        }
    }
}
