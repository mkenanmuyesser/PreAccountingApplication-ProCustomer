using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using ProCustomer.Classes;
using System.IO;
using System.Drawing.Imaging;

namespace ProCustomer.Forms
{
    public partial class Muayene : DevExpress.XtraEditors.XtraForm
    {
        MuayeneKart gelenkart = null;
        List<UrunMu> eklenenurunler = new List<UrunMu>();
        List<HatirlatmaData> datahat = new List<HatirlatmaData>();
        List<HatirlatmaData> datass = new List<HatirlatmaData>();
        ProCustomerDBEntities entities = Program.entities;
        int r1 = 0;
        int r2 = 0;
        int r3 = 0;
        int r4 = 0;
        int r5 = 0;
        int r6 = 0;
        public Muayene()
        {
            InitializeComponent();
        }

        public Muayene(MuayeneKart mk)
        {
            InitializeComponent();
            gelenkart = mk;
            MKDoldur();
        }

        public void MKDoldur()
        {
            Doldur();
            txtFiyat1.Text = gelenkart.MuayeneTutar.ToString();
            txtMuayeneNedeni.Text = gelenkart.MuayeneNedeni;
            txtMuayeneSonuc.Text = gelenkart.MuayeneSonucu;
            txtTeshis.Text = gelenkart.Teşhis;
            txtUygulananTedavi.Text = gelenkart.UygTedavi;
            cmbHayvani.SelectedItem = entities.HayvanTanims.First(a => a.ID == gelenkart.HayvanID);
            cmbHekim.SelectedItem = entities.Musteris.First(a => a.ID == gelenkart.MusteriID);
            cmbMusteri.SelectedItem = entities.Musteris.First(a => a.ID == gelenkart.MusteriID);
            foreach (var item in entities.Asilars.Where(a => a.MuayeneKartID == gelenkart.ID))
            {
                HatirlatmaData ekle = new HatirlatmaData
                {
                    TedaviAdı = item.AsiAdi,
                    TedaviTarihi = Convert.ToDateTime(item.AsiTarihi),
                };
                datass.Add(ekle);
            }
            AsiMain.DataSource = datass;
            foreach (var item in entities.KullMals.Where(a => a.MuayeneKart.ID == gelenkart.ID))
            {
                UrunMu urun = new UrunMu
                {
                    Adeti = Convert.ToInt32(item.UrunAdeti),
                    UrunAdı = item.Urun.UrunAdi,
                };
                eklenenurunler.Add(urun);
            }
            MalzemeMain.DataSource = eklenenurunler;
            cmbHayvani.Enabled = false;
            cmbMusteri.Enabled = false;
            cmbHekim.Enabled = false;
            btnMalzEkle.Enabled = false;
            nmrAdet.Enabled = false;
            cmbMalz.Enabled = false;
            btnSil.Enabled = false;
            try
            {
                MemoryStream ms = new MemoryStream(gelenkart.Sonuc1);
                pictureBox1.Image = Image.FromStream(ms);
                ms.Close();
            }
            catch
            {
                pictureBox1.Image = null;
            }
            try
            {
                MemoryStream ms = new MemoryStream(gelenkart.Sonuc2);
                pictureBox2.Image = Image.FromStream(ms);
                ms.Close();
            }
            catch
            {
                pictureBox2.Image = null;
            }
            try
            {
                MemoryStream ms = new MemoryStream(gelenkart.Sonuc3);
                pictureBox3.Image = Image.FromStream(ms);
                ms.Close();
            }
            catch
            {
                pictureBox3.Image = null;
            }
            try
            {
                MemoryStream ms = new MemoryStream(gelenkart.Sonuc4);
                pictureBox4.Image = Image.FromStream(ms);
                ms.Close();
            }
            catch
            {
                pictureBox4.Image = null;
            }
            try
            {
                MemoryStream ms = new MemoryStream(gelenkart.Sonuc5);
                pictureBox5.Image = Image.FromStream(ms);
                ms.Close();
            }
            catch
            {
                pictureBox5.Image = null;
            }
            try
            {
                MemoryStream ms = new MemoryStream(gelenkart.Sonuc6);
                pictureBox6.Image = Image.FromStream(ms);
                ms.Close();
            }
            catch
            {
                pictureBox6.Image = null;
            }
        }

