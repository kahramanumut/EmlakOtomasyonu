using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyonManisa
{
    public class IniOkuYaz
    {
        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string bolum, string anahtar, string deger, string dosyaYolu);
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string bolum, string anahtar, string def, StringBuilder retVal, int size, string dosyaYolu);
        public IniOkuYaz()
        {
            DOSYAYOLU = Application.StartupPath + @"\Settings.ini";
        }
        public string DOSYAYOLU = String.Empty;
        public string Varsayilan { get; set; }
        public string Oku(string bolum, string ayaradi)
        {
            //Alt satırı anlamadım..
            Varsayilan = Varsayilan ?? String.Empty;
            StringBuilder StrBuild = new StringBuilder(256);
            GetPrivateProfileString(bolum, ayaradi, Varsayilan, StrBuild, 255, DOSYAYOLU);
            return StrBuild.ToString();
        }
        public long Yaz(string bolum, string ayaradi, string deger)
        {
            return WritePrivateProfileString(bolum, ayaradi, deger, DOSYAYOLU);
        }
    }

    //Kaydetmek için aşağıdaki kodlardan yararlan. @hopehero3

    /*public void Kaydet()
    {
        INIKaydet INI = new INIKaydet(Application.StartupPath + @"\Ayarlar.ini");
        INI.Yaz("TEST", "TXT KUTUSU METNİ", txtAnahtar.Text);
        /* INI.Yaz("TEST", "CHBOX DURUMU", chBox.Checked.ToString());
         INI.Yaz("TEST", "RD BUTON DURUMU", rdBtn.Checked.ToString());
         INI.Yaz("TEST", "CM BOX DURUMU", cmBox.SelectedIndex.ToString());
        MessageBox.Show("Ayarlar kaydedildi.");

    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
        Kaydet();
    }


    //Okumak için aşağıdaki kodlardan yararlan. @hopehero3
     try
           {
               if (File.Exists(Application.StartupPath + @"\Ayarlar.ini"))
               {
                   INIKaydet INI = new INIKaydet(Application.StartupPath + @"\Ayarlar.ini");
                   txtMetin.Text = INI.Oku("TEST", "TXT KUTUSU METNİ");
                   chBox.Checked = Convert.ToBoolean(INI.Oku("TEST", "CHBOX DURUMU"));
                   rdBtn.Checked = Convert.ToBoolean(INI.Oku("TEST", "RD BUTON DURUMU"));
                   cmBox.SelectedIndex = Convert.ToInt32(INI.Oku("TEST", "CM BOX DURUMU"));

               }
               else
               {
                   MessageBox.Show("Ayarlar.ini ayar dosyası kayıp");
               }
           }
           catch (Exception hata)
           {
               MessageBox.Show("İni ayar dosyası zarar görmüş" + hata.Message);
           }*/

}

