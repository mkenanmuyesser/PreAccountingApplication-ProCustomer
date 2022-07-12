using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProCustomer.Forms
{
    public partial class _BildirimForm2 : DevExpress.XtraEditors.XtraForm
    {
        public bool SONUC;
        public _BildirimForm2()
        {
            InitializeComponent();
        }

        public static _BildirimForm2 Goster(string mesaj)
        {
            _BildirimForm2 frm = new _BildirimForm2();
            frm.lblIslem.Text = mesaj;            
            frm.ShowDialog();
            return frm;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            SONUC = false;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            SONUC = true;
            this.Close();
        }

    }
}