using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;

namespace ProCustomer.Forms
{
    public partial class _31UrunEkleDegistirForm : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        public _31UrunEkleDegistirForm()
        {
            InitializeComponent();
        }

        Urun URN = null;
        public _31UrunEkleDegistirForm(Urun urn)
        {
            InitializeComponent();
            URN = urn;
            Doldur();
            KayitDoldur();
        }

        private void KayitDoldur()
        {
            cmbKategori.SelectedValue = URN.UrunGrup.ID;
            txtUrunTanim.Text = URN.UrunAdi;
            txtBarkod.Text = URN.Barkod;
            txtFiyat1.Text = URN.Fiyat1.ToString();
            txtFiyat2.Text = URN.Fiyat2.ToString();
            txtFiyat3.Text = URN.Fiyat3.ToString();
            txtFiyat4.Text = URN.Fiyat4.ToString();
            txtFiyat5.Text = URN.Fiyat5.ToString();
            txtFiyat6.Text = URN.Fiyat6.ToString();
            txtAciklama.Text = URN.Aciklama;
            nudKdv.Value = URN.KdvOran;
            chkKDV.Checked = URN.KdvDahil;
        }

        private void _31UrunEkleDegistirForm_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            entities.Refresh(RefreshMode.StoreWins, entities.Uruns);
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (URN == null)
            {
                string urunadi = txtUrunTanim.Text;
                if (entities.Uruns.Where(a => a.UrunAdi.Contains(urunadi)).Count() > 0)
                {
                    _BildirimForm1.Goster("Aynı isimle tanımlanmış ürün bulunmaktadır.");
                }
                else
                {
                    try
                    {
                        Urun yeniurun = new Urun
                        {
                            Aciklama = txtAciklama.Text,
                            Barkod = txtBarkod.Text,
                            Fiyat1 = Convert.ToDecimal(txtFiyat1.Text),
                            Fiyat2 = Convert.ToDecimal(txtFiyat2.Text),
                            Fiyat3 = Convert.ToDecimal(txtFiyat3.Text),
                            Fiyat4 = Convert.ToDecimal(txtFiyat4.Text),
                            Fiyat5 = Convert.ToDecimal(txtFiyat5.Text),
                            Fiyat6 = Convert.ToDecimal(txtFiyat6.Text),
                            KdvDahil = chkKDV.Checked,
                            KdvOran = Convert.ToByte(nudKdv.Value),
                            UrunAdi = txtUrunTanim.Text,
                            UrunGrup = cmbKategori.SelectedItem as UrunGrup,
                        };
                        entities.AddToUruns(yeniurun);
                        int stokadeti = 0;
                        try
                        {
                            stokadeti = Convert.ToInt32(txtStok.Text);
                        }
                        catch
                        {
                            stokadeti = 0;
                        }
                        UrunStok yenistok = new UrunStok
                        {
                            Kasa = entities.Kasas.First(),
                            Miktar = stokadeti,
                            Urun = yeniurun,
                            Giris = true,
                        };
                        entities.AddToUrunStoks(yenistok);
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
            else
            {
                try
                {
                    Urun degistirilen = entities.Uruns.First(a => a.ID == URN.ID);

                    degistirilen.Aciklama = txtAciklama.Text;
                    degistirilen.Barkod = txtBarkod.Text;
                    degistirilen.Fiyat1 = Convert.ToDecimal(txtFiyat1.Text);
                    degistirilen.Fiyat2 = Convert.ToDecimal(txtFiyat2.Text);
                    degistirilen.Fiyat3 = Convert.ToDecimal(txtFiyat3.Text);
                    degistirilen.Fiyat4 = Convert.ToDecimal(txtFiyat4.Text);
                    degistirilen.Fiyat5 = Convert.ToDecimal(txtFiyat5.Text);
                    degistirilen.Fiyat6 = Convert.ToDecimal(txtFiyat6.Text);
                    degistirilen.KdvDahil = chkKDV.Checked;
                    degistirilen.KdvOran = Convert.ToByte(nudKdv.Value);
                    degistirilen.UrunAdi = txtUrunTanim.Text;
                    degistirilen.UrunGrup = cmbKategori.SelectedItem as UrunGrup;

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

        private void btnKatEkle_Click(object sender, EventArgs e)
        {
            _32UrunGrupForm ugfrm = new _32UrunGrupForm() { };
            ugfrm.FormClosed += delegate
            {
                Doldur();
            };
            ugfrm.ShowDialog();
        }

        void Doldur()
        {
            cmbKategori.DataSource = null;
            cmbKategori.DisplayMember = "GrupTanim";
            cmbKategori.ValueMember = "ID";
            cmbKategori.DataSource = entities.UrunGrups;
            txtStok.Text = "0";
        }
    }
}
