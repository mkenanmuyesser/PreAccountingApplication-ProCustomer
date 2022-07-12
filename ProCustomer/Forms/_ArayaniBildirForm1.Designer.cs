namespace ProCustomer.Forms
{
    partial class _ArayaniBildirForm1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ArayaniBildirForm1));
            this.btnCancel = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArayan = new System.Windows.Forms.Label();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grdSonSip = new DevExpress.XtraGrid.GridControl();
            this.grdSonSipView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pc1 = new System.Windows.Forms.PictureBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSonSip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSonSipView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageIndex = 0;
            this.btnCancel.ImageList = this.ımageList1;
            this.btnCancel.Location = new System.Drawing.Point(243, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 46);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "İptal";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "block.png");
            this.ımageList1.Images.SetKeyName(1, "shopping_cart.png");
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.ImageIndex = 1;
            this.btnOk.ImageList = this.ımageList1;
            this.btnOk.Location = new System.Drawing.Point(102, 111);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(92, 46);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Kaydet";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(99, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sipariş Listesine Eklemek İstiyor musunuz?";
            // 
            // lblArayan
            // 
            this.lblArayan.AutoSize = true;
            this.lblArayan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArayan.Location = new System.Drawing.Point(12, 19);
            this.lblArayan.Name = "lblArayan";
            this.lblArayan.Size = new System.Drawing.Size(170, 23);
            this.lblArayan.TabIndex = 7;
            this.lblArayan.Text = "Arayan Numara :";
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteri.Location = new System.Drawing.Point(12, 52);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(95, 23);
            this.lblMusteri.TabIndex = 7;
            this.lblMusteri.Text = "Müşteri :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProCustomer.Properties.Resources.phone_book;
            this.pictureBox1.Location = new System.Drawing.Point(372, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // grdSonSip
            // 
            this.grdSonSip.Location = new System.Drawing.Point(24, 217);
            this.grdSonSip.MainView = this.grdSonSipView;
            this.grdSonSip.Name = "grdSonSip";
            this.grdSonSip.Size = new System.Drawing.Size(400, 250);
            this.grdSonSip.TabIndex = 11;
            this.grdSonSip.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdSonSipView});
            // 
            // grdSonSipView
            // 
            this.grdSonSipView.GridControl = this.grdSonSip;
            this.grdSonSipView.Name = "grdSonSipView";
            // 
            // pc1
            // 
            this.pc1.Image = global::ProCustomer.Properties.Resources.exclamination_mark;
            this.pc1.Location = new System.Drawing.Point(380, 111);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(49, 46);
            this.pc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc1.TabIndex = 12;
            this.pc1.TabStop = false;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(24, 168);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(400, 43);
            this.txtAciklama.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Açıklama";
            // 
            // _ArayaniBildirForm1
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(448, 489);
            this.ControlBox = false;
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.pc1);
            this.Controls.Add(this.grdSonSip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.lblArayan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "_ArayaniBildirForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArayaniBildir";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSonSip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSonSipView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblArayan;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl grdSonSip;
        private DevExpress.XtraGrid.Views.Grid.GridView grdSonSipView;
        private System.Windows.Forms.PictureBox pc1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtAciklama;
    }
}