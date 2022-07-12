using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProCustomer.Classes;
using ProCustomer.Forms;
using System.Data.Objects;

namespace ProCustomer.UserControls
{
    public partial class _2CariModul : UserControl
    {
        ProCustomerDBEntities entities = Program.entities;
        byte SW;
        Musteri MUS;

        //sw=1 tahsilat
        //2 ödeme
        //3 kayıt sil

        //public _2CariModul(int sw, Musteri MUS)
        public _2CariModul()
        {
            InitializeComponent();
            //SW = sw;
            //MUS = mus == null ? null : entities.Musteris.First(a => a.ID == MUS.ID);
        }

        private void _2CariModul_Load(object sender, EventArgs e)
        {
            Doldur();
            treMusteri.ExpandAll();
            xtraTabControl1.SelectedTabPageIndex = 0;
        }

        public void filtre(List<Musteri> gelen)
        {
            grdMusteriMain.DataSource = null;
            List<MusteriData> yukle = new List<MusteriData>();
            foreach (var item in gelen)
            {
                int pp = 0;
                try
                {
                    pp = Convert.ToInt32(item.ParaPuan);
                }
                catch
                {
                    pp = 0;
                }
                MusteriData asd = new MusteriData
                {
                    ID = item.ID,
                    Ad_Unvan = item.Ad_Unvan,
                    Adres = item.Adres,
                    Cinsiyet = item.Cinsiyet == true ? "Bay" : "Bayan",
                    EPosta = item.Eposta,
                    GoldUye = item.Gold == true ? "Evet" : "Hayır",
                    KayitTarihi = item.KayitTarihi,
                    ParaPuan = pp.ToString("C"),
                    Telefon = item.Telefon1,
                };
                yukle.Add(asd);
            }
            grdMusteriMain.DataSource = yukle;
        }

        public void treMusteri_AfterSelect(object sender, TreeViewEventArgs e)
        {
            grdMusteriMain.DataSource = null;
            grdCariMain.DataSource = null;
            grdSiparisHareketMain.DataSource = null;
            if (e != null && e.Node != null)
            {

                MusteriGrup secilen = e.Node.Tag as MusteriGrup;
                List<MusteriData> datadizi = new List<MusteriData>();
                if (secilen.AltGrupID == null)
                {
                    List<int> dizi = entities.MusteriGrups.ToList().Where(a => a.AltGrupID == secilen.ID).Select(a => a.ID).ToList();

                    var sorgu = entities.Musteris.ToList().Where(a => a.MusteriGrup != null && (a.MusteriGrup.ID == secilen.ID || (dizi.Contains(a.MusteriGrup.ID)))).ToArray().Select(a => new { a.ID, a.Ad_Unvan, a.Telefon1, a.Eposta, a.KayitTarihi, a.Cinsiyet, a.Gold, a.ParaPuan, a.Adres }).ToArray();
                    foreach (var item in sorgu)
                    {
                        int pp = 0;
                        try
                        {
                            pp = Convert.ToInt32(entities.Musteris.Where(a => a.ID == item.ID).Select(a => a.ParaPuan).First());
                        }
                        catch
                        {
                            pp = 0;
                        }

                        datadizi.Add(new MusteriData
                        {
                            ID = item.ID,
                            Cinsiyet = item.Cinsiyet == true ? "Bay" : "Bayan",
                            Ad_Unvan = item.Ad_Unvan,
                            EPosta = item.Eposta,
                            KayitTarihi = item.KayitTarihi,
                            Telefon = item.Telefon1,
                            GoldUye = item.Gold == true ? "Evet" : "Hayır",
                            ParaPuan = pp.ToString("C"),
                            Adres = item.Adres,
                        }
                            );

                    }
                    grdMusteriMain.DataSource = datadizi;
                }
                else
                {
                    var sorgu = entities.Musteris.Where(a => a.MusteriGrup.ID == secilen.ID).ToArray().Select(a => new { a.ID, a.Ad_Unvan, a.Telefon1, a.Eposta, a.KayitTarihi, a.Cinsiyet, a.Gold, a.Adres });
                    foreach (var item in sorgu)
                    {
                        int pp = 0;
                        try
                        {
                            pp = Convert.ToInt32(entities.Musteris.Where(a => a.ID == item.ID).Select(a => a.ParaPuan).First());
                        }
                        catch
                        {
                            pp = 0;
                        }
                        datadizi.Add(new MusteriData
                        {
                            ID = item.ID,
                            Cinsiyet = item.Cinsiyet == true ? "Bay" : "Bayan",
                            Ad_Unvan = item.Ad_Unvan,
                            EPosta = item.Eposta,
                            KayitTarihi = item.KayitTarihi,
                            Telefon = item.Telefon1,
                            GoldUye = item.Gold == true ? "Evet" : "Hayır",
                            ParaPuan = pp.ToString("C"),
                            Adres = item.Adres,
                        }
                            );

                    }
                    grdMusteriMain.DataSource = datadizi;
                }
            }
        }

