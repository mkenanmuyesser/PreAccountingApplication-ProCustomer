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
    public partial class OdemeTipiForm : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        public OdemeTipiForm()
        {
            InitializeComponent();
        }

        private void OdemeTipiForm_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            entities.Refresh(RefreshMode.StoreWins, entities.OdemeTips);
            this.Close();
        }
        void Doldur()
        {
            grdOdemeMain.DataSource = null;
            grdOdemeMain.DataSource = entities.OdemeTips.ToArray();
            grdOdeme.Columns[0].OptionsColumn.ReadOnly = true;
            grdOdeme.Columns[2].Visible = false;
            grdOdeme.Columns[3].Visible = false;
            grdOdeme.Columns[4].Visible = false;
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            try
            {
                OdemeTip yeni = new OdemeTip
                {
                    OdemeTipi = txtOdemeYeri.Text,
                };

                entities.AddToOdemeTips(yeni);
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
            if (grdOdeme.RowCount == 1)
            {
                _BildirimForm1.Goster("En az bir kayıt bulunmalıdır!");
            }
            else
            {
                try
                {
                    OdemeTip secilenodeme = grdOdeme.GetFocusedRow() as OdemeTip;
                    entities.DeleteObject(secilenodeme);
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
                entities.Refresh(RefreshMode.StoreWins, entities.OdemeTips);
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
