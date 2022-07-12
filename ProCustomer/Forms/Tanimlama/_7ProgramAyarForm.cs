using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Objects;
using System.Linq;

namespace ProCustomer.Forms.Tanimlama
{
    public partial class ProgramAyarForm : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        ProgramAyar PAYAR = null;
        public ProgramAyarForm()
        {
            InitializeComponent();
        }

        private void ProgramAyarForm_Load(object sender, EventArgs e)
        {
            PAYAR = entities.ProgramAyars.First();
            txtSmsKa.Text = entities.ProgramAyars.Select(a => a.SmsKullaniciAdi).First().ToString();
            txtSmsSifre.Text = entities.ProgramAyars.Select(a => a.SmsSifre).First().ToString();
            txtSmtpGAd.Text = entities.ProgramAyars.Select(a => a.SmtpGonderenAd).First().ToString();
            txtSmtpGMail.Text = entities.ProgramAyars.Select(a => a.SmtpGonderenEmail).First().ToString();
            txtSmtpHost.Text = entities.ProgramAyars.Select(a => a.SmtpHost).First().ToString();
            txtSmtpKa.Text = entities.ProgramAyars.Select(a => a.SmtpKullaniciAdi).First().ToString();
            txtSmtpPort.Text = entities.ProgramAyars.Select(a => a.SmtpPort).First().ToString();
            txtSmtpSifre.Text = entities.ProgramAyars.Select(a => a.SmtpSifre).First().ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                PAYAR.SmsKullaniciAdi = txtSmsKa.Text;
                PAYAR.SmsSifre = txtSmsSifre.Text;
                PAYAR.SmtpGonderenAd = txtSmtpGAd.Text;
                PAYAR.SmtpGonderenEmail = txtSmtpGMail.Text;
                PAYAR.SmtpHost = txtSmtpHost.Text;
                PAYAR.SmtpKullaniciAdi = txtSmtpKa.Text;
                PAYAR.SmtpPort = Convert.ToInt32(txtSmtpPort.Text);
                PAYAR.SmtpSifre = txtSmtpSifre.Text;
                entities.SaveChanges(true);
                foreach (var item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        (item as TextBox).Clear();
                    }
                }
                _BildirimForm1.Goster("Kayıt işlemi başarıyla gerçekleştirildi.");
                this.Close();
            }
            catch
            {
                _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
            }
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}