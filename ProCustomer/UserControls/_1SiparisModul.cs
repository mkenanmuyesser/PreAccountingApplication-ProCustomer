using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using ProCustomer.Classes;
using ProCustomer.Forms;

namespace ProCustomer.UserControls
{
    public partial class _1SiparisModul : UserControl
    {
        AnaForm FRM;
        ProCustomerDBEntities entities = Program.entities;
        public _1SiparisModul(AnaForm frm)
        {
            InitializeComponent();
            FRM = frm;
        }

        private void SiparisModul_Load(object sender, EventArgs e)
        {
            cmbSatisTipi.SelectedIndex = 0;
            dtpBaslangic.Value = DateTime.Now.Date;
            dtpBitis.Value = DateTime.Now.Date.AddDays(1).AddMinutes(-1);
            lblCallerId.Text = "Cihaz bağlantısı bekleniyor...";

            List<SiparisDurum> son = new List<SiparisDurum>();
            SiparisDurum olustur = new SiparisDurum
            {
                Durum = "Tümü",
            };
            son.Add(olustur);
            foreach (SiparisDurum item in entities.SiparisDurums)
            {
                son.Add(item);
            }

            cmbSiparisDurum.DisplayMember = "Durum";
            cmbSiparisDurum.ValueMember = "ID";
            cmbSiparisDurum.DataSource = son;
            cmbSiparisDurum.SelectedIndex = 0;
            Doldur();
        }

        private void CallerTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                //if (FRM.axCIDv51.Command("Devicemodel") == null)
                //    lblCallerId.Text = "Cihaz bağlantısı bekleniyor...";
                //else
                //    lblCallerId.Text = "Cihaz bağlantısı kuruldu.";
            }
            catch
            {

            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        public void Doldur()
        {
            SiparisDurum durum = cmbSiparisDurum.SelectedItem as SiparisDurum;
            string arama = txtAdUnvan.Text;
            DateTime baslangic = dtpBaslangic.Value;
            DateTime bitis = dtpBitis.Value;
            grdSiparisMain.DataSource = null;
            entities.Refresh(RefreshMode.StoreWins, entities.Siparis);
            List<SiparisData> datadizi = new List<SiparisData>();

            if (string.IsNullOrEmpty(arama))
            {
                switch (cmbSatisTipi.SelectedIndex)
                {
                    case 0:
                        if (cmbSiparisDurum.Text == "Tümü")
                        {
                            var sorgu1 = entities.Siparis.Where(a => a.SiparisTarih >= baslangic && a.SiparisTarih <= bitis && a.Musteri != null).Select(a => new { a.ID, a.SiparisDurum, a.SiparisDurum.Durum, a.SiparisTarih, a.Ad_Unvan, a.Telefon, a.TeslimAdres, a.Aciklama }).OrderByDescending(a => a.SiparisTarih);
                            foreach (var item in sorgu1)
                            {
                                Musteri mus = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.Musteri).First();
                                decimal toplam = 0;
                                try
                                {
                                    toplam = entities.SiparisDetays.Where(a => a.Sipari.ID == item.ID).Sum(a => a.Toplam);
                                }
                                catch
                                {
                                    toplam = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.SiparisTutar).First();
                                }

                                datadizi.Add(new SiparisData
                                {
                                    Açıklama = item.Aciklama,
                                    Ad_Unvan = mus.Ad_Unvan,
                                    Adres = mus.Adres,
                                    ID = item.ID,
                                    SiparişDurum = item.Durum == null ? "Taksitli Satış" : item.Durum,
                                    SiparişTarih = item.SiparisTarih,
                                    Telefon = mus.Telefon1,
                                    Tutar = toplam.ToString("C"),
                                });
                            }
                            grdSiparisMain.DataSource = datadizi.ToList();
                        }
                        else
                        {
                            var sorgu1 = entities.Siparis.Where(a => a.SiparisDurum.ID == cmbSiparisDurum.SelectedIndex && a.SiparisTarih >= baslangic && a.SiparisTarih <= bitis && a.Musteri != null).Select(a => new { a.ID, a.SiparisDurum, a.SiparisDurum.Durum, a.SiparisTarih, a.Ad_Unvan, a.Telefon, a.TeslimAdres, a.Aciklama }).OrderByDescending(a => a.SiparisTarih);
                            foreach (var item in sorgu1)
                            {
                                Musteri mus = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.Musteri).First();
                                decimal toplam = 0;
                                try
                                {
                                    toplam = entities.SiparisDetays.Where(a => a.Sipari.ID == item.ID).Sum(a => a.Toplam);
                                }
                                catch
                                {
                                    toplam = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.SiparisTutar).First();
                                }

                                datadizi.Add(new SiparisData
                                {
                                    Açıklama = item.Aciklama,
                                    Ad_Unvan = mus.Ad_Unvan,
                                    Adres = mus.Adres,
                                    ID = item.ID,
                                    SiparişDurum = item.Durum == null ? "Taksitli Satış" : item.Durum,
                                    SiparişTarih = item.SiparisTarih,
                                    Telefon = mus.Telefon1,
                                    Tutar = toplam.ToString("C"),
                                });
                            }
                            grdSiparisMain.DataSource = datadizi.ToList();
                        }