        private void grdMusteri_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                if (grdMusteri.GetFocusedRow() as MusteriData != null)
                {
                    MusteriData musdat = grdMusteri.GetFocusedRow() as MusteriData;
                    MUS = entities.Musteris.First(a => a.ID == musdat.ID);
                    CariDoldur(MUS);
                    SiparisDoldur(MUS);
                }
            }
        }

        #region click grubu



        private void btnTahsilat_Click(object sender, EventArgs e)
        {
            if (grdCari.GetFocusedRow() == null)
            {
                _BildirimForm1.Goster("Kayıt bulunamadı!");
            }
            else
            {
                MusteriCariHareketData gelen = grdCari.GetFocusedRow() as MusteriCariHareketData;
                string toplam = gelen.Tutar;
                if (_BildirimForm2.Goster(toplam + "'lik alışverişi tahsil etmek istiyor musunuz?").SONUC)
                {
                    KasaIslem guncelle = entities.KasaIslems.First(a => a.ID == gelen.ID);
                    guncelle.GirisCikis = true;
                    entities.SaveChanges(true);
                    CariDoldur(MUS);
                }
                else
                {

                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (grdMusteri.GetFocusedRow() == null)
            {
                _BildirimForm1.Goster("Kayıt bulunamadı!");
            }
            else
            {
                MusteriCariHareketData asd = grdCari.GetFocusedRow() as MusteriCariHareketData;
                KasaIslem data = entities.KasaIslems.First(a => a.ID == asd.ID);
                entities.DeleteObject(data);
                entities.SaveChanges(true);
                CariDoldur(MUS);
            }
        }

        public void Doldur()
        {
            cmbSekil.SelectedIndex = 0;
            DataLoad.MusteriTreeDoldur(treMusteri, null);
            treMusteri.ExpandAll();
            treMusteri.SelectedNode = treMusteri.Nodes[0];
        }

        public void SiparisDoldur(Musteri mus)
        {
            List<Siparis2> datadizi = new List<Siparis2>();
            var sorgu = entities.Siparis.Include("Personel").Include("Musteri").Where(a => a.Musteri.ID == mus.ID && a.Musteri != null).Select(a => new { a.ID, a.Musteri, a.Aciklama, a.SiparisTarih, a.SiparisTutar, a.TaksitliSatis, a.Personel });
            foreach (var item in sorgu)
            {
                decimal tutar;
                try
                {
                    tutar = entities.SiparisDetays.Where(a => a.Sipari.ID == item.ID).Sum(a => a.Toplam);
                }
                catch
                {
                    tutar = entities.Siparis.Where(a => a.ID == item.ID).Select(a => a.SiparisTutar).First();
                }
                datadizi.Add(new Siparis2
                {
                    Aciklama = item.Aciklama,
                    Personel = item.Personel == null ? null : item.Personel.AdSoyad,
                    Musteri = item.Musteri.Ad_Unvan,
                    ID = item.ID,
                    TaksitliSatış = item.TaksitliSatis == true ? "Taksitli" : "Normal",
                    Tarih = item.SiparisTarih,
                    Tutar = tutar.ToString("C"),
                }
                    );
            }
            grdSiparisHareketMain.DataSource = datadizi;
        }

        public void CariDoldur(Musteri mus)
        {
            List<MusteriCariHareketData> datadizi = new List<MusteriCariHareketData>();
            var sorgu = entities.KasaIslems.Where(a => a.Musteri.ID == mus.ID && a.Musteri != null).Select(a => new { a.ID, a.Tarih, a.GirisCikis, a.OdemeTip.OdemeTipi, a.Tutar, a.Aciklama });
            foreach (var item in sorgu)
            {
                datadizi.Add(new MusteriCariHareketData
                {
                    Aciklama = item.Aciklama,
                    Durum = item.GirisCikis == false ? "Beklemede" : "Ödendi",
                    ID = item.ID,
                    OdemeTipi = item.OdemeTipi == null ? "Taksitli Satış" : item.OdemeTipi,
                    Tarih = item.Tarih,
                    Tutar = item.Tutar.ToString("C"),
                }
                    );
            }
            grdCariMain.DataSource = datadizi;
            decimal fiyat;
            try
            {
                fiyat = entities.KasaIslems.Where(a => a.Musteri.ID == MUS.ID && a.GirisCikis == false).Sum(b => b.Tutar);
            }
            catch
            {
                fiyat = 0;
            }
            lblbakiye.Text = fiyat.ToString("C");

        }

        private void btnYazici_Click(object sender, EventArgs e)
        {
            string musteri = MUS.Ad_Unvan;
            grdCari.Columns[0].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average;
            grdCari.Columns[0].SummaryItem.DisplayFormat = musteri;
            grdCari.ShowRibbonPrintPreview();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = sfdExcel.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                grdCari.ExportToXls(sfdExcel.FileName);
            }
        }

        private void btnSiparisHareketPrinter_Click(object sender, EventArgs e)
        {
            grdSiparisHereket.ShowRibbonPrintPreview();
        }

        private void btnSiparisHareketExcel_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = sfdExcel.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                grdSiparisHereket.ExportToXls(sfdExcel.FileName);
            }
        }

        private void grdMusteriMain_DoubleClick(object sender, EventArgs e)
        {
            if (grdMusteri.GetFocusedRow() != null)
            {
                MusteriData musdata = grdMusteri.GetFocusedRow() as MusteriData;
                Musteri musduz = entities.Musteris.First(a => a.ID == musdata.ID);
                _21MusteriEkleDegistirForm kbdfrm = new _21MusteriEkleDegistirForm(musduz.ID) { };
                kbdfrm.FormClosed += delegate
                {

                };
                kbdfrm.ShowDialog();
            }
            else
            {
                _BildirimForm1.Goster("Kayıt bulunamadı!");
            }
        }

        private void btnCariAra_Click(object sender, EventArgs e)
        {
            bool odendi;
            if (cmbSekil.SelectedIndex == 0)
            {
                odendi = false;
            }
            else
            {
                odendi = true;
            }
            List<MusteriCariHareketData> datadizi = new List<MusteriCariHareketData>();
            var sorgu = entities.KasaIslems.Where(a => a.Musteri.ID == MUS.ID && a.GirisCikis == odendi && a.Musteri != null).Select(a => new { a.ID, a.Tarih, a.GirisCikis, a.OdemeTip.OdemeTipi, a.Tutar, a.Aciklama });
            foreach (var item in sorgu)
            {
                datadizi.Add(new MusteriCariHareketData
                {
                    Aciklama = item.Aciklama,
                    Durum = item.GirisCikis == false ? "Beklemede" : "Ödendi",
                    ID = item.ID,
                    OdemeTipi = item.OdemeTipi == null ? "Taksitli Satış" : item.OdemeTipi,
                    Tarih = item.Tarih,
                    Tutar = item.Tutar.ToString("C"),
                }
                    );
            }
            grdCariMain.DataSource = datadizi;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string barkodno = txtBarkod.Text;
            string musad = txtMust.Text;
            if (barkodno == "" && musad != "")
            {
                List<Musteri> secilen = entities.Musteris.Where(a => a.Ad_Unvan.Contains(musad)).ToList();
                filtre(secilen);
            }
            else if (musad == "" && barkodno != "")
            {
                List<Musteri> secilen = entities.Musteris.Where(a => a.Barkod == barkodno).ToList();
                filtre(secilen);
            }
            else if (musad == "" && barkodno == "")
            {
                List<Musteri> secilen = entities.Musteris.ToList();
                filtre(secilen);
            }
            else
            { }
            txtMust.Text = "";
            txtBarkod.Text = "";
        }

        private void txtBarkod_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnAra_Click(null, null);
            }
        }

        private void grdMusteri_RowCountChanged(object sender, EventArgs e)
        {
            if (grdMusteri.GetFocusedRow() as MusteriData != null)
            {
                MusteriData musdat = grdMusteri.GetFocusedRow() as MusteriData;
                MUS = entities.Musteris.First(a => a.ID == musdat.ID);
                CariDoldur(MUS);
                SiparisDoldur(MUS);
            }
            else
            {
                grdSiparisHareketMain.DataSource = null;
                grdCariMain.DataSource = null;
                lblbakiye.Text = "";
            }
        }
    }
}


        #endregion
