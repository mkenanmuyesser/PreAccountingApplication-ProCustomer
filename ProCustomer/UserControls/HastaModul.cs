using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProCustomer.Forms;
using ProCustomer.Classes;

namespace ProCustomer.UserControls
{
    public partial class HastaModul : UserControl
    {
        ProCustomerDBEntities entities = Program.entities;
        public HastaModul()
        {
            InitializeComponent();
        }

        private void HastaModul_Load(object sender, EventArgs e)
        {
            dtp1.Value = DateTime.Now.Date;
            dtp2.Value = DateTime.Now.Date.AddDays(1).AddMinutes(-1);
            Doldur();
        }

        public void Doldur()
        {
            List<MuayeneData> doldur = new List<MuayeneData>();
            foreach (var item in entities.MuayeneKarts.Where(a => a.Tarih > dtp1.Value && a.Tarih < dtp2.Value))
            {
                MuayeneData data = new MuayeneData
                {
                    Doktor = entities.Musteris.Where(a => a.ID == item.DoktorID).Select(a => a.Ad_Unvan).First(),
                    Musteri = entities.Musteris.Where(a => a.ID == item.MusteriID).Select(a => a.Ad_Unvan).First(),
                    Hayvan = entities.HayvanTanims.Where(a => a.ID == item.HayvanID).Select(a => a.Adi).First(),
                    MauyeneNedeni = item.MuayeneNedeni,
                    Tarih = Convert.ToDateTime(item.Tarih),
                    Tutar = item.MuayeneTutar.ToString("C"),
                    ID=item.ID,
                };
                doldur.Add(data);
            }
            grdKart.DataSource = doldur;
        }

        public void btnAra_Click(object sender, EventArgs e)
        {
            grdKart.DataSource = null;
            List<MuayeneData> doldur = new List<MuayeneData>();
            foreach (var item in entities.MuayeneKarts.Where(a => a.Tarih > dtp1.Value && a.Tarih < dtp2.Value))
            {
                MuayeneData data = new MuayeneData
                {
                    Doktor = entities.Musteris.Where(a => a.ID == item.DoktorID).Select(a => a.Ad_Unvan).First(),
                    Musteri = entities.Musteris.Where(a => a.ID == item.MusteriID).Select(a => a.Ad_Unvan).First(),
                    Hayvan = entities.HayvanTanims.Where(a => a.ID == item.HayvanID).Select(a => a.Adi).First(),
                    MauyeneNedeni = item.MuayeneNedeni,
                    Tarih = Convert.ToDateTime(item.Tarih),
                    Tutar = item.MuayeneTutar.ToString("C"),
                    ID=item.ID,
                };
                doldur.Add(data);
            }
            grdKart.DataSource = doldur;
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            List<MuayeneData> doldur = new List<MuayeneData>();
            foreach (var item in entities.MuayeneKarts.Where(a => a.Tarih > dtp1.Value && a.Tarih < dtp2.Value))
            {
                MuayeneData data = new MuayeneData
                {
                    Doktor = entities.Musteris.Where(a => a.ID == item.DoktorID).Select(a => a.Ad_Unvan).First(),
                    Musteri = entities.Musteris.Where(a => a.ID == item.MusteriID).Select(a => a.Ad_Unvan).First(),
                    Hayvan = entities.HayvanTanims.Where(a => a.ID == item.HayvanID).Select(a => a.Adi).First(),
                    MauyeneNedeni = item.MuayeneNedeni,
                    Tarih = Convert.ToDateTime(item.Tarih),
                    Tutar = item.MuayeneTutar.ToString("C"),
                    ID=item.ID,
                };
                doldur.Add(data);
            }
            decimal genel = entities.MuayeneKarts.Where(a => a.Tarih > dtp1.Value && a.Tarih < dtp2.Value).Sum(a => a.MuayeneTutar);
            RaporForm abc = new RaporForm(doldur, true);
            abc.lblToplam.Text = genel.ToString("C");
            abc.ShowDialog();

        }

        private void grdKartMain_DoubleClick(object sender, EventArgs e)
        {
            if (grdKartMain.GetFocusedRow() as MuayeneData != null)
            {
                int MuyID = (grdKartMain.GetFocusedRow() as MuayeneData).ID;
                MuayeneKart mk = entities.MuayeneKarts.First(a=>a.ID==MuyID);
                Muayene form = new Muayene(mk);
                form.FormClosed += delegate
                {
                    btnAra_Click(null, null);
                };
                form.ShowDialog();
            }
        }
    }
}
