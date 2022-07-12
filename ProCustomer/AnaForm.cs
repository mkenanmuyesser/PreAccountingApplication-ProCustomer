using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ProCustomer.UserControls;
using DevExpress.XtraBars;
using ProCustomer.Forms;
using ProCustomer.UserControls.Iletisim;
using System.Diagnostics;
using System.Data.Objects;
using DevExpress.XtraGrid;
using System.Linq;
using ProCustomer.Forms.Tanimlama;
using System.Data.SqlClient;
using ProCustomer.Properties;
using System.Configuration;
using ProCustomer.Classes;

namespace ProCustomer
{
    public partial class AnaForm : DevExpress.XtraEditors.XtraForm
    {
        _1SiparisModul siparismodul = null;
        _2CariModul carimodul = null;
        _3UrunModul urunmodul = null;
        _4KasaModul kasamodul = null;
        HastaModul hastamodul = null;
        Doviz dovizmodul = null;
        ProCustomerDBEntities entities = Program.entities;
        public AnaForm()
        {
            InitializeComponent();
            btnOdemeTipi.Visibility = BarItemVisibility.Never;
            string kategori = "Customer;";
            switch (kategori)
            {
                case "Customer;":
                    this.Text = "ProCustomer v1.4";
                    DovizPage.Visible = false;
                    MuayenePage.Visible = false;
                    btnTurTanım.Visibility = BarItemVisibility.Never;
                    btnHayvanlar.Visibility = BarItemVisibility.Never;
                    btnMuayene.Visibility = BarItemVisibility.Never;
                    btnGunluk.Visibility = BarItemVisibility.Never;
                    siparismodul = new _1SiparisModul(this) { Dock = DockStyle.Fill };
                    break;
                case "Gold;":
                    this.Text = "ProGold v1.4";
                    MuayenePage.Visible = false;
                    btnTurTanım.Visibility = BarItemVisibility.Never;
                    btnHayvanlar.Visibility = BarItemVisibility.Never;
                    btnMuayene.Visibility = BarItemVisibility.Never;
                    btnGunluk.Visibility = BarItemVisibility.Never;
                    dovizmodul = new Doviz() { Dock = DockStyle.Fill };
                    break;
                case "Pet;":
                    this.Text = "ProPet v1.4";
                    DovizPage.Visible = false;
                    MuayenePage.Visible = false;
                    btnMuayene.Visibility = BarItemVisibility.Never;
                    btnGunluk.Visibility = BarItemVisibility.Never;
                    break;
                case "Vet;":
                    DovizPage.Visible = false;
                    this.Text = "ProVet v1.4";
                    break;
                case "Health;":
                    this.Text = "ProHealth v1.4";
                    break;
                case "Secretary;":
                    this.Text = "ProSecretary v1.4";
                    break;
                case "Sport;":
                    this.Text = "ProSport v1.4";
                    DovizPage.Visible = false;
                    MuayenePage.Visible = false;
                    btnTurTanım.Visibility = BarItemVisibility.Never;
                    btnHayvanlar.Visibility = BarItemVisibility.Never;
                    btnMuayene.Visibility = BarItemVisibility.Never;
                    btnGunluk.Visibility = BarItemVisibility.Never;
                    break;
                case "Beauty;":
                    this.Text = "ProBeauty v1.4";
                    DovizPage.Visible = false;
                    MuayenePage.Visible = false;
                    btnTurTanım.Visibility = BarItemVisibility.Never;
                    btnHayvanlar.Visibility = BarItemVisibility.Never;
                    btnMuayene.Visibility = BarItemVisibility.Never;
                    btnGunluk.Visibility = BarItemVisibility.Never;
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            axCIDv51.Hide();
            axCIDv51.Start();
            pnlMain.Controls.Add(siparismodul);
        }

        private void mainRibbon_SelectedPageChanged(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            Temizle();
            if (mainRibbon.SelectedPage == SiparisPage)
            {
                siparismodul = new _1SiparisModul(this) { Dock = DockStyle.Fill };
                pnlMain.Controls.Add(siparismodul);
            }
            else if (mainRibbon.SelectedPage == CarilerPage)
            {
                carimodul = new _2CariModul() { Dock = DockStyle.Fill };
                pnlMain.Controls.Add(carimodul);
                carimodul.txtBarkod.Focus();
            }
            else if (mainRibbon.SelectedPage == UrunlerPage)
            {
                urunmodul = new _3UrunModul() { Dock = DockStyle.Fill };
                pnlMain.Controls.Add(urunmodul);
                urunmodul.txtBarkod.Focus();
            }
            else if (mainRibbon.SelectedPage == KasaPage)
            {
                kasamodul = new _4KasaModul() { Dock = DockStyle.Fill };
                pnlMain.Controls.Add(kasamodul);
            }
            else if (mainRibbon.SelectedPage == DovizPage)
            {
                dovizmodul = new Doviz() { Dock = DockStyle.Fill };
                pnlMain.Controls.Add(dovizmodul);
            }
            else if (mainRibbon.SelectedPage == MuayenePage)
            {
                hastamodul = new HastaModul() { Dock = DockStyle.Fill };
                pnlMain.Controls.Add(hastamodul);
            }
        }

        private void axCIDv51_OnCallerID(object sender, Axcidv5callerid.ICIDv5Events_OnCallerIDEvent e)
        {
            //çağrı listesine ekle
            string telno = e.phoneNumber.Replace('+', ' ');
            IEnumerable<Musteri> dizi = entities.Musteris.Where(a =>
                 a.Telefon1.Contains(telno) ||
                 a.Telefon2.Contains(telno) ||
                 a.Telefon3.Contains(telno) ||
                 a.Telefon4.Contains(telno) ||
                 a.Telefon5.Contains(telno) ||
                 a.Telefon6.Contains(telno));

            if (dizi.Count() == 1)
            {
                Musteri musteri = dizi.First();
                string aciklama = "";
                _ArayaniBildirForm1 frm = _ArayaniBildirForm1.Goster(telno, musteri.Ad_Unvan);
                if (frm.SONUC)
                {
                    aciklama = frm.txtAciklama.Text;
                    _11SiparisEkleDegistirForm se = new _11SiparisEkleDegistirForm(null, musteri) { };
                    se.FormClosed += delegate
                    {
                        if (siparismodul != null)
                        {
                            siparismodul.Doldur();
                        }
                    };
                    se.ShowDialog();
                }


                entities.AddToCagris(new Cagri
                {
                    Ad_Unvan = musteri.Ad_Unvan,
                    Musteri = musteri,
                    Tarih = DateTime.Now,
                    TelefonNo = telno,
                    Aciklama = aciklama,
                });
            }
            else
            {
                string aciklama = "";
                _ArayaniBildirForm2 frm = _ArayaniBildirForm2.Goster(telno);
                if (frm.SONUC)
                {
                    aciklama = frm.txtAciklama.Text;
                    _21MusteriEkleDegistirForm musterifrm = new _21MusteriEkleDegistirForm(true, true) { };
                    musterifrm.txtTel1.Text = telno;
                    musterifrm.FormClosed += delegate
                    {
                        if (carimodul != null)
                        {
                            carimodul.Doldur();
                        }
                    };
                    musterifrm.ShowDialog();

                }

                entities.AddToCagris(new Cagri
                {
                    Tarih = DateTime.Now,
                    TelefonNo = telno,
                    Aciklama = aciklama,
                });

            }
            entities.SaveChanges(true);
        }

        private void btnMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BarButtonItem item = e.Item as BarButtonItem;
            switch (item.Name)
            {

                #region siparis grubu
                case "btnSiparisEkle":
                    _11SiparisEkleDegistirForm sekfrm111 = new _11SiparisEkleDegistirForm() { };
                    sekfrm111.FormClosed += delegate
                    {
                        siparismodul.Doldur();
                    };
                    sekfrm111.ShowDialog();
                    break;
                case "btnSiparisDuzenle":
                    if (siparismodul.grdSiparis.GetFocusedRow() != null)
                    {
                        SiparisData sprdata = siparismodul.grdSiparis.GetFocusedRow() as SiparisData;
                        if (sprdata.SiparişDurum == "Taksitli Satış")
                        {
                            _13TaksitliSatisForm abc = new _13TaksitliSatisForm();
                            abc.ShowDialog();
                        }
                        else
                        {
                            Sipari sprduz = entities.Siparis.Include("SiparisDurum").First(a => a.ID == sprdata.ID);
                            int id = Convert.ToInt32(sprduz.SiparisDurumReference.EntityKey.EntityKeyValues.First().Value);
                            _11SiparisEkleDegistirForm seklefrm2 = new _11SiparisEkleDegistirForm(sprduz) { };
                            seklefrm2.FormClosed += delegate
                            {
                                siparismodul.Doldur();
                            };
                            seklefrm2.ShowDialog();
                        }
                    }
                    else
                    {
                        _BildirimForm1.Goster("Kayıt bulunamadı!");
                    }
                    break;
                case "btnSiparisSil":
                    if (siparismodul.grdSiparis.GetFocusedRow() != null)
                    {
                        SiparisData sprdata1 = siparismodul.grdSiparis.GetFocusedRow() as SiparisData;
                        Sipari sprsil = entities.Siparis.First(a => a.ID == sprdata1.ID);
                        if (_BildirimForm2.Goster("Silmek istediğinizden emin misiniz?").SONUC)
                        {
                            try
                            {
                                entities.DeleteObject(sprsil);
                                entities.SaveChanges(true);
                                siparismodul.Doldur();
                                _BildirimForm1.Goster("Silme işlemi başarıyla gerçekleştirildi.");
                            }
                            catch
                            {
                                _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
                            }
                        }
                    }
                    else
                    {
                        _BildirimForm1.Goster("Kayıt bulunamadı!");
                    }
                    break;
                case "btnTumunuSil":
                    if (siparismodul.grdSiparis.GetFocusedRow() == null)
                    {
                        _BildirimForm1.Goster("Kayıt bulunamadı!");
                    }
                    else
                    {
                        if (_BildirimForm2.Goster("Tümünü silmek istediğinizden emin misiniz?").SONUC)
                        {
                            int rowsayisi = siparismodul.grdSiparis.RowCount;
                            for (int i = 0; i < rowsayisi; i++)
                            {
                                SiparisData satirdata = siparismodul.grdSiparis.GetRow(i) as SiparisData;
                                Sipari silinecek = entities.Siparis.First(a => a.ID == satirdata.ID);
                                entities.DeleteObject(silinecek);
                            }

                            try
                            {
                                entities.SaveChanges(true);
                                siparismodul.Doldur();
                                _BildirimForm1.Goster("Silme işlemi başarıyla gerçekleştirildi.");
                            }
                            catch
                            {
                                _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
                            }
                        }
                    }
                    break;
                case "btnSiparisTaksitliSatis":
                    _13TaksitliSatisForm zxc = new _13TaksitliSatisForm();
                    zxc.FormClosed += delegate
                             {
                                 siparismodul.Doldur();
                             };
                    zxc.ShowDialog();

                    break;
                case "btnHesapBilgisi":
                    if (siparismodul.grdSiparis.GetFocusedRow() != null)
                    {
                        SiparisData sprhesap = siparismodul.grdSiparis.GetFocusedRow() as SiparisData;

                        Sipari secilen = entities.Siparis.Include("Musteri").First(a => a.ID == sprhesap.ID);
                        _21MusteriEkleDegistirForm kayitfrm = new _21MusteriEkleDegistirForm(secilen.Musteri.ID) { };
                        kayitfrm.ShowDialog();
                    }
                    else
                    {
                        _BildirimForm1.Goster("Kayıt bulunamadı!");
                    }
                    break;
                #endregion

                #region cari grubu
                case "btnMusteriEkle":
                    _21MusteriEkleDegistirForm kbfrm = new _21MusteriEkleDegistirForm() { };
                    kbfrm.FormClosed += delegate
                    {
                        carimodul.Doldur();
                    };
                    kbfrm.ShowDialog();
                    break;
                case "btnHayvanlar":
                    _25EsDurum hfrm = new _25EsDurum() { };
                    hfrm.FormClosed += delegate
                    {

                    };
                    hfrm.ShowDialog();

                    break;
                case "btnMusteriDuzenle":
                    if (carimodul.grdMusteri.GetFocusedRow() != null)
                    {
                        MusteriData musdata = carimodul.grdMusteri.GetFocusedRow() as MusteriData;
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
                    break;
                case "btnMusteriSil":
                    if (carimodul.grdMusteri.GetFocusedRow() != null)
                    {
                        MusteriData musdata1 = carimodul.grdMusteri.GetFocusedRow() as MusteriData;
                        if (musdata1.Ad_Unvan == "_Genel Müşteri")
                        {
                            _BildirimForm1.Goster("Genel müşteri silinemez!.");
                        }
                        else
                        {
                            Musteri mussil = entities.Musteris.First(a => a.ID == musdata1.ID);
                            if (_BildirimForm2.Goster("Müşteriye ait Satış, Cari ve Bütün kayılar silinecektir. Onaylıyor musunuz?").SONUC)
                            {
                                try
                                {

                                    entities.DeleteObject(mussil);
                                    entities.SaveChanges(true);
                                    carimodul.Doldur();
                                    _BildirimForm1.Goster("Silme işlemi başarıyla gerçekleştirildi.");
                                }
                                catch
                                {
                                    _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
                                }
                            }
                        }
                    }
                    else
                    {
                        _BildirimForm1.Goster("Kayıt bulunamadı!");
                    }
                    break;
                case "btnMusteriEkleDuzenle":
                    _22MusteriGrupForm musgrupfrm = new _22MusteriGrupForm() { };
                    musgrupfrm.FormClosed += delegate
                    {
                        carimodul.Doldur();
                        carimodul.treMusteri.ExpandAll();
                    };
                    musgrupfrm.ShowDialog();
                    break;
                case "btnEpostaGonder":
                    if (carimodul.grdMusteri.GetFocusedRow() != null)
                    {
                        MusteriData must = carimodul.grdMusteri.GetFocusedRow() as MusteriData;
                        Musteri muse = entities.Musteris.First(a => a.ID == must.ID);
                        if (muse == null)
                        {
                            _BildirimForm1.Goster("Kayıt bulunamadı!");
                        }
                        else if (string.IsNullOrEmpty(muse.Eposta))
                        {
                            _BildirimForm1.Goster("E-posta adresi bulunamadı!");
                        }
                        else
                        {
                            new _23EPostaForm(muse.Eposta) { }.ShowDialog();
                        }
                    }
                    break;
                case "btnSmsGonder":
                    if (carimodul.grdMusteri.GetFocusedRow() != null)
                    {
                        MusteriData must = carimodul.grdMusteri.GetFocusedRow() as MusteriData;
                        Musteri muse = entities.Musteris.First(a => a.ID == must.ID);
                        if (muse == null)
                        {
                            _BildirimForm1.Goster("Kayıt bulunamadı!");
                        }
                        else if (string.IsNullOrEmpty(muse.Telefon1))
                        {
                            _BildirimForm1.Goster("Telefon numarası bulunamadı!");
                        }
                        else
                        {
                            new _24SmsForm(muse.Telefon1) { }.ShowDialog();
                        }
                    }
                    break;
                #endregion

                #region urun grubu
                case "btnUrunEkle":
                    _31UrunEkleDegistirForm uefrm = new _31UrunEkleDegistirForm() { };
                    uefrm.FormClosed += delegate
                    {
                        urunmodul.Doldur();
                        urunmodul.treUrun.ExpandAll();
                    };
                    uefrm.ShowDialog();
                    break;
                case "btnUrunDuzenle":
                    if (urunmodul.grdUrun.GetFocusedRow() != null)
                    {
                        UrunData urundata = urunmodul.grdUrun.GetFocusedRow() as UrunData;
                        Urun urnduz = entities.Uruns.First(a => a.ID == urundata.ID);

                        _31UrunEkleDegistirForm udfrm = new _31UrunEkleDegistirForm(urnduz) { };
                        udfrm.FormClosed += delegate
                        {
                            urunmodul.Doldur();
                            urunmodul.treUrun.ExpandAll();
                        };
                        udfrm.ShowDialog();

                    }
                    else
                    {
                        _BildirimForm1.Goster("Kayıt bulunamadı!");
                    }
                    break;
                case "btnUrunSil":
                    if (urunmodul.grdUrun.GetFocusedRow() != null)
                    {

                        UrunData urundata = urunmodul.grdUrun.GetFocusedRow() as UrunData;
                        Urun urnsil = entities.Uruns.First(a => a.ID == urundata.ID);
                        {
                            if (_BildirimForm2.Goster("Silmek istediğinizden emin misiniz?").SONUC)
                            {
                                Urun urn = entities.Uruns.First(a => a.ID == urnsil.ID);
                                entities.DeleteObject(urn);
                                entities.SaveChanges(true);
                                urunmodul.Doldur();
                                urunmodul.treUrun.ExpandAll();
                                _BildirimForm1.Goster("Silme işlemi başarıyla gerçekleştirildi.");
                            }
                        }
                    }
                    else
                    {
                        _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
                    }
                    break;
                case "btnUrunGrupEkle":
                    _32UrunGrupForm urngrupfrm = new _32UrunGrupForm() { };
                    urngrupfrm.FormClosed += delegate
                    {
                        urunmodul.Doldur();
                        urunmodul.treUrun.ExpandAll();
                    };
                    urngrupfrm.ShowDialog();
                    break;
                #endregion

                #region hasta grubu
                case "btnMuayene":
                    Muayene m = new Muayene();
                    m.ShowDialog();
                    break;

                case "btnGunluk":
                    RandevuListeForm kk = new RandevuListeForm();
                    kk.ShowDialog();
                    break;
                #endregion

                #region kasa grubu
                case "btnKasaEkle":
                    _41KasaIslemForm kifrm = new _41KasaIslemForm() { };
                    kifrm.FormClosed += delegate
                    {
                        kasamodul.Doldur();
                    };
                    kifrm.ShowDialog();
                    break;
                case "btnKasaDuzenle":
                    if (kasamodul.grdKasa.GetFocusedRow() != null)
                    {
                        KasaData data = kasamodul.grdKasa.GetFocusedRow() as KasaData;
                        KasaIslem kasaislemduzenle = entities.KasaIslems.First(a => a.ID == data.ID);
                        _41KasaIslemForm kifrm2 = new _41KasaIslemForm(kasaislemduzenle, null) { };
                        kifrm2.FormClosed += delegate
                        {
                            kasamodul.entities.Refresh(RefreshMode.StoreWins, entities.KasaIslems);
                            kasamodul.Doldur();
                        };
                        kifrm2.ShowDialog();
                    }
                    else
                    {
                        _BildirimForm1.Goster("Kayıt bulunamadı!");
                    }
                    break;
                case "btnKasaSil":
                    if (kasamodul.grdKasa.GetFocusedRow() != null)
                    {
                        KasaData data1 = kasamodul.grdKasa.GetFocusedRow() as KasaData;
                        KasaIslem kasaislemsil = entities.KasaIslems.First(a => a.ID == data1.ID);
                        if (_BildirimForm2.Goster("Silmek istediğinizden emin misiniz?").SONUC)
                        {
                            try
                            {
                                KasaIslem son = entities.KasaIslems.First(a => a.ID == kasaislemsil.ID);
                                entities.DeleteObject(son);
                                entities.SaveChanges(true);
                                //kasamodul.entities.Refresh(RefreshMode.StoreWins, entities.KasaIslems);
                                kasamodul.Doldur();
                            }
                            catch
                            {
                                _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
                            }
                        }
                    }
                    else
                    {
                        _BildirimForm1.Goster("Kayıt bulunamadı!");
                    }
                    break;
                //case "btnEmanetVer":
                //    new _6KasaIslemlerForm() { }.ShowDialog();
                //    break;
                //case "btnEmanetGeriAl":
                //    new _6KasaIslemlerForm() { }.ShowDialog();
                //    break;
                #endregion

                #region iletisim grubu
                case "btnRandevu":
                    pnlMain.Controls.Clear();
                    Randevu rnd = new Randevu();
                    rnd.ShowDialog();
                    break;
                case "btnCagrilar":
                    pnlMain.Controls.Clear();
                    _1CagriModul cm = new _1CagriModul() { Dock = DockStyle.Fill };
                    pnlMain.Controls.Add(cm);
                    break;
                case "btnHatirlatmalar":
                    pnlMain.Controls.Clear();
                    _2HatirlatmaModul hm = new _2HatirlatmaModul() { Dock = DockStyle.Fill };
                    pnlMain.Controls.Add(hm);
                    break;
                case "btnPosta":
                    pnlMain.Controls.Clear();
                    _3EpostaModul em = new _3EpostaModul() { Dock = DockStyle.Fill };
                    pnlMain.Controls.Add(em);
                    break;
                case "btnSms":
                    pnlMain.Controls.Clear();
                    _4SmsModul sm = new _4SmsModul() { Dock = DockStyle.Fill };
                    pnlMain.Controls.Add(sm);
                    break;
                #endregion

                #region tanimlar grubu
                case "btnParaPuan":
                    new _8ParaPuan() { }.ShowDialog();
                    break;
                case "btnTurTanım":
                    new _10HayvanTurTanim() { }.ShowDialog();
                    break;
                case "btnKasaTanimla":
                    new KasaTanimForm() { }.ShowDialog();
                    break;
                case "btnPersonel":
                    new PersonelListeForm() { }.ShowDialog();
                    break;
                case "btnBolgeTanimla":
                    new BolgeListeForm() { }.ShowDialog();
                    break;
                case "btnOdemeTipi":
                    new OdemeTipiForm() { }.ShowDialog();
                    break;
                case "btnSirketTanim":
                    new SirketBilgiForm() { }.ShowDialog();
                    break;
                case "btnKullaniciTanim":
                    new KullaniciTanimForm() { }.ShowDialog();
                    break;
                case "btnProgramAyar":
                    new ProgramAyarForm() { }.ShowDialog();
                    break;
                #endregion

                #region yardim grubu
                case "btnHarita":
                    Process.Start("http://maps.google.com/");
                    break;
                case "btnCaller":
                    new _51CallerIdBaglantiForm() { }.ShowDialog();
                    break;
                case "btnHakkimizda":
                    new _HakkimizdaForm() { }.ShowDialog();
                    break;
                #endregion

                #region excel grubu
                case "btnSiparisExcel":
                    ExcelKaydet(siparismodul.grdSiparisMain);
                    break;
                case "btnCariExcel":
                    ExcelKaydet(carimodul.grdMusteriMain);
                    break;
                case "btnUrunExcel":
                    ExcelKaydet(urunmodul.grdUrunMain);
                    break;
                case "btnKasaExcel":
                    ExcelKaydet(kasamodul.grdKasaMain);
                    break;
                #endregion

                #region yazici grubu
                case "btnSiparisYazici":
                    siparismodul.grdSiparisMain.ShowRibbonPrintPreview();
                    break;
                case "btnCariYazici":
                    carimodul.grdMusteriMain.ShowRibbonPrintPreview();
                    break;
                case "btnUrunYazici":
                    urunmodul.grdUrunMain.ShowRibbonPrintPreview();
                    break;
                case "btnKasaYazici":
                    kasamodul.grdKasaMain.ShowRibbonPrintPreview();
                    break;

                #endregion

                #region sag menu grubu
                case "biBackup":
                    DialogResult sonuc = sfdBackup.ShowDialog();
                    if (sonuc == DialogResult.OK)
                    {
                        try
                        {
                            string cnnstring = ConfigurationManager.ConnectionStrings["ProData"].ConnectionString;
                            SqlConnection cnn = new SqlConnection(cnnstring);
                            SqlCommand cmd = new SqlCommand("backup database ProCustomerDB to disk='" + sfdBackup.FileName + "'", cnn);
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                            _BildirimForm1.Goster("Yedekleme işlemi başarıyla gerçekleştirildi.");
                        }
                        catch
                        {
                            _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
                        }
                    }
                    break;
                case "biAbout":
                    new _HakkimizdaForm() { }.ShowDialog();
                    break;
                case "biExit":
                    if (_BildirimForm2.Goster("Çıkış yapmak istiyor musunuz?").SONUC)
                    {
                        Environment.Exit(0);
                    }
                    break;
            }
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_BildirimForm2.Goster("Çıkış yapmak istiyor musunuz?").SONUC)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        void ExcelKaydet(GridControl grd)
        {
            DialogResult sonuc = sfdExcel.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                grd.ExportToXls(sfdExcel.FileName);
            }
        }

        void Temizle()
        {
            siparismodul = null;
            carimodul = null;
            urunmodul = null;
            kasamodul = null;
        }
    }
}
                #endregion