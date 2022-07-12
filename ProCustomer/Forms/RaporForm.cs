using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ProCustomer.Classes;

namespace ProCustomer.Forms
{
    public partial class RaporForm : DevExpress.XtraEditors.XtraForm
    {
        public RaporForm()
        {
            InitializeComponent();
        }

        public RaporForm(List<RaporData> rpr)
        {
            InitializeComponent();
            gridControl1.DataSource = rpr;
        }

        public RaporForm(List<MuayeneData> mk, bool sonuc)
        {
            InitializeComponent();
            gridControl1.DataSource = mk;
        }


        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            gridView1.Columns[0].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average;
            gridView1.Columns[0].SummaryItem.DisplayFormat = "Toplam = " + lblToplam.Text;
        }
    }
}