                        break;
                    case 1:
                        var sorgu2 = entities.Siparis.Where(a => a.SiparisDurum == null && a.SiparisTarih >= baslangic && a.SiparisTarih <= bitis && a.TaksitliSatis == true && a.Musteri != null).Select(a => new { a.ID, a.SiparisDurum.Durum, a.SiparisTarih, a.Ad_Unvan, a.Telefon, a.SiparisDurum, a.TeslimAdres, a.Aciklama }).OrderByDescending(a => a.SiparisTarih);
                        foreach (var item in sorgu2)
                        {
                            Musteri mus = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.Musteri).First();
                            decimal toplam = 0;
                            try
                            {
                                toplam = entities.SiparisDetays.Where(a => a.Sipari.ID == item.ID).Sum(a => a.Toplam);
                            }
                            catch
                            {
                                toplam = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.SiparisTutar).First();
                            }

                            datadizi.Add(new SiparisData
                            {
                                Açıklama = item.Aciklama,
                                Ad_Unvan = mus.Ad_Unvan,
                                Adres = mus.Adres,
                                ID = item.ID,
                                SiparişDurum = item.Durum == null ? "Taksitli Satış" : item.Durum,
                                SiparişTarih = item.SiparisTarih,
                                Telefon = mus.Telefon1,
                                Tutar = toplam.ToString("C"),
                            });
                        }
                        grdSiparisMain.DataSource = datadizi.ToList();
                        break;
                    case 2:
                        if (cmbSiparisDurum.Text == "Tümü")
                        {
                            var sorgu3 = entities.Siparis.Where(a => a.SiparisDurum != null && a.SiparisTarih >= baslangic && a.SiparisTarih <= bitis && a.TaksitliSatis == false && a.Musteri != null).Select(a => new { a.ID, a.SiparisDurum.Durum, a.SiparisTarih, a.Ad_Unvan, a.Telefon, a.TeslimAdres, a.SiparisDurum, a.Aciklama }).OrderByDescending(a => a.SiparisTarih);
                            foreach (var item in sorgu3)
                            {
                                Musteri mus = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.Musteri).First();
                                decimal toplam = 0;
                                try
                                {
                                    toplam = entities.SiparisDetays.Where(a => a.Sipari.ID == item.ID).Sum(a => a.Toplam);
                                }
                                catch
                                {
                                    toplam = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.SiparisTutar).First();
                                }

                                datadizi.Add(new SiparisData
                                {
                                    Açıklama = item.Aciklama,
                                    Ad_Unvan = mus.Ad_Unvan,
                                    Adres = mus.Adres,
                                    ID = item.ID,
                                    SiparişDurum = item.Durum == null ? "Taksitli Satış" : item.Durum,
                                    SiparişTarih = item.SiparisTarih,
                                    Telefon = mus.Telefon1,
                                    Tutar = toplam.ToString("C"),
                                });
                            }
                            grdSiparisMain.DataSource = datadizi.ToList();
                        }
                        else
                        {
                            var sorgu3 = entities.Siparis.Where(a => a.SiparisDurum.ID == cmbSiparisDurum.SelectedIndex && a.SiparisDurum != null && a.SiparisTarih >= baslangic && a.SiparisTarih <= bitis && a.TaksitliSatis == false && a.Musteri != null).Select(a => new { a.ID, a.SiparisDurum.Durum, a.SiparisTarih, a.Ad_Unvan, a.Telefon, a.TeslimAdres, a.SiparisDurum, a.Aciklama }).OrderByDescending(a => a.SiparisTarih);
                            foreach (var item in sorgu3)
                            {
                                Musteri mus = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.Musteri).First();
                                decimal toplam = 0;
                                try
                                {
                                    toplam = entities.SiparisDetays.Where(a => a.Sipari.ID == item.ID).Sum(a => a.Toplam);
                                }
                                catch
                                {
                                    toplam = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.SiparisTutar).First();
                                }

                                datadizi.Add(new SiparisData
                                {
                                    Açıklama = item.Aciklama,
                                    Ad_Unvan = mus.Ad_Unvan,
                                    Adres = mus.Adres,
                                    ID = item.ID,
                                    SiparişDurum = item.Durum == null ? "Taksitli Satış" : item.Durum,
                                    SiparişTarih = item.SiparisTarih,
                                    Telefon = mus.Telefon1,
                                    Tutar = toplam.ToString("C"),
                                });
                            }
                            grdSiparisMain.DataSource = datadizi.ToList();
                        }
                        break;
                }
            }
            else
            {
                switch (cmbSatisTipi.SelectedIndex)
                {
                    case 0:
                        if (cmbSiparisDurum.Text == "Tümü")
                        {
                            var sorgu1 = entities.Siparis.Where(a => a.Ad_Unvan.Contains(arama) && a.SiparisTarih >= baslangic && a.SiparisTarih <= bitis && a.TaksitliSatis == false && a.Musteri != null).Select(a => new { a.ID, a.SiparisDurum.Durum, a.SiparisTarih, a.Ad_Unvan, a.Telefon, a.SiparisDurum, a.TeslimAdres, a.Aciklama }).OrderByDescending(a => a.SiparisTarih);
                            foreach (var item in sorgu1)
                            {
                                decimal toplam = 0;
                                try
                                {
                                    toplam = entities.SiparisDetays.Where(a => a.Sipari.ID == item.ID).Sum(a => a.Toplam);
                                }
                                catch
                                {
                                    toplam = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.SiparisTutar).First();
                                }

                                datadizi.Add(new SiparisData
                                {
                                    Açıklama = item.Aciklama,
                                    Ad_Unvan = item.Ad_Unvan,
                                    Adres = item.TeslimAdres,
                                    ID = item.ID,
                                    SiparişDurum = item.Durum,
                                    SiparişTarih = item.SiparisTarih,
                                    Telefon = item.Telefon,
                                    Tutar = toplam.ToString("C"),
                                });
                            }
                            grdSiparisMain.DataSource = datadizi.ToList();
                        }
                        else
                        {
                            var sorgu1 = entities.Siparis.Where(a => a.SiparisDurum.ID == cmbSiparisDurum.SelectedIndex && a.Ad_Unvan.Contains(arama) && a.SiparisTarih >= baslangic && a.SiparisTarih <= bitis && a.TaksitliSatis == false && a.Musteri != null).Select(a => new { a.ID, a.SiparisDurum.Durum, a.SiparisTarih, a.Ad_Unvan, a.Telefon, a.SiparisDurum, a.TeslimAdres, a.Aciklama }).OrderByDescending(a => a.SiparisTarih);
                            foreach (var item in sorgu1)
                            {
                                decimal toplam = 0;
                                try
                                {
                                    toplam = entities.SiparisDetays.Where(a => a.Sipari.ID == item.ID).Sum(a => a.Toplam);
                                }
                                catch
                                {
                                    toplam = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.SiparisTutar).First();
                                }

                                datadizi.Add(new SiparisData
                                {
                                    Açıklama = item.Aciklama,
                                    Ad_Unvan = item.Ad_Unvan,
                                    Adres = item.TeslimAdres,
                                    ID = item.ID,
                                    SiparişDurum = item.Durum,
                                    SiparişTarih = item.SiparisTarih,
                                    Telefon = item.Telefon,
                                    Tutar = toplam.ToString("C"),
                                });
                            }
                            grdSiparisMain.DataSource = datadizi.ToList();
                        }
                        break;
                    case 1:
                        if (cmbSiparisDurum.Text == "Tümü")
                        {
                            var sorgu2 = entities.Siparis.Where(a => a.Ad_Unvan.Contains(arama) && a.SiparisDurum == null && a.SiparisTarih >= baslangic && a.SiparisTarih <= bitis && a.TaksitliSatis == false && a.Musteri != null).Select(a => new { a.ID, a.SiparisDurum.Durum, a.SiparisTarih, a.SiparisDurum, a.Ad_Unvan, a.Telefon, a.TeslimAdres, a.Aciklama }).OrderByDescending(a => a.SiparisTarih);
                            foreach (var item in sorgu2)
                            {
                                decimal toplam = 0;
                                try
                                {
                                    toplam = entities.SiparisDetays.Where(a => a.Sipari.ID == item.ID).Sum(a => a.Toplam);
                                }
                                catch
                                {
                                    toplam = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.SiparisTutar).First();
                                }

                                datadizi.Add(new SiparisData
                                {
                                    Açıklama = item.Aciklama,
                                    Ad_Unvan = item.Ad_Unvan,
                                    Adres = item.TeslimAdres,
                                    ID = item.ID,
                                    SiparişDurum = item.Durum,
                                    SiparişTarih = item.SiparisTarih,
                                    Telefon = item.Telefon,
                                    Tutar = toplam.ToString("C"),
                                });
                            }
                            grdSiparisMain.DataSource = datadizi.ToList();
                        }
                        else
                        {
                            var sorgu2 = entities.Siparis.Where(a => a.SiparisDurum.ID == cmbSiparisDurum.SelectedIndex && a.Ad_Unvan.Contains(arama) && a.SiparisDurum == null && a.SiparisTarih >= baslangic && a.SiparisTarih <= bitis && a.TaksitliSatis == false && a.Musteri != null).Select(a => new { a.ID, a.SiparisDurum.Durum, a.SiparisTarih, a.SiparisDurum, a.Ad_Unvan, a.Telefon, a.TeslimAdres, a.Aciklama }).OrderByDescending(a => a.SiparisTarih);
                            foreach (var item in sorgu2)
                            {
                                decimal toplam = 0;
                                try
                                {
                                    toplam = entities.SiparisDetays.Where(a => a.Sipari.ID == item.ID).Sum(a => a.Toplam);
                                }
                                catch
                                {
                                    toplam = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.SiparisTutar).First();
                                }

                                datadizi.Add(new SiparisData
                                {
                                    Açıklama = item.Aciklama,
                                    Ad_Unvan = item.Ad_Unvan,
                                    Adres = item.TeslimAdres,
                                    ID = item.ID,
                                    SiparişDurum = item.Durum,
                                    SiparişTarih = item.SiparisTarih,
                                    Telefon = item.Telefon,
                                    Tutar = toplam.ToString("C"),
                                });
                            }
                            grdSiparisMain.DataSource = datadizi.ToList();
                        }
                        break;
                    case 2:
                        if (cmbSiparisDurum.Text == "Tümü")
                        {
                            var sorgu3 = entities.Siparis.Where(a => a.Ad_Unvan.Contains(arama) && a.SiparisDurum != null && a.SiparisTarih >= baslangic && a.SiparisTarih <= bitis && a.TaksitliSatis == false && a.Musteri != null).Select(a => new { a.ID, a.SiparisDurum.Durum, a.SiparisTarih, a.SiparisDurum, a.Ad_Unvan, a.Telefon, a.TeslimAdres, a.Aciklama }).OrderByDescending(a => a.SiparisTarih);
                            foreach (var item in sorgu3)
                            {
                                decimal toplam = 0;
                                try
                                {
                                    toplam = entities.SiparisDetays.Where(a => a.Sipari.ID == item.ID).Sum(a => a.Toplam);
                                }
                                catch
                                {
                                    toplam = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.SiparisTutar).First();
                                }

                                datadizi.Add(new SiparisData
                                {
                                    Açıklama = item.Aciklama,
                                    Ad_Unvan = item.Ad_Unvan,
                                    Adres = item.TeslimAdres,
                                    ID = item.ID,
                                    SiparişDurum = item.Durum,
                                    SiparişTarih = item.SiparisTarih,
                                    Telefon = item.Telefon,
                                    Tutar = toplam.ToString("C"),
                                });
                            }
                            grdSiparisMain.DataSource = datadizi.ToList();
                        }
                        else
                        {
                            var sorgu3 = entities.Siparis.Where(a => a.SiparisDurum.ID == cmbSiparisDurum.SelectedIndex && a.Ad_Unvan.Contains(arama) && a.SiparisDurum != null && a.SiparisTarih >= baslangic && a.SiparisTarih <= bitis && a.TaksitliSatis == false && a.Musteri != null).Select(a => new { a.ID, a.SiparisDurum.Durum, a.SiparisTarih, a.SiparisDurum, a.Ad_Unvan, a.Telefon, a.TeslimAdres, a.Aciklama }).OrderByDescending(a => a.SiparisTarih);
                            foreach (var item in sorgu3)
                            {
                                decimal toplam = 0;
                                try
                                {
                                    toplam = entities.SiparisDetays.Where(a => a.Sipari.ID == item.ID).Sum(a => a.Toplam);
                                }
                                catch
                                {
                                    toplam = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.SiparisTutar).First();
                                }

                                datadizi.Add(new SiparisData
                                {
                                    Açıklama = item.Aciklama,
                                    Ad_Unvan = item.Ad_Unvan,
                                    Adres = item.TeslimAdres,
                                    ID = item.ID,
                                    SiparişDurum = item.Durum,
                                    SiparişTarih = item.SiparisTarih,
                                    Telefon = item.Telefon,
                                    Tutar = toplam.ToString("C"),
                                });
                            }
                            grdSiparisMain.DataSource = datadizi.ToList();
                        }
                        break;
                }
            }


            grdSiparis.Columns["SiparişTarih"].DisplayFormat.FormatString = "dd.MM.yyyy HH:mm";
        }

        private void cmbSatisTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSatisTipi.SelectedIndex == 1)
            {
                cmbSiparisDurum.SelectedIndex = 0;
            }
        }

        private void grdSiparisMain_DoubleClick(object sender, EventArgs e)
        {
            SiparisData sprdata = grdSiparis.GetFocusedRow() as SiparisData;
            if (sprdata.SiparişDurum == "Taksitli Satış")
            {
                _13TaksitliSatisForm abc = new _13TaksitliSatisForm();
                abc.ShowDialog();
            }
            else
            {
                Sipari sprduz = entities.Siparis.Include("SiparisDurum").First(a => a.ID == sprdata.ID);
                int id = Convert.ToInt32(sprduz.SiparisDurumReference.EntityKey.EntityKeyValues.First().Value);
                int yakala = entities.SiparisDetays.Where(a => a.Sipari.ID == sprdata.ID).Count();
                if (entities.SiparisDetays.Where(a => a.Urun != null && a.Sipari.ID == sprduz.ID).Count() == yakala)
                {
                    _11SiparisEkleDegistirForm seklefrm2 = new _11SiparisEkleDegistirForm(sprduz) { };
                    seklefrm2.FormClosed += delegate
                    {
                        Doldur();
                    };
                    seklefrm2.ShowDialog();
                }
                else
                {
                    _BildirimForm1.Goster("UYARI bu kayıttan ürün silinmiştir detay eksik gösterilecektir.!");
                    _11SiparisEkleDegistirForm seklefrm2 = new _11SiparisEkleDegistirForm(sprduz) { };
                    seklefrm2.FormClosed += delegate
                    {
                        Doldur();
                    };
                    seklefrm2.ShowDialog();
                }
            }
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            List<int> urunid = new List<int>();
            List<int?> nali = new List<int?>();
            urunid.AddRange(entities.SiparisDetays.Where(a => a.Urun != null && a.Sipari.SiparisTarih >= dtpBaslangic.Value && a.Sipari.SiparisTarih <= dtpBitis.Value).Distinct().Select(a => a.Urun.ID));
            nali.AddRange(entities.Siparis.Where(a => a.SiparisTarih >= dtpBaslangic.Value && a.SiparisTarih <= dtpBitis.Value && a.UrunID != null).Distinct().Select(a => a.UrunID));
            List<int> sonurun = new List<int>();
            sonurun.AddRange(urunid.Distinct());
            foreach (var item in nali)
            {
                if (item != null)
                {
                    int yeniid = Convert.ToInt32(item);
                    sonurun.Add(yeniid);
                }
            }
            decimal genel = 0;
            List<RaporData> gride = new List<RaporData>();
            foreach (int item in sonurun.Distinct())
            {
                decimal tutar = 0;
                decimal tutar1 = 0;
                int adet = 0;
                int adet1 = 0;
                try
                {
                    tutar = entities.Siparis.Where(a => a.UrunID == item && a.SiparisTarih >= dtpBaslangic.Value && a.SiparisTarih <= dtpBitis.Value && a.UrunID != null).Sum(a => a.SiparisTutar);
                }
                catch
                {
                    tutar = 0;
                }
                try
                {
                    tutar1 = entities.SiparisDetays.Where(a => a.Urun.ID == item && a.Sipari.SiparisTarih >= dtpBaslangic.Value && a.Sipari.SiparisTarih <= dtpBitis.Value).Sum(a => a.Toplam);
                }
                catch
                {
                    tutar1 = 0;
                }
                try
                {
                    adet = entities.Siparis.Where(a => a.UrunID == item && a.SiparisTarih >= dtpBaslangic.Value && a.SiparisTarih <= dtpBitis.Value && a.UrunID != null).Count();
                }
                catch
                {
                    adet = 0;
                }
                try
                {
                    adet1 = entities.SiparisDetays.Where(a => a.Urun.ID == item && a.Sipari.SiparisTarih >= dtpBaslangic.Value && a.Sipari.SiparisTarih <= dtpBitis.Value).Sum(a => a.Adet);
                }
                catch
                {
                    adet1 = 0;
                }
                RaporData yeni = new RaporData
                {
                    UrunAdi = entities.Uruns.Where(a => a.ID == item).Select(a => a.UrunAdi).First(),
                    UrunAdeti = (adet + adet1),
                    UrunTutarı = (tutar + tutar1).ToString("C"),
                };
                genel += (tutar + tutar1);
                gride.Add(yeni);
            }
            RaporForm abc = new RaporForm(gride);
            abc.lblToplam.Text = genel.ToString("C");
            abc.ShowDialog();
        }
    }
}
