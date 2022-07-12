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
    public partial class KullaniciTanimForm : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        public KullaniciTanimForm()
        {
            InitializeComponent();
        }

        private void KullaniciTanimForm_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            entities.Refresh(RefreshMode.StoreWins, entities.Kullanicis);
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanici yeni = new Kullanici
                {
                    KullaniciAdi = txtKa.Text,
                    Sifre = txtSifre.Text,
                };
                entities.AddToKullanicis(yeni);
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
        void Doldur()
        {
            grdKullaniciMain.DataSource = null;
            grdKullaniciMain.DataSource = entities.Kullanicis.ToArray();
            grdKullanici.Columns[0].OptionsColumn.ReadOnly = true;
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            if (grdKullanici.RowCount == 1)
            {
                _BildirimForm1.Goster("En az bir kayıt bulunmalıdır!");
            }
            else
            {
                try
                {
                    Kullanici secilenkullanici = grdKullanici.GetFocusedRow() as Kullanici;
                    entities.DeleteObject(secilenkullanici);
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
                entities.Refresh(RefreshMode.StoreWins, entities.Kullanicis);
                Doldur();
                _BildirimForm1.Goster("Yapılan değişiklikler iptal edildi.");
            }
            catch
            {
                _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
            }
        }

    }
}