using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axCIDv51.Hide();
            axCIDv51.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Cihaz : " + axCIDv51.Command("Devicemodel") + "     " + axCIDv51.Command("Serial");
        }

        private void axCIDv51_OnCallerID(object sender, Axcidv5callerid.ICIDv5Events_OnCallerIDEvent e)
        {
         listBox1.Items.Add("Tel" + e.line + " - " + e.dateTime + " - " + e.phoneNumber);
            //  e.dateTime Telefon santrali tarafından gönderilen zaman bilgisidir. Saat ve dakika olarak gelir saniye gelmez.
            //  PC zamanından bağımsızdır. Gerekirse PC zamanı da kullanılabilir.
            //  Nesne .start  ile başlatılmışsa ve numara algılanmışsa, bu olay tetiklenir.

        }


    }
}