        private void Muayene_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        public void Doldur()
        {
            cmbMusteri.DisplayMember = "Ad_Unvan";
            cmbMusteri.ValueMember = "ID";
            cmbMusteri.DataSource = entities.HayvanTanims.Where(a => a.Musteri != null).Select(a => a.Musteri);
            cmbMusteri.AutoCompleteCustomSource.AddRange(entities.HayvanTanims.Where(a => a.Musteri != null).Select(a => a.Musteri.Ad_Unvan).ToArray());
            cmbMusteri.SelectedIndex = 0;

            cmbHekim.DisplayMember = "Ad_Unvan";
            cmbHekim.ValueMember = "ID";
            cmbHekim.DataSource = entities.Musteris.Where(a => a.Meslek == "Şirket Hekimi");

            cmbMalz.DisplayMember = "UrunAdi";
            cmbMalz.ValueMember = "ID";
            cmbMalz.DataSource = entities.Uruns.Where(a => a.Fiyat1 == 0 && a.Fiyat2 == 0 && a.Fiyat3 == 0 && a.Fiyat4 == 0 && a.Fiyat5 == 0 && a.Fiyat6 == 0);
            cmbMalz.AutoCompleteCustomSource.AddRange(entities.Uruns.Where(a => a.Fiyat1 == 0 && a.Fiyat2 == 0 && a.Fiyat3 == 0 && a.Fiyat4 == 0 && a.Fiyat5 == 0 && a.Fiyat6 == 0).Select(a => a.UrunAdi).ToArray());
            txtMuayeneNedeni.AutoCompleteCustomSource.AddRange(entities.MuayeneKarts.Where(a => a.MuayeneNedeni != null).Select(a => a.MuayeneNedeni).ToArray());
            txtMuayeneSonuc.AutoCompleteCustomSource.AddRange(entities.MuayeneKarts.Where(a => a.MuayeneSonucu != null).Select(a => a.MuayeneSonucu).ToArray());
            txtTeshis.AutoCompleteCustomSource.AddRange(entities.MuayeneKarts.Where(a => a.Teşhis != null).Select(a => a.Teşhis).ToArray());
            txtUygulananTedavi.AutoCompleteCustomSource.AddRange(entities.MuayeneKarts.Where(a => a.UygTedavi != null).Select(a => a.UygTedavi).ToArray());
        }

        private void AsiDoldur()
        {
            txtAsiAdi.AutoCompleteCustomSource.AddRange(entities.Asilars.Where(a => a.AsiAdi != null).Select(a => a.AsiAdi).ToArray());
            AsiMain.DataSource = null;
            AsiMain.DataSource = datahat.ToList();
        }

