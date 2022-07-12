namespace ProCustomer.Forms.Tanimlama
{
    partial class _8ParaPuan
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
            this.grdParaPuanTanim = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdParaPuanMain = new DevExpress.XtraGrid.GridControl();
            this.LBLlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrLimit = new System.Windows.Forms.NumericUpDown();
            this.nmrKarsilik = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdParaPuanTanim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdParaPuanMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKarsilik)).BeginInit();
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
            this.groupControl1.TabIndex = 28;
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
            // grdParaPuanTanim
            // 
            this.grdParaPuanTanim.GridControl = this.grdParaPuanMain;
            this.grdParaPuanTanim.Name = "grdParaPuanTanim";
            // 
            // grdParaPuanMain
            // 
            this.grdParaPuanMain.Location = new System.Drawing.Point(12, 131);
            this.grdParaPuanMain.MainView = this.grdParaPuanTanim;
            this.grdParaPuanMain.Name = "grdParaPuanMain";
            this.grdParaPuanMain.Size = new System.Drawing.Size(522, 251);
            this.grdParaPuanMain.TabIndex = 26;
            this.grdParaPuanMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdParaPuanTanim});
            // 
            // LBLlbl
            // 
            this.LBLlbl.AutoSize = true;
            this.LBLlbl.Location = new System.Drawing.Point(12, 16);
            this.LBLlbl.Name = "LBLlbl";
            this.LBLlbl.Size = new System.Drawing.Size(79, 13);
            this.LBLlbl.TabIndex = 27;
            this.LBLlbl.Text = "Alışveriş Limiti :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Karşılığı ParaPuan :";
            // 
            // nmrLimit
            // 
            this.nmrLimit.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrLimit.Location = new System.Drawing.Point(119, 14);
            this.nmrLimit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrLimit.Name = "nmrLimit";
            this.nmrLimit.Size = new System.Drawing.Size(120, 21);
            this.nmrLimit.TabIndex = 5;
            this.nmrLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmrKarsilik
            // 
            this.nmrKarsilik.Location = new System.Drawing.Point(119, 50);
            this.nmrKarsilik.Name = "nmrKarsilik";
            this.nmrKarsilik.Size = new System.Drawing.Size(120, 21);
            this.nmrKarsilik.TabIndex = 5;
            this.nmrKarsilik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _8ParaPuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 394);
            this.ControlBox = false;
            this.Controls.Add(this.nmrKarsilik);
            this.Controls.Add(this.nmrLimit);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grdParaPuanMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "_8ParaPuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para Puan";
            this.Load += new System.EventHandler(this._8ParaPuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdParaPuanTanim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdParaPuanMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKarsilik)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView grdParaPuanTanim;
        private DevExpress.XtraGrid.GridControl grdParaPuanMain;
        private System.Windows.Forms.Label LBLlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrLimit;
        private System.Windows.Forms.NumericUpDown nmrKarsilik;
    }
}