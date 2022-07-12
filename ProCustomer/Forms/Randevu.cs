using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Localization.Internal;
using DevExpress.XtraScheduler.Localization;
using System.Linq;
using DevExpress.XtraScheduler;

namespace ProCustomer.Forms
{
    public partial class Randevu : DevExpress.XtraEditors.XtraForm
    {
        ProCustomerDBEntities entities = Program.entities;
        public Randevu()
        {
            InitializeComponent();
        }

        private void Randevu_Load(object sender, EventArgs e)
        {
            List<Musteri> doldur = new List<Musteri>();
            Musteri yenimüs = new Musteri
            {
                ID = 0,
                Ad_Unvan = "Tümü",
            };
            doldur.Add(yenimüs);
            doldur.AddRange(entities.Musteris);

            cmbmusteri.DisplayMember = "Ad_Unvan";
            cmbmusteri.ValueMember = "ID";
            cmbmusteri.DataSource = doldur.ToList();
            cmbmusteri.AutoCompleteCustomSource.AddRange(doldur.Select(a => a.Ad_Unvan).ToArray());
            var sorgu = entities.Hatirlatmalars.Where(a => a.MusteriID != null).ToList();
            foreach (var item in sorgu)
            {
                TimeSpan fark = item.Bitis - item.Baslangic;
                string ID = item.ID.ToString();
                Appointment yeni = new Appointment(AppointmentType.Normal, item.Baslangic, fark, item.Subject, ID)
                {
                    Start = item.Baslangic,
                    AllDay = item.allday == null ? false : (bool)item.allday,
                    End = item.Bitis,
                    Description = item.description,
                    HasReminder = item.hasreminder == null ? false : (bool)item.hasreminder,
                    Location = item.location,
                    Subject = item.Subject,
                };
                StorageSC.Appointments.Add(yeni);
            }
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StorageSC_AppointmentsInserted(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            if (((Appointment)(e.Objects[0])).Id == null)
            {
                string subject = ((Appointment)(e.Objects[0])).Subject;
                DateTime baslangic = ((Appointment)(e.Objects[0])).Start;
                DateTime bitis = ((Appointment)(e.Objects[0])).End;
                bool allday = ((Appointment)(e.Objects[0])).AllDay;
                string description = ((Appointment)(e.Objects[0])).Description;
                bool Hasreminder = ((Appointment)(e.Objects[0])).HasReminder;
                bool occurence = ((Appointment)(e.Objects[0])).IsOccurrence;
                string location = ((Appointment)(e.Objects[0])).Location;
                Hatirlatmalar yeni = new Hatirlatmalar
                {
                    Subject = subject,
                    Baslangic = baslangic,
                    Bitis = bitis,
                    MusteriID = (cmbmusteri.SelectedItem as Musteri).ID,
                    location = (cmbmusteri.SelectedItem as Musteri).Ad_Unvan == "Tümü" ? location : (cmbmusteri.SelectedItem as Musteri).Ad_Unvan + " " + location,
                    occurence = occurence,
                    hasreminder = Hasreminder,
                    description = description,
                    allday = allday,
                };
                entities.AddToHatirlatmalars(yeni);
                entities.SaveChanges(true);
            }
        }

        private void StorageSC_AppointmentsDeleted(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            if (((Appointment)(e.Objects[0])).Id != null)
            {
                int id = Convert.ToInt32(((Appointment)(e.Objects[0])).Id);
                Hatirlatmalar silinecek = entities.Hatirlatmalars.Where(a => a.ID == id).First();
                entities.DeleteObject(silinecek);
                entities.SaveChanges(true);
            }
        }

        private void StorageSC_AppointmentsChanged(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            if (((Appointment)(e.Objects[0])).Id != null)
            {
                int id = Convert.ToInt32(((Appointment)(e.Objects[0])).Id);
                Hatirlatmalar degisecek = entities.Hatirlatmalars.First(a => a.ID == id);
                degisecek.allday = ((Appointment)(e.Objects[0])).AllDay;
                degisecek.Baslangic = ((Appointment)(e.Objects[0])).Start;
                degisecek.Bitis = ((Appointment)(e.Objects[0])).End;
                degisecek.description = ((Appointment)(e.Objects[0])).Description;
                degisecek.hasreminder = ((Appointment)(e.Objects[0])).HasReminder;
                degisecek.location = ((Appointment)(e.Objects[0])).Location;
                degisecek.occurence = ((Appointment)(e.Objects[0])).IsOccurrence;
                degisecek.Subject = ((Appointment)(e.Objects[0])).Subject;
                entities.SaveChanges(true);
            }
        }
    }
}