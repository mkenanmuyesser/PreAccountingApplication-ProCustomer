namespace ProCustomer.Forms.Tanimlama
{
    partial class _9HayvanTanimForm
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
            this.grdHTanimMain = new DevExpress.XtraGrid.GridControl();
            this.grdHTanim = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdDisi = new System.Windows.Forms.RadioButton();
            this.rdErkek = new System.Windows.Forms.RadioButton();
            this.chkEs = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTuru = new System.Windows.Forms.ComboBox();
            this.nmrAylik = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHTanimMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHTanim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAylik)).BeginInit();
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
            this.groupControl1.Location = new System.Drawing.Point(257, 9);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(274, 102);
            this.groupControl1.TabIndex = 34;
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
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Location = new System.Drawing.Point(86, 69);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(108, 23);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // grdHTanimMain
            // 
            this.grdHTanimMain.Location = new System.Drawing.Point(9, 128);
            this.grdHTanimMain.MainView = this.grdHTanim;
            this.grdHTanimMain.Name = "grdHTanimMain";
            this.grdHTanimMain.Size = new System.Drawing.Size(522, 251);
            this.grdHTanimMain.TabIndex = 31;
            this.grdHTanimMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdHTanim});
            // 
            // grdHTanim
            // 
            this.grdHTanim.GridControl = this.grdHTanimMain;
            this.grdHTanim.Name = "grdHTanim";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(94, 10);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(154, 21);
            this.txtAdi.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Adi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Cinsi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Eş Arıyor ? :";
            // 
            // rdDisi
            // 
            this.rdDisi.AutoSize = true;
            this.rdDisi.Location = new System.Drawing.Point(115, 82);
            this.rdDisi.Name = "rdDisi";
            this.rdDisi.Size = new System.Drawing.Size(41, 17);
            this.rdDisi.TabIndex = 38;
            this.rdDisi.TabStop = true;
            this.rdDisi.Text = "Dişi";
            this.rdDisi.UseVisualStyleBackColor = true;
            // 
            // rdErkek
            // 
            this.rdErkek.AutoSize = true;
            this.rdErkek.Location = new System.Drawing.Point(182, 82);
            this.rdErkek.Name = "rdErkek";
            this.rdErkek.Size = new System.Drawing.Size(51, 17);
            this.rdErkek.TabIndex = 39;
            this.rdErkek.TabStop = true;
            this.rdErkek.Text = "Erkek";
            this.rdErkek.UseVisualStyleBackColor = true;
            // 
            // chkEs
            // 
            this.chkEs.AutoSize = true;
            this.chkEs.Location = new System.Drawing.Point(159, 104);
            this.chkEs.Name = "chkEs";
            this.chkEs.Size = new System.Drawing.Size(15, 14);
            this.chkEs.TabIndex = 40;
            this.chkEs.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Türü :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Kaç Aylık :";
            // 
            // cmbTuru
            // 
            this.cmbTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTuru.FormattingEnabled = true;
            this.cmbTuru.Location = new System.Drawing.Point(94, 34);
            this.cmbTuru.Name = "cmbTuru";
            this.cmbTuru.Size = new System.Drawing.Size(154, 21);
            this.cmbTuru.TabIndex = 42;
            // 
            // nmrAylik
            // 
            this.nmrAylik.Location = new System.Drawing.Point(94, 61);
            this.nmrAylik.Name = "nmrAylik";
            this.nmrAylik.Size = new System.Drawing.Size(52, 21);
            this.nmrAylik.TabIndex = 43;
            this.nmrAylik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmrAylik.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _9HayvanTanimForm
            // 
            this.AcceptButton = this.btnKayitEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(540, 388);
            this.ControlBox = false;
            this.Controls.Add(this.nmrAylik);
            this.Controls.Add(this.cmbTuru);
            this.Controls.Add(this.chkEs);
            this.Controls.Add(this.rdErkek);
            this.Controls.Add(this.rdDisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grdHTanimMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "_9HayvanTanimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hayvan Tanımla";
            this.Load += new System.EventHandler(this._9HayvanTanimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHTanimMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHTanim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAylik)).EndInit();
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
        private DevExpress.XtraGrid.GridControl grdHTanimMain;
        private DevExpress.XtraGrid.Views.Grid.GridView grdHTanim;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdDisi;
        private System.Windows.Forms.RadioButton rdErkek;
        private System.Windows.Forms.CheckBox chkEs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTuru;
        private System.Windows.Forms.NumericUpDown nmrAylik;
    }
}