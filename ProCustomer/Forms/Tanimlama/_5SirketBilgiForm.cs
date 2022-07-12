using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;

namespace ProCustomer.Forms
{
    public partial class SirketBilgiForm : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        public SirketBilgiForm()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SirketBilgiForm_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        void Doldur()
        {
            grdSirketBilgiMain.DataSource = null;
            grdSirketBilgiMain.DataSource = entities.Sirkets.ToArray();
            grdSirketBilgi.Columns[0].OptionsColumn.ReadOnly = true;
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Sirket yeni = new Sirket
                {
                    Aciklama=txtNot.Text,
                    Adres=txtAdres.Text,
                    BankaAdi=txtBanka.Text,
                    BankaSube=txtBankaSube.Text,
                    Eposta=txtMail.Text,
                    Fax=txtFaks.Text,
                    HesapNo=txtHesapNo.Text,
                    SicilNo=txtSicilNo.Text,
                    SubeKodu=txtSubeKod.Text,
                    Tel1=txtTelefon.Text,
                    Unvan=txtFirmaUnvan.Text,
                    VDNo=txtVergiNo.Text,
                    VergiDairesi=txtVergiDairesi.Text,
                    WebSayfa=txtWeb.Text,
                };

                entities.AddToSirkets(yeni);
                entities.SaveChanges(true);
                Doldur();
                foreach (var item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        (item as TextBox).Clear();
                    }
                }
                _BildirimForm1.Goster("Kayıt işlemi başarıyla gerçekleştirildi.");
            }
            catch
            {
                _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
            }
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            if (grdSirketBilgi.RowCount == 1)
            {
                _BildirimForm1.Goster("En az bir kayıt bulunmalıdır!");
            }
            else
            {
                try
                {
                    Sirket secilensirket = grdSirketBilgi.GetFocusedRow() as Sirket;
                    entities.DeleteObject(secilensirket);
                    entities.SaveChanges(true);
                    Doldur();
                    _BildirimForm1.Goster("Silme işlemi başarıyla gerçekleştirildi.");
                }
                catch
                {
                    _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
                }
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                entities.SaveChanges(true);
                Doldur();
                _BildirimForm1.Goster("Değişiklik işlemleri başarıyla gerçekleştirildi.");
            }
            catch
            {
                _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            try
            {
                entities.Refresh(RefreshMode.StoreWins, entities.Sirkets);
                Doldur();
                _BildirimForm1.Goster("Yapılan değişiklikler iptal edildi.");
            }
            catch
            {
                _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
            }
        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            entities.Refresh(RefreshMode.StoreWins, entities.Sirkets);
            this.Close();
        }

    }
}
