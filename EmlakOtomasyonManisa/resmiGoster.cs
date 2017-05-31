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
    public partial class resmiGoster : Form
    {
        Image nufusCuzdani;
        int cariID;
        public resmiGoster(Image nufusCuzdani, int cariID)
        {
            InitializeComponent();
            this.nufusCuzdani = nufusCuzdani;
            this.cariID = cariID;
        }

        private void resmiGoster_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width - 720, 5);
            pictureBox1.Image = nufusCuzdani;
        }

        private void resmiGoster_LocationChanged(object sender, EventArgs e)
        {
            if (this.Location.X < 156)
                this.Location = new System.Drawing.Point(156, this.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            saveFileDialog1.Title = "Kayıt";
            saveFileDialog1.FileName = "nufusCuzdanı_" + cariID;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }
    }
}
