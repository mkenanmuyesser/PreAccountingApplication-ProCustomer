using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using ProCustomer.Forms;
using System.Net.NetworkInformation;
using Microsoft.Win32;
using ProCustomer.Classes;
using DevExpress.XtraGrid.Localization;
using ProCustomer.Forms.Tanimlama;

namespace ProCustomer
{
    static class Program
    {
        public static ProCustomerDBEntities entities = new ProCustomerDBEntities();
        public static string key = null;
        public static string kategori = null;
        public static DateTime trh = DateTime.Now;
        public static List<string> kategories = new List<string>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //kategories.Add("Customer;");
            //kategories.Add("Gold;");
            //kategories.Add("Pet;");
            //kategories.Add("Vet;");
            //kategories.Add("Health;");
            //kategories.Add("Secretary;");
            //kategories.Add("Sport;");
            //kategories.Add("Beauty;");

            //try
            //{
            //    NetworkInterface[] arayuz;
            //    arayuz = NetworkInterface.GetAllNetworkInterfaces();
            //    NetworkInterfaceType type;
            //    type = arayuz[0].NetworkInterfaceType;
            //    PhysicalAddress mac;
            //    mac = arayuz[0].GetPhysicalAddress();
            //    String mac2 = mac.ToString();
            //    RegistryKey rg = Registry.CurrentUser.OpenSubKey("SOFTWARE").OpenSubKey("AtolyaTeknoloji").OpenSubKey("ProgramKey");
            //    key = rg.GetValue("ky").ToString();
            //    kategori = rg.GetValue("kategori").ToString();
            //    if (Crypto.DecryptStringAES(key, "10081008") == mac2 && kategories.Contains(rg.GetValue("kategori").ToString()))
            //    {
            //        if (Convert.ToDateTime(rg.GetValue("com").ToString()) > DateTime.Now)
            //        {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        DevExpress.Skins.SkinManager.EnableFormSkins();
                        DevExpress.UserSkins.BonusSkins.Register();
                        UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
                        GridLocalizer.Active = new GridLocalization();
                        Application.Run(new GirisForm());
                        //Application.Run(new AnaForm());
            //        }
            //        else
            //        {
            //            _BildirimForm1.Goster("Program lisans süresi bitmiştir.\nLütfen Atolya Teknolojiyle iletişime geçin.");
            //            Application.Exit();
            //        }
            //    }
            //    else
            //    {
            //        _BildirimForm1.Goster("Program lisans hatası");
            //        Application.Exit();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    _BildirimForm1.Goster("Program hatası.\n" + ex.Message);
            //    Application.Exit();
            //}
        }
    }
}
