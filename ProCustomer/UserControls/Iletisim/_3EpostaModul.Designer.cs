namespace ProCustomer.UserControls.Iletisim
{
    partial class _3EpostaModul
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
            this.txtMesajIcerik = new System.Windows.Forms.TextBox();
            this.btnEpostaGonder = new System.Windows.Forms.Button();
            this.txtMesajKonu = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnYazici = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.grdEpostaMain = new DevExpress.XtraGrid.GridControl();
            this.grdEposta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sfdExcel = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEpostaMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEposta)).BeginInit();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.grdEpostaMain);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(950, 419);
            this.splitContainerControl1.SplitterPosition = 158;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.splitContainerControl2.Panel1.Controls.Add(this.txtMesajIcerik);
            this.splitContainerControl2.Panel1.Controls.Add(this.btnEpostaGonder);
            this.splitContainerControl2.Panel1.Controls.Add(this.txtMesajKonu);
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl2);
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
            // txtMesajIcerik
            // 
            this.txtMesajIcerik.Location = new System.Drawing.Point(97, 34);
            this.txtMesajIcerik.Multiline = true;
            this.txtMesajIcerik.Name = "txtMesajIcerik";
            this.txtMesajIcerik.Size = new System.Drawing.Size(256, 106);
            this.txtMesajIcerik.TabIndex = 1;
            // 
            // btnEpostaGonder
            // 
            this.btnEpostaGonder.BackgroundImage = global::ProCustomer.Properties.Resources.send_mail;
            this.btnEpostaGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEpostaGonder.Location = new System.Drawing.Point(359, 93);
            this.btnEpostaGonder.Name = "btnEpostaGonder";
            this.btnEpostaGonder.Size = new System.Drawing.Size(48, 47);
            this.btnEpostaGonder.TabIndex = 2;
            this.btnEpostaGonder.UseVisualStyleBackColor = true;
            this.btnEpostaGonder.Click += new System.EventHandler(this.btnEpostaGonder_Click);
            // 
            // txtMesajKonu
            // 
            this.txtMesajKonu.Location = new System.Drawing.Point(97, 8);
            this.txtMesajKonu.Name = "txtMesajKonu";
            this.txtMesajKonu.Size = new System.Drawing.Size(256, 20);
            this.txtMesajKonu.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 13);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Mesaj İçeriği :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Mesaj Konusu :";
            // 
            // btnYazici
            // 
            this.btnYazici.BackgroundImage = global::ProCustomer.Properties.Resources.printer;
            this.btnYazici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYazici.Location = new System.Drawing.Point(71, 92);
            this.btnYazici.Name = "btnYazici";
            this.btnYazici.Size = new System.Drawing.Size(48, 47);
            this.btnYazici.TabIndex = 1;
            this.btnYazici.UseVisualStyleBackColor = true;
            this.btnYazici.Click += new System.EventHandler(this.btnYazici_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = global::ProCustomer.Properties.Resources.Excel_icon;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.Location = new System.Drawing.Point(125, 92);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(48, 47);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackgroundImage = global::ProCustomer.Properties.Resources.search;
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAra.Location = new System.Drawing.Point(17, 92);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(48, 47);
            this.btnAra.TabIndex = 0;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // grdEpostaMain
            // 
            this.grdEpostaMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEpostaMain.Location = new System.Drawing.Point(0, 0);
            this.grdEpostaMain.LookAndFeel.SkinName = "Black";
            this.grdEpostaMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdEpostaMain.MainView = this.grdEposta;
            this.grdEpostaMain.Name = "grdEpostaMain";
            this.grdEpostaMain.Size = new System.Drawing.Size(950, 256);
            this.grdEpostaMain.TabIndex = 0;
            this.grdEpostaMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdEposta});
            // 
            // grdEposta
            // 
            this.grdEposta.GridControl = this.grdEpostaMain;
            this.grdEposta.Name = "grdEposta";
            // 
            // sfdExcel
            // 
            this.sfdExcel.FileName = "rapor";
            this.sfdExcel.Filter = "Excel dosyası|*.xls";
            // 
            // _3EpostaModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "_3EpostaModul";
            this.Size = new System.Drawing.Size(950, 419);
            this.Load += new System.EventHandler(this._3EpostaModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEpostaMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEposta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnEpostaGonder;
        private System.Windows.Forms.Button btnAra;
        private DevExpress.XtraGrid.GridControl grdEpostaMain;
        private DevExpress.XtraGrid.Views.Grid.GridView grdEposta;
        private System.Windows.Forms.TextBox txtMesajIcerik;
        private System.Windows.Forms.TextBox txtMesajKonu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.SaveFileDialog sfdExcel;
        private System.Windows.Forms.Button btnYazici;
    }
}
