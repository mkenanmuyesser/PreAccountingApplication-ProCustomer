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

namespace ProCustomer.UserControls
{
    public partial class _4KasaModul : UserControl
    {
        public ProCustomerDBEntities entities = Program.entities;
        public _4KasaModul()
        {
            InitializeComponent(); 
        }

        private void CariModul_Load(object sender, EventArgs e)
        {
            if (e != null)
            {
                dtpBaslangic.Value = DateTime.Now.Date;
                dtpBitis.Value = DateTime.Now.Date.AddDays(1).AddMinutes(-1);
                cmbHareketler.SelectedIndex = 0;

                List<Kasa> dolan = new List<Kasa>();
                Kasa abc = new Kasa
                {
                    KasaAdi = "Tüm Kasalar",
                };
                dolan.Add(abc);
                foreach (Kasa item in entities.Kasas)
                {
                    dolan.Add(item);
                }

                cmbKasa.DisplayMember = "KasaAdi";
                cmbKasa.ValueMember = "ID";
                cmbKasa.DataSource = dolan;

                /////

                List<Personel> dolan1 = new List<Personel>();
                Personel per = new Personel
                {
                    AdSoyad = "Tüm Personel",
                };
                dolan1.Add(per);
                foreach (Personel item in entities.Personels)
                {
                    dolan1.Add(item);
                }

                cmbPersonel.DisplayMember = "AdSoyad";
                cmbPersonel.ValueMember = "ID";
                cmbPersonel.DataSource = dolan1;

                //cmbPersonel.AutoCompleteCustomSource.AddRange(entities.Personels.Select(a => a.AdSoyad).ToArray());

                List<OdemeTip> tip = new List<OdemeTip>();
                OdemeTip qwe = new OdemeTip
                {
                    OdemeTipi = "Tüm Tipler",
                };
                tip.Add(qwe);
                foreach (OdemeTip item in entities.OdemeTips)
                {
                    tip.Add(item);
                }
                cmbOdemeTipi.DisplayMember = "OdemeTipi";
                cmbOdemeTipi.ValueMember = "ID";
                cmbOdemeTipi.DataSource = tip;
                Doldur();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        public void Doldur()
        {
            List<KasaData> dizidata = new List<KasaData>();
            if (!string.IsNullOrEmpty(txtEvrakNo.Text))
            {
                var sorgu = entities.KasaIslems.Where(a => a.EvrakNo.Contains(txtEvrakNo.Text)).Select(a => new { a.ID, a.Tarih, a.Musteri, a.Tutar, a.GirisCikis }).OrderByDescending(a => a.Tarih);
                foreach (var item in sorgu)
                {

                    dizidata.Add(new KasaData
                    {
                        GirisCikis = item.GirisCikis==true?"Tahsilat":"Satış",
                        ID = item.ID,
                        MusteriAdi = item.Musteri == null ? "--Silinmiş Müşteri--" : item.Musteri.Ad_Unvan,
                        Tarih = item.Tarih,
                        Tutar = item.Tutar.ToString("C"),
                    });
                }
            }
            else if (!string.IsNullOrEmpty(txtCari.Text))
            {
                var sorgu = entities.KasaIslems.Where(a => a.Ad_Unvan.Contains(txtCari.Text)).Select(a => new { a.ID, a.Tarih, a.Musteri, a.Tutar, a.GirisCikis }).OrderByDescending(a => a.Tarih);
                foreach (var item in sorgu)
                {
                    dizidata.Add(new KasaData
                    {
                        GirisCikis = item.GirisCikis == true ? "Tahsilat" : "Satış",
                        ID = item.ID,
                        MusteriAdi = item.Musteri == null ? "--Silinmiş Müşteri--" : item.Musteri.Ad_Unvan,
                        Tarih = item.Tarih,
                        Tutar = item.Tutar.ToString("C"),
                    });
                }
            }
            else
            {
                if (cmbKasa.SelectedIndex == 0 && cmbHareketler.SelectedIndex == 0 && cmbPersonel.SelectedIndex == 0 && cmbOdemeTipi.SelectedIndex == 0)
                {
                    var sorgu = entities.KasaIslems.Select(a => new { a.ID, a.Tarih, a.Musteri, a.Tutar, a.GirisCikis }).OrderByDescending(a => a.Tarih);
                    foreach (var item in sorgu)
                    {
                        dizidata.Add(new KasaData
                        {
                            GirisCikis = item.GirisCikis == true ? "Tahsilat" : "Satış",
                            ID = item.ID,
                            MusteriAdi = item.Musteri == null ? "--Silinmiş Müşteri--" : item.Musteri.Ad_Unvan,
                            Tarih = item.Tarih,
                            Tutar = item.Tutar.ToString("C"),
                        });
                    }
                }
                else
                {
                    if (cmbKasa.SelectedIndex > 0)
                    {
                        int id = (cmbKasa.SelectedItem as Kasa).ID;
                        var sorgu = entities.KasaIslems.Where(a => a.Kasa.ID == id).Select(a => new { a.ID, a.Tarih, a.Musteri, a.Tutar, a.GirisCikis }).OrderByDescending(a => a.Tarih);
                        foreach (var item in sorgu)
                        {
                            dizidata.Add(new KasaData
                            {
                                GirisCikis = item.GirisCikis == true ? "Tahsilat" : "Satış",
                                ID = item.ID,
                                MusteriAdi = item.Musteri == null ? "--Silinmiş Müşteri--" : item.Musteri.Ad_Unvan,
                                Tarih = item.Tarih,
                                Tutar = item.Tutar.ToString("C"),
                            });
                        }
                    }
                    else if (cmbHareketler.SelectedIndex > 0)
                    {
                        var sorgu = entities.KasaIslems.Where(a => (a.GirisCikis == (cmbHareketler.SelectedIndex == 1 ? true : false))).Select(a => new { a.ID, a.Tarih, a.Musteri, a.Tutar, a.GirisCikis }).OrderByDescending(a => a.Tarih);
                        foreach (var item in sorgu)
                        {
                            dizidata.Add(new KasaData
                            {
                                GirisCikis = item.GirisCikis == true ? "Tahsilat" : "Satış",
                                ID = item.ID,
                                MusteriAdi = item.Musteri == null ? "--Silinmiş Müşteri--" : item.Musteri.Ad_Unvan,
                                Tarih = item.Tarih,
                                Tutar = item.Tutar.ToString("C"),
                            });
                        }
                    }
                    else if (cmbPersonel.SelectedIndex > 0)
                    {
                        int id = (cmbPersonel.SelectedItem as Personel).ID;
                        var sorgu = entities.KasaIslems.Where(a => a.Personel.ID == id).Select(a => new { a.ID, a.Tarih, a.Musteri, a.Tutar, a.GirisCikis }).OrderByDescending(a => a.Tarih);
                        foreach (var item in sorgu)
                        {
                            dizidata.Add(new KasaData
                            {
                                GirisCikis = item.GirisCikis == true ? "Tahsilat" : "Satış",
                                ID = item.ID,
                                MusteriAdi = item.Musteri == null ? "--Silinmiş Müşteri--" : item.Musteri.Ad_Unvan,
                                Tarih = item.Tarih,
                                Tutar = item.Tutar.ToString("C"),
                            });
                        }
                    }
                    else if (cmbOdemeTipi.SelectedIndex > 0)
                    {
                        int id = (cmbOdemeTipi.SelectedItem as OdemeTip).ID;
                        var sorgu = entities.KasaIslems.Where(a => a.OdemeTip.ID == id).Select(a => new { a.ID, a.Tarih, a.Musteri, a.Tutar, a.GirisCikis }).OrderByDescending(a => a.Tarih);
                        foreach (var item in sorgu)
                        {
                            dizidata.Add(new KasaData
                            {
                                GirisCikis = item.GirisCikis == true ? "Tahsilat" : "Satış",
                                ID = item.ID,
                                MusteriAdi = item.Musteri==null?"--Silinmiş Müşteri--":item.Musteri.Ad_Unvan,
                                Tarih = item.Tarih,
                                Tutar = item.Tutar.ToString("C"),
                            });
                        }
                    }

                }

            }

            grdKasaMain.DataSource = dizidata;
            grdKasa.OptionsBehavior.ReadOnly = true;
        }

        private void cmbKasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKasa.SelectedIndex != 0)
            {
                txtEvrakNo.Text = "";
                txtCari.Text = "";
                cmbHareketler.SelectedIndex = 0;
                cmbPersonel.SelectedIndex = 0;
                cmbOdemeTipi.SelectedIndex = 0;

                txtEvrakNo.Enabled = false;
                txtCari.Enabled = false;
                cmbHareketler.Enabled = false;
                cmbPersonel.Enabled = false;
                cmbOdemeTipi.Enabled = false;
            }
            else
            {
                txtEvrakNo.Enabled = true;
                txtCari.Enabled = true;
                cmbHareketler.Enabled = true;
                cmbPersonel.Enabled = true;
                cmbOdemeTipi.Enabled = true;
            }
        }

