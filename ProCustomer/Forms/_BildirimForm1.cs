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
    public partial class _BildirimForm1 : DevExpress.XtraEditors.XtraForm
    {
        public _BildirimForm1()
        {
            InitializeComponent();
        }

        public static void Goster(string mesaj)
        {
            _BildirimForm1 frm = new _BildirimForm1();
            frm.lblIslem.Text = mesaj;
            frm.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}