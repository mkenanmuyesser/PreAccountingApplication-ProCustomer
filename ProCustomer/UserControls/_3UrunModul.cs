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
    public partial class _3UrunModul : UserControl
    {
        Urun uruntut;
        ProCustomerDBEntities entities = Program.entities;
        public _3UrunModul()
        {
            InitializeComponent();
        }

        private void _3UrunModul_Load(object sender, EventArgs e)
        {
            Doldur();
            treUrun.ExpandAll();
        }

        public void filtre(List<Urun> gelen)
        {
            grdUrunMain.DataSource = null;
            List<UrunData> yukle = new List<UrunData>();
            foreach (var item in gelen)
            {
                UrunData asd = new UrunData
                {
                    ID = item.ID,
                    UrunAdi = item.UrunAdi,
                    KdvDahil = item.KdvDahil == true ? "Evet" : "Hayır",
                    KdvOran = item.KdvOran,
                    Aciklama = item.Aciklama,
                    Fiyat1 = item.Fiyat1.ToString("C"),
                    Fiyat2 = item.Fiyat2.ToString("C"),
                    Fiyat3 = item.Fiyat3.ToString("C"),
                    Fiyat4 = item.Fiyat4.ToString("C"),
                    Fiyat5 = item.Fiyat5.ToString("C"),
                    Fiyat6 = item.Fiyat6.ToString("C"),
                };
                yukle.Add(asd);
            }
            grdUrunMain.DataSource = yukle;
        }

        private void treUrun_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                List<UrunData> dizidata = new List<UrunData>();
                UrunGrup secilen = e.Node.Tag as UrunGrup;

                if (secilen.AltGrupID == null)
                {
                    List<int> dizi = entities.UrunGrups.ToList().Where(a => a.AltGrupID == secilen.ID).Select(a => a.ID).ToList();
                    var sorgu = entities.Uruns.ToList().Where(a => a.UrunGrup != null && (a.UrunGrup.ID == secilen.ID || (dizi.Contains(a.UrunGrup.ID)))).ToArray().Select(a => new { a.ID, a.UrunAdi, a.Fiyat1, a.Fiyat2, a.Fiyat3, a.Fiyat4, a.Fiyat5, a.Fiyat6, a.KdvOran, a.KdvDahil, a.Aciklama });
                    foreach (var item in sorgu)
                    {
                        dizidata.Add(new UrunData
                        {
                            Aciklama = item.Aciklama,
                            Fiyat1 = item.Fiyat1.ToString("C"),
                            Fiyat2 = item.Fiyat2.ToString("C"),
                            Fiyat3 = item.Fiyat3.ToString("C"),
                            Fiyat4 = item.Fiyat4.ToString("C"),
                            Fiyat5 = item.Fiyat5.ToString("C"),
                            Fiyat6 = item.Fiyat6.ToString("C"),
                            ID = item.ID,
                            KdvDahil = item.KdvDahil == true ? "Evet" : "Hayır",
                            KdvOran = item.KdvOran,
                            UrunAdi = item.UrunAdi,
                        });
                    }
                    grdUrunMain.DataSource = dizidata;
                }
                else
                {
                    var sorgu = entities.Uruns.Where(a => a.UrunGrup.ID == secilen.ID).ToArray().Select(a => new { a.ID, a.UrunAdi, a.Fiyat1, a.Fiyat2, a.Fiyat3, a.Fiyat4, a.Fiyat5, a.Fiyat6, a.KdvOran, a.KdvDahil, a.Aciklama });
                    foreach (var item in sorgu)
                    {
                        dizidata.Add(new UrunData
                        {
                            Aciklama = item.Aciklama,
                            Fiyat1 = item.Fiyat1.ToString("C"),
                            Fiyat2 = item.Fiyat2.ToString("C"),
                            Fiyat3 = item.Fiyat3.ToString("C"),
                            Fiyat4 = item.Fiyat4.ToString("C"),
                            Fiyat5 = item.Fiyat5.ToString("C"),
                            Fiyat6 = item.Fiyat6.ToString("C"),
                            ID = item.ID,
                            KdvDahil = item.KdvDahil == true ? "Evet" : "Hayır",
                            KdvOran = item.KdvOran,
                            UrunAdi = item.UrunAdi,
                        });
                    }
                    grdUrunMain.DataSource = dizidata;
                }
            }
        }

        #region click grubu

        private void btnUrunStokEkle_Click(object sender, EventArgs e)
        {
            if (grdUrun.GetFocusedRow() != null)
            {
                UrunData abc = grdUrun.GetFocusedRow() as UrunData;
                Urun tiklanan = entities.Uruns.First(a => a.ID == abc.ID);
                _33UrunStokForm frm = new _33UrunStokForm(1, null, tiklanan) { };
                frm.FormClosed += delegate
                {
                    //
                };
                frm.ShowDialog();
            }
        }

        private void btnUrunStokAzalt_Click(object sender, EventArgs e)
        {
            if (grdUrun.GetFocusedRow() != null)
            {
                UrunData urn = grdUrun.GetFocusedRow() as UrunData;
                Urun urn1 = entities.Uruns.First(a => a.ID == urn.ID);
                _33UrunStokForm frm = new _33UrunStokForm(2, null, urn1) { };
                frm.FormClosed += delegate
                {
                    if (grdUrun.GetFocusedRow() == null)
                    {
                        StokDoldur(null);
                    }
                    else
                    {
                        StokDoldur(urn1);
                    }
                };
                frm.ShowDialog();
            }
        }

        #endregion

        #region metod grubu

        public void Doldur()
        {
            DataLoad.UrunTreeDoldur(treUrun, null);
            treUrun.SelectedNode = treUrun.Nodes[0];
        }

        public void StokDoldur(Urun urn)
        {
            List<UrunStokData> dizidata = new List<UrunStokData>();
            var sorgu = entities.UrunStoks.Include("Kasa").Where(a => a.Urun.ID == urn.ID).ToList();
            if (sorgu != null)
            {
                foreach (var item in sorgu)
                {
                    dizidata.Add(new UrunStokData
                    {
                        ID = item.ID,
                        GirisCikis = item.Giris == true ? "Giriş" : "Çıkış",
                        KasaAdi = item.Kasa.KasaAdi,
                        Miktar = item.Miktar,
                    });
                }
                grdUrunHareketMain.DataSource = dizidata;
            }
        }

        private void btnStokYazdir_Click(object sender, EventArgs e)
        {
            grdUrunHareket.ShowRibbonPrintPreview();
        }

        private void btnStokExcel_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = sfdExcel.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                grdUrunHareket.ExportToXls(sfdExcel.FileName);
            }
        }

        private void btnYazici_Click(object sender, EventArgs e)
        {
            grdSiparis.ShowRibbonPrintPreview();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = sfdExcel.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                grdSiparis.ExportToXls(sfdExcel.FileName);
            }
        }

        private void grdUrun_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                if (grdUrun.GetFocusedRow() != null)
                {
                    UrunData udata = grdUrun.GetFocusedRow() as UrunData;
                    Urun giden = entities.Uruns.First(a => a.ID == udata.ID);
                    SiparisDoldur(giden);
                    StokDoldur(giden);
                    try
                    {
                        var sorgu = entities.UrunStoks.Where(a => a.Urun.ID == giden.ID);
                        int giris = sorgu.Where(a => a.Giris).Count() == 0 ? 0 : sorgu.Where(a => a.Giris).Sum(a => a.Miktar);
                        int cikis = sorgu.Where(a => !a.Giris).Count() == 0 ? 0 : sorgu.Where(a => !a.Giris).Sum(a => a.Miktar);
                        int sonuc = giris - cikis;
                        lblUrunStok.Text = "Stokta " + sonuc.ToString() + " adet ürün bulunmaktadır.";
                        if (sonuc <= 10)
                        {
                            lblUrunStok.ForeColor = Color.Red;
                        }
                        else
                        {
                            lblUrunStok.ForeColor = Color.Black;
                        }
                    }
                    catch
                    {
                        lblUrunStok.Text = "error";
                    }
                }
            }
        }

        public void SiparisDoldur(Urun gelen)
        {
            List<Siparis2> datadizi = new List<Siparis2>();
            var sorgu = entities.SiparisDetays.Where(a => a.Urun.ID == gelen.ID && a.Sipari != null);
            foreach (var item in sorgu)
            {
                int siparisid = Convert.ToInt32(item.SipariReference.EntityKey.EntityKeyValues.First().Value);
                string musad = entities.Siparis.Where(a => a.ID == siparisid).Select(a => a.Musteri.Ad_Unvan).First();
                string per = entities.Siparis.Where(a => a.ID == siparisid).Select(a => a.Personel.AdSoyad).First();
                bool degis = entities.Siparis.Where(a => a.ID == siparisid).Select(a => a.TaksitliSatis).First();
                DateTime tarih = entities.Siparis.Where(a => a.ID == siparisid).Select(a => a.SiparisTarih).First();
                datadizi.Add(new Siparis2
                {
                    Aciklama = item.Aciklama,
                    Personel = per,
                    Musteri = musad,
                    ID = item.ID,
                    TaksitliSatış = "Normal",
                    Tarih = tarih,
                    Tutar = item.Toplam.ToString("C"),
                }
                    );
            }
            var sor = entities.Siparis.Include("Musteri").Include("Personel").Where(a => a.TaksitliSatis == true);
            foreach (var item in sor)
            {
                datadizi.Add(new Siparis2
                {
                    Aciklama = item.Aciklama,
                    ID = item.ID,
                    Musteri = item.Musteri.Ad_Unvan,
                    Personel = item.Personel.AdSoyad,
                    TaksitliSatış = "Taksitli",
                    Tarih = item.SiparisTarih,
                    Tutar = item.SiparisTutar.ToString("C"),
                });
            }
            grdSiparisMain.DataSource = datadizi;

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string barkodno = txtBarkod.Text;
            string urunad = txtUrun.Text;
            if (barkodno == "" && urunad != "")
            {
                List<Urun> secilen = entities.Uruns.Where(a => a.UrunAdi.Contains(urunad)).ToList();
                filtre(secilen);
            }
            else if (urunad == "" && barkodno != "")
            {
                List<Urun> secilen = entities.Uruns.Where(a => a.Barkod == barkodno).ToList();
                filtre(secilen);
            }
            else if (urunad == "" && barkodno == "")
            {
                List<Urun> secilen = entities.Uruns.ToList();
                filtre(secilen);
            }
            else
            { }
            txtUrun.Text = "";
            txtBarkod.Text = "";
        }

        private void txtBarkod_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnAra_Click(null, null);
            }
        }

        private void grdUrun_RowCountChanged(object sender, EventArgs e)
        {
            if (grdUrun.GetFocusedRow() != null)
            {
                UrunData udata = grdUrun.GetFocusedRow() as UrunData;
                Urun giden = entities.Uruns.First(a => a.ID == udata.ID);
                SiparisDoldur(giden);
                StokDoldur(giden);
                try
                {
                    var sorgu = entities.UrunStoks.Where(a => a.Urun.ID == giden.ID);
                    int giris = sorgu.Where(a => a.Giris).Count() == 0 ? 0 : sorgu.Where(a => a.Giris).Sum(a => a.Miktar);
                    int cikis = sorgu.Where(a => !a.Giris).Count() == 0 ? 0 : sorgu.Where(a => !a.Giris).Sum(a => a.Miktar);
                    int sonuc = giris - cikis;
                    lblUrunStok.Text = "Stokta " + sonuc.ToString() + " adet ürün bulunmaktadır.";
                    if (sonuc <= 10)
                    {
                        lblUrunStok.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblUrunStok.ForeColor = Color.Black;
                    }
                }
                catch
                {
                    lblUrunStok.Text = "error";
                }
            }
            else
            {
                grdSiparisMain.DataSource = null;
                grdUrunHareketMain.DataSource = null;
                lblUrunStok.Text = "";
            }
        }

    }
        #endregion
}
