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

namespace ProCustomer.Forms
{
    public partial class _25EsDurum : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        public _25EsDurum()
        {
            InitializeComponent();
        }

        private void _25EsDurum_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        public void Doldur()
        {
            grdEsMain.DataSource = null;
            List<PetData> datadizi = new List<PetData>();
            var sorgu = entities.HayvanTanims.Where(a=>a.Ciftlesme==true && a.Musteri!=null && a.Cinsi!=null).OrderBy(a => a.ID).ToArray();
            
            foreach (var item in sorgu)
            {
                string id = entities.HayvanTanims.Where(a => a.ID == item.ID).Select(a => a.Musteri).First().ID.ToString();
                int idd = Convert.ToInt32(id);
                string madi = entities.Musteris.Where(a => a.ID == idd).Select(a => a.Ad_Unvan).First().ToString();
                datadizi.Add(new PetData
                {
                    Adi = item.Adi,
                    Aylık = item.Aylik,
                    ID = item.ID,
                    Cinsi = item.Cinsi==true?true:false,
                    Türü = item.Turu,
                    Müşteri = madi,
                });
            }
            grdEsMain.DataSource = datadizi;
            grdEs.Columns[0].OptionsColumn.ReadOnly = true;
            grdEs.Columns[1].OptionsColumn.ReadOnly = true;
            grdEs.Columns[2].OptionsColumn.ReadOnly = true;
            grdEs.Columns[3].OptionsColumn.ReadOnly = true;
            grdEs.Columns[4].OptionsColumn.ReadOnly = true;
            
            cmbTur.DisplayMember = "TurAdi";
            cmbTur.ValueMember = "ID";
            cmbTur.DataSource = entities.HayvanTurs;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAylik.Text == "")
            {
                grdEsMain.DataSource = null;
                List<PetData> datadizi = new List<PetData>();
                var sorgu = entities.HayvanTanims.Where(a => a.Turu == cmbTur.Text && a.Ciftlesme == true).OrderBy(a => a.ID).ToArray();
                foreach (var item in sorgu)
                {
                    string id = entities.HayvanTanims.Where(a => a.ID == item.ID).Select(a => a.Musteri).First().ID.ToString();
                    int idd = Convert.ToInt32(id);
                    string madi = entities.Musteris.Where(a => a.ID == idd).Select(a => a.Ad_Unvan).First().ToString();
                    datadizi.Add(new PetData
                    {
                        Adi = item.Adi,
                        Aylık = item.Aylik,
                        ID = item.ID,
                        Cinsi = item.Cinsi == true ? true : false,
                        Türü = item.Turu,
                        Müşteri = madi,
                    });
                }

                grdEsMain.DataSource = datadizi;
                grdEs.Columns[0].OptionsColumn.ReadOnly = true;
                grdEs.Columns[1].OptionsColumn.ReadOnly = true;
                grdEs.Columns[2].OptionsColumn.ReadOnly = true;
                grdEs.Columns[3].OptionsColumn.ReadOnly = true;
                grdEs.Columns[4].OptionsColumn.ReadOnly = true;
            }
            else
            {
                try
                {
                    grdEsMain.DataSource = null;
                    int yas = Convert.ToInt32(txtAylik.Text);
                    List<PetData> datadizi = new List<PetData>();
                    var sorgu = entities.HayvanTanims.Where(a => a.Turu == cmbTur.Text && a.Ciftlesme == true && a.Aylik == yas).OrderBy(a=>a.ID).ToArray();
                    foreach (var item in sorgu)
                    {
                        string id = entities.HayvanTanims.Where(a => a.ID == item.ID).Select(a => a.Musteri).First().ID.ToString();
                        int idd = Convert.ToInt32(id);
                        string madi = entities.Musteris.Where(a => a.ID == idd).Select(a => a.Ad_Unvan).First().ToString();
                        datadizi.Add(new PetData
                        {
                            Adi = item.Adi,
                            Aylık = item.Aylik,
                            ID = item.ID,
                            Cinsi = item.Cinsi == true ? true : false,
                            Türü = item.Turu,
                            Müşteri = madi,
                        });
                    }


                    grdEsMain.DataSource = datadizi;
                    grdEs.Columns[0].OptionsColumn.ReadOnly = true;
                    grdEs.Columns[1].OptionsColumn.ReadOnly = true;
                    grdEs.Columns[2].OptionsColumn.ReadOnly = true;
                    grdEs.Columns[3].OptionsColumn.ReadOnly = true;
                    grdEs.Columns[4].OptionsColumn.ReadOnly = true;
                }
                catch
                {
                    _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}