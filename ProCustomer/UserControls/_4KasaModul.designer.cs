namespace ProCustomer.UserControls
{
    partial class _4KasaModul
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_4KasaModul));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtEvrakNo = new System.Windows.Forms.TextBox();
            this.cmbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.cmbHareketler = new System.Windows.Forms.ComboBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.cmbKasa = new System.Windows.Forms.ComboBox();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.btnAra = new System.Windows.Forms.Button();
            this.grdKasaMain = new DevExpress.XtraGrid.GridControl();
            this.grdKasa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKasaMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKasa)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtEvrakNo);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmbOdemeTipi);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmbPersonel);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmbHareketler);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtCari);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmbKasa);
            this.splitContainerControl1.Panel1.Controls.Add(this.dtpBitis);
            this.splitContainerControl1.Panel1.Controls.Add(this.dtpBaslangic);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnAra);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerControl1.Panel2.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.splitContainerControl1.Panel2.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.splitContainerControl1.Panel2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.splitContainerControl1.Panel2.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Panel2.Appearance.Options.UseBorderColor = true;
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Panel2.Controls.Add(this.grdKasaMain);
            this.splitContainerControl1.Panel2.Controls.Add(this.button1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(950, 419);
            this.splitContainerControl1.SplitterPosition = 111;
            this.splitContainerControl1.TabIndex = 20;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(406, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Ödeme Tipi :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 69);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 13);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Cari Adı/Ünvanı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(406, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Personel Adı :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 43);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 13);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "İşlem Tarihi :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(406, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Hareket Tipi :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 17);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(100, 13);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "Evrak No/İşlem Yeri :";
            // 
            // txtEvrakNo
            // 
            this.txtEvrakNo.Location = new System.Drawing.Point(118, 14);
            this.txtEvrakNo.Name = "txtEvrakNo";
            this.txtEvrakNo.Size = new System.Drawing.Size(133, 20);
            this.txtEvrakNo.TabIndex = 0;
            // 
            // cmbOdemeTipi
            // 
            this.cmbOdemeTipi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbOdemeTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeTipi.FormattingEnabled = true;
            this.cmbOdemeTipi.Location = new System.Drawing.Point(502, 66);
            this.cmbOdemeTipi.Name = "cmbOdemeTipi";
            this.cmbOdemeTipi.Size = new System.Drawing.Size(246, 21);
            this.cmbOdemeTipi.TabIndex = 7;
            this.cmbOdemeTipi.SelectedIndexChanged += new System.EventHandler(this.cmbOdemeTipi_SelectedIndexChanged);
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(502, 40);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(246, 21);
            this.cmbPersonel.TabIndex = 6;
            this.cmbPersonel.SelectedIndexChanged += new System.EventHandler(this.cmbPersonel_SelectedIndexChanged);
            // 
            // cmbHareketler
            // 
            this.cmbHareketler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHareketler.FormattingEnabled = true;
            this.cmbHareketler.Items.AddRange(new object[] {
            "Tüm Hareketler",
            "Giriş Hareketleri",
            "Çıkış Hareketleri"});
            this.cmbHareketler.Location = new System.Drawing.Point(502, 13);
            this.cmbHareketler.Name = "cmbHareketler";
            this.cmbHareketler.Size = new System.Drawing.Size(246, 21);
            this.cmbHareketler.TabIndex = 5;
            this.cmbHareketler.SelectedIndexChanged += new System.EventHandler(this.cmbHareketler_SelectedIndexChanged);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(118, 66);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(271, 20);
            this.txtCari.TabIndex = 4;
            // 
            // cmbKasa
            // 
            this.cmbKasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKasa.FormattingEnabled = true;
            this.cmbKasa.Location = new System.Drawing.Point(257, 13);
            this.cmbKasa.Name = "cmbKasa";
            this.cmbKasa.Size = new System.Drawing.Size(132, 21);
            this.cmbKasa.TabIndex = 1;
            this.cmbKasa.SelectedIndexChanged += new System.EventHandler(this.cmbKasa_SelectedIndexChanged);
            // 
            // dtpBitis
            // 
            this.dtpBitis.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBitis.Location = new System.Drawing.Point(257, 40);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(132, 20);
            this.dtpBitis.TabIndex = 3;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBaslangic.Location = new System.Drawing.Point(118, 40);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(133, 20);
            this.dtpBaslangic.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAra.BackgroundImage")));
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAra.Location = new System.Drawing.Point(777, 40);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(48, 47);
            this.btnAra.TabIndex = 8;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // grdKasaMain
            // 
            this.grdKasaMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKasaMain.Location = new System.Drawing.Point(0, 0);
            this.grdKasaMain.LookAndFeel.SkinName = "Black";
            this.grdKasaMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdKasaMain.MainView = this.grdKasa;
            this.grdKasaMain.Name = "grdKasaMain";
            this.grdKasaMain.Size = new System.Drawing.Size(942, 295);
            this.grdKasaMain.TabIndex = 1;
            this.grdKasaMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdKasa});
            // 
            // grdKasa
            // 
            this.grdKasa.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdKasa.GridControl = this.grdKasaMain;
            this.grdKasa.Name = "grdKasa";
            this.grdKasa.OptionsBehavior.Editable = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(942, 295);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // _4KasaModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "_4KasaModul";
            this.Size = new System.Drawing.Size(950, 419);
            this.Load += new System.EventHandler(this.CariModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKasaMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKasa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtEvrakNo;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ComboBox cmbKasa;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Button btnAra;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbOdemeTipi;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.ComboBox cmbHareketler;
        public DevExpress.XtraGrid.GridControl grdKasaMain;
        public DevExpress.XtraGrid.Views.Grid.GridView grdKasa;
    }
}
