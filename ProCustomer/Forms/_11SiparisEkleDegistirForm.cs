using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProCustomer.Classes;
using System.Data.Objects;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace ProCustomer.Forms
{
    public partial class _11SiparisEkleDegistirForm : DevExpress.XtraEditors.XtraForm
    {
        decimal toplamtutar;
        ProCustomerDBEntities entities = Program.entities;
        List<SiparisDetayData> eklenenur = new List<SiparisDetayData>();
        List<SiparisDetayData> eksilenur = new List<SiparisDetayData>();
        List<SiparisDetayData> eklenenurunler = new List<SiparisDetayData>();
        Sipari SIPARIS = null;
        public _11SiparisEkleDegistirForm()
        {
            InitializeComponent();
            Doldur();
        }

        public _11SiparisEkleDegistirForm(Sipari siparis)
        {
            InitializeComponent();
            SIPARIS = siparis;
            DuzenleDataDoldur();
        }

        public _11SiparisEkleDegistirForm(Sipari siparis, Musteri mus)
        {
            InitializeComponent();
            musteridoldur1();
            cmbAdUnvan.SelectedItem = mus;
            UrunDoldur();
            DataLoad.UrunTreeDoldur(treUrunGrup, null);
            treUrunGrup.ExpandAll();
        }

        private void treCesit_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                lstUrun.DisplayMember = "UrunAdi";
                lstUrun.ValueMember = "ID";
                UrunGrup secilen = e.Node.Tag as UrunGrup;
                if (secilen.AltGrupID == null)
                {

                    List<int> dizi = entities.UrunGrups.ToList().Where(a => a.AltGrupID == secilen.ID).Select(a => a.ID).ToList();
                    lstUrun.DataSource = entities.Uruns.ToList().Where(a => a.UrunGrup != null && (a.UrunGrup.ID == secilen.ID || (dizi.Contains((int)a.UrunGrup.ID)))).ToArray();
                }
                else
                {
                    lstUrun.DataSource = entities.Uruns.ToList().Where(a => a.UrunGrup.ID == secilen.ID).ToArray();
                }
            }
        }

        #region click grubu

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbAdUnvan.SelectedIndex != -1)
            {
                try
                {
                    if (SIPARIS == null)
                    {
                        decimal toplamm = 0;
                        int idd = (cmbAdUnvan.SelectedItem as Musteri).ID;
                        Musteri muss = entities.Musteris.First(a => a.ID == idd);
                        if (muss.ParaPuan > 0)
                        {
                            if (_BildirimForm2.Goster(muss.ParaPuan.ToString() + " Para Puanınız Var Kullanmak İstermisiniz?").SONUC)
                            {
                                toplamm = (eklenenurunler.Sum(a => a.Toplam)) - Convert.ToDecimal(muss.ParaPuan);
                                Musteri odenen = entities.Musteris.First(a => a.ID == idd);
                                odenen.ParaPuan = 0;
                            }
                            else
                            {
                                toplamm = eklenenurunler.Sum(a => a.Toplam);
                            }
                        }

                        Sipari yenisiparis = new Sipari
                        {
                            SiparisTarih = dtpTarih.Value,
                            TeslimTarih = dtpTeslimatTarih.Value,
                            Aciklama = txtAciklama.Text,
                            Ad_Unvan = cmbAdUnvan.Text,
                            Telefon = lblTelefonNo.Text,
                            TeslimAdres = txtTAdresi.Text,
                            TahsilEdildi = chkTahsilEdildi.Checked,
                            TeslimEdildi = chkTEdildi.Checked,
                            SiparisTutar = toplamm,
                            TaksitliSatis = false,
                        };
                        yenisiparis.PersonelReference.EntityKey = new EntityKey("ProCustomerDBEntities.Personels", "ID", (cmbPersonel.SelectedItem as Personel).ID);
                        yenisiparis.SiparisDurumReference.EntityKey = new EntityKey("ProCustomerDBEntities.SiparisDurums", "ID", (cmbSDurum.SelectedItem as SiparisDurum).ID);
                        yenisiparis.MusteriReference.EntityKey = new EntityKey("ProCustomerDBEntities.Musteris", "ID", (cmbAdUnvan.SelectedItem as Musteri).ID);
                        entities.AddToSiparis(yenisiparis);
                        entities.SaveChanges(true);

                        foreach (var item in eklenenurunler)
                        {
                            SiparisDetay siparisdetay = new SiparisDetay
                            {
                                Adet = item.Adet,
                                Fiyat = item.Fiyat,
                                KdvOran = item.KdvOran,
                                KdvTutar = item.KdvTutar,
                                Sipari = yenisiparis,
                                Toplam = item.Toplam,
                                Urun = entities.Uruns.Where(a => a.UrunAdi == item.Urun).First(),
                            };
                            entities.AddToSiparisDetays(siparisdetay);
                        }

                        KasaIslem yenikasa = new KasaIslem
                        {
                            Aciklama = txtAciklama.Text,
                            Ad_Unvan = cmbAdUnvan.Text,
                            GirisCikis = true,
                            Kasa = entities.Kasas.First(),
                            OdemeTip = entities.OdemeTips.First(a => a.ID == 3),
                            Personel = cmbPersonel.SelectedItem as Personel,
                            Tarih = DateTime.Now,
                            Tutar = eklenenurunler.Sum(a => a.Toplam),
                        };
                        yenikasa.MusteriReference.EntityKey = new EntityKey("ProCustomerDBEntities.Musteris", "ID", (cmbAdUnvan.SelectedItem as Musteri).ID);
                        entities.AddToKasaIslems(yenikasa);

                        foreach (var item in eklenenurunler)
                        {
                            UrunStok stok = new UrunStok
                            {
                                Miktar = item.Adet,
                                Giris = false,
                                Kasa = entities.Kasas.First(),
                                Urun = entities.Uruns.Where(a => a.UrunAdi == item.Urun).First(),
                            };
                            entities.AddToUrunStoks(stok);
                        }

                        decimal toplam = eklenenurunler.Sum(a => a.Toplam);
                        List<ParaPuan> sorgu = entities.ParaPuans.Where(a => a.AlisverisTutari <= toplam).OrderByDescending(a => a.AlisverisTutari).ToList();
                        int puan;
                        if (sorgu.Count == 0)
                        {
                            puan = 0;
                        }
                        else
                        {
                            puan = sorgu[0].KarsiligiParaPuan;
                        }

                        int id = (cmbAdUnvan.SelectedItem as Musteri).ID;
                        Musteri mus = entities.Musteris.First(a => a.ID == id);
                        mus.ParaPuan = (mus.ParaPuan == null ? 0 : mus.ParaPuan) + puan;
                        entities.SaveChanges(true);
                    }
                    else
                    {
                        Sipari duzenle = entities.Siparis.First(a => a.ID == SIPARIS.ID);
                        duzenle.SiparisTarih = dtpTarih.Value;
                        duzenle.TeslimTarih = dtpTeslimatTarih.Value;
                        duzenle.Aciklama = txtAciklama.Text;
                        duzenle.Ad_Unvan = cmbAdUnvan.Text;
                        duzenle.Telefon = lblTelefonNo.Text;
                        duzenle.TeslimAdres = txtTAdresi.Text;
                        duzenle.TahsilEdildi = chkTahsilEdildi.Checked;
                        duzenle.TeslimEdildi = chkTEdildi.Checked;
                        duzenle.TaksitliSatis = false;

                        duzenle.SiparisDurumReference.EntityKey = new EntityKey("ProCustomerDBEntities.SiparisDurums", "ID", (cmbSDurum.SelectedItem as SiparisDurum).ID);
                        duzenle.MusteriReference.EntityKey = new EntityKey("ProCustomerDBEntities.Musteris", "ID", (cmbAdUnvan.SelectedItem as Musteri).ID);

                        List<SiparisDetay> dirtydizi = new List<SiparisDetay>();
                        dirtydizi.AddRange(entities.SiparisDetays.Include("Urun").Where(a => a.Sipari.ID == SIPARIS.ID));
                        foreach (var item in dirtydizi)
                        {
                            entities.DeleteObject(item);
                        }
                        foreach (var item in eklenenurunler)
                        {
                            SiparisDetay siparisdetay = new SiparisDetay
                            {
                                Adet = item.Adet,
                                Fiyat = item.Fiyat,
                                KdvOran = item.KdvOran,
                                KdvTutar = item.KdvTutar,
                                Sipari = duzenle,
                                Toplam = item.Toplam,
                                Urun = entities.Uruns.Where(a => a.UrunAdi == item.Urun).First(),
                            };
                            entities.AddToSiparisDetays(siparisdetay);

                        }
                        decimal fark = eklenenurunler.Sum(a => a.Toplam) - toplamtutar;
                        KasaIslem upd;
                        try
                        {
                            upd = entities.KasaIslems.Where(a => a.Musteri.ID == SIPARIS.Musteri.ID && a.Tarih.Day == SIPARIS.SiparisTarih.Day && a.Tarih.Month == SIPARIS.SiparisTarih.Month && a.Tarih.Year == SIPARIS.SiparisTarih.Year && a.Tutar == toplamtutar).First();
                            upd.Tutar = eklenenurunler.Sum(a => a.Toplam);
                        }
                        catch
                        {

                        }

                        if (_BildirimForm2.Goster(fark.ToString("C") + " fark ödenecektir işleme devam etmek istiyor musunuz?").SONUC)
                        {
                            foreach (SiparisDetayData item in eklenenur)
                            {
                                UrunStok ekle = new UrunStok
                                {
                                    Urun = entities.Uruns.Where(a => a.UrunAdi == item.Urun).First(),
                                    Miktar = item.Adet,
                                    Giris = false,
                                    Kasa = entities.Kasas.First(),
                                };
                                entities.AddToUrunStoks(ekle);
                            }
                            foreach (SiparisDetayData item in eksilenur)
                            {
                                UrunStok ekle = new UrunStok
                                {
                                    Urun = entities.Uruns.Where(a => a.UrunAdi == item.Urun).First(),
                                    Miktar = item.Adet,
                                    Giris = true,
                                    Kasa = entities.Kasas.First(),
                                };
                                entities.AddToUrunStoks(ekle);
                            }
                            entities.SaveChanges(true);
                        }
                        else
                        {
                            entities.Refresh(RefreshMode.StoreWins, entities.KasaIslems);
                            this.Close();
                            return;
                        }
                    }
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
                _BildirimForm1.Goster(cmbAdUnvan.Text + " Adında bir müşteri kaydı bulunmamaktadır!.");
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            grdHesapMain.ShowRibbonPrintPreview();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _21MusteriEkleDegistirForm frm = new _21MusteriEkleDegistirForm() { };
            frm.FormClosed += delegate
            {
                cmbAdUnvan.DataSource = null;
                Thread.Sleep(1);
                MusteriDoldur();
            };
            frm.ShowDialog();
        }

        private void btnUEkle_Click(object sender, EventArgs e)
        {
            if (SIPARIS == null)
            {
                if (string.IsNullOrEmpty(txtBarkod.Text))
                {
                    if (lstUrun.SelectedItem == null)
                    {
                        _BildirimForm1.Goster("Kayıt bulunamadı!");
                    }
                    else
                    {
                        Urun secilen = lstUrun.SelectedItem as Urun;
                        ListeUrunEkle(secilen);
                    }
                }
                else
                {
                    IEnumerable<Urun> urunler = entities.Uruns.Where(a => a.Barkod == txtBarkod.Text);
                    if (urunler.Count() == 1)
                    {
                        Urun secilen = urunler.First();
                        ListeUrunEkle(secilen);
                    }
                    else
                    {
                        _BildirimForm1.Goster("Belirtilen barkod numaralı ürün bulunamadı!");
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtBarkod.Text))
                {
                    if (lstUrun.SelectedItem == null)
                    {
                        _BildirimForm1.Goster("Kayıt bulunamadı!");
                    }
                    else
                    {
                        Urun secilen = lstUrun.SelectedItem as Urun;
                        ListeUrunEkle(secilen);
                    }
                }
                else
                {
                    IEnumerable<Urun> urunler = entities.Uruns.Where(a => a.Barkod == txtBarkod.Text);
                    if (urunler.Count() == 1)
                    {
                        Urun secilen = urunler.First();
                        ListeUrunEkle(secilen);
                    }
                    else
                    {
                        _BildirimForm1.Goster("Belirtilen barkod numaralı ürün bulunamadı!");
                    }
                }
            }
            txtBarkod.Clear();
            UrunDoldur();
            txtBarkod.Focus();
        }

        private void btnUSil_Click(object sender, EventArgs e)
        {
            if (grdHesap.GetFocusedRow() == null)
            {
                _BildirimForm1.Goster("Kayıt bulunamadı!");
            }
            else
            {
                if (_BildirimForm2.Goster("Silmek istediğinizden emin misiniz?").SONUC)
                {
                    string secilen1 = (grdHesap.GetFocusedRowCellValue("Urun")).ToString();
                    int secilen = entities.Uruns.Where(a => a.UrunAdi == secilen1).Select(a => a.ID).First();
                    ListeUrunSil(secilen1);
                    UrunDoldur();
                }
            }
            lblKDVTutar.Text = eklenenurunler.Sum(a => a.KdvTutar).ToString("C");
            lblTTutar.Text = eklenenurunler.Sum(a => a.Toplam).ToString("C");
        }

        private void btnFiyat_Click(object sender, EventArgs e)
        {
            if (grdHesap.GetFocusedRow() == null)
            {
                _BildirimForm1.Goster("Kayıt bulunamadı!");
            }
            else
            {
                SiparisDetayData secilen = grdHesap.GetFocusedRow() as SiparisDetayData;
                new _12FiyatSecForm(secilen, this) { }.ShowDialog();
            }
        }

        private void btnTahsilatEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnTahsilatSil_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region metod grubu

        public void Doldur()
        {
            cmbSDurum.DisplayMember = "Durum";
            cmbSDurum.ValueMember = "ID";
            cmbSDurum.DataSource = entities.SiparisDurums;

            MusteriDoldur();

            cmbPersonel.DisplayMember = "AdSoyad";
            cmbPersonel.ValueMember = "ID";
            cmbPersonel.DataSource = entities.Personels;

            DataLoad.UrunTreeDoldur(treUrunGrup, null);
            treUrunGrup.ExpandAll();
            treUrunGrup.SelectedNode = treUrunGrup.Nodes[0];
        }

        private void DuzenleDataDoldur()
        {
            cmbSDurum.DisplayMember = "Durum";
            cmbSDurum.ValueMember = "ID";
            cmbSDurum.DataSource = entities.SiparisDurums;

            cmbAdUnvan.DisplayMember = "Ad_Unvan";
            cmbAdUnvan.ValueMember = "ID";
            cmbAdUnvan.DataSource = entities.Musteris;
            cmbAdUnvan.AutoCompleteCustomSource.AddRange(entities.Musteris.Select(a => a.Ad_Unvan).ToArray());

            cmbAdUnvan.SelectedItem = SIPARIS.Musteri;
            cmbSDurum.SelectedItem = SIPARIS.SiparisDurum;
            cmbTeslimatci.SelectedItem = SIPARIS.Personel;
            dtpTarih.Value = SIPARIS.SiparisTarih;
            dtpTeslimatTarih.Value = SIPARIS.TeslimTarih;
            txtAciklama.Text = SIPARIS.Aciklama;
            cmbAdUnvan.SelectedText = SIPARIS.Ad_Unvan;
            lblTelefonNo.Text = SIPARIS.Telefon;
            txtTAdresi.Text = SIPARIS.TeslimAdres;
            chkTahsilEdildi.Checked = SIPARIS.TahsilEdildi;
            chkTEdildi.Checked = SIPARIS.TeslimEdildi;
            List<SiparisDetayData> datadizi = new List<SiparisDetayData>();
            foreach (var item in entities.SiparisDetays.Include("Urun").Where(a => a.Sipari.ID == SIPARIS.ID && a.Urun != null))
            {
                datadizi.Add(new SiparisDetayData
                {
                    ID = item.ID,
                    Adet = item.Adet,
                    Fiyat = item.Fiyat,
                    KdvOran = item.KdvOran,
                    KdvTutar = item.KdvTutar,
                    Toplam = item.Toplam,
                    Urun = item.Urun.UrunAdi,
                    Acıklama = item.Aciklama,
                });
            }
            eklenenurunler.AddRange(datadizi);
            lblKDVTutar.Text = SIPARIS.SiparisDetays.Sum(a => a.KdvTutar).ToString("C");
            lblTTutar.Text = SIPARIS.SiparisDetays.Sum(a => a.Toplam).ToString("C");
            UrunDoldur();
            DataLoad.UrunTreeDoldur(treUrunGrup, null);
            treUrunGrup.ExpandAll();
            treUrunGrup.SelectedNode = treUrunGrup.Nodes[0];
            toplamtutar = eklenenurunler.Sum(a => a.Toplam);
        }

        public void MusteriDoldur()
        {
            ProCustomerDBEntities en = new ProCustomerDBEntities();
            cmbAdUnvan.DisplayMember = "Ad_Unvan";
            cmbAdUnvan.ValueMember = "ID";
            cmbAdUnvan.DataSource = en.Musteris.Include("Bolge");
            cmbAdUnvan.AutoCompleteCustomSource.AddRange(entities.Musteris.Select(a => a.Ad_Unvan).ToArray());
        }

        public void musteridoldur1()
        {
            cmbAdUnvan.DisplayMember = "Ad_Unvan";
            cmbAdUnvan.ValueMember = "ID";
            cmbAdUnvan.DataSource = entities.Musteris;
            cmbAdUnvan.AutoCompleteCustomSource.AddRange(entities.Musteris.Select(a => a.Ad_Unvan).ToArray());
        }

        public void UrunDoldur()
        {
            grdHesapMain.DataSource = null;
            grdHesapMain.DataSource = eklenenurunler;//.Select(a => new { a.ID, a.Urun.UrunAdi, a.Adet, a.Fiyat, a.KdvOran, a.KdvTutar, a.Toplam, a.Acıklama }).ToArray();
            grdHesap.Columns[0].Visible = false;
        }

        private void ListeUrunEkle(Urun secilen)
        {
            if (SIPARIS != null)
            {
                SiparisDetayData eelenecek = new SiparisDetayData
                {
                    Adet = 0,
                    Urun = secilen.UrunAdi,
                };
                eklenenur.Add(eelenecek);
            }

            IEnumerable<SiparisDetayData> detaylar = eklenenurunler.Where(a => a.Urun == secilen.UrunAdi);
            IEnumerable<SiparisDetayData> detaylar1 = eklenenur.Where(a => a.Urun == secilen.UrunAdi);
            if (detaylar.Count() == 0)
            {
                decimal fiyat = 0;
                Musteri gelen = cmbAdUnvan.SelectedItem as Musteri;
                int sec;
                try
                {
                    sec = entities.Musteris.Where(a => a.ID == gelen.ID && a.Bolge != null).Select(a => a.Bolge.FiyatKademe).First();
                }
                catch
                {
                    sec = 0;
                }

                switch (sec)
                {
                    case 0:
                        fiyat = secilen.Fiyat1;
                        break;
                    case 1:
                        fiyat = secilen.Fiyat1;
                        break;
                    case 2:
                        fiyat = secilen.Fiyat2;
                        break;
                    case 3:
                        fiyat = secilen.Fiyat3;
                        break;
                    case 4:
                        fiyat = secilen.Fiyat4;
                        break;
                    case 5:
                        fiyat = secilen.Fiyat5;
                        break;
                    case 6:
                        fiyat = secilen.Fiyat6;
                        break;

                    default:
                        break;
                }
                eklenenurunler.Add(new SiparisDetayData
                {
                    Fiyat = fiyat,
                    KdvOran = secilen.KdvOran,
                    Urun = secilen.UrunAdi,
                    KdvTutar = secilen.KdvDahil ? (fiyat - (fiyat / (1 + (fiyat / (decimal)100)))) : (fiyat * (secilen.KdvOran / (decimal)100)),
                    Adet = 1,
                    Toplam = fiyat * 1,

                });
                if (SIPARIS != null)
                {
                    eklenenur.Add(new SiparisDetayData
                    {
                        Fiyat = fiyat,
                        KdvOran = secilen.KdvOran,
                        Urun = secilen.UrunAdi,
                        KdvTutar = secilen.KdvDahil ? (fiyat - (fiyat / (1 + (fiyat / (decimal)100)))) : (fiyat * (secilen.KdvOran / (decimal)100)),
                        Adet = 1,
                        Toplam = fiyat * 1,

                    });
                }
            }
            else
            {
                SiparisDetayData detay = detaylar.First();
                detay.Adet++;
                detay.Toplam = detay.Fiyat * detay.Adet;
                detay.KdvTutar = secilen.KdvDahil ? (detay.Toplam - (detay.Toplam / (1 + (secilen.KdvOran / (decimal)100)))) : (detay.Toplam * (secilen.KdvOran / (decimal)100));
                if (SIPARIS != null)
                {
                    SiparisDetayData detay1 = detaylar1.First();
                    detay1.Adet++;
                    detay1.Toplam = detay1.Fiyat * detay1.Adet;
                    detay1.KdvTutar = secilen.KdvDahil ? (detay1.Toplam - (detay1.Toplam / (1 + (secilen.KdvOran / (decimal)100)))) : (detay1.Toplam * (secilen.KdvOran / (decimal)100));
                }
            }
            lblKDVTutar.Text = eklenenurunler.Sum(a => a.KdvTutar).ToString("C");
            lblTTutar.Text = eklenenurunler.Sum(a => a.Toplam).ToString("C");
        }

        private void ListeUrunSil(string secilen1)
        {
            if (SIPARIS != null)
            {
                SiparisDetayData yeni = new SiparisDetayData
                {
                    Urun = secilen1,
                    Adet = 0,
                };
                eksilenur.Add(yeni);
            }
            SiparisDetayData secilen = eklenenurunler.Where(a => a.Urun == secilen1).First();
            if (secilen.Adet > 1)
            {
                Urun urn = entities.Uruns.First(a => a.UrunAdi == secilen.Urun);
                secilen.Adet--;
                secilen.Toplam = secilen.Fiyat * secilen.Adet;
                secilen.KdvTutar = urn.KdvDahil ? (secilen.Toplam - (secilen.Toplam / (1 + (secilen.KdvOran / (decimal)100)))) : (secilen.Toplam * (secilen.KdvOran / (decimal)100));
                if (SIPARIS != null)
                {
                    IEnumerable<SiparisDetayData> eksil = eksilenur.Where(a => a.Urun == secilen1);
                    SiparisDetayData eksildi = eksil.First();
                    eksildi.Adet++;
                }
            }
            else
            {
                eklenenurunler.Remove(secilen);
                IEnumerable<SiparisDetayData> eksil = eksilenur.Where(a => a.Urun == secilen1);
                SiparisDetayData eksildi = eksil.First();
                eksildi.Adet++;
            }
        }
        #endregion

        private void cmbAdUnvan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtTAdresi.Text = entities.Musteris.Where(a => a.Ad_Unvan == cmbAdUnvan.Text).Select(a => a.Adres).First();
                lblTelefonNo.Text = entities.Musteris.Where(a => a.Ad_Unvan == cmbAdUnvan.Text).Select(a => a.Telefon1).First();
            }
            catch
            { }
        }

        private void btnTermal_Click(object sender, EventArgs e)
        {
            dcm.Print();
        }

        private void dcm_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            pageSetupDialog1.PageSettings.Margins.Top = 20;
            pageSetupDialog1.PageSettings.Margins.Left = 10;
            pageSetupDialog1.PageSettings.Margins.Bottom = 10;
            
            e.Graphics.DrawString(cmbAdUnvan.Text + " " + DateTime.Now.ToString(), new Font("Arial", 8), new SolidBrush(Color.Black), new Point(10, 20));
            e.Graphics.DrawString("-----------------------------", new Font("Arial", 8), new SolidBrush(Color.Black), new Point(10, 30));
            e.Graphics.DrawString("-----------------------------", new Font("Arial", 8), new SolidBrush(Color.Black), new Point(10, 40));
            e.Graphics.DrawString("Urun Adet Fiyat", new Font("Arial", 8), new SolidBrush(Color.Black), new Point(10, 50));

            int nokta = 60;
            for (int i = 0; i < grdHesap.RowCount; i++)
            {
                SiparisDetayData u = grdHesap.GetRow(i) as SiparisDetayData;
                e.Graphics.DrawString(u.Urun, new Font("Arial", 8), new SolidBrush(Color.Black), new Point(10, nokta));
                e.Graphics.DrawString(u.Adet.ToString() + " Adet" + " Tutar: " + u.Toplam.ToString(), new Font("Arial", 8), new SolidBrush(Color.Black), new Point(10, nokta + 10));
                e.Graphics.DrawString("", new Font("Arial", 8), new SolidBrush(Color.Black), new Point(10, nokta + 10));
                nokta += 30;
            }

            nokta += 10;
            e.Graphics.DrawString(".................................", new Font("Arial", 8), new SolidBrush(Color.Black), new Point(10, nokta));
            nokta += 10;
            e.Graphics.DrawString("TOPLAM : " + lblTTutar.Text, new Font("Arial", 8), new SolidBrush(Color.Black), new Point(10, nokta));
            nokta += 10;
            e.Graphics.DrawString("", new Font("Arial", 8), new SolidBrush(Color.Black), new Point(10, nokta));
            nokta += 10;
            e.Graphics.DrawString(txtTAdresi.Text, new Font("Arial", 8), new SolidBrush(Color.Black), new Point(10, nokta));
            nokta += 10;
            e.Graphics.DrawString(txtAciklama.Text, new Font("Arial", 8), new SolidBrush(Color.Black), new Point(10, nokta));
        }
    }
}
