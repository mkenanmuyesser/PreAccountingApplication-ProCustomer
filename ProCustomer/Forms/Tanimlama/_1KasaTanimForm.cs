using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;

namespace ProCustomer.Forms.Tanimlama
{
    public partial class KasaTanimForm : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        public KasaTanimForm()
        {
            InitializeComponent();
        }

        private void KasaTanimForm_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kasa yeni = new Kasa
                {
                    KasaAdi = txtKasaAdi.Text,
                };
                entities.AddToKasas(yeni);
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
            grdKasaTanimMain.DataSource = null;
            grdKasaTanimMain.DataSource = entities.Kasas.ToArray();
            grdKasaTanim.Columns[2].Visible = false;
            grdKasaTanim.Columns[3].Visible = false;
            grdKasaTanim.Columns[0].OptionsColumn.ReadOnly = true;
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            if (grdKasaTanim.RowCount==1)
            {
                _BildirimForm1.Goster("En az bir kayıt bulunmalıdır!");
            }
            else
            {
                try
                {
                    Kasa teslim = grdKasaTanim.GetFocusedRow() as Kasa;
                    entities.DeleteObject(teslim);
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

        private void btnKapat_Click(object sender, EventArgs e)
        {
            entities.Refresh(RefreshMode.StoreWins, entities.Kasas);
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            try
            {
                entities.Refresh(RefreshMode.StoreWins, entities.Kasas);
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