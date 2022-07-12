namespace ProCustomer.UserControls.Iletisim
{
    partial class _2HatirlatmaModul
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.chkHaberVer = new System.Windows.Forms.CheckBox();
            this.btnSmsGonder = new System.Windows.Forms.Button();
            this.btnMailGonder = new System.Windows.Forms.Button();
            this.chkOzelGun = new System.Windows.Forms.CheckBox();
            this.chkDogumGunu = new System.Windows.Forms.CheckBox();
            this.txtSmsIcerik = new System.Windows.Forms.TextBox();
            this.txtMesajIcerik = new System.Windows.Forms.TextBox();
            this.txtMesajKonu = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnYazici = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.grdHatirlatmaMain = new DevExpress.XtraGrid.GridControl();
            this.grdHatirlatma = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sfdExcel = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHatirlatmaMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHatirlatma)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grdHatirlatmaMain);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(950, 419);
            this.splitContainerControl1.SplitterPosition = 158;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.splitContainerControl2.Panel1.Controls.Add(this.dtpBitis);
            this.splitContainerControl2.Panel1.Controls.Add(this.dtpBaslangic);
            this.splitContainerControl2.Panel1.Controls.Add(this.chkHaberVer);
            this.splitContainerControl2.Panel1.Controls.Add(this.btnSmsGonder);
            this.splitContainerControl2.Panel1.Controls.Add(this.btnMailGonder);
            this.splitContainerControl2.Panel1.Controls.Add(this.chkOzelGun);
            this.splitContainerControl2.Panel1.Controls.Add(this.chkDogumGunu);
            this.splitContainerControl2.Panel1.Controls.Add(this.txtSmsIcerik);
            this.splitContainerControl2.Panel1.Controls.Add(this.txtMesajIcerik);
            this.splitContainerControl2.Panel1.Controls.Add(this.txtMesajKonu);
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl4);
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl5);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl2.Panel2.Controls.Add(this.btnYazici);
            this.splitContainerControl2.Panel2.Controls.Add(this.btnExcel);
            this.splitContainerControl2.Panel2.Controls.Add(this.btnAra);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(946, 154);
            this.splitContainerControl2.SplitterPosition = 192;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // dtpBitis
            // 
            this.dtpBitis.CustomFormat = "dd.MM.yyyy";
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBitis.Location = new System.Drawing.Point(96, 34);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(147, 20);
            this.dtpBitis.TabIndex = 1;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.CustomFormat = "dd.MM.yyyy";
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBaslangic.Location = new System.Drawing.Point(96, 8);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(147, 20);
            this.dtpBaslangic.TabIndex = 0;
            // 
            // chkHaberVer
            // 
            this.chkHaberVer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHaberVer.Checked = true;
            this.chkHaberVer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHaberVer.Location = new System.Drawing.Point(10, 114);
            this.chkHaberVer.Name = "chkHaberVer";
            this.chkHaberVer.Size = new System.Drawing.Size(104, 17);
            this.chkHaberVer.TabIndex = 4;
            this.chkHaberVer.Text = "Haber Ver :";
            this.chkHaberVer.UseVisualStyleBackColor = true;
            // 
            // btnSmsGonder
            // 
            this.btnSmsGonder.BackgroundImage = global::ProCustomer.Properties.Resources.send_mail;
            this.btnSmsGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSmsGonder.Location = new System.Drawing.Point(786, 91);
            this.btnSmsGonder.Name = "btnSmsGonder";
            this.btnSmsGonder.Size = new System.Drawing.Size(48, 47);
            this.btnSmsGonder.TabIndex = 9;
            this.btnSmsGonder.UseVisualStyleBackColor = true;
            this.btnSmsGonder.Click += new System.EventHandler(this.btnSmsGonder_Click);
            // 
            // btnMailGonder
            // 
            this.btnMailGonder.BackgroundImage = global::ProCustomer.Properties.Resources.send_mail;
            this.btnMailGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMailGonder.Location = new System.Drawing.Point(513, 91);
            this.btnMailGonder.Name = "btnMailGonder";
            this.btnMailGonder.Size = new System.Drawing.Size(48, 47);
            this.btnMailGonder.TabIndex = 8;
            this.btnMailGonder.UseVisualStyleBackColor = true;
            this.btnMailGonder.Click += new System.EventHandler(this.btnMailGonder_Click);
            // 
            // chkOzelGun
            // 
            this.chkOzelGun.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkOzelGun.Checked = true;
            this.chkOzelGun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOzelGun.Location = new System.Drawing.Point(10, 91);
            this.chkOzelGun.Name = "chkOzelGun";
            this.chkOzelGun.Size = new System.Drawing.Size(104, 17);
            this.chkOzelGun.TabIndex = 3;
            this.chkOzelGun.Text = "Evlilik Yılı :";
            this.chkOzelGun.UseVisualStyleBackColor = true;
            // 
            // chkDogumGunu
            // 
            this.chkDogumGunu.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDogumGunu.Checked = true;
            this.chkDogumGunu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDogumGunu.Location = new System.Drawing.Point(10, 61);
            this.chkDogumGunu.Name = "chkDogumGunu";
            this.chkDogumGunu.Size = new System.Drawing.Size(104, 24);
            this.chkDogumGunu.TabIndex = 2;
            this.chkDogumGunu.Text = "Doğum Günü :";
            this.chkDogumGunu.UseVisualStyleBackColor = true;
            // 
            // txtSmsIcerik
            // 
            this.txtSmsIcerik.Location = new System.Drawing.Point(608, 7);
            this.txtSmsIcerik.Multiline = true;
            this.txtSmsIcerik.Name = "txtSmsIcerik";
            this.txtSmsIcerik.Size = new System.Drawing.Size(172, 131);
            this.txtSmsIcerik.TabIndex = 7;
            // 
            // txtMesajIcerik
            // 
            this.txtMesajIcerik.Location = new System.Drawing.Point(335, 33);
            this.txtMesajIcerik.Multiline = true;
            this.txtMesajIcerik.Name = "txtMesajIcerik";
            this.txtMesajIcerik.Size = new System.Drawing.Size(172, 106);
            this.txtMesajIcerik.TabIndex = 6;
            // 
            // txtMesajKonu
            // 
            this.txtMesajKonu.Location = new System.Drawing.Point(335, 7);
            this.txtMesajKonu.Name = "txtMesajKonu";
            this.txtMesajKonu.Size = new System.Drawing.Size(172, 20);
            this.txtMesajKonu.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Bitiş Tarihi :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(249, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 13);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Mesaj İçeriği :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(513, 10);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 13);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Sms Mesaj İçeriği :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(249, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Mesaj Konusu :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 14);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(80, 13);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Başlangıç Tarihi :";
            // 
            // btnYazici
            // 
            this.btnYazici.BackgroundImage = global::ProCustomer.Properties.Resources.printer;
            this.btnYazici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYazici.Location = new System.Drawing.Point(72, 92);
            this.btnYazici.Name = "btnYazici";
            this.btnYazici.Size = new System.Drawing.Size(48, 47);
            this.btnYazici.TabIndex = 0;
            this.btnYazici.UseVisualStyleBackColor = true;
            this.btnYazici.Click += new System.EventHandler(this.btnYazici_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = global::ProCustomer.Properties.Resources.Excel_icon;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.Location = new System.Drawing.Point(126, 91);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(48, 47);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackgroundImage = global::ProCustomer.Properties.Resources.search;
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAra.Location = new System.Drawing.Point(18, 92);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(48, 47);
            this.btnAra.TabIndex = 24;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // grdHatirlatmaMain
            // 
            this.grdHatirlatmaMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHatirlatmaMain.Location = new System.Drawing.Point(0, 0);
            this.grdHatirlatmaMain.LookAndFeel.SkinName = "Black";
            this.grdHatirlatmaMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdHatirlatmaMain.MainView = this.grdHatirlatma;
            this.grdHatirlatmaMain.Name = "grdHatirlatmaMain";
            this.grdHatirlatmaMain.Size = new System.Drawing.Size(950, 256);
            this.grdHatirlatmaMain.TabIndex = 0;
            this.grdHatirlatmaMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdHatirlatma});
            // 
            // grdHatirlatma
            // 
            this.grdHatirlatma.GridControl = this.grdHatirlatmaMain;
            this.grdHatirlatma.Name = "grdHatirlatma";
            // 
            // sfdExcel
            // 
            this.sfdExcel.FileName = "rapor";
            this.sfdExcel.Filter = "Excel dosyası|*.xls";
            // 
            // _2HatirlatmaModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "_2HatirlatmaModul";
            this.Size = new System.Drawing.Size(950, 419);
            this.Load += new System.EventHandler(this._2HatirlatmaModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHatirlatmaMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHatirlatma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.TextBox txtMesajIcerik;
        private System.Windows.Forms.TextBox txtMesajKonu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnMailGonder;
        private System.Windows.Forms.Button btnAra;
        private DevExpress.XtraGrid.GridControl grdHatirlatmaMain;
        private DevExpress.XtraGrid.Views.Grid.GridView grdHatirlatma;
        private System.Windows.Forms.CheckBox chkHaberVer;
        private System.Windows.Forms.CheckBox chkOzelGun;
        private System.Windows.Forms.CheckBox chkDogumGunu;
        private System.Windows.Forms.TextBox txtSmsIcerik;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Button btnSmsGonder;
        private System.Windows.Forms.SaveFileDialog sfdExcel;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Button btnYazici;
    }
}
