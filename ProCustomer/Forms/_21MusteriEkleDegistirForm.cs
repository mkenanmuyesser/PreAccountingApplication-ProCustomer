using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using ProCustomer.UserControls;
using ProCustomer.Forms.Tanimlama;

namespace ProCustomer.Forms
{
    public partial class _21MusteriEkleDegistirForm : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        int MUSTERIID;
        public _21MusteriEkleDegistirForm()
        {
            InitializeComponent();
            Doldur();
            btnHayvanTanimla.Visible = false;
        }

        public _21MusteriEkleDegistirForm(int Musteriid)
        {
            InitializeComponent();
            Doldur();
            MUSTERIID = Musteriid;
            kayitdoldur();
            if (Program.kategori == "Pet;" || Program.kategori == "Vet;")
            {
                btnHayvanTanimla.Visible = true;
            }
            else
            {
                btnHayvanTanimla.Visible = false;
            }
        }

        public _21MusteriEkleDegistirForm(bool menu, bool menudengelen)
        {
            InitializeComponent();
            Doldur();
            if (Program.kategori == "Pet")
            {
                btnHayvanTanimla.Visible = true;
            }
            else
            {
                btnHayvanTanimla.Visible = false;
            }
        }

        public void kayitdoldur()
        {
            Musteri gelen = entities.Musteris.First(a => a.ID == MUSTERIID);
            txtAdUnvan.Text = gelen.Ad_Unvan;
            txtTel1.Text = gelen.Telefon1;
            txtTel2.Text = gelen.Telefon2;
            txtTel3.Text = gelen.Telefon3;
            txtTel4.Text = gelen.Telefon4;
            txtTel5.Text = gelen.Telefon5;
            txtTel6.Text = gelen.Telefon6;
            txtAcikadres.Text = gelen.Adres;
            txtFatAdres.Text = gelen.FaturaAdres;
            txtVergiDai.Text = gelen.VergiDairesi;
            txtVergiNo.Text = gelen.VergiNo;
            txtAciklama.Text = gelen.Aciklama;
            txtEMail.Text = gelen.Eposta;
            cmbBolgeAdi.SelectedItem = gelen.Bolge;
            cmbMusteriGrup.SelectedItem = gelen.MusteriGrup;
            cmbMeslek.Text = gelen.Meslek;
            txtBarkodNo.Text = gelen.Barkod;
            chkGold.Checked = gelen.Gold == true ? true : false;
            bool sonuc = gelen.Cinsiyet;
            if (sonuc)
            {
                rdBay.Checked = true;
            }
            else
            {
                rdBayan.Checked = true;
            }
            txtFatUnvan.Text = gelen.FaturaUnvan;
        }

        public void _21MusteriEkleDegistirForm_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (entities.Mesleklers.Where(a => a.Meslek == cmbMeslek.Text).Count() == 0)
            {
                Meslekler yeni = new Meslekler
                {
                    Meslek = cmbMeslek.Text,
                };
                entities.AddToMesleklers(yeni);
                entities.SaveChanges(true);
            }

