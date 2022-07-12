using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ProCustomer.Classes;
using System.Data.Objects;
using System.Linq;

namespace ProCustomer.Forms
{
    public partial class _22MusteriGrupForm : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        public _22MusteriGrupForm()
        {
            InitializeComponent();
        }

        private void _22MusteriGrupForm_Load(object sender, EventArgs e)
        {
            DataLoad.MusteriTreeDoldur(treMusteri, null);
            treMusteri.ExpandAll();
        }

        private void btnAnaGrupEkle_Click(object sender, EventArgs e)
        {
            MusteriGrup anagrup = new MusteriGrup
            {
                GrupTanim = txtGrupTanim.Text,
            };
            entities.AddToMusteriGrups(anagrup);
            try
            {
                entities.SaveChanges(true);
            }
            catch
            {
                _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
                entities.Refresh(RefreshMode.StoreWins, entities.MusteriGrups);
            }
            DataLoad.MusteriTreeDoldur(treMusteri, null);
            treMusteri.ExpandAll();
            txtGrupTanim.Text = "";
        }

        private void btnAltGrupEkle_Click(object sender, EventArgs e)
        {
            if (treMusteri.SelectedNode == null)
            {
                _BildirimForm1.Goster("Kayıt bulunamadı!");
            }
            else if ((treMusteri.SelectedNode.Tag as MusteriGrup).AltGrupID != null)
            {
                MusteriGrup urngrp = treMusteri.SelectedNode.Tag as MusteriGrup;
                MusteriGrup altgrup = new MusteriGrup
                {
                    GrupTanim = txtGrupTanim.Text,
                    AltGrupID = urngrp.AltGrupID,
                };
                entities.AddToMusteriGrups(altgrup);

                try
                {
                    entities.SaveChanges(true);
                }
                catch
                {
                    _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
                    entities.Refresh(RefreshMode.StoreWins, entities.MusteriGrups);
                }

                DataLoad.MusteriTreeDoldur(treMusteri, null);
                treMusteri.ExpandAll();
            }
            else
            {
                MusteriGrup urngrp = treMusteri.SelectedNode.Tag as MusteriGrup;
                MusteriGrup altgrup = new MusteriGrup
                {
                    GrupTanim = txtGrupTanim.Text,
                    AltGrupID = urngrp.ID,
                };
                entities.AddToMusteriGrups(altgrup);

                try
                {
                    entities.SaveChanges(true);
                }
                catch
                {
                    _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
                    entities.Refresh(RefreshMode.StoreWins, entities.MusteriGrups);
                }

                DataLoad.MusteriTreeDoldur(treMusteri, null);
                treMusteri.ExpandAll();
            }
            txtGrupTanim.Text = "";
        }

        private void btnGrupSil_Click(object sender, EventArgs e)
        {
            if (entities.MusteriGrups.Where(a => a.AltGrupID != null).Count() >= 0 && entities.MusteriGrups.Where(a => a.ID != null).Count() > 1)
            {
                if (treMusteri.SelectedNode == null)
                {
                    _BildirimForm1.Goster("Kayıt bulunamadı!");
                }
                else if ((treMusteri.SelectedNode.Tag as MusteriGrup).AltGrupID == null)
                {
                    MusteriGrup musgrp = treMusteri.SelectedNode.Tag as MusteriGrup;
                    if (entities.MusteriGrups.Where(a => a.AltGrupID == musgrp.ID).Count() == 0)
                    {
                        if (entities.Musteris.Where(a => a.MusteriGrup.ID == musgrp.ID).Count() == 0)
                        {
                            if ((treMusteri.SelectedNode.Tag as MusteriGrup).GrupTanim != "MusteriGrup")
                            {
                                DataSil();
                            }
                            else
                            {
                                _BildirimForm1.Goster("Sabit grubu silemezsiniz!.");
                            }
                        }
                        else
                        {
                            _BildirimForm1.Goster("Öncelikle gruba ait olan müşterileri silmelisiniz!.");
                        }
                    }
                    else
                    {
                        _BildirimForm1.Goster("Öncelikle alt grupları silmeniz gerekmektedir!");
                    }
                }
                else
                {
                    MusteriGrup musgrp = treMusteri.SelectedNode.Tag as MusteriGrup;
                    if (entities.Musteris.Where(a => a.MusteriGrup.ID == musgrp.AltGrupID).Count() == 0)
                    {
                        DataSil();
                    }
                    else
                    {
                        _BildirimForm1.Goster("Öncelikle gruba ait olan müşterileri silmelisiniz!.");
                    }
                }
            }
            else
            {
                _BildirimForm1.Goster("1 Adet grup bulunmalı!");
            }
        }

        private void DataSil()
        {

            if (_BildirimForm2.Goster("Silmek istediğinizden emin misiniz?").SONUC)
            {
                MusteriGrup musgrp = treMusteri.SelectedNode.Tag as MusteriGrup;
                MusteriGrup silinecek = entities.MusteriGrups.First(a => a.ID == musgrp.ID);
                entities.DeleteObject(silinecek);
                entities.SaveChanges(true);
                DataLoad.MusteriTreeDoldur(treMusteri, null);
                treMusteri.ExpandAll();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            entities.Refresh(RefreshMode.StoreWins, entities.MusteriGrups);
            this.Close();
        }
    }
}