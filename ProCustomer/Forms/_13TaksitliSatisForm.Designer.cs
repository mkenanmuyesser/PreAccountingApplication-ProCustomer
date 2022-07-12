namespace ProCustomer.Forms
{
    partial class _13TaksitliSatisForm
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
            this.tpOdeme = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.grdTaksit = new DevExpress.XtraGrid.GridControl();
            this.grdTaksitView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rdOdenmemis = new System.Windows.Forms.RadioButton();
            this.rdOdenmis = new System.Windows.Forms.RadioButton();
            this.rdTumu = new System.Windows.Forms.RadioButton();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.btnAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpSatis = new DevExpress.XtraTab.XtraTabPage();
            this.txtBirimAdet = new System.Windows.Forms.NumericUpDown();
            this.txtTSayisi = new System.Windows.Forms.NumericUpDown();
            this.txtToplam = new DevExpress.XtraEditors.CalcEdit();
            this.chkDahil = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTiptal = new System.Windows.Forms.Button();
            this.btnTaksitEkle = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.cmbBirimFiyat = new System.Windows.Forms.ComboBox();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbPer = new System.Windows.Forms.ComboBox();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.dtpTBaslangic = new System.Windows.Forms.DateTimePicker();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tpOdeme)).BeginInit();
            this.tpOdeme.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaksit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaksitView)).BeginInit();
            this.tpSatis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirimAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tpOdeme
            // 
            this.tpOdeme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpOdeme.Location = new System.Drawing.Point(0, 0);
            this.tpOdeme.Name = "tpOdeme";
            this.tpOdeme.SelectedTabPage = this.xtraTabPage2;
            this.tpOdeme.Size = new System.Drawing.Size(705, 423);
            this.tpOdeme.TabIndex = 0;
            this.tpOdeme.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpSatis,
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.btnCikis);
            this.xtraTabPage2.Controls.Add(this.btnIptal);
            this.xtraTabPage2.Controls.Add(this.btnKaydet);
            this.xtraTabPage2.Controls.Add(this.grdTaksit);
            this.xtraTabPage2.Controls.Add(this.rdOdenmemis);
            this.xtraTabPage2.Controls.Add(this.rdOdenmis);
            this.xtraTabPage2.Controls.Add(this.rdTumu);
            this.xtraTabPage2.Controls.Add(this.dtpBitis);
            this.xtraTabPage2.Controls.Add(this.dtpBaslangic);
            this.xtraTabPage2.Controls.Add(this.btnAra);
            this.xtraTabPage2.Controls.Add(this.label2);
            this.xtraTabPage2.Controls.Add(this.label1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(700, 397);
            this.xtraTabPage2.Text = "Ödeme Yap/Düzenle";
            // 
            // btnCikis
            // 
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.Location = new System.Drawing.Point(573, 366);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(119, 23);
            this.btnCikis.TabIndex = 25;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(448, 366);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(119, 23);
            this.btnIptal.TabIndex = 24;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(323, 366);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(119, 23);
            this.btnKaydet.TabIndex = 23;
            this.btnKaydet.Text = "Değişiklikleri Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // grdTaksit
            // 
            this.grdTaksit.Location = new System.Drawing.Point(11, 59);
            this.grdTaksit.MainView = this.grdTaksitView;
            this.grdTaksit.Name = "grdTaksit";
            this.grdTaksit.Size = new System.Drawing.Size(681, 301);
            this.grdTaksit.TabIndex = 21;
            this.grdTaksit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdTaksitView});
            // 
            // grdTaksitView
            // 
            this.grdTaksitView.GridControl = this.grdTaksit;
            this.grdTaksitView.Name = "grdTaksitView";
            // 
            // rdOdenmemis
            // 
            this.rdOdenmemis.AutoSize = true;
            this.rdOdenmemis.Location = new System.Drawing.Point(269, 36);
            this.rdOdenmemis.Name = "rdOdenmemis";
            this.rdOdenmemis.Size = new System.Drawing.Size(92, 17);
            this.rdOdenmemis.TabIndex = 20;
            this.rdOdenmemis.Text = "Ödenmemişler";
            this.rdOdenmemis.UseVisualStyleBackColor = true;
            // 
            // rdOdenmis
            // 
            this.rdOdenmis.AutoSize = true;
            this.rdOdenmis.Location = new System.Drawing.Point(163, 36);
            this.rdOdenmis.Name = "rdOdenmis";
            this.rdOdenmis.Size = new System.Drawing.Size(78, 17);
            this.rdOdenmis.TabIndex = 19;
            this.rdOdenmis.Text = "Ödenmişler";
            this.rdOdenmis.UseVisualStyleBackColor = true;
            // 
            // rdTumu
            // 
            this.rdTumu.AutoSize = true;
            this.rdTumu.Checked = true;
            this.rdTumu.Location = new System.Drawing.Point(70, 36);
            this.rdTumu.Name = "rdTumu";
            this.rdTumu.Size = new System.Drawing.Size(51, 17);
            this.rdTumu.TabIndex = 18;
            this.rdTumu.TabStop = true;
            this.rdTumu.Text = "Tümü";
            this.rdTumu.UseVisualStyleBackColor = true;
            // 
            // dtpBitis
            // 
            this.dtpBitis.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBitis.Location = new System.Drawing.Point(269, 9);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(133, 21);
            this.dtpBitis.TabIndex = 17;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBaslangic.Location = new System.Drawing.Point(67, 9);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(133, 21);
            this.dtpBaslangic.TabIndex = 17;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(418, 7);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(43, 23);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitiş :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç :";
            // 
            // tpSatis
            // 
            this.tpSatis.Controls.Add(this.txtBirimAdet);
            this.tpSatis.Controls.Add(this.txtTSayisi);
            this.tpSatis.Controls.Add(this.txtToplam);
            this.tpSatis.Controls.Add(this.chkDahil);
            this.tpSatis.Controls.Add(this.label3);
            this.tpSatis.Controls.Add(this.btnTiptal);
            this.tpSatis.Controls.Add(this.btnTaksitEkle);
            this.tpSatis.Controls.Add(this.txtAciklama);
            this.tpSatis.Controls.Add(this.cmbBirimFiyat);
            this.tpSatis.Controls.Add(this.cmbMusteri);
            this.tpSatis.Controls.Add(this.cmbPer);
            this.tpSatis.Controls.Add(this.cmbUrun);
            this.tpSatis.Controls.Add(this.dtpTBaslangic);
            this.tpSatis.Controls.Add(this.labelControl8);
            this.tpSatis.Controls.Add(this.labelControl6);
            this.tpSatis.Controls.Add(this.labelControl5);
            this.tpSatis.Controls.Add(this.labelControl4);
            this.tpSatis.Controls.Add(this.labelControl3);
            this.tpSatis.Controls.Add(this.labelControl2);
            this.tpSatis.Controls.Add(this.labelControl9);
            this.tpSatis.Controls.Add(this.labelControl7);
            this.tpSatis.Controls.Add(this.labelControl1);
            this.tpSatis.Name = "tpSatis";
            this.tpSatis.Size = new System.Drawing.Size(700, 397);
            this.tpSatis.Text = "Satış/Taksit Ekle";
            // 
            // txtBirimAdet
            // 
            this.txtBirimAdet.Location = new System.Drawing.Point(154, 165);
            this.txtBirimAdet.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.txtBirimAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtBirimAdet.Name = "txtBirimAdet";
            this.txtBirimAdet.Size = new System.Drawing.Size(142, 21);
            this.txtBirimAdet.TabIndex = 25;
            this.txtBirimAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBirimAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtBirimAdet.ValueChanged += new System.EventHandler(this.cmbBirimFiyat_SelectedIndexChanged);
            // 
            // txtTSayisi
            // 
            this.txtTSayisi.Location = new System.Drawing.Point(154, 197);
            this.txtTSayisi.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.txtTSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTSayisi.Name = "txtTSayisi";
            this.txtTSayisi.Size = new System.Drawing.Size(142, 21);
            this.txtTSayisi.TabIndex = 25;
            this.txtTSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTSayisi.ValueChanged += new System.EventHandler(this.cmbBirimFiyat_SelectedIndexChanged);
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(154, 229);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtToplam.Size = new System.Drawing.Size(142, 20);
            this.txtToplam.TabIndex = 6;
            // 
            // chkDahil
            // 
            this.chkDahil.AutoSize = true;
            this.chkDahil.Location = new System.Drawing.Point(180, 264);
            this.chkDahil.Name = "chkDahil";
            this.chkDahil.Size = new System.Drawing.Size(15, 14);
            this.chkDahil.TabIndex = 24;
            this.chkDahil.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Location = new System.Drawing.Point(61, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Bu Ay Dahil Olsun Mu?";
            // 
            // btnTiptal
            // 
            this.btnTiptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTiptal.Location = new System.Drawing.Point(145, 315);
            this.btnTiptal.Name = "btnTiptal";
            this.btnTiptal.Size = new System.Drawing.Size(75, 23);
            this.btnTiptal.TabIndex = 10;
            this.btnTiptal.Text = "İptal/Çıkış";
            this.btnTiptal.UseVisualStyleBackColor = true;
            this.btnTiptal.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTaksitEkle
            // 
            this.btnTaksitEkle.Location = new System.Drawing.Point(61, 315);
            this.btnTaksitEkle.Name = "btnTaksitEkle";
            this.btnTaksitEkle.Size = new System.Drawing.Size(75, 23);
            this.btnTaksitEkle.TabIndex = 8;
            this.btnTaksitEkle.Text = "Taksit Ekle";
            this.btnTaksitEkle.UseVisualStyleBackColor = true;
            this.btnTaksitEkle.Click += new System.EventHandler(this.btnTaksitEkle_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(340, 129);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(282, 209);
            this.txtAciklama.TabIndex = 7;
            // 
            // cmbBirimFiyat
            // 
            this.cmbBirimFiyat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirimFiyat.FormattingEnabled = true;
            this.cmbBirimFiyat.Location = new System.Drawing.Point(154, 132);
            this.cmbBirimFiyat.Name = "cmbBirimFiyat";
            this.cmbBirimFiyat.Size = new System.Drawing.Size(142, 21);
            this.cmbBirimFiyat.TabIndex = 3;
            this.cmbBirimFiyat.SelectedIndexChanged += new System.EventHandler(this.cmbBirimFiyat_SelectedIndexChanged);
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbMusteri.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(154, 100);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(142, 21);
            this.cmbMusteri.TabIndex = 2;
            // 
            // cmbPer
            // 
            this.cmbPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPer.FormattingEnabled = true;
            this.cmbPer.Location = new System.Drawing.Point(428, 36);
            this.cmbPer.Name = "cmbPer";
            this.cmbPer.Size = new System.Drawing.Size(142, 21);
            this.cmbPer.TabIndex = 1;
            // 
            // cmbUrun
            // 
            this.cmbUrun.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbUrun.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(154, 68);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(142, 21);
            this.cmbUrun.TabIndex = 1;
            this.cmbUrun.SelectedIndexChanged += new System.EventHandler(this.cmbUrun_SelectedIndexChanged);
            // 
            // dtpTBaslangic
            // 
            this.dtpTBaslangic.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpTBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTBaslangic.Location = new System.Drawing.Point(154, 38);
            this.dtpTBaslangic.Name = "dtpTBaslangic";
            this.dtpTBaslangic.Size = new System.Drawing.Size(142, 21);
            this.dtpTBaslangic.TabIndex = 0;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(64, 232);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(72, 13);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "Taksit Toplam :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(64, 199);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(65, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Taksit Sayısı :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(64, 167);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Birim Adet :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(64, 135);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Birim Fiyat :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(64, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Müşteri :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(64, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ürün :";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(340, 105);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 13);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "Açıklama :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(340, 39);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(66, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Personel Adı :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(64, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "İşlem Tarihi :";
            // 
            // _13TaksitliSatisForm
            // 
            this.AcceptButton = this.btnTaksitEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTiptal;
            this.ClientSize = new System.Drawing.Size(705, 423);
            this.ControlBox = false;
            this.Controls.Add(this.tpOdeme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "_13TaksitliSatisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taksitli Satış";
            ((System.ComponentModel.ISupportInitialize)(this.tpOdeme)).EndInit();
            this.tpOdeme.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaksit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaksitView)).EndInit();
            this.tpSatis.ResumeLayout(false);
            this.tpSatis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirimAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplam.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tpOdeme;
        private DevExpress.XtraTab.XtraTabPage tpSatis;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.DateTimePicker dtpTBaslangic;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.GridControl grdTaksit;
        private DevExpress.XtraGrid.Views.Grid.GridView grdTaksitView;
        private System.Windows.Forms.RadioButton rdOdenmemis;
        private System.Windows.Forms.RadioButton rdOdenmis;
        private System.Windows.Forms.RadioButton rdTumu;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTiptal;
        private System.Windows.Forms.Button btnTaksitEkle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox chkDahil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBirimFiyat;
        private DevExpress.XtraEditors.CalcEdit txtToplam;
        private System.Windows.Forms.NumericUpDown txtTSayisi;
        private System.Windows.Forms.NumericUpDown txtBirimAdet;
        private System.Windows.Forms.ComboBox cmbPer;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}