using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ProCustomer.Properties;

namespace ProCustomer.Forms
{
    public partial class _51CallerIdBaglantiForm : DevExpress.XtraEditors.XtraForm
    {
        public _51CallerIdBaglantiForm()
        {
            InitializeComponent();
        }

        private void CallerIdBaglantiForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.CallerResim1;
            pictureBox2.Image = Resources.CallerResim2;
            pictureBox3.Image = Resources.CallerResim3;
            pictureBox4.Image = Resources.CallerResim4;
            pictureBox5.Image = Resources.CallerResim5;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}