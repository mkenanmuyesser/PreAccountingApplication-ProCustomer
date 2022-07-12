using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;

namespace ProCustomer.UserControls.Iletisim
{
    public partial class _1CagriModul : UserControl
    {
        ProCustomerDBEntities entities = Program.entities;
        public _1CagriModul()
        {
            InitializeComponent();
        }

        private void _1CagriModul_Load(object sender, EventArgs e)
        {
            dtpBaslangic.Value = DateTime.Now.Date;
            dtpBitis.Value = DateTime.Now.Date.AddDays(1).AddMinutes(-1);
            Doldur();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = sfdExcel.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                grdCagriMain.ExportToXls(sfdExcel.FileName);
            }
        }

        public void Doldur()
        {
            DateTime baslangic = dtpBaslangic.Value;
            DateTime bitis = dtpBitis.Value;
            grdCagriMain.DataSource = null;
            grdCagriMain.DataSource = entities.Cagris.Where(a => a.Tarih >= baslangic && a.Tarih <= bitis).ToArray();
            grdCagri.Columns["Tarih"].DisplayFormat.FormatString = "dd.MM.yyyy HH:mm";
        }

        private void btnYazici_Click(object sender, EventArgs e)
        {
            grdCagri.ShowRibbonPrintPreview();
        }

    }
}
