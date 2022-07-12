using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProCustomer.UserControls
{
    public partial class Doviz : UserControl
    {
        public Doviz()
        {
            InitializeComponent();
        }

        public void Doviz_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton3.Checked = true;
            cmb_ilk.SelectedIndex = 6;
            cmbiki.SelectedIndex = 0;
            try
            {
                DataSet eskiler = new DataSet();
                eskiler.ReadXml("http://www.altinkaynak.com/main_xml/eski.xml");
                DataSet doldur = new DataSet();
                doldur.ReadXml("http://xml.altinkaynak.com.tr/altinkaynak.xml");
                DataSet altin = new DataSet();
                altin.ReadXml("http://xml.altinkaynak.com.tr/altin.xml");
                DataSet parite = new DataSet();
                parite.ReadXml("http://www.altinkaynak.com/main_xml/parite.xml");
                lbl_d_usd.Text = doldur.Tables[0].Rows[1][1].ToString() + " / " + doldur.Tables[0].Rows[1][2].ToString();
                lbl_d_eur.Text = doldur.Tables[0].Rows[2][1].ToString() + " / " + doldur.Tables[0].Rows[2][2].ToString();
                lbl_a_hasaltın.Text = doldur.Tables[0].Rows[12][1].ToString() + " / " + doldur.Tables[0].Rows[12][2].ToString();
                lbl_a_22ayar.Text = doldur.Tables[0].Rows[13][1].ToString() + " / " + doldur.Tables[0].Rows[13][2].ToString();
                lbl_a_gümüs.Text = doldur.Tables[0].Rows[15][1].ToString() + " / " + doldur.Tables[0].Rows[15][2].ToString();
                lbl_s_1.Text = "Yeni Çeyrek " + altin.Tables[0].Rows[4][1].ToString() + " / " + altin.Tables[0].Rows[4][2].ToString();
                lbl_s_2.Text = "Eski Çeyrek " + eskiler.Tables[0].Rows[1][1].ToString() + " / " + eskiler.Tables[0].Rows[1][2].ToString();
                lbl_s_3.Text = "Yeni Yarım " + altin.Tables[0].Rows[5][1].ToString() + " / " + altin.Tables[0].Rows[5][2].ToString();
                lbl_s_4.Text = "Eski Yarım " + eskiler.Tables[0].Rows[2][1].ToString() + " / " + eskiler.Tables[0].Rows[2][2].ToString();
                lbl_s_5.Text = "Yeni Teklik " + altin.Tables[0].Rows[6][1].ToString() + " / " + altin.Tables[0].Rows[6][2].ToString();
                lbl_s_6.Text = "Eski Teklik " + eskiler.Tables[0].Rows[3][1].ToString() + " / " + eskiler.Tables[0].Rows[3][2].ToString();
                lbl_s_7.Text = "Yeni Gremse " + altin.Tables[0].Rows[7][1].ToString() + " / " + altin.Tables[0].Rows[7][2].ToString();
                lbl_s_8.Text = "Eski Gremse " + eskiler.Tables[0].Rows[4][1].ToString() + " / " + eskiler.Tables[0].Rows[4][2].ToString();
                lbl_u_1.Text = "EUR/USD " + parite.Tables[0].Rows[0][5].ToString();
                lbl_u_2.Text = "GBP/USD " + parite.Tables[0].Rows[0][13].ToString();
                lbl_u_3.Text = "USD/JPY " + parite.Tables[0].Rows[0][12].ToString();
                lbl_u_4.Text = "EUR/JPY " + parite.Tables[0].Rows[0][2].ToString();
                lbl_u_5.Text = "EUR/GBP " + parite.Tables[0].Rows[0][4].ToString();
                lbl_u_6.Text = "USD/CHF " + parite.Tables[0].Rows[0][15].ToString();
                lbl_u_7.Text = "EUR/CHF " + parite.Tables[0].Rows[0][14].ToString();
                lbl_u_8.Text = "XAG/USD " + parite.Tables[0].Rows[0][1].ToString();
                lbl_u_9.Text = "XPD/USD " + parite.Tables[0].Rows[0][19].ToString();
                lbl_u_10.Text = "XPT/USD " + parite.Tables[0].Rows[0][16].ToString();
                lbl_u_11.Text = "USD/DEM " + parite.Tables[0].Rows[0][7].ToString();
            }
            catch
            {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Ediniz!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_miktar.Text != "")
            {
                DataSet doldur = new DataSet();
                doldur.ReadXml("http://xml.altinkaynak.com.tr/altinkaynak.xml");
                DataSet altin = new DataSet();
                altin.ReadXml("http://xml.altinkaynak.com.tr/altin.xml");
                DataSet parite = new DataSet();
                parite.ReadXml("http://www.altinkaynak.com/main_xml/parite.xml");
                decimal eura = Convert.ToDecimal(doldur.Tables[0].Rows[2][1].ToString()) / 10000;
                decimal eurs = Convert.ToDecimal(doldur.Tables[0].Rows[2][2].ToString()) / 10000;
                decimal usda = Convert.ToDecimal(doldur.Tables[0].Rows[1][1].ToString()) / 10000;
                decimal usds = Convert.ToDecimal(doldur.Tables[0].Rows[1][2].ToString()) / 10000;
                decimal ca = Convert.ToDecimal(altin.Tables[0].Rows[4][1].ToString()) / 10000;
                decimal cs = Convert.ToDecimal(altin.Tables[0].Rows[4][2].ToString()) / 10000;
                decimal ya = Convert.ToDecimal(altin.Tables[0].Rows[5][1].ToString()) / 10000;
                decimal ys = Convert.ToDecimal(altin.Tables[0].Rows[5][2].ToString()) / 10000;
                decimal ta = Convert.ToDecimal(altin.Tables[0].Rows[6][1].ToString()) / 10000;
                decimal ts = Convert.ToDecimal(altin.Tables[0].Rows[6][2].ToString()) / 10000;
                decimal ga = Convert.ToDecimal(altin.Tables[0].Rows[7][1].ToString()) / 10000;
                decimal gs = Convert.ToDecimal(altin.Tables[0].Rows[7][2].ToString()) / 10000;

                switch (cmb_ilk.Text)
                {
                    case "USD":
                        switch (cmbiki.Text)
                        {
                            case "EUR":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usda) / eura).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usds) / eurs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usda) / eurs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usds) / eura).ToString();
                                }
                                break;
                            case "TL":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = (Convert.ToDecimal(txt_miktar.Text) * usda).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = (Convert.ToDecimal(txt_miktar.Text) * usds).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = (Convert.ToDecimal(txt_miktar.Text) * usds).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = (Convert.ToDecimal(txt_miktar.Text) * usda).ToString();
                                }
                                break;
                            case "ÇEYREK":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usda) / ca).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usds) / cs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usda) / cs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usds) / ca).ToString();
                                }
                                break;
                            case "YARIM":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usda) / ya).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usds) / ys).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usda) / ys).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usds) / ya).ToString();
                                }
                                break;
                            case "TAM":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usda) / ta).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usds) / ts).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usda) / ts).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usds) / ta).ToString();
                                }
                                break;
                            case "GREMSE":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usda) / ga).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usds) / gs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usda) / gs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * usds) / ga).ToString();
                                }
                                break;
                            default:
                                txt_sonuc.Text = "";
                                break;
                        }
                        break;
                    case "EUR":
                        switch (cmbiki.Text)
                        {
                            case "USD":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eura) / usda).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eurs) / usds).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eura) / usds).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eurs) / usda).ToString();
                                }
                                break;
                            case "TL":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = (Convert.ToDecimal(txt_miktar.Text) * eura).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = (Convert.ToDecimal(txt_miktar.Text) * eurs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = (Convert.ToDecimal(txt_miktar.Text) * eurs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = (Convert.ToDecimal(txt_miktar.Text) * eura).ToString();
                                }
                                break;
                            case "ÇEYREK":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eura) / ca).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eurs) / cs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eura) / cs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eurs) / ca).ToString();
                                }
                                break;
                            case "YARIM":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eura) / ya).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eurs) / ys).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eura) / ys).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eurs) / ya).ToString();
                                }
                                break;
                            case "TAM":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eura) / ta).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eurs) / ts).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eura) / ts).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eurs) / ta).ToString();
                                }
                                break;
                            case "GREMSE":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eura) / ga).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eurs) / gs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eura) / gs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * eurs) / ga).ToString();
                                }
                                break;
                            default:
                                txt_sonuc.Text = "";
                                break;
                        }
                        break;
                    case "TL":
                        switch (cmbiki.Text)
                        {
                            case "USD":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / usda).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / usds).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / usds).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / usda).ToString();
                                }
                                break;
                            case "EUR":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = (Convert.ToDecimal(txt_miktar.Text) * 1 / eura).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = (Convert.ToDecimal(txt_miktar.Text) * 1 / eurs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = (Convert.ToDecimal(txt_miktar.Text) * 1 / eurs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = (Convert.ToDecimal(txt_miktar.Text) * 1 / eura).ToString();
                                }
                                break;
                            case "ÇEYREK":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / ca).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / cs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / cs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / ca).ToString();
                                }
                                break;
                            case "YARIM":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / ya).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / ys).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / ys).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / ya).ToString();
                                }
                                break;
                            case "TAM":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / ta).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / ts).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / ts).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / ta).ToString();
                                }
                                break;
                            case "GREMSE":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / ga).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / gs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / gs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * 1) / ga).ToString();
                                }
                                break;
                            default:
                                txt_sonuc.Text = "";
                                break;
                        }
                        break;
                    case "ÇEYREK":
                        switch (cmbiki.Text)
                        {
                            case "USD":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ca) / usda).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * cs) / usds).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ca) / usds).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * cs) / usda).ToString();
                                }
                                break;
                            case "EUR":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ca) / eura).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * cs) / eurs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ca) / eurs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * cs) / eura).ToString();
                                }
                                break;
                            case "TL":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ca) / 1).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * cs) / 1).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ca) / 1).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * cs) / 1).ToString();
                                }
                                break;
                            case "YARIM":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ca) / ya).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * cs) / ys).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ca) / ys).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * cs) / ya).ToString();
                                }
                                break;
                            case "TAM":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ca) / ta).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * cs) / ts).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ca) / ts).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * cs) / ta).ToString();
                                }
                                break;
                            case "GREMSE":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ca) / ga).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * cs) / gs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ca) / gs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * cs) / ga).ToString();
                                }
                                break;
                            default:
                                txt_sonuc.Text = "";
                                break;
                        }
                        break;
                    case "YARIM":
                        switch (cmbiki.Text)
                        {
                            case "USD":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ya) / usda).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ys) / usds).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ya) / usds).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ys) / usda).ToString();
                                }
                                break;
                            case "EUR":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ya) / eura).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ys) / eurs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ya) / eurs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ys) / eura).ToString();
                                }
                                break;
                            case "ÇEYREK":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ya) / ca).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ys) / cs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ya) / cs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ys) / ca).ToString();
                                }
                                break;
                            case "TL":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ya) / 1).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ys) / 1).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ya) / 1).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ys) / 1).ToString();
                                }
                                break;
                            case "TAM":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ya) / ta).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ys) / ts).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ya) / ts).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ys) / ta).ToString();
                                }
                                break;
                            case "GREMSE":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ya) / ga).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ys) / gs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ya) / gs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ys) / ga).ToString();
                                }
                                break;
                            default:
                                txt_sonuc.Text = "";
                                break;
                        }
                        break;
                    case "TAM":
                        switch (cmbiki.Text)
                        {
                            case "USD":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ta) / usda).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ts) / usds).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ta) / usds).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ts) / usda).ToString();
                                }
                                break;
                            case "EUR":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ta) / eura).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ts) / eurs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ta) / eurs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ts) / eura).ToString();
                                }
                                break;
                            case "ÇEYREK":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ta) / ca).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ts) / cs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ta) / cs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ts) / ca).ToString();
                                }
                                break;
                            case "YARIM":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ta) / ya).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ts) / ys).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ta) / ys).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ts) / ya).ToString();
                                }
                                break;
                            case "TL":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ta) / 1).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ts) / 1).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ta) / 1).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ts) / 1).ToString();
                                }
                                break;
                            case "GREMSE":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ta) / ga).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ts) / gs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ta) / gs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ts) / ga).ToString();
                                }
                                break;
                            default:
                                txt_sonuc.Text = "";
                                break;
                        }
                        break;
                    case "GREMSE":
                        switch (cmbiki.Text)
                        {
                            case "USD":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ga) / usda).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * gs) / usds).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ga) / usds).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * gs) / usda).ToString();
                                }
                                break;
                            case "EUR":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ga) / eura).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * gs) / eurs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ga) / eurs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * gs) / eura).ToString();
                                }
                                break;
                            case "ÇEYREK":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ga) / ca).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * gs) / cs).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ga) / cs).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * gs) / ca).ToString();
                                }
                                break;
                            case "YARIM":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ga) / ya).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * gs) / ys).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ga) / ys).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * gs) / ya).ToString();
                                }
                                break;
                            case "TAM":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ga) / ta).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * gs) / ts).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ga) / ta).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * gs) / ts).ToString();
                                }
                                break;
                            case "TL":
                                if (radioButton1.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ga) / 1).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * gs) / 1).ToString();
                                }
                                if (radioButton1.Checked == true && radioButton4.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * ga) / 1).ToString();
                                }
                                if (radioButton2.Checked == true && radioButton3.Checked == true)
                                {
                                    txt_sonuc.Text = ((Convert.ToDecimal(txt_miktar.Text) * gs) / 1).ToString();
                                }
                                break;
                            default:
                                txt_sonuc.Text = "";
                                break;
                        }
                        break;
                    default:
                        txt_sonuc.Text = "";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Lütfen Miktar Giriniz.","Çevirim Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
