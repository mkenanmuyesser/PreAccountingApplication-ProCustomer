using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using System.Data.Objects;

namespace ProCustomer.Forms.Tanimlama
{
    public partial class _9HayvanTanimForm : DevExpress.XtraEditors.XtraForm
    {
        int MUSTERIID;
        ProCustomerDBEntities entities = Program.entities;
        public _9HayvanTanimForm(int id)
        {
            InitializeComponent();
            MUSTERIID = id;
        }

        private void _9HayvanTanimForm_Load(object sender, EventArgs e)
        {
            rdDisi.Checked = true;
            Doldur();
        }

        public void Doldur()
        {
            grdHTanimMain.DataSource = null;
            grdHTanimMain.DataSource = entities.HayvanTanims.Where(a => a.Musteri.ID == MUSTERIID).ToArray();
            grdHTanim.Columns[0].OptionsColumn.ReadOnly = true;
            grdHTanim.Columns[6].Visible = false;
            cmbTuru.DisplayMember = "TurAdi";
            cmbTuru.ValueMember = "ID";
            cmbTuru.DataSource = entities.HayvanTurs;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            if (cmbTuru.SelectedIndex != -1)
            {
                if (txtAdi.Text != "")
                {
                    try
                    {
                        HayvanTanim ekle = new HayvanTanim
                            {
                                Musteri = entities.Musteris.First(a => a.ID == MUSTERIID),
                                Adi = txtAdi.Text,
                                Ciftlesme = chkEs.Checked,
                                Cinsi = rdErkek.Checked == true ? true : false,
                                Aylik = Convert.ToInt32(nmrAylik.Value),
                                Turu = cmbTuru.Text,
                            };
                        entities.AddToHayvanTanims(ekle);
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
            txtAdi.Text = "";
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            try
            {
                HayvanTanim secilen = grdHTanim.GetFocusedRow() as HayvanTanim;
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
                entities.Refresh(RefreshMode.StoreWins, entities.HayvanTanims);
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