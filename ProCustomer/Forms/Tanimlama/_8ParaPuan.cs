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
    public partial class _8ParaPuan : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        public _8ParaPuan()
        {
            InitializeComponent();
        }

        public void _8ParaPuan_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        public void Doldur()
        {
            grdParaPuanMain.DataSource = null;
            grdParaPuanMain.DataSource = entities.ParaPuans.ToArray();
            nmrLimit.Value = 100;
            nmrKarsilik.Value = 1;
        }
        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            try
            {
                ParaPuan yeni = new ParaPuan
                {
                    AlisverisTutari = Convert.ToDecimal(nmrLimit.Value),
                    KarsiligiParaPuan = Convert.ToInt32(nmrKarsilik.Value),
                };
                entities.AddToParaPuans(yeni);
                entities.SaveChanges(true);
                Doldur();
                _BildirimForm1.Goster("Kayıt işlemi başarıyla gerçekleştirildi.");
            }
            catch
            {
                _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            entities.Refresh(RefreshMode.StoreWins, entities.ParaPuans);
            this.Close();
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            if (grdParaPuanTanim.RowCount == 1)
            {
                _BildirimForm1.Goster("En az bir kayıt bulunmalıdır!");
            }
            else
            {
                try
                {
                    ParaPuan teslim = grdParaPuanTanim.GetFocusedRow() as ParaPuan;
                    entities.DeleteObject(teslim);
                    entities.SaveChanges(true);
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
                entities.Refresh(RefreshMode.StoreWins, entities.ParaPuans);
                _BildirimForm1.Goster("Yapılan değişiklikler iptal edildi.");
            }
            catch
            {
                _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
            }
        }
    }
}