            if (MUSTERIID == 0)
            {
                int bid = Convert.ToInt32(cmbBolgeAdi.SelectedValue);
                Musteri asd = new Musteri
                {
                    MusteriGrup = cmbMusteriGrup.SelectedItem as MusteriGrup,
                    Ad_Unvan = txtAdUnvan.Text,
                    Telefon1 = txtTel1.Text,
                    Telefon2 = txtTel2.Text,
                    Telefon3 = txtTel3.Text,
                    Telefon4 = txtTel4.Text,
                    Telefon5 = txtTel5.Text,
                    Telefon6 = txtTel6.Text,
                    Adres = txtAcikadres.Text,
                    FaturaAdres = txtFatAdres.Text,
                    VergiDairesi = txtVergiDai.Text,
                    VergiNo = txtVergiNo.Text,
                    Aciklama = txtAciklama.Text,
                    Eposta = txtEMail.Text,
                    Bolge = entities.Bolges.First(a => a.ID == bid),
                    Cinsiyet = rdBay.Checked,
                    //FaturaGrupID=
                    FaturaUnvan = txtFatUnvan.Text,
                    KayitTarihi = DateTime.Now,
                    Meslek = cmbMeslek.Text,
                    //ZimmetMiktar
                    //Sirket
                    OzelGunHatırlat = chkOGHatirlat.Checked,
                    OzelGunTarih = dtpOGHatirlat.Value,
                    Tarih = dtpDiger.Value,
                    Hatırlat = chkDiger.Checked,
                    DogumGunuHatırlat = chkDGHatirlat.Checked,
                    DogumGunuTarih = dtpDGHatirlat.Value,
                    Barkod = txtBarkodNo.Text,
                    Gold = chkGold.Checked,
                };
                entities.AddToMusteris(asd);
                entities.SaveChanges(true);
            }
            else
            {
                Musteri gelen = entities.Musteris.First(a => a.ID == MUSTERIID);
                gelen.Ad_Unvan = txtAdUnvan.Text;
                gelen.Telefon1 = txtTel1.Text;
                gelen.Telefon2 = txtTel2.Text;
                gelen.Telefon3 = txtTel3.Text;
                gelen.Telefon4 = txtTel4.Text;
                gelen.Telefon5 = txtTel5.Text;
                gelen.Telefon6 = txtTel6.Text;
                gelen.Adres = txtAcikadres.Text;
                gelen.FaturaAdres = txtFatAdres.Text;
                gelen.VergiDairesi = txtVergiDai.Text;
                gelen.VergiNo = txtVergiNo.Text;
                gelen.Aciklama = txtAciklama.Text;
                gelen.Eposta = txtEMail.Text;
                gelen.Bolge = cmbBolgeAdi.SelectedItem as Bolge;
                gelen.Cinsiyet = rdBay.Checked;
                gelen.FaturaUnvan = txtFatUnvan.Text;
                gelen.Meslek = cmbMeslek.Text;
                gelen.DogumGunuHatırlat = chkDGHatirlat.Checked;
                gelen.DogumGunuTarih = dtpDGHatirlat.Value;
                gelen.OzelGunHatırlat = chkOGHatirlat.Checked;
                gelen.OzelGunTarih = dtpOGHatirlat.Value;
                gelen.Hatırlat = chkDiger.Checked;
                gelen.Tarih = dtpDiger.Value;
                gelen.Barkod = txtBarkodNo.Text;
                entities.SaveChanges(true);
                gelen.Gold = chkGold.Checked;
                gelen.MusteriGrup = cmbMusteriGrup.SelectedItem as MusteriGrup;
            }
            //Doldur();
            this.Close();

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Doldur()
        {
            cmbMusteriGrup.DataSource = null;
            cmbMusteriGrup.ValueMember = "ID";
            cmbMusteriGrup.DisplayMember = "GrupTanim";
            cmbMusteriGrup.DataSource = entities.MusteriGrups;

            cmbBolgeAdi.DataSource = null;
            cmbBolgeAdi.ValueMember = "ID";
            cmbBolgeAdi.DisplayMember = "Tanim";
            cmbBolgeAdi.DataSource = entities.Bolges;

            cmbMeslek.DataSource = null;
            cmbMeslek.ValueMember = "ID";
            cmbMeslek.DisplayMember = "Meslek";
            cmbMeslek.DataSource = entities.Mesleklers;
            cmbMeslek.AutoCompleteCustomSource.AddRange(entities.Mesleklers.Select(a=>a.Meslek).ToArray());
        }

        public void Doldur1()
        {
            ProCustomerDBEntities en = new ProCustomerDBEntities();
            cmbBolgeAdi.DataSource = null;
            cmbBolgeAdi.ValueMember = "ID";
            cmbBolgeAdi.DisplayMember = "Tanim";
            cmbBolgeAdi.DataSource = en.Bolges;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _22MusteriGrupForm frm = new _22MusteriGrupForm();
            frm.FormClosed += delegate
            {
                Doldur();
            };
            frm.ShowDialog();
        }

        private void btnBEkle_Click(object sender, EventArgs e)
        {
            BolgeListeForm son = new BolgeListeForm();
            son.FormClosed += delegate
            {
                Doldur1();
            };
            son.ShowDialog();
        }

        private void btnHayvanTanimla_Click(object sender, EventArgs e)
        {
            _9HayvanTanimForm son = new _9HayvanTanimForm(MUSTERIID);
            son.FormClosed += delegate
            {

            };
            son.ShowDialog();
        }
    }
}
