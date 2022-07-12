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
    public partial class _ArayaniBildirForm2 : DevExpress.XtraEditors.XtraForm
    {
        public bool SONUC;
        public _ArayaniBildirForm2()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SONUC = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SONUC = false;
            this.Close();
        }

        public static _ArayaniBildirForm2 Goster(string numara)
        {
            _ArayaniBildirForm2 frm = new _ArayaniBildirForm2();
            frm.lblArayan.Text += " " + numara;
            frm.ShowDialog();
            return frm;
        }
    }
}