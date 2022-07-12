using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace ProCustomer.Forms
{
    public partial class _24SmsForm : DevExpress.XtraEditors.XtraForm
    {
        string SMS = null;
        ProCustomerDBEntities entities = Program.entities;
        SmsReferans.smsservice smsservice = new SmsReferans.smsservice();
        public _24SmsForm(string sms)
        {
            InitializeComponent();
            SMS = sms;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            ProgramAyar ayar = entities.ProgramAyars.First();
            string[] dizisms = { SMS };

            try
            {
                string[] sonuc = smsservice.SmsInsert_1_N(ayar.SmsKullaniciAdi, ayar.SmsSifre, DateTime.Now, null, dizisms, txtMesajIcerik.Text);
                _BildirimForm1.Goster("SMS gönderme işlemi başarılıdır.");
            }
            catch
            {
                _BildirimForm1.Goster("SMS gönderme işlemi başarısızdır.");
            }

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}