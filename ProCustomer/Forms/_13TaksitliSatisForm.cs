using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ProCustomer.Classes;
using ProCustomer.Forms;
using System.Data.Objects;
using System.Linq;

namespace ProCustomer.Forms
{
    public partial class _13TaksitliSatisForm : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        public _13TaksitliSatisForm()
        {
            InitializeComponent();
            dtpBaslangic.Value = DateTime.Now.Date;
            dtpBitis.Value = DateTime.Now.Date.AddMonths(1).AddHours(-1);
            Doldur();
        }

        private void Doldur()
        {
            grdTaksit.DataSource = null;
            txtBirimAdet.Text = "1";

            cmbMusteri.DisplayMember = "Ad_Unvan";
            cmbMusteri.ValueMember = "ID";
            cmbMusteri.DataSource = entities.Musteris;
            cmbMusteri.AutoCompleteCustomSource.AddRange(entities.Musteris.Where(a => a.Ad_Unvan!=null).Select(a=>a.Ad_Unvan).ToArray());

            cmbUrun.DisplayMember = "UrunAdi";
            cmbUrun.ValueMember = "ID";
            cmbUrun.DataSource = entities.Uruns;
            cmbUrun.AutoCompleteCustomSource.AddRange(entities.Uruns.Where(a => a.UrunAdi != null).Select(a => a.UrunAdi).ToArray());

            cmbPer.DisplayMember = "AdSoyad";
            cmbPer.ValueMember = "ID";
            cmbPer.DataSource = entities.Personels;


            List<TaksitData> datadizi = new List<TaksitData>();
            var sorgu = entities.Siparis.ToList().Where(a => a.SiparisTarih >= dtpBaslangic.Value && a.SiparisTarih <= dtpBitis.Value && a.Musteri != null).ToList().Where(a => a.TaksitliSatis == true).ToList().Select(a => new { a.ID, a.SiparisTarih, a.SiparisTutar });
            foreach (var item in sorgu)
            {
                string mus = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.Musteri.Ad_Unvan).First();
                datadizi.Add(new TaksitData
                {
                    ID = item.ID,
                    SiparisTarih = item.SiparisTarih,
                    SiparisTutar = item.SiparisTutar.ToString("C"),
                    Musteri = mus,
                });
            }
            grdTaksit.DataSource = datadizi;
            grdTaksitView.Columns[0].OptionsColumn.ReadOnly = true;
            grdTaksitView.Columns[1].OptionsColumn.ReadOnly = true;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            entities.Refresh(RefreshMode.StoreWins, entities.Siparis);
            this.Close();
        }

        private void btnTaksitEkle_Click(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedIndex != -1 && cmbUrun.SelectedIndex != -1)
            {
                if (string.IsNullOrEmpty(cmbMusteri.Text))
                {
                    _BildirimForm1.Goster("Kayıt bulunamadı!");
                }
                else
                {
                    DateTime dtpTBaslangicValue = dtpTBaslangic.Value;
                    DateTime tarihi = dtpTBaslangicValue;
                    int taksitsayisi = Convert.ToInt32(txtTSayisi.Text);
                    for (int i = 0; i < taksitsayisi; i++)
                    {

                        Sipari taksit = new Sipari
                        {
                            Aciklama = txtAciklama.Text,
                            TaksitliSatis = true,
                            SiparisTarih = chkDahil.Checked ? dtpBaslangic.Value.Date.AddMonths(i) : dtpBaslangic.Value.Date.AddMonths(i + 1),
                            TeslimTarih = DateTime.Now,
                            Ad_Unvan = cmbMusteri.Text,
                            TeslimEdildi = true,
                            TahsilEdildi = false,
                            SiparisTutar = Convert.ToDecimal(txtBirimAdet.Text) * Convert.ToDecimal(cmbBirimFiyat.Text) / Convert.ToDecimal(txtTSayisi.Text),
                            UrunID = (cmbUrun.SelectedItem as Urun).ID,
                        };
                        taksit.PersonelReference.EntityKey = new EntityKey("ProCustomerDBEntities.Personels", "ID", (cmbPer.SelectedItem as Personel).ID);
                        taksit.MusteriReference.EntityKey = new EntityKey("ProCustomerDBEntities.Musteris", "ID", (cmbMusteri.SelectedItem as Musteri).ID);

                        KasaIslem yeni = new KasaIslem
                        {
                            Aciklama = txtAciklama.Text,
                            Tarih = chkDahil.Checked ? dtpBaslangic.Value.Date.AddMonths(i) : dtpBaslangic.Value.Date.AddMonths(i + 1),
                            Tutar = Convert.ToDecimal(txtToplam.Text) / Convert.ToDecimal(txtTSayisi.Text),
                            Ad_Unvan = cmbMusteri.Text,
                            GirisCikis = false,
                        };
                        yeni.MusteriReference.EntityKey = new EntityKey("ProCustomerDBEntities.Musteris", "ID", (cmbMusteri.SelectedItem as Musteri).ID);
                        entities.AddToKasaIslems(yeni);
                        entities.AddToSiparis(taksit);
                    }
                    if ((Convert.ToDecimal(txtBirimAdet.Text) * Convert.ToDecimal(cmbBirimFiyat.Text) - Convert.ToDecimal(txtToplam.Text)) != 0)
                    {
                        KasaIslem ekle = new KasaIslem
                        {
                            Aciklama = txtAciklama.Text,
                            Tarih = DateTime.Now,
                            Tutar = (Convert.ToDecimal(txtBirimAdet.Text) * Convert.ToDecimal(cmbBirimFiyat.Text) - Convert.ToDecimal(txtToplam.Text)),
                            Ad_Unvan = cmbMusteri.Text,
                            GirisCikis = true,
                        };
                        ekle.MusteriReference.EntityKey = new EntityKey("ProCustomerDBEntities.Musteris", "ID", (cmbMusteri.SelectedItem as Musteri).ID);
                        entities.AddToKasaIslems(ekle);
                    }
                    UrunStok stok = new UrunStok
                    {
                        Miktar = Convert.ToInt32(txtBirimAdet.Value),
                        Giris = false,
                        Kasa = entities.Kasas.First(),
                    };
                    stok.UrunReference.EntityKey = new EntityKey("ProCustomerDBEntities.Uruns", "ID", (cmbUrun.SelectedItem as Urun).ID);
                    entities.SaveChanges(true);
                    _BildirimForm1.Goster("Kayıt işlemi başarıyla gerçekleştirildi.");
                    txtAciklama.Text = "";
                    Doldur();
                }
            }
            else
            {
                _BildirimForm1.Goster("Urun yada Müşteri tanımlamasında hata var!.");
            }
        }

        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBirimFiyat.DataSource = null;
            ProCustomerDBEntities yeni = new ProCustomerDBEntities();
            int id = Convert.ToInt32(cmbUrun.SelectedValue);
            Urun secilen = yeni.Uruns.First(a => a.ID == id);
            List<decimal> fiyatlar = new List<decimal>();
            fiyatlar.Add(secilen.Fiyat1);
            fiyatlar.Add(secilen.Fiyat2);
            fiyatlar.Add(secilen.Fiyat3);
            fiyatlar.Add(secilen.Fiyat4);
            fiyatlar.Add(secilen.Fiyat5);
            fiyatlar.Add(secilen.Fiyat6);
            cmbBirimFiyat.DataSource = fiyatlar;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            grdTaksit.DataSource = null;
            if (rdOdenmemis.Checked == true)
            {
                List<TaksitData> datadizi = new List<TaksitData>();
                var sorgu = entities.Siparis.ToList().Where(a => a.SiparisTarih >= dtpBaslangic.Value && a.Musteri != null && a.SiparisTarih <= dtpBitis.Value).ToList().Where(a => a.TaksitliSatis == true).ToArray().Where(a => a.TahsilEdildi == false).ToList().Select(a => new { a.ID, a.SiparisTarih, a.SiparisTutar });
                foreach (var item in sorgu)
                {
                    string mus = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.Musteri.Ad_Unvan).First();
                    datadizi.Add(new TaksitData
                    {
                        ID = item.ID,
                        SiparisTarih = item.SiparisTarih,
                        SiparisTutar = item.SiparisTutar.ToString("C"),
                        Musteri = mus,
                    });
                }

                grdTaksit.DataSource = datadizi;
            }
            else if (rdOdenmis.Checked == true)
            {
                List<TaksitData> datadizi = new List<TaksitData>();
                var sorgu = entities.Siparis.ToList().Where(a => a.SiparisTarih >= dtpBaslangic.Value && a.Musteri != null && a.SiparisTarih <= dtpBitis.Value).ToList().Where(a => a.TaksitliSatis == true).Where(a => a.TahsilEdildi == true).Select(a => new { a.ID, a.SiparisTarih, a.SiparisTutar }).ToArray();
                foreach (var item in sorgu)
                {
                    string mus = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.Musteri.Ad_Unvan).First();
                    datadizi.Add(new TaksitData
                    {
                        ID = item.ID,
                        SiparisTarih = item.SiparisTarih,
                        SiparisTutar = item.SiparisTutar.ToString("C"),
                        Musteri = mus,
                    });
                }
                grdTaksit.DataSource = datadizi;
            }
            else if (rdTumu.Checked == true)
            {

                List<TaksitData> datadizi = new List<TaksitData>();
                var sorgu = entities.Siparis.ToList().Where(a => a.SiparisTarih >= dtpBaslangic.Value && a.Musteri != null && a.SiparisTarih <= dtpBitis.Value).ToList().Where(a => a.TaksitliSatis == true).ToList().Select(a => new { a.ID, a.SiparisTarih, a.SiparisTutar });
                foreach (var item in sorgu)
                {
                    string mus = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.Musteri.Ad_Unvan).First();
                    datadizi.Add(new TaksitData
                    {
                        ID = item.ID,
                        SiparisTarih = item.SiparisTarih,
                        SiparisTutar = item.SiparisTutar.ToString("C"),
                        Musteri = mus,
                    });
                }

                grdTaksit.DataSource = datadizi;
            }
            grdTaksitView.Columns[0].OptionsColumn.ReadOnly = true;
            grdTaksitView.Columns[1].OptionsColumn.ReadOnly = true;
        }

        private void txtBirimAdet_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbBirimFiyat.Text != "")
            {
                if (txtBirimAdet.Text == "")
                {
                    txtToplam.Text = "";
                }
                else
                {
                    txtToplam.Text = (Convert.ToDecimal(cmbBirimFiyat.Text) * Convert.ToDecimal(txtBirimAdet.Value)).ToString();
                }
            }
        }

        private void cmbBirimFiyat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBirimFiyat.Text != "")
            {
                if (txtBirimAdet.Text == "")
                {
                    txtToplam.Text = "";
                }
                else
                {
                    txtToplam.Text = (Convert.ToDecimal(cmbBirimFiyat.Text) * Convert.ToDecimal(txtBirimAdet.Value)).ToString();
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
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
                entities.Refresh(RefreshMode.StoreWins, entities.Siparis);
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