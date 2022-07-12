using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using ProCustomer.Forms;

namespace ProCustomer.UserControls.Iletisim
{
    public partial class _4SmsModul : UserControl
    {
        ProCustomerDBEntities entities = Program.entities;
        SmsReferans.smsservice smsservice = new SmsReferans.smsservice();
        public _4SmsModul()
        {
            
            InitializeComponent();
        }

        private void _4SmsModul_Load(object sender, EventArgs e)
        {
            DataLoads();
        }  

        private void btnAra_Click(object sender, EventArgs e)
        {
            DataLoads();
        }

        private void btnSmsGonder_Click(object sender, EventArgs e)
        {
            ProgramAyar ayar = entities.ProgramAyars.Single();
            string[] dizisms = new string[0];

            for (int i = 0; i < grdSms.RowCount; i++)
            {
                SmsData mdmsms = grdSms.GetRow(i) as SmsData;
                if (mdmsms.Gonder)
                {
                    Array.Resize(ref dizisms, dizisms.Length + 1);
                    dizisms[dizisms.Length - 1] = mdmsms.Telefon;
                }
            }

            try
            {
                string[] sonuc = smsservice.SmsInsert_1_N(ayar.SmsKullaniciAdi, ayar.SmsSifre, DateTime.Now, null, dizisms, txtSmsIcerik.Text);
                _BildirimForm1.Goster("SMS gönderme işlemi başarılıdır.");
            }
            catch
            {
                _BildirimForm1.Goster("SMS gönderme işlemi başarısızdır.");
            }
        }  

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = sfdExcel.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                grdSmsMain.ExportToXls(sfdExcel.FileName);
            }
        }

        private void DataLoads()
        {
            List<SmsData> SmsDatas = new List<SmsData>();
            foreach (var item in entities.Musteris.Select(a => new {  a.Ad_Unvan, a.Telefon1 }))
            {
                SmsData md = new SmsData
                {
                    Ad_Unvan = item.Ad_Unvan,
                    Telefon = item.Telefon1,
                    Gonder = true,
                };
                SmsDatas.Add(md);
            }
            grdSmsMain.DataSource = SmsDatas;
            grdSms.Columns["Gonder"].Width = 30;
            grdSms.Columns["Ad_Unvan"].OptionsColumn.AllowEdit = false;
            grdSms.Columns["Telefon"].OptionsColumn.AllowEdit = false;
        }

        public class SmsData
        {
            public bool Gonder { get; set; }
            public string Ad_Unvan { get; set; }
            public string Telefon { get; set; }
        }

        private void btnYazici_Click(object sender, EventArgs e)
        {
            grdSms.ShowRibbonPrintPreview();
        }

    }
}
