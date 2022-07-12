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

namespace ProCustomer.Forms
{
    public partial class _41KasaIslemForm : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        public _41KasaIslemForm()
        {
            InitializeComponent();
            Doldur();
        }

        KasaIslem KASAISLEM = null;
        Musteri MUSTERI;
        public _41KasaIslemForm(KasaIslem kasaislem, Musteri musteri)
        {
            InitializeComponent();
            KASAISLEM = kasaislem;
            Doldur();
            KasaDoldur();
            MUSTERI = musteri;
        }

        private void KasaDoldur()
        {
            txtAciklama.Text = KASAISLEM.Aciklama;
            cmbAUnvan.SelectedValue = KASAISLEM.Musteri.ID;
            txtEvrakNo.Text = KASAISLEM.EvrakNo;
            if (KASAISLEM.GirisCikis == true)
            { btnGiris.Checked = true; }
            else
            { btnCikis.Checked = true; }

            cmbislemYeri.SelectedItem = KASAISLEM.Kasa;
            cmbOSekli.SelectedItem = KASAISLEM.OdemeTip;
            cmbPAdi.SelectedItem = KASAISLEM.Musteri;
            txtislemTutar.Text = KASAISLEM.Tutar.ToString();
        }
        public _41KasaIslemForm(KasaIslem kasaislem, Musteri musteri, bool odeme)
        {
            InitializeComponent();
            KASAISLEM = kasaislem;
            Doldur();
            MUSTERI = musteri;
            if (odeme)
            {
                btnGiris.Checked = true;
                btnGiris.Visible = false;
                btnCikis.Visible = false;
            }
            else
            {
                btnCikis.Checked = true;
                btnCikis.Visible = false;
                btnGiris.Visible = false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (KASAISLEM == null)
            {
                try
                {
                    KasaIslem yeni = new KasaIslem
                    {
                        Musteri = MUSTERI,
                        Aciklama = txtAciklama.Text,
                        Ad_Unvan =cmbAUnvan.Text,
                        EvrakNo = txtEvrakNo.Text,
                        GirisCikis = btnGiris.Checked,
                        Kasa = cmbislemYeri.SelectedItem as Kasa,
                        OdemeTip = cmbOSekli.SelectedItem as OdemeTip,
                        Personel = cmbPAdi.SelectedItem as Personel,
                        Tarih = DateTime.Now,
                        Tutar = Convert.ToDecimal(txtislemTutar.Text),
                    };
                    entities.AddToKasaIslems(yeni);
                    entities.SaveChanges(true);
                    _BildirimForm1.Goster("Kayıt işlemi başarıyla gerçekleştirildi.");
                    this.Close();
                }
                catch
                {
                    _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
                }
            }
            else
            {
                try
                {
                    // KasaIslem gelen = entities.KasaIslems.Where(a => a.ID = KASAISLEM.ID) as KasaIslem;

                    KASAISLEM.Aciklama = txtAciklama.Text;
                    KASAISLEM.Ad_Unvan = cmbAUnvan.Text;
                    KASAISLEM.EvrakNo = txtEvrakNo.Text;
                    KASAISLEM.GirisCikis = btnGiris.Checked;
                    KASAISLEM.Kasa = cmbislemYeri.SelectedItem as Kasa;
                    KASAISLEM.OdemeTip = cmbOSekli.SelectedItem as OdemeTip;
                    KASAISLEM.Personel = cmbPAdi.SelectedItem as Personel;
                    KASAISLEM.Tarih = DateTime.Now;
                    KASAISLEM.Tutar = Convert.ToDecimal(txtislemTutar.Text);
                    entities.SaveChanges(true);
                    _BildirimForm1.Goster("Kayıt işlemi başarıyla gerçekleştirildi.");
                    this.Close();
                }
                catch
                {
                    _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
                }
            }
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Doldur()
        {
            txtislemTutar.Text = "0";
            txtEvrakNo.Text = "0";
            cmbislemYeri.ValueMember = "ID";
            cmbislemYeri.DisplayMember = "KasaAdi";
            cmbislemYeri.DataSource = entities.Kasas;
            cmbOSekli.ValueMember = "ID";
            cmbOSekli.DisplayMember = "OdemeTipi";
            cmbOSekli.DataSource = entities.OdemeTips;
            cmbAUnvan.ValueMember = "ID";
            cmbAUnvan.DisplayMember = "Ad_Unvan";
            cmbAUnvan.DataSource = entities.Musteris;
            cmbPAdi.ValueMember = "ID";
            cmbPAdi.DisplayMember = "AdSoyad";
            cmbPAdi.DataSource = entities.Personels;
        }

    }
}