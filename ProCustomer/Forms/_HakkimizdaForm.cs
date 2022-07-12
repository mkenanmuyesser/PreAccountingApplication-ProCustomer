using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace ProCustomer.Forms
{
    public partial class _HakkimizdaForm : DevExpress.XtraEditors.XtraForm
    {
        public _HakkimizdaForm()
        {
            InitializeComponent();
        }

        private void lnk_Click(object sender, EventArgs e)
        {
            LinkLabel lbl = sender as LinkLabel;
            switch (lbl.Name)
            {
                case "lnkSite":
                case "lnkFace":
                    Process.Start(lbl.Text);
                    break;
                case "lnkEposta":
                    Process.Start("mailto:" + lbl.Text + "?subject=Destek&body=");
                    break;
            }
        }


    }
}