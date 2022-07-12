using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net.Mail;
using System.Linq;

namespace ProCustomer.Forms
{
    public partial class _23EPostaForm : DevExpress.XtraEditors.XtraForm
    {
        string EPOSTA = null;
        ProCustomerDBEntities entities = Program.entities;
        public _23EPostaForm(string eposta)
        {
            InitializeComponent();
            EPOSTA = eposta;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            ProgramAyar ayar = entities.ProgramAyars.First();
            try
            {
                MailAddress gonderici = new MailAddress(ayar.SmtpGonderenEmail, ayar.SmtpGonderenAd);
                MailMessage mesaj = new MailMessage();
                mesaj.From = gonderici;
                mesaj.To.Add(EPOSTA);
                mesaj.Subject = txtMesajKonu.Text;
                mesaj.Body = txtMesajIcerik.Text;
                SmtpClient cli = new SmtpClient(ayar.SmtpHost, ayar.SmtpPort);
                cli.Send(mesaj);
                _BildirimForm1.Goster("Mesaj gönderme işlemi başarılıdır.");
                this.Close();
            }
            catch
            {
                _BildirimForm1.Goster("Mesaj gönderme işlemi başarısızdır.");
            }
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}