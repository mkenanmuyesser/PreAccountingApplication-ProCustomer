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
using ProCustomer.Classes;

namespace ProCustomer.Forms
{
    public partial class _32UrunGrupForm : DevExpress.XtraEditors.XtraForm
    {

        ProCustomerDBEntities entities = Program.entities;
        public _32UrunGrupForm()
        {
            InitializeComponent();
        }

        private void _32UrunGrupForm_Load(object sender, EventArgs e)
        {
            DataLoad.UrunTreeDoldur(treUrun, null);
            treUrun.ExpandAll();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            entities.Refresh(RefreshMode.StoreWins, entities.UrunGrups);
            this.Close();
        }

        private void btnAnaGrupEkle_Click(object sender, EventArgs e)
        {
            UrunGrup anagrup = new UrunGrup
            {
                GrupTanim = txtGrupTanim.Text,
            };
            entities.AddToUrunGrups(anagrup);
            try
            {
                entities.SaveChanges(true);
            }
            catch
            {
                _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
                entities.Refresh(RefreshMode.StoreWins, entities.UrunGrups);
            }
            DataLoad.UrunTreeDoldur(treUrun, null);
            treUrun.ExpandAll();
            txtGrupTanim.Text = "";
        }

        private void btnAltGrupEkle_Click(object sender, EventArgs e)
        {
            if (treUrun.SelectedNode == null)
            {
                _BildirimForm1.Goster("Kayıt bulunamadı!");
            }
            else if ((treUrun.SelectedNode.Tag as UrunGrup).AltGrupID != null)
            {
                UrunGrup urngrp = treUrun.SelectedNode.Tag as UrunGrup;
                UrunGrup altgrup = new UrunGrup
                {
                    GrupTanim = txtGrupTanim.Text,
                    AltGrupID = urngrp.AltGrupID,
                };
                entities.AddToUrunGrups(altgrup);

                try
                {
                    entities.SaveChanges(true);
                }
                catch
                {
                    _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
                    entities.Refresh(RefreshMode.StoreWins, entities.UrunGrups);
                }

                DataLoad.UrunTreeDoldur(treUrun, null);
                treUrun.ExpandAll();
            }
            else
            {
                UrunGrup urngrp = treUrun.SelectedNode.Tag as UrunGrup;
                UrunGrup altgrup = new UrunGrup
                {
                    GrupTanim = txtGrupTanim.Text,
                    AltGrupID = urngrp.ID,
                };
                entities.AddToUrunGrups(altgrup);

                try
                {
                    entities.SaveChanges(true);
                }
                catch
                {
                    _BildirimForm1.Goster("İşlem sırasında bir hata oluştu!");
                    entities.Refresh(RefreshMode.StoreWins, entities.UrunGrups);
                }

                DataLoad.UrunTreeDoldur(treUrun, null);
                treUrun.ExpandAll();
            }
            txtGrupTanim.Text = "";
        }

        private void btnGrupSil_Click(object sender, EventArgs e)
        {
            if (entities.UrunGrups.Where(a => a.AltGrupID != null).Count() >= 0 && entities.UrunGrups.Where(a => a.ID != null).Count() > 1)
            {
                if (treUrun.SelectedNode == null)
                {
                    _BildirimForm1.Goster("Kayıt bulunamadı!");
                }
                else if ((treUrun.SelectedNode.Tag as UrunGrup).AltGrupID == null)
                {
                    UrunGrup urngrp = treUrun.SelectedNode.Tag as UrunGrup;
                    if (entities.UrunGrups.Where(a => a.AltGrupID == urngrp.ID).Count() == 0)
                    {
                        if (entities.Uruns.Where(a => a.UrunGrup.ID == urngrp.ID).Count() == 0)
                        {
                            if ((treUrun.SelectedNode.Tag as UrunGrup).GrupTanim != "UrunGrup")
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
                            _BildirimForm1.Goster("Öncelikle gruba ait olan ürünleri silmelisiniz!.");
                        }
                    }
                    else
                    {
                        _BildirimForm1.Goster("Öncelikle alt grupları silmelisiniz!.");
                    }
                }
                else
                {
                    UrunGrup urngrp = treUrun.SelectedNode.Tag as UrunGrup;
                    if (entities.Uruns.Where(a => a.UrunGrup.ID == urngrp.AltGrupID).Count() == 0)
                    {
                        DataSil();
                    }
                    else
                    {
                        _BildirimForm1.Goster("Öncelikle gruba ait olan ürünleri silmelisiniz!.");
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
                UrunGrup urngrp = treUrun.SelectedNode.Tag as UrunGrup;
                UrunGrup silinecek = entities.UrunGrups.First(a => a.ID == urngrp.ID);
                entities.DeleteObject(silinecek);
                entities.SaveChanges(true);
                DataLoad.UrunTreeDoldur(treUrun, null);
                treUrun.ExpandAll();
            }
        }
    }
}