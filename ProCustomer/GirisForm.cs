using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace ProCustomer
{
    public partial class GirisForm : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ka = txtKullaniciAdi.Text;
            if (entities.Kullanicis.Where(a => a.KullaniciAdi.Contains(ka)).Count() == 1)
            {
                string pw = entities.Kullanicis.Where(a => a.KullaniciAdi.Contains(ka)).Select(a => a.Sifre).First();
                if (pw == txtSifre.Text)
                {
                    AnaForm anfrm = new AnaForm();
                    anfrm.Show();
                    this.Hide();
                }
                else
                {
                    lblSonuc.Text = "Şifre Hatalı!.";
                }
            }
            else
            {
                lblSonuc.Text = "Kullanıcı adı Hatalı!.";
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}