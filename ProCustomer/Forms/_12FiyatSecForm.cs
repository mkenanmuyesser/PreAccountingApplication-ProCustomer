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
using ProCustomer.Classes;

namespace ProCustomer.Forms
{
    public partial class _12FiyatSecForm : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        SiparisDetayData DETAY = null;
        Urun URN=null;
        _11SiparisEkleDegistirForm EKLEDEGISTIR = null;
        public _12FiyatSecForm(SiparisDetayData detay, _11SiparisEkleDegistirForm ekledegistir)
        {
            InitializeComponent();
            DETAY = detay;
            URN = entities.Uruns.First(a => a.UrunAdi == DETAY.Urun);
            EKLEDEGISTIR = ekledegistir;
        }

        private void FiyatSecForm_Load(object sender, EventArgs e)
        {

            txtFiyat1.Text = URN.Fiyat1.ToString();
            txtFiyat2.Text = URN.Fiyat2.ToString();
            txtFiyat3.Text = URN.Fiyat3.ToString();
            txtFiyat4.Text = URN.Fiyat4.ToString();
            txtFiyat5.Text = URN.Fiyat5.ToString();
            txtFiyat6.Text = URN.Fiyat6.ToString();
            txtFiyat7.Text = "0";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            entities.Refresh(RefreshMode.StoreWins, entities.SiparisDetays);
            this.Close();
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DETAY.Fiyat = Convert.ToDecimal(txtFiyat1.Text);
            }
            else if (radioButton2.Checked)
            {
                DETAY.Fiyat = Convert.ToDecimal(txtFiyat2.Text);
            }
            else if (radioButton3.Checked)
            {
                DETAY.Fiyat = Convert.ToDecimal(txtFiyat3.Text);
            }
            else if (radioButton4.Checked)
            {
                DETAY.Fiyat = Convert.ToDecimal(txtFiyat4.Text);
            }
            else if (radioButton5.Checked)
            {
                DETAY.Fiyat = Convert.ToDecimal(txtFiyat5.Text);
            }
            else if (radioButton6.Checked)
            {
                DETAY.Fiyat = Convert.ToDecimal(txtFiyat6.Text);
            }
            else
            {
                DETAY.Fiyat = Convert.ToDecimal(txtFiyat7.Text);
            }

            DETAY.Toplam = DETAY.Fiyat * DETAY.Adet;
            DETAY.KdvTutar = URN.KdvDahil ? (DETAY.Toplam - (DETAY.Toplam / (1 + (URN.KdvOran / (decimal)100)))) : (DETAY.Toplam * (URN.KdvOran / (decimal)100));

            EKLEDEGISTIR.UrunDoldur();
        }

    }
}