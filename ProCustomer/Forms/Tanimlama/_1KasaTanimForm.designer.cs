namespace ProCustomer.Forms.Tanimlama
{
    partial class KasaTanimForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKayitEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.LBLlbl = new System.Windows.Forms.Label();
            this.grdKasaTanimMain = new DevExpress.XtraGrid.GridControl();
            this.grdKasaTanim = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtKasaAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKasaTanimMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKasaTanim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.btnKayitEkle);
            this.groupControl1.Controls.Add(this.btnIptal);
            this.groupControl1.Controls.Add(this.btnDuzenle);
            this.groupControl1.Controls.Add(this.btnKayitSil);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Location = new System.Drawing.Point(260, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(274, 102);
            this.groupControl1.TabIndex = 24;
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.Location = new System.Drawing.Point(18, 11);
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(108, 23);
            this.btnKayitEkle.TabIndex = 0;
            this.btnKayitEkle.Text = "Kayıt Ekle";
            this.btnKayitEkle.UseVisualStyleBackColor = true;
            this.btnKayitEkle.Click += new System.EventHandler(this.btnKayitEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(148, 40);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(108, 23);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "Değişiklik İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(18, 40);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(108, 23);
            this.btnDuzenle.TabIndex = 2;
            this.btnDuzenle.Text = "Değişiklik Kaydet";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.Location = new System.Drawing.Point(148, 11);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(108, 23);
            this.btnKayitSil.TabIndex = 1;
            this.btnKayitSil.Text = "Kayıt Sil";
            this.btnKayitSil.UseVisualStyleBackColor = true;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(86, 69);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(108, 23);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // LBLlbl
            // 
            this.LBLlbl.AutoSize = true;
            this.LBLlbl.Location = new System.Drawing.Point(12, 16);
            this.LBLlbl.Name = "LBLlbl";
            this.LBLlbl.Size = new System.Drawing.Size(58, 13);
            this.LBLlbl.TabIndex = 23;
            this.LBLlbl.Text = "Kasa Adı  :";
            // 
            // grdKasaTanimMain
            // 
            this.grdKasaTanimMain.Location = new System.Drawing.Point(12, 131);
            this.grdKasaTanimMain.MainView = this.grdKasaTanim;
            this.grdKasaTanimMain.Name = "grdKasaTanimMain";
            this.grdKasaTanimMain.Size = new System.Drawing.Size(522, 251);
            this.grdKasaTanimMain.TabIndex = 21;
            this.grdKasaTanimMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdKasaTanim});
            // 
            // grdKasaTanim
            // 
            this.grdKasaTanim.GridControl = this.grdKasaTanimMain;
            this.grdKasaTanim.Name = "grdKasaTanim";
            // 
            // txtKasaAdi
            // 
            this.txtKasaAdi.Location = new System.Drawing.Point(93, 12);
            this.txtKasaAdi.Name = "txtKasaAdi";
            this.txtKasaAdi.Size = new System.Drawing.Size(158, 21);
            this.txtKasaAdi.TabIndex = 1;
            // 
            // KasaTanimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 394);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.LBLlbl);
            this.Controls.Add(this.grdKasaTanimMain);
            this.Controls.Add(this.txtKasaAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "KasaTanimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Tanım";
            this.Load += new System.EventHandler(this.KasaTanimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKasaTanimMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKasaTanim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnKayitEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnKayitSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label LBLlbl;
        private DevExpress.XtraGrid.GridControl grdKasaTanimMain;
        private DevExpress.XtraGrid.Views.Grid.GridView grdKasaTanim;
        private System.Windows.Forms.TextBox txtKasaAdi;
    }
}