namespace ProCustomer.Forms
{
    partial class BolgeListeForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBolgeTanimi = new System.Windows.Forms.TextBox();
            this.grdBolgeListeMain = new DevExpress.XtraGrid.GridControl();
            this.grdBolgeListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbFiyatKademesi = new System.Windows.Forms.ComboBox();
            this.cmbSorumlu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBolgeListeMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBolgeListe)).BeginInit();
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
            this.groupControl1.TabIndex = 12;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bölge Fiyat Kademesi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bölge Sorumlusu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bölge Tanımı :";
            // 
            // txtBolgeTanimi
            // 
            this.txtBolgeTanimi.Location = new System.Drawing.Point(126, 12);
            this.txtBolgeTanimi.Name = "txtBolgeTanimi";
            this.txtBolgeTanimi.Size = new System.Drawing.Size(125, 21);
            this.txtBolgeTanimi.TabIndex = 0;
            // 
            // grdBolgeListeMain
            // 
            this.grdBolgeListeMain.Location = new System.Drawing.Point(12, 131);
            this.grdBolgeListeMain.MainView = this.grdBolgeListe;
            this.grdBolgeListeMain.Name = "grdBolgeListeMain";
            this.grdBolgeListeMain.Size = new System.Drawing.Size(522, 251);
            this.grdBolgeListeMain.TabIndex = 5;
            this.grdBolgeListeMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdBolgeListe});
            // 
            // grdBolgeListe
            // 
            this.grdBolgeListe.GridControl = this.grdBolgeListeMain;
            this.grdBolgeListe.Name = "grdBolgeListe";
            // 
            // cmbFiyatKademesi
            // 
            this.cmbFiyatKademesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiyatKademesi.FormattingEnabled = true;
            this.cmbFiyatKademesi.Items.AddRange(new object[] {
            "Fiyat 1",
            "Fiyat 2",
            "Fiyat 3",
            "Fiyat 4",
            "Fiyat 5",
            "Fiyat 6"});
            this.cmbFiyatKademesi.Location = new System.Drawing.Point(126, 66);
            this.cmbFiyatKademesi.Name = "cmbFiyatKademesi";
            this.cmbFiyatKademesi.Size = new System.Drawing.Size(125, 21);
            this.cmbFiyatKademesi.TabIndex = 2;
            // 
            // cmbSorumlu
            // 
            this.cmbSorumlu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSorumlu.FormattingEnabled = true;
            this.cmbSorumlu.Location = new System.Drawing.Point(126, 39);
            this.cmbSorumlu.Name = "cmbSorumlu";
            this.cmbSorumlu.Size = new System.Drawing.Size(125, 21);
            this.cmbSorumlu.TabIndex = 1;
            // 
            // BolgeListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 394);
            this.ControlBox = false;
            this.Controls.Add(this.cmbSorumlu);
            this.Controls.Add(this.cmbFiyatKademesi);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBolgeTanimi);
            this.Controls.Add(this.grdBolgeListeMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "BolgeListeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bolge Tanım";
            this.Load += new System.EventHandler(this.BolgeListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBolgeListeMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBolgeListe)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBolgeTanimi;
        private DevExpress.XtraGrid.GridControl grdBolgeListeMain;
        private DevExpress.XtraGrid.Views.Grid.GridView grdBolgeListe;
        private System.Windows.Forms.ComboBox cmbFiyatKademesi;
        private System.Windows.Forms.ComboBox cmbSorumlu;

    }
}