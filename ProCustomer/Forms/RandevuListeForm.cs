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
    public partial class RandevuListeForm : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        public RandevuListeForm()
        {
            InitializeComponent();
        }

        private void RandevuListeForm_Load(object sender, EventArgs e)
        {
            dtpRandevu.Value = DateTime.Now;
            DateTime tarih = dtpRandevu.Value;
            List<RandevuData> data = new List<RandevuData>();
            var sorgu = entities.Hatirlatmalars.Where(a => (a.Subject.Contains("muayene") || a.location.Contains("muayene") || a.Subject.Contains("Muayene") || a.location.Contains("Muayene") || a.Subject.Contains("MUAYENE") || a.location.Contains("MUAYENE")) && a.Baslangic.Year == tarih.Year && a.Baslangic.Month == tarih.Month && a.Baslangic.Day == tarih.Day).Select(a => new { MuayeneTarihi = a.Baslangic, MusteriAdi = a.MusteriID });
            foreach (var item in sorgu)
            {
                string musad="";
                if (item.MusteriAdi != 0)
                {
                    musad = entities.Musteris.Where(a => a.ID == item.MusteriAdi).Select(a => a.Ad_Unvan).First();
                    RandevuData ekle = new RandevuData
                    {
                        MusteriAdi = musad,
                        RandevuTarihi = item.MuayeneTarihi,
                    };
                    data.Add(ekle);
                }
            }
            RListe.DataSource = data;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            DateTime tarih = dtpRandevu.Value;
            RListe.DataSource = null;
            List<RandevuData> data = new List<RandevuData>();
            var sorgu = entities.Hatirlatmalars.Where(a => (a.Subject.Contains("muayene") || a.location.Contains("muayene")) && a.Baslangic.Year == tarih.Year && a.Baslangic.Month == tarih.Month && a.Baslangic.Day == tarih.Day).Select(a => new { MuayeneTarihi = a.Baslangic, MusteriAdi = a.MusteriID });
            foreach (var item in sorgu)
            {
                string musad = "";
                if (item.MusteriAdi != 0)
                {
                    musad = entities.Musteris.Where(a => a.ID == item.MusteriAdi).Select(a => a.Ad_Unvan).First();
                    RandevuData ekle = new RandevuData
                    {
                        MusteriAdi = musad,
                        RandevuTarihi = item.MuayeneTarihi,
                    };
                    data.Add(ekle);
                }                
            }
            RListe.DataSource = data;
        }
    }
}