        private void cmbMusteri_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cmbHayvani.DisplayMember = "Adi";
                cmbHayvani.ValueMember = "ID";
                Musteri asd = entities.Musteris.First(a => a.Ad_Unvan == cmbMusteri.Text);
                cmbHayvani.DataSource = entities.HayvanTanims.Where(a => a.Musteri.ID == asd.ID).ToArray();
            }
            catch (Exception)
            {
                cmbHayvani.DataSource = null;
                AsiMain.DataSource = null;
            }
        }

        private void btnAsiEkle_Click(object sender, EventArgs e)
        {
            cmbHayvani.Enabled = false;
            cmbHekim.Enabled = false;
            cmbMusteri.Enabled = false;
            if (cmbMusteri.SelectedIndex != -1)
            {
                if (txtAsiAdi.Text != "")
                {
                    Hatirlatmalar yeni = new Hatirlatmalar
                    {
                        Subject = "Aşı" + " " + txtAsiAdi.Text,
                        location = "M:" + (cmbMusteri.SelectedItem as Musteri).Ad_Unvan + " H:" + cmbHayvani.Text + " Dr:" + cmbHekim.Text,
                        Baslangic = dtpAsi.Value,
                        Bitis = dtpAsi.Value,
                        MusteriID = (cmbMusteri.SelectedItem as Musteri).ID,
                    };
                    entities.AddToHatirlatmalars(yeni);
                    entities.SaveChanges(true);
                    HatirlatmaData hdata = new HatirlatmaData
                    {
                        TedaviAdı = txtAsiAdi.Text,
                        TedaviTarihi = dtpAsi.Value.Date,
                    };
                    datahat.Add(hdata);
                    AsiDoldur();
                    txtAsiAdi.Text = "";
                }
                else
                {
                    _BildirimForm1.Goster("Aşı adı giriniz!.");
                }
            }
            else
            {
                _BildirimForm1.Goster("Müşteri seçimi yapmalısınız!.");
            }
        }

        private void btnMalzEkle_Click(object sender, EventArgs e)
        {
            if (cmbMalz.SelectedIndex != -1)
            {
                cmbHayvani.Enabled = false;
                cmbHekim.Enabled = false;
                cmbMusteri.Enabled = false;
                if (eklenenurunler.Where(a => a.UrunAdı.Contains(cmbMalz.Text)).Count() > 0)
                {
                    IEnumerable<UrunMu> detaylar = eklenenurunler.Where(a => a.UrunAdı == cmbMalz.Text);
                    UrunMu gelen = detaylar.First();
                    gelen.Adeti = gelen.Adeti + Convert.ToInt32(nmrAdet.Value);
                }
                else
                {
                    UrunMu eklenen = new UrunMu
                    {
                        Adeti = Convert.ToInt32(nmrAdet.Value),
                        UrunAdı = cmbMalz.Text,
                    };
                    eklenenurunler.Add(eklenen);
                }
                MalzemeMain.DataSource = null;
                MalzemeMain.DataSource = eklenenurunler.ToArray();
                nmrAdet.Value = 1;
            }
            else
            {
                cmbMalz.Text = "";
                _BildirimForm1.Goster("Böyle Bir Ürün Bulunmamaktadır!.");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            cmbHayvani.Enabled = false;
            cmbHekim.Enabled = false;
            cmbMusteri.Enabled = false;
            OpenFileDialog yukle = new OpenFileDialog();
            if (yukle.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = yukle.FileName;
                r1++;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            cmbHayvani.Enabled = false;
            cmbHekim.Enabled = false;
            cmbMusteri.Enabled = false;
            OpenFileDialog yukle = new OpenFileDialog();
            if (yukle.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = yukle.FileName;
                r2++;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            cmbHayvani.Enabled = false;
            cmbHekim.Enabled = false;
            cmbMusteri.Enabled = false;
            OpenFileDialog yukle = new OpenFileDialog();
            if (yukle.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.ImageLocation = yukle.FileName;
                r3++;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            cmbHayvani.Enabled = false;
            cmbHekim.Enabled = false;
            cmbMusteri.Enabled = false;
            OpenFileDialog yukle = new OpenFileDialog();
            if (yukle.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.ImageLocation = yukle.FileName;
                r4++;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            cmbHayvani.Enabled = false;
            cmbHekim.Enabled = false;
            cmbMusteri.Enabled = false;
            OpenFileDialog yukle = new OpenFileDialog();
            if (yukle.ShowDialog() == DialogResult.OK)
            {
                pictureBox5.ImageLocation = yukle.FileName;
                r5++;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            cmbHayvani.Enabled = false;
            cmbHekim.Enabled = false;
            cmbMusteri.Enabled = false;
            OpenFileDialog yukle = new OpenFileDialog();
            if (yukle.ShowDialog() == DialogResult.OK)
            {
                pictureBox6.ImageLocation = yukle.FileName;
                r6++;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (gelenkart == null && cmbMusteri.SelectedIndex != -1)
            {
                byte[] array6 = null;
                byte[] array1 = null;
                byte[] array2 = null;
                byte[] array3 = null;
                byte[] array4 = null;
                byte[] array5 = null;
                if (pictureBox1.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                    array1 = ms.GetBuffer();
                    ms.Close();
                }
                if (pictureBox2.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox2.Image.Save(ms, ImageFormat.Jpeg);
                    array2 = ms.GetBuffer();
                    ms.Close();
                }
                if (pictureBox3.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox3.Image.Save(ms, ImageFormat.Jpeg);
                    array3 = ms.GetBuffer();
                    ms.Close();
                }
                if (pictureBox4.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox4.Image.Save(ms, ImageFormat.Jpeg);
                    array4 = ms.GetBuffer();
                    ms.Close();
                }
                if (pictureBox5.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox5.Image.Save(ms, ImageFormat.Jpeg);
                    array5 = ms.GetBuffer();
                    ms.Close();
                }

                if (pictureBox6.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox6.Image.Save(ms, ImageFormat.Jpeg);
                    array6 = ms.GetBuffer();
                    ms.Close();
                }
                MuayeneKart kart = new MuayeneKart
                {
                    DoktorID = (cmbHekim.SelectedItem as Musteri).ID,
                    HayvanID = (cmbHayvani.SelectedItem as HayvanTanim).ID,
                    MusteriID = (cmbMusteri.SelectedItem as Musteri).ID,
                    MuayeneNedeni = txtMuayeneNedeni.Text,
                    MuayeneSonucu = txtMuayeneSonuc.Text,
                    MuayeneTutar = Convert.ToDecimal(txtFiyat1.Text),
                    Teşhis = txtTeshis.Text,
                    UygTedavi = txtUygulananTedavi.Text,
                    Sonuc1 = array1,
                    Sonuc2 = array2,
                    Sonuc3 = array3,
                    Sonuc4 = array4,
                    Sonuc5 = array5,
                    Sonuc6 = array6,
                    Tarih = DateTime.Now,
                };
                entities.AddToMuayeneKarts(kart);
                entities.SaveChanges(true);

                foreach (var item in datahat)
                {
                    Asilar asi = new Asilar
                    {
                        MuayeneKartID = kart.ID,
                        AsiAdi = item.TedaviAdı,
                        AsiTarihi = item.TedaviTarihi,
                    };
                    entities.AddToAsilars(asi);
                }
                foreach (var item in eklenenurunler)
                {
                    KullMal malz = new KullMal
                    {
                        MuayeneKart = kart,
                        UrunAdeti = item.Adeti,
                        Urun = entities.Uruns.First(a => a.UrunAdi == item.UrunAdı),
                    };
                    entities.AddToKullMals(malz);
                }
                foreach (var item in eklenenurunler)
                {
                    UrunStok stok = new UrunStok
                    {
                        Kasa = entities.Kasas.First(),
                        Miktar = item.Adeti,
                        Urun = entities.Uruns.First(a => a.UrunAdi == item.UrunAdı),
                        Giris = false,
                    };
                    entities.AddToUrunStoks(stok);
                }
                entities.SaveChanges(true);
                KasaIslem ekle = new KasaIslem
                {
                    OdemeTip = entities.OdemeTips.First(a=>a.ID==3),
                    Aciklama = "Muayene Bedeli",
                    Ad_Unvan = cmbMusteri.Text,
                    GirisCikis = true,
                    Tutar = Convert.ToDecimal(txtFiyat1.Text),
                    Tarih = DateTime.Now,
                    Musteri = (cmbMusteri.SelectedItem as Musteri),
                };
                entities.AddToKasaIslems(ekle);
                entities.SaveChanges(true);
                _BildirimForm1.Goster("işlem başarıyla kaydedilmiştir!.");
                Bosalt();

            }
            else if (gelenkart != null && cmbMusteri.SelectedIndex != -1)
            {
                byte[] array6 = null;
                byte[] array1 = null;
                byte[] array2 = null;
                byte[] array3 = null;
                byte[] array4 = null;
                byte[] array5 = null;
                MuayeneKart kart = entities.MuayeneKarts.First(a => a.ID == gelenkart.ID);
                kart.MuayeneNedeni = txtMuayeneNedeni.Text;
                kart.MuayeneSonucu = txtMuayeneSonuc.Text;
                kart.MuayeneTutar = Convert.ToDecimal(txtFiyat1.Text);
                kart.Teşhis = txtTeshis.Text;
                kart.UygTedavi = txtUygulananTedavi.Text;
                if (pictureBox1.Image != null && r1 > 0)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                    array1 = ms.GetBuffer();
                    kart.Sonuc1 = array1;
                    ms.Close();
                }
                if (pictureBox2.Image != null && r2 > 0)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox2.Image.Save(ms, ImageFormat.Jpeg);
                    array2 = ms.GetBuffer();
                    kart.Sonuc2 = array2;
                    ms.Close();
                }
                if (pictureBox3.Image != null && r3 > 0)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox3.Image.Save(ms, ImageFormat.Jpeg);
                    array3 = ms.GetBuffer();
                    kart.Sonuc3 = array3;
                    ms.Close();
                }
                if (pictureBox4.Image != null && r4 > 0)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox4.Image.Save(ms, ImageFormat.Jpeg);
                    array4 = ms.GetBuffer();
                    kart.Sonuc4 = array4;
                    ms.Close();
                }
                if (pictureBox5.Image != null && r5 > 0)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox5.Image.Save(ms, ImageFormat.Jpeg);
                    array5 = ms.GetBuffer();
                    kart.Sonuc5 = array5;
                    ms.Close();
                }

                if (pictureBox6.Image != null && r6 > 0)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox6.Image.Save(ms, ImageFormat.Jpeg);
                    array6 = ms.GetBuffer();
                    kart.Sonuc6 = array6;
                    ms.Close();
                }
                entities.SaveChanges(true);

                foreach (var item in datahat)
                {
                    Asilar asi = new Asilar
                    {
                        MuayeneKartID = kart.ID,
                        AsiAdi = item.TedaviAdı,
                        AsiTarihi = item.TedaviTarihi,
                    };
                    entities.AddToAsilars(asi);
                }
                entities.SaveChanges(true);
                if (Convert.ToDecimal(txtFiyat1.Text) - gelenkart.MuayeneTutar > 0)
                {
                    KasaIslem ekle = new KasaIslem
                    {
                        OdemeTip = entities.OdemeTips.First(a => a.ID == 3),
                        Aciklama = "Muayene Bedeli",
                        Ad_Unvan = cmbMusteri.Text,
                        GirisCikis = true,
                        Tutar = Convert.ToDecimal(txtFiyat1.Text) - gelenkart.MuayeneTutar,
                        Tarih = DateTime.Now,
                        Musteri = (cmbMusteri.SelectedItem as Musteri),
                    };
                    entities.AddToKasaIslems(ekle);
                    entities.SaveChanges(true);
                }
                _BildirimForm1.Goster("işlem başarıyla kaydedilmiştir!.");
            }
        }

        private void Bosalt()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            txtAsiAdi.Text = "";
            txtFiyat1.Text = "0";
            txtMuayeneNedeni.Text = "";
            txtMuayeneSonuc.Text = "";
            txtTeshis.Text = "";
            txtUygulananTedavi.Text = "";
            AsiMain.DataSource = null;
            MalzemeMain.DataSource = null;
        }


        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                Image sonuc = pictureBox2.Image;
                PhotoForm yukle = new PhotoForm();
                yukle.pictureBox1.Image = sonuc;
                yukle.ShowDialog();
            }
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            if (pictureBox3.Image != null)
            {
                Image sonuc = pictureBox3.Image;
                PhotoForm yukle = new PhotoForm();
                yukle.pictureBox1.Image = sonuc;
                yukle.ShowDialog();
            }
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            if (pictureBox4.Image != null)
            {
                Image sonuc = pictureBox4.Image;
                PhotoForm yukle = new PhotoForm();
                yukle.pictureBox1.Image = sonuc;
                yukle.ShowDialog();
            }
        }

        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            if (pictureBox5.Image != null)
            {
                Image sonuc = pictureBox5.Image;
                PhotoForm yukle = new PhotoForm();
                yukle.pictureBox1.Image = sonuc;
                yukle.ShowDialog();
            }
        }

        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        {
            if (pictureBox6.Image != null)
            {
                Image sonuc = pictureBox6.Image;
                PhotoForm yukle = new PhotoForm();
                yukle.pictureBox1.Image = sonuc;
                yukle.ShowDialog();
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Image sonuc = pictureBox1.Image;
                PhotoForm yukle = new PhotoForm();
                yukle.pictureBox1.Image = sonuc;
                yukle.ShowDialog();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            HatirlatmaData silinecek = AsiMainS.GetFocusedRow() as HatirlatmaData;
            HatirlatmaData silinen = datahat.Where(a => a == silinecek).First();
            datahat.Remove(silinen);
            AsiMain.DataSource = null;
            AsiMain.DataSource = datahat;
        }
    }
}