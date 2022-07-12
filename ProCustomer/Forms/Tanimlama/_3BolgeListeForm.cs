using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using ProCustomer.Classes;

namespace ProCustomer.Forms
{
    public partial class BolgeListeForm : DevExpress.XtraEditors.XtraForm
    {
        //ProCustomerDBEntities entities = Program.entities;
        ProCustomerDBEntities entities = Program.entities;
        public BolgeListeForm()
        {
            InitializeComponent();
        }

        private void BolgeListeForm_Load(object sender, EventArgs e)
        {
            cmbSorumlu.ValueMember = "ID";
            cmbSorumlu.DisplayMember = "AdSoyad";
            cmbSorumlu.DataSource = entities.Personels;
            cmbFiyatKademesi.SelectedIndex = 0;
            Doldur();
        }

        void Doldur()
        {
            grdBolgeListeMain.DataSource = null;
            grdBolgeListeMain.DataSource = entities.Bolges.ToArray();
            grdBolgeListe.Columns[3].Visible= false;
            grdBolgeListe.Columns[4].Visible = false;
            grdBolgeListe.Columns[0].Visible = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            entities.Refresh(RefreshMode.StoreWins, entities.Bolges);
            this.Close();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            if (cmbSorumlu.SelectedIndex != -1 && cmbFiyatKademesi.SelectedIndex != -1)
            {
                Personel yeni = cmbSorumlu.SelectedItem as Personel;
                try
                {
                    Bolge yenibolge = new Bolge
                    {
                        Tanim = txtBolgeTanimi.Text,
                        Personel = yeni,
                        FiyatKademe = cmbFiyatKademesi.SelectedIndex + 1,
                    };
                    entities.AddToBolges(yenibolge);
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
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            if (_BildirimForm2.Goster("Silmek istediğinizden emin misiniz?.").SONUC)
            {
                if (grdBolgeListe.RowCount == 1)
                {
                    _BildirimForm1.Goster("En az bir kayıt bulunmalıdır!");
                }
                else
                {
                    try
                    {
                        Bolge secilen = grdBolgeListe.GetFocusedRow() as Bolge;
                        Bolge secilenbolge = entities.Bolges.First(a => a.ID == secilen.ID && a.Tanim!="GenelBölge");
                        entities.DeleteObject(secilenbolge);
                        entities.SaveChanges(true);
                        Doldur();
                        _BildirimForm1.Goster("Silme işlemi başarıyla gerçekleştirildi.");
                    }
                    catch
                    {
                        _BildirimForm1.Goster("Genel Bölge Silinemez.!");
                    }
                }
            }
            else
            { }
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
                entities.Refresh(RefreshMode.StoreWins, entities.Bolges);
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
