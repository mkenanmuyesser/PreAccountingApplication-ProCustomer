using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using ProCustomer.Classes;

namespace ProCustomer.Forms
{
    public partial class _ArayaniBildirForm1 : DevExpress.XtraEditors.XtraForm
    {
        public bool SONUC;
        public _ArayaniBildirForm1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SONUC = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SONUC = false;
            this.Close();
        }

        public static _ArayaniBildirForm1 Goster(string arayan, string musteri)
        {
            _ArayaniBildirForm1 frm = new _ArayaniBildirForm1();
            ProCustomerDBEntities entities = Program.entities;
            if (entities.Musteris.Where(a => a.Ad_Unvan == musteri).Where(a => a.Gold == true).Count() > 0)
            {
                frm.pc1.Visible = true;
            }
            else
            {
                frm.pc1.Visible = false;
            }
            var sorgu = entities.Siparis.Where(a => a.Musteri.Ad_Unvan == musteri && a.Musteri != null && a.TaksitliSatis == false).OrderByDescending(a => a.ID).Take(5).ToList();
            List<AramaData> gelenarama = new List<AramaData>();
            foreach (var item in sorgu)
            {
                SiparisDetay urunadi = entities.SiparisDetays.First(a => a.Sipari.ID == item.ID);
                int urunid = entities.SiparisDetays.Where(a => a.ID == urunadi.ID).Select(a => a.Urun.ID).First();
                Urun urunler = entities.Uruns.First(a => a.ID == urunid);
                gelenarama.Add(new AramaData
                {
                    Tarih = item.TeslimTarih,
                    Urun = urunler.UrunAdi,
                });
            }
            frm.grdSonSip.DataSource = gelenarama;
            frm.lblArayan.Text += " " + arayan;
            frm.lblMusteri.Text += " " + musteri;
            frm.ShowDialog();
            return frm;
        }
    }
}