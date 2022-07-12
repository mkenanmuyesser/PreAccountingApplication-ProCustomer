namespace ProCustomer.Forms
{
    partial class _31UrunEkleDegistirForm
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
            this.btniptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtUrunTanim = new System.Windows.Forms.TextBox();
            this.btnKatEkle = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkKDV = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.nudKdv = new System.Windows.Forms.NumericUpDown();
            this.txtFiyat1 = new DevExpress.XtraEditors.CalcEdit();
            this.txtFiyat2 = new DevExpress.XtraEditors.CalcEdit();
            this.txtFiyat3 = new DevExpress.XtraEditors.CalcEdit();
            this.txtFiyat4 = new DevExpress.XtraEditors.CalcEdit();
            this.txtFiyat5 = new DevExpress.XtraEditors.CalcEdit();
            this.txtFiyat6 = new DevExpress.XtraEditors.CalcEdit();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudKdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat6.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btniptal
            // 
            this.btniptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btniptal.Location = new System.Drawing.Point(312, 380);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(75, 23);
            this.btniptal.TabIndex = 14;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(234, 380);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Tamam";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtUrunTanim
            // 
            this.txtUrunTanim.Location = new System.Drawing.Point(112, 44);
            this.txtUrunTanim.Name = "txtUrunTanim";
            this.txtUrunTanim.Size = new System.Drawing.Size(272, 21);
            this.txtUrunTanim.TabIndex = 2;
            // 
            // btnKatEkle
            // 
            this.btnKatEkle.Location = new System.Drawing.Point(343, 13);
            this.btnKatEkle.Name = "btnKatEkle";
            this.btnKatEkle.Size = new System.Drawing.Size(42, 23);
            this.btnKatEkle.TabIndex = 1;
            this.btnKatEkle.Text = "EKLE";
            this.btnKatEkle.UseVisualStyleBackColor = true;
            this.btnKatEkle.Click += new System.EventHandler(this.btnKatEkle_Click);
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(113, 15);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(227, 21);
            this.cmbKategori.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ürün Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kategori :";
            // 
            // chkKDV
            // 
            this.chkKDV.AutoSize = true;
            this.chkKDV.Location = new System.Drawing.Point(251, 232);
            this.chkKDV.Name = "chkKDV";
            this.chkKDV.Size = new System.Drawing.Size(71, 17);
            this.chkKDV.TabIndex = 10;
            this.chkKDV.Text = "KDV Dahil";
            this.chkKDV.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Fiyat 6 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Fiyat 5 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Fiyat 4 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fiyat 3 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Açıklama :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "KDV Oranı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fiyat 1 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Fiyat 2 :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(112, 289);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(210, 59);
            this.txtAciklama.TabIndex = 11;
            // 
            // nudKdv
            // 
            this.nudKdv.Location = new System.Drawing.Point(112, 231);
            this.nudKdv.Name = "nudKdv";
            this.nudKdv.Size = new System.Drawing.Size(124, 21);
            this.nudKdv.TabIndex = 9;
            this.nudKdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFiyat1
            // 
            this.txtFiyat1.Location = new System.Drawing.Point(112, 71);
            this.txtFiyat1.Name = "txtFiyat1";
            this.txtFiyat1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFiyat1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFiyat1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFiyat1.Properties.NullText = "0";
            this.txtFiyat1.Size = new System.Drawing.Size(124, 20);
            this.txtFiyat1.TabIndex = 3;
            // 
            // txtFiyat2
            // 
            this.txtFiyat2.Location = new System.Drawing.Point(112, 97);
            this.txtFiyat2.Name = "txtFiyat2";
            this.txtFiyat2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFiyat2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFiyat2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFiyat2.Properties.NullText = "0";
            this.txtFiyat2.Size = new System.Drawing.Size(124, 20);
            this.txtFiyat2.TabIndex = 4;
            // 
            // txtFiyat3
            // 
            this.txtFiyat3.Location = new System.Drawing.Point(112, 122);
            this.txtFiyat3.Name = "txtFiyat3";
            this.txtFiyat3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFiyat3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFiyat3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFiyat3.Properties.NullText = "0";
            this.txtFiyat3.Size = new System.Drawing.Size(124, 20);
            this.txtFiyat3.TabIndex = 5;
            // 
            // txtFiyat4
            // 
            this.txtFiyat4.Location = new System.Drawing.Point(112, 149);
            this.txtFiyat4.Name = "txtFiyat4";
            this.txtFiyat4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFiyat4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFiyat4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFiyat4.Properties.NullText = "0";
            this.txtFiyat4.Size = new System.Drawing.Size(124, 20);
            this.txtFiyat4.TabIndex = 6;
            // 
            // txtFiyat5
            // 
            this.txtFiyat5.Location = new System.Drawing.Point(112, 176);
            this.txtFiyat5.Name = "txtFiyat5";
            this.txtFiyat5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFiyat5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFiyat5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFiyat5.Properties.NullText = "0";
            this.txtFiyat5.Size = new System.Drawing.Size(124, 20);
            this.txtFiyat5.TabIndex = 7;
            // 
            // txtFiyat6
            // 
            this.txtFiyat6.Location = new System.Drawing.Point(112, 203);
            this.txtFiyat6.Name = "txtFiyat6";
            this.txtFiyat6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFiyat6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFiyat6.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFiyat6.Properties.NullText = "0";
            this.txtFiyat6.Size = new System.Drawing.Size(124, 20);
            this.txtFiyat6.TabIndex = 8;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(112, 356);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(272, 21);
            this.txtBarkod.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Barkod No :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Stok Adeti :";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(112, 258);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(124, 21);
            this.txtStok.TabIndex = 2;
            // 
            // _31UrunEkleDegistirForm
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(399, 414);
            this.ControlBox = false;
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudKdv);
            this.Controls.Add(this.txtFiyat6);
            this.Controls.Add(this.txtFiyat5);
            this.Controls.Add(this.txtFiyat4);
            this.Controls.Add(this.txtFiyat3);
            this.Controls.Add(this.txtFiyat2);
            this.Controls.Add(this.txtFiyat1);
            this.Controls.Add(this.chkKDV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtUrunTanim);
            this.Controls.Add(this.btnKatEkle);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btniptal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "_31UrunEkleDegistirForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun Ekle / Değiştir";
            this.Load += new System.EventHandler(this._31UrunEkleDegistirForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat6.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtUrunTanim;
        private System.Windows.Forms.Button btnKatEkle;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkKDV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.NumericUpDown nudKdv;
        private DevExpress.XtraEditors.CalcEdit txtFiyat1;
        private DevExpress.XtraEditors.CalcEdit txtFiyat2;
        private DevExpress.XtraEditors.CalcEdit txtFiyat3;
        private DevExpress.XtraEditors.CalcEdit txtFiyat4;
        private DevExpress.XtraEditors.CalcEdit txtFiyat5;
        private DevExpress.XtraEditors.CalcEdit txtFiyat6;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStok;
    }
}