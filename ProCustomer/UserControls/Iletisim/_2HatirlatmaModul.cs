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
using System.Net.Mail;

namespace ProCustomer.UserControls.Iletisim
{
    public partial class _2HatirlatmaModul : UserControl
    {
        ProCustomerDBEntities entities = Program.entities;
        SmsReferans.smsservice smsservice = new SmsReferans.smsservice();
        public _2HatirlatmaModul()
        {
            InitializeComponent();
        }

        private void _2HatirlatmaModul_Load(object sender, EventArgs e)
        {
            dtpBaslangic.Value = DateTime.Now.Date;
            dtpBitis.Value = DateTime.Now.Date.AddDays(1).AddMinutes(-1);
            DataLoads();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            DataLoads();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = sfdExcel.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                grdHatirlatmaMain.ExportToXls(sfdExcel.FileName);
            }
        }

        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            ProgramAyar ayar = entities.ProgramAyars.First();
            string[] dizimail = new string[0];
            for (int i = 0; i < grdHatirlatma.RowCount; i++)
            {
                MailSmsData mdmsms = grdHatirlatma.GetRow(i) as MailSmsData;
                if (mdmsms.MailGonder)
                {
                    Array.Resize(ref dizimail, dizimail.Length + 1);
                    dizimail[dizimail.Length - 1] = mdmsms.Eposta;
                }
            }

            try
            {
                MailAddress gonderici = new MailAddress(ayar.SmtpGonderenEmail, ayar.SmtpGonderenAd);
                MailMessage mesaj = new MailMessage();
                mesaj.From = gonderici;
                foreach (var item in dizimail)
                {
                    mesaj.To.Add(item);
                }
                mesaj.Subject = txtMesajKonu.Text;
                mesaj.Body = txtMesajIcerik.Text;
                SmtpClient cli = new SmtpClient(ayar.SmtpHost, ayar.SmtpPort);
                cli.Send(mesaj);
                _BildirimForm1.Goster("Mesaj gönderme işlemi başarılıdır.");
            }
            catch
            {
                _BildirimForm1.Goster("Mesaj gönderme işlemi başarısızdır.");
            }
        }

        private void btnSmsGonder_Click(object sender, EventArgs e)
        {
            ProgramAyar ayar = entities.ProgramAyars.First();
            string[] dizisms = new string[0];

            for (int i = 0; i < grdHatirlatma.RowCount; i++)
            {
                MailSmsData mdmsms = grdHatirlatma.GetRow(i) as MailSmsData;
                if (mdmsms.SmsGonder)
                {
                    Array.Resize(ref dizisms, dizisms.Length + 1);
                    dizisms[dizisms.Length - 1] = mdmsms.Eposta;
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

        private void DataLoads()
        {
            List<MailSmsData> mailsmsdatas = new List<MailSmsData>();
            var sonuc = entities.Musteris.Where(a => a.ID == 0).ToList();
            if (chkHaberVer.Checked)
            {
                sonuc.AddRange(entities.Musteris.Where(a => a.Hatırlat == chkHaberVer.Checked && (a.Tarih.Day >= dtpBaslangic.Value.Day && a.Tarih.Month >= dtpBaslangic.Value.Month) && (a.Tarih.Day <= dtpBitis.Value.Day && a.Tarih.Month <= dtpBitis.Value.Month)));

            }
            if (chkDogumGunu.Checked)
            {

                sonuc.AddRange(entities.Musteris.Where(a => a.DogumGunuHatırlat == chkDogumGunu.Checked && (a.DogumGunuTarih.Day >= dtpBaslangic.Value.Day && a.DogumGunuTarih.Month >= dtpBaslangic.Value.Month) && (a.DogumGunuTarih.Day <= dtpBitis.Value.Day && a.DogumGunuTarih.Month <= dtpBitis.Value.Month)));

            }
            if (chkOzelGun.Checked)
            {

                sonuc.AddRange(entities.Musteris.Where(a => a.OzelGunHatırlat == chkOzelGun.Checked && (a.OzelGunTarih.Day >= dtpBaslangic.Value.Day && a.OzelGunTarih.Month >= dtpBaslangic.Value.Month) && (a.OzelGunTarih.Day <= dtpBitis.Value.Day && a.OzelGunTarih.Month <= dtpBitis.Value.Month)));

            }

            foreach (var item in sonuc.Distinct())
            {
                MailSmsData md = new MailSmsData
                {
                    SmsGonder = true,
                    MailGonder = true,
                    Ad_Unvan = item.Ad_Unvan,
                    Eposta = item.Eposta,
                    Telefon = item.Telefon1,
                    Açıklama = item.Aciklama,
                };
                mailsmsdatas.Add(md);
            }
            grdHatirlatmaMain.DataSource = mailsmsdatas;
            grdHatirlatma.Columns["Ad_Unvan"].OptionsColumn.AllowEdit = false;
            grdHatirlatma.Columns["Eposta"].OptionsColumn.AllowEdit = false;
            grdHatirlatma.Columns["Telefon"].OptionsColumn.AllowEdit = false;
            grdHatirlatma.Columns["Açıklama"].OptionsColumn.AllowEdit = false;
        }

        public class MailSmsData
        {
            public bool MailGonder { get; set; }
            public bool SmsGonder { get; set; }
            public string Ad_Unvan { get; set; }
            public string Eposta { get; set; }
            public string Telefon { get; set; }
            public string Açıklama { get; set; }
        }

        private void btnYazici_Click(object sender, EventArgs e)
        {
            grdHatirlatma.ShowRibbonPrintPreview();
        }

    }
}