        private void cmbHareketler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHareketler.SelectedIndex != 0)
            {
                txtEvrakNo.Text = "";
                txtCari.Text = "";
                cmbKasa.SelectedIndex = 0;
                cmbPersonel.SelectedIndex = 0;
                cmbOdemeTipi.SelectedIndex = 0;

                txtEvrakNo.Enabled = false;
                txtCari.Enabled = false;
                cmbKasa.Enabled = false;
                cmbPersonel.Enabled = false;
                cmbOdemeTipi.Enabled = false;
            }
            else
            {
                txtEvrakNo.Enabled = true;
                txtCari.Enabled = true;
                cmbKasa.Enabled = true;
                cmbPersonel.Enabled = true;
                cmbOdemeTipi.Enabled = true;
            }
        }

        private void cmbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPersonel.SelectedIndex != 0)
            {
                txtEvrakNo.Text = "";
                txtCari.Text = "";
                cmbKasa.SelectedIndex = 0;
                cmbHareketler.SelectedIndex = 0;
                cmbOdemeTipi.SelectedIndex = 0;

                txtEvrakNo.Enabled = false;
                txtCari.Enabled = false;
                cmbKasa.Enabled = false;
                cmbHareketler.Enabled = false;
                cmbOdemeTipi.Enabled = false;
            }
            else
            {
                txtEvrakNo.Enabled = true;
                txtCari.Enabled = true;
                cmbKasa.Enabled = true;
                cmbHareketler.Enabled = true;
                cmbOdemeTipi.Enabled = true;
            }
        }

        private void cmbOdemeTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOdemeTipi.SelectedIndex != 0)
            {
                txtEvrakNo.Text = "";
                txtCari.Text = "";
                cmbKasa.SelectedIndex = 0;
                cmbHareketler.SelectedIndex = 0;
                cmbPersonel.SelectedIndex = 0;

                txtEvrakNo.Enabled = false;
                txtCari.Enabled = false;
                cmbKasa.Enabled = false;
                cmbHareketler.Enabled = false;
                cmbPersonel.Enabled = false;
            }
            else
            {
                txtEvrakNo.Enabled = true;
                txtCari.Enabled = true;
                cmbKasa.Enabled = true;
                cmbHareketler.Enabled = true;
                cmbPersonel.Enabled = true;
            }
        }
    }
}
