using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyonManisa
{
    public partial class sifremiUnuttum : Form
    {
        public sifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            if (txt_name.Text == "E-Posta Adresinizi Girin")
            {
                txt_name.Text = "";
                txt_name.ForeColor = Color.Black;
            }
        }

        private void txt_name_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_name.Text))
            {
                txt_name.ForeColor = Color.Gray;
                txt_name.Text = "E-Posta Adresinizi Girin";
            }
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
        EntityEmlakOtomasyonManisa ctx = new EntityEmlakOtomasyonManisa();
        users sifresiUnutulanKullanici;

        private void button1_Click(object sender, EventArgs e)
        {
            sifresiUnutulanKullanici = ctx.users.SingleOrDefault(b => b.ePosta == txt_name.Text);
            if (sifresiUnutulanKullanici != null)
            {
                içerik = "Kullanıcı adı : " + sifresiUnutulanKullanici.userName + " Şifre : " + sifresiUnutulanKullanici.password;
                BackgroundWorker backgroundWorker2 = new BackgroundWorker();
                backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Gonder_DoWork);
                backgroundWorker2.RunWorkerAsync();
                MessageBox.Show("Şifreniz Eposta Adresine Gönderilmiştir.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı mevcut değil.");
            }

        }

        MailMessage ePosta = new MailMessage();
        string içerik = "";
        private void Gonder_DoWork(object sender, DoWorkEventArgs e)
        {
            ePosta.From = new MailAddress("tayyipitunes@hotmail.com");
            ePosta.To.Add(txt_name.Text);
            ePosta.Subject = "Emlak Otomasyonu - Şifremi Unuttum";
            ePosta.Body = içerik;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("tayyipitunes@hotmail.com", "Tayyip1212");
            smtp.Port = 587;
            smtp.Host = "smtp.live.com";
            smtp.EnableSsl = true;
            smtp.Send(ePosta);
            this.Close();
        }
    }
}
