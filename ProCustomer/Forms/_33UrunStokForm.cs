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
using ProCustomer.UserControls;

namespace ProCustomer.Forms
{
    public partial class _33UrunStokForm : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        byte SW;
        UrunStok STOK;
        Urun GELENURUN;
        //sw=1 arttır
        //2 azalt
        //3 düzenle
        public _33UrunStokForm(byte sw, UrunStok stok, Urun gelenurun)
        {
            InitializeComponent();
            SW = sw;
            STOK = stok == null ? null : entities.UrunStoks.First(a => a.ID == stok.ID);
            GELENURUN = gelenurun;
        }

        private void _33UrunStokForm_Load(object sender, EventArgs e)
        {
            txtMiktar.Text = "0";
            cmbIslemYeri.DisplayMember = "KasaAdi";
            cmbIslemYeri.ValueMember = "ID";
            cmbIslemYeri.DataSource = entities.Kasas;

            //cmbUrun.DisplayMember = "UrunAdi";
            //cmbUrun.ValueMember = "ID";
            //cmbUrun.DataSource = entities.Uruns;
            //cmbUrun.AutoCompleteCustomSource.AddRange(entities.Uruns.Select(a => a.UrunAdi).ToArray());

            if (SW == 3)
            {
                cmbIslemYeri.SelectedItem = STOK.Kasa;
                //cmbUrun.SelectedValue = STOK.UrunID;
                txtMiktar.Text = STOK.Miktar.ToString();
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            entities.Refresh(RefreshMode.StoreWins, entities.UrunStoks);
            this.Close();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            switch (SW)
            {
                case 1:
                    //arttır
                    UrunStok stokarttir = new UrunStok
                    {
                        Giris = true,
                        Kasa = cmbIslemYeri.SelectedItem as Kasa,
                        Miktar = Convert.ToInt32(txtMiktar.Text),
                        Urun = GELENURUN,
                    };
                    entities.AddToUrunStoks(stokarttir);
                    break;
                case 2:
                    //azalt
                    UrunStok stokazalt = new UrunStok
                  {
                      Giris = false,
                      Kasa = cmbIslemYeri.SelectedItem as Kasa,
                      Miktar = Convert.ToInt32(txtMiktar.Text),
                      Urun = GELENURUN,
                  };
                    entities.AddToUrunStoks(stokazalt);
                    break;
                case 3:
                    //düzenle
                    UrunStok yenile = entities.UrunStoks.First(a => a.ID == STOK.ID);
                    yenile.Kasa = cmbIslemYeri.SelectedItem as Kasa;
                    yenile.Miktar = Convert.ToInt32(txtMiktar.Text);
                    break;
            }
            entities.SaveChanges(true);
            _BildirimForm1.Goster("Kayıt işlemi başarıyla gerçekleştirildi.");
            this.Close();
        }
    }
}