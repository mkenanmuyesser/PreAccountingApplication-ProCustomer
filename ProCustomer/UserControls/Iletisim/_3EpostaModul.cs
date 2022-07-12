using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Net.Mail;
using ProCustomer.Forms;

namespace ProCustomer.UserControls.Iletisim
{
    public partial class _3EpostaModul : UserControl
    {
        ProCustomerDBEntities entities = Program.entities;
        public _3EpostaModul()
        {
           
            InitializeComponent();
        }

        private void _3EpostaModul_Load(object sender, EventArgs e)
        {
            DataLoads();
        }

        private void btnEpostaGonder_Click(object sender, EventArgs e)
        {
            ProgramAyar ayar = entities.ProgramAyars.First();
            string[] dizimail = new string[0];
            for (int i = 0; i < grdEposta.RowCount; i++)
            {
                MailData mdmsms = grdEposta.GetRow(i) as MailData;
                if (mdmsms.Gonder)
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

        private void btnAra_Click(object sender, EventArgs e)
        {
            DataLoads();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = sfdExcel.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                grdEpostaMain.ExportToXls(sfdExcel.FileName);
            }
        }

        private void DataLoads()
        {
            List<MailData> maildatas = new List<MailData>();
            foreach (var item in entities.Musteris.Select(a => new { a.Ad_Unvan, a.Eposta, }))
            {
                MailData md = new MailData
                {
                    Ad_Unvan = item.Ad_Unvan,
                    Eposta = item.Eposta,
                    Gonder = true,                 
                };
                maildatas.Add(md);
            }
            grdEpostaMain.DataSource = maildatas;
            grdEposta.Columns["Gonder"].Width = 30;
            grdEposta.Columns["Ad_Unvan"].OptionsColumn.AllowEdit = false;
            grdEposta.Columns["Eposta"].OptionsColumn.AllowEdit = false;        
        }

        public class MailData
        {
            public bool Gonder { get; set; }
            public string Ad_Unvan { get; set; }
            public string Eposta { get; set; }
        }

        private void btnYazici_Click(object sender, EventArgs e)
        {
            grdEposta.ShowRibbonPrintPreview();
        }
      
    }
}
