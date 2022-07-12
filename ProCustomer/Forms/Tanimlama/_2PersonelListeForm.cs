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
    public partial class PersonelListeForm : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        public PersonelListeForm()
        {
            InitializeComponent();
        }

        private void PersonelListeForm_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Personel yenipersonel = new Personel
                {
                    AdSoyad = txtAdSoyad.Text,
                    Telefon = txtTEL.Text,
                    Eposta = txtEposta.Text,
                };
                entities.AddToPersonels(yenipersonel);
                entities.SaveChanges(true);
                Doldur();
                foreach (var item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        (item as TextBox).Clear();
                    }
                }
                txtTEL.Text = "";
                _BildirimForm1.Goster("Kayıt işlemi başarıyla gerçekleştirildi.");
            }
            catch
            {
                _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
            }
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            if (grdPersonel.RowCount == 1)
            {
                _BildirimForm1.Goster("En az bir kayıt bulunmalıdır!");
            }
            else
            {
                try
                {
                    Personel secilenpersonel = grdPersonel.GetFocusedRow() as Personel;
                    if (secilenpersonel.AdSoyad == "_Genel Personel")
                    {
                        _BildirimForm1.Goster("Genel personel silinemez!.");
                    }
                    else
                    {
                        entities.DeleteObject(secilenpersonel);
                        entities.SaveChanges(true);
                        Doldur();
                        _BildirimForm1.Goster("Silme işlemi başarıyla gerçekleştirildi.");
                    }
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
                entities.Refresh(RefreshMode.StoreWins, entities.Personels);
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
            entities.Refresh(RefreshMode.StoreWins, entities.Personels);
            this.Close();
        }

        void Doldur()
        {
            grdPersonelMain.DataSource = null;
            grdPersonelMain.DataSource = entities.Personels.ToArray();
            grdPersonel.Columns[0].OptionsColumn.ReadOnly = true;
            grdPersonel.Columns[4].Visible = false;
            grdPersonel.Columns[5].Visible = false;
            grdPersonel.Columns[6].Visible = false;
            grdPersonel.Columns[7].Visible = false;
        }
    }
}
