namespace ProCustomer.UserControls.Iletisim
{
    partial class _1CagriModul
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnYazici = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.grdCagriMain = new DevExpress.XtraGrid.GridControl();
            this.grdCagri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sfdExcel = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCagriMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCagri)).BeginInit();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.grdCagriMain);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(950, 419);
            this.splitContainerControl1.SplitterPosition = 74;
            this.splitContainerControl1.TabIndex = 0;
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
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl5);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl2.Panel2.Controls.Add(this.btnYazici);
            this.splitContainerControl2.Panel2.Controls.Add(this.btnExcel);
            this.splitContainerControl2.Panel2.Controls.Add(this.btnAra);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(946, 70);
            this.splitContainerControl2.SplitterPosition = 205;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // dtpBitis
            // 
            this.dtpBitis.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBitis.Location = new System.Drawing.Point(96, 34);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(147, 20);
            this.dtpBitis.TabIndex = 24;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBaslangic.Location = new System.Drawing.Point(96, 8);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(147, 20);
            this.dtpBaslangic.TabIndex = 25;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Bitiş Tarihi :";
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
            this.btnYazici.Location = new System.Drawing.Point(77, 8);
            this.btnYazici.Name = "btnYazici";
            this.btnYazici.Size = new System.Drawing.Size(48, 47);
            this.btnYazici.TabIndex = 24;
            this.btnYazici.UseVisualStyleBackColor = true;
            this.btnYazici.Click += new System.EventHandler(this.btnYazici_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = global::ProCustomer.Properties.Resources.Excel_icon;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.Location = new System.Drawing.Point(131, 8);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(48, 47);
            this.btnExcel.TabIndex = 24;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackgroundImage = global::ProCustomer.Properties.Resources.search;
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAra.Location = new System.Drawing.Point(23, 8);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(48, 47);
            this.btnAra.TabIndex = 24;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // grdCagriMain
            // 
            this.grdCagriMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCagriMain.Location = new System.Drawing.Point(0, 0);
            this.grdCagriMain.LookAndFeel.SkinName = "Black";
            this.grdCagriMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdCagriMain.MainView = this.grdCagri;
            this.grdCagriMain.Name = "grdCagriMain";
            this.grdCagriMain.Size = new System.Drawing.Size(950, 340);
            this.grdCagriMain.TabIndex = 0;
            this.grdCagriMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdCagri});
            // 
            // grdCagri
            // 
            this.grdCagri.GridControl = this.grdCagriMain;
            this.grdCagri.Name = "grdCagri";
            this.grdCagri.OptionsBehavior.Editable = false;
            // 
            // sfdExcel
            // 
            this.sfdExcel.FileName = "rapor";
            this.sfdExcel.Filter = "Excel dosyası|*.xls";
            // 
            // _1CagriModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "_1CagriModul";
            this.Size = new System.Drawing.Size(950, 419);
            this.Load += new System.EventHandler(this._1CagriModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCagriMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCagri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl grdCagriMain;
        private DevExpress.XtraGrid.Views.Grid.GridView grdCagri;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.SaveFileDialog sfdExcel;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Button btnYazici;
    }
}
