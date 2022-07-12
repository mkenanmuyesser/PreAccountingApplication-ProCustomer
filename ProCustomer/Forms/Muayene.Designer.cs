namespace ProCustomer.Forms
{
    partial class Muayene
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbHayvani = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMuayeneNedeni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTeshis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUygulananTedavi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHekim = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMuayeneSonuc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MalzemeMain = new DevExpress.XtraGrid.GridControl();
            this.MalzemeMains = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.txtFiyat1 = new DevExpress.XtraEditors.CalcEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpAsi = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAsiAdi = new System.Windows.Forms.TextBox();
            this.AsiMain = new DevExpress.XtraGrid.GridControl();
            this.AsiMainS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAsiEkle = new System.Windows.Forms.Button();
            this.btnMalzEkle = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.cmbMalz = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.MalzemeMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MalzemeMains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsiMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsiMainS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbMusteri.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(123, 12);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(121, 21);
            this.cmbMusteri.TabIndex = 0;
            this.cmbMusteri.TextChanged += new System.EventHandler(this.cmbMusteri_TextChanged);
            // 
            // cmbHayvani
            // 
            this.cmbHayvani.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHayvani.FormattingEnabled = true;
            this.cmbHayvani.Location = new System.Drawing.Point(123, 39);
            this.cmbHayvani.Name = "cmbHayvani";
            this.cmbHayvani.Size = new System.Drawing.Size(121, 21);
            this.cmbHayvani.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Musteri Adı :";
            // 
            // btnKapat
            // 
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Location = new System.Drawing.Point(962, 388);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Çıkış";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(880, 388);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Muayene Nedeni :";
            // 
            // txtMuayeneNedeni
            // 
            this.txtMuayeneNedeni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtMuayeneNedeni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMuayeneNedeni.Location = new System.Drawing.Point(108, 32);
            this.txtMuayeneNedeni.Name = "txtMuayeneNedeni";
            this.txtMuayeneNedeni.Size = new System.Drawing.Size(273, 21);
            this.txtMuayeneNedeni.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teşhis :";
            // 
            // txtTeshis
            // 
            this.txtTeshis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtTeshis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTeshis.Location = new System.Drawing.Point(108, 57);
            this.txtTeshis.Multiline = true;
            this.txtTeshis.Name = "txtTeshis";
            this.txtTeshis.Size = new System.Drawing.Size(273, 70);
            this.txtTeshis.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Uygulanan Tedavi :";
            // 
            // txtUygulananTedavi
            // 
            this.txtUygulananTedavi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtUygulananTedavi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUygulananTedavi.Location = new System.Drawing.Point(108, 131);
            this.txtUygulananTedavi.Multiline = true;
            this.txtUygulananTedavi.Name = "txtUygulananTedavi";
            this.txtUygulananTedavi.Size = new System.Drawing.Size(273, 70);
            this.txtUygulananTedavi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hekim :";
            // 
            // cmbHekim
            // 
            this.cmbHekim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHekim.FormattingEnabled = true;
            this.cmbHekim.Location = new System.Drawing.Point(123, 68);
            this.cmbHekim.Name = "cmbHekim";
            this.cmbHekim.Size = new System.Drawing.Size(122, 21);
            this.cmbHekim.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Muayene Sonucu :";
            // 
            // txtMuayeneSonuc
            // 
            this.txtMuayeneSonuc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtMuayeneSonuc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMuayeneSonuc.Location = new System.Drawing.Point(108, 205);
            this.txtMuayeneSonuc.Multiline = true;
            this.txtMuayeneSonuc.Name = "txtMuayeneSonuc";
            this.txtMuayeneSonuc.Size = new System.Drawing.Size(273, 70);
            this.txtMuayeneSonuc.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Evraklar :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label8.Location = new System.Drawing.Point(10, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Malzeme\r\nEkle :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MalzemeMain
            // 
            this.MalzemeMain.Location = new System.Drawing.Point(8, 95);
            this.MalzemeMain.MainView = this.MalzemeMains;
            this.MalzemeMain.Name = "MalzemeMain";
            this.MalzemeMain.Size = new System.Drawing.Size(289, 180);
            this.MalzemeMain.TabIndex = 7;
            this.MalzemeMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MalzemeMains});
            // 
            // MalzemeMains
            // 
            this.MalzemeMains.GridControl = this.MalzemeMain;
            this.MalzemeMains.Name = "MalzemeMains";
            this.MalzemeMains.OptionsBehavior.Editable = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(342, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(460, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(579, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.DoubleClick += new System.EventHandler(this.pictureBox3_DoubleClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(695, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.DoubleClick += new System.EventHandler(this.pictureBox4_DoubleClick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Location = new System.Drawing.Point(813, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 54);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.DoubleClick += new System.EventHandler(this.pictureBox5_DoubleClick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Location = new System.Drawing.Point(932, 10);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 54);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.DoubleClick += new System.EventHandler(this.pictureBox6_DoubleClick);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(378, 68);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(28, 23);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "...";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(495, 68);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(28, 23);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "...";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(614, 68);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(28, 23);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "...";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(731, 70);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(28, 23);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "...";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(848, 70);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(28, 23);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "...";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(967, 70);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(28, 23);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "...";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // txtFiyat1
            // 
            this.txtFiyat1.Location = new System.Drawing.Point(750, 390);
            this.txtFiyat1.Name = "txtFiyat1";
            this.txtFiyat1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFiyat1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFiyat1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFiyat1.Properties.NullText = "0";
            this.txtFiyat1.Size = new System.Drawing.Size(124, 20);
            this.txtFiyat1.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(655, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Muayene Tutarı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tekrarlanacak\r\nTedavi Tarihi :\r\n";
            // 
            // dtpAsi
            // 
            this.dtpAsi.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpAsi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAsi.Location = new System.Drawing.Point(100, 27);
            this.dtpAsi.Name = "dtpAsi";
            this.dtpAsi.Size = new System.Drawing.Size(168, 21);
            this.dtpAsi.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tedavi Adı :";
            // 
            // txtAsiAdi
            // 
            this.txtAsiAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtAsiAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAsiAdi.Location = new System.Drawing.Point(100, 63);
            this.txtAsiAdi.Name = "txtAsiAdi";
            this.txtAsiAdi.Size = new System.Drawing.Size(113, 21);
            this.txtAsiAdi.TabIndex = 5;
            // 
            // AsiMain
            // 
            this.AsiMain.Location = new System.Drawing.Point(15, 96);
            this.AsiMain.MainView = this.AsiMainS;
            this.AsiMain.Name = "AsiMain";
            this.AsiMain.Size = new System.Drawing.Size(289, 180);
            this.AsiMain.TabIndex = 7;
            this.AsiMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.AsiMainS});
            // 
            // AsiMainS
            // 
            this.AsiMainS.GridControl = this.AsiMain;
            this.AsiMainS.Name = "AsiMainS";
            this.AsiMainS.OptionsBehavior.Editable = false;
            // 
            // btnAsiEkle
            // 
            this.btnAsiEkle.Location = new System.Drawing.Point(219, 62);
            this.btnAsiEkle.Name = "btnAsiEkle";
            this.btnAsiEkle.Size = new System.Drawing.Size(49, 23);
            this.btnAsiEkle.TabIndex = 9;
            this.btnAsiEkle.Text = "Ekle";
            this.btnAsiEkle.UseVisualStyleBackColor = true;
            this.btnAsiEkle.Click += new System.EventHandler(this.btnAsiEkle_Click);
            // 
            // btnMalzEkle
            // 
            this.btnMalzEkle.Location = new System.Drawing.Point(261, 36);
            this.btnMalzEkle.Name = "btnMalzEkle";
            this.btnMalzEkle.Size = new System.Drawing.Size(35, 23);
            this.btnMalzEkle.TabIndex = 9;
            this.btnMalzEkle.Text = "Ekle";
            this.btnMalzEkle.UseVisualStyleBackColor = true;
            this.btnMalzEkle.Click += new System.EventHandler(this.btnMalzEkle_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label12.Location = new System.Drawing.Point(182, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Adet :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(221, 37);
            this.nmrAdet.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(39, 21);
            this.nmrAdet.TabIndex = 13;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbMalz
            // 
            this.cmbMalz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbMalz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbMalz.FormattingEnabled = true;
            this.cmbMalz.Location = new System.Drawing.Point(65, 37);
            this.cmbMalz.Name = "cmbMalz";
            this.cmbMalz.Size = new System.Drawing.Size(116, 21);
            this.cmbMalz.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpAsi);
            this.groupBox1.Controls.Add(this.txtAsiAdi);
            this.groupBox1.Controls.Add(this.AsiMain);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnAsiEkle);
            this.groupBox1.Location = new System.Drawing.Point(401, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 285);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hatırlatma";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(268, 62);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(49, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.nmrAdet);
            this.groupBox2.Controls.Add(this.cmbMalz);
            this.groupBox2.Controls.Add(this.MalzemeMain);
            this.groupBox2.Controls.Add(this.btnMalzEkle);
            this.groupBox2.Location = new System.Drawing.Point(733, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 285);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stok";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtMuayeneNedeni);
            this.groupBox3.Controls.Add(this.txtTeshis);
            this.groupBox3.Controls.Add(this.txtUygulananTedavi);
            this.groupBox3.Controls.Add(this.txtMuayeneSonuc);
            this.groupBox3.Location = new System.Drawing.Point(8, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 285);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Muayene";
            // 
            // Muayene
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(1049, 421);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFiyat1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbHekim);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHayvani);
            this.Controls.Add(this.cmbMusteri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Muayene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muayene Kartı";
            this.Load += new System.EventHandler(this.Muayene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MalzemeMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MalzemeMains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsiMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsiMainS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbHayvani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMuayeneNedeni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTeshis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUygulananTedavi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHekim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMuayeneSonuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.GridControl MalzemeMain;
        private DevExpress.XtraGrid.Views.Grid.GridView MalzemeMains;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private DevExpress.XtraEditors.CalcEdit txtFiyat1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpAsi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAsiAdi;
        private DevExpress.XtraGrid.GridControl AsiMain;
        private DevExpress.XtraGrid.Views.Grid.GridView AsiMainS;
        private System.Windows.Forms.Button btnAsiEkle;
        private System.Windows.Forms.Button btnMalzEkle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.ComboBox cmbMalz;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSil;
    }
}