using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyonManisa
{
    static class Program
    {
        public static bool girisBasariliMi;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            girisBasariliMi = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EntityEmlakOtomasyonManisa ctx = new EntityEmlakOtomasyonManisa();
            settings deneme = ctx.settings.SingleOrDefault(x => x.id == 1);
            bool isLogin = Convert.ToBoolean(deneme.isLogin);

            if (isLogin)
            {
                girisBasariliMi = false;
                Application.Run(new login());
            }
            if (girisBasariliMi)
                Application.Run(new ContainerForm());
        }
    }
}