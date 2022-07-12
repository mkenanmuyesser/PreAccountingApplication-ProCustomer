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
    public partial class _10HayvanTurTanim : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        public _10HayvanTurTanim()
        {
            InitializeComponent();
            Doldur();
        }

        public void Doldur()
        {
            grdHTanimMain.DataSource = null;
            grdHTanimMain.DataSource = entities.HayvanTurs.OrderBy(a => a.ID).ToArray();
            grdHTanim.Columns[0].OptionsColumn.ReadOnly = true;
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            if (txtTuru.Text != "")
            {
                try
                {
                    HayvanTur tur = new HayvanTur
                    {
                        TurAdi = txtTuru.Text,
                    };
                    entities.AddToHayvanTurs(tur);
                    entities.SaveChanges(true);
                    Doldur();
                    _BildirimForm1.Goster("Kayıt işlemi başarıyla gerçekleştirildi.");
                }
                catch
                {
                    _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
                }
            }
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            if (grdHTanim.RowCount == 1)
            {
                _BildirimForm1.Goster("En az bir kayıt bulunmalıdır!");
            }
            {
                try
                {
                    HayvanTur secilen = grdHTanim.GetFocusedRow() as HayvanTur;
                    entities.DeleteObject(secilen);
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
                entities.Refresh(RefreshMode.StoreWins, entities.HayvanTurs);
                Doldur();
                _BildirimForm1.Goster("Yapılan değişiklikler iptal edildi.");
            }
            catch
            {
                _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}