namespace ProCustomer.UserControls.Iletisim
{
    partial class _4SmsModul
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnSmsGonder = new System.Windows.Forms.Button();
            this.txtSmsIcerik = new System.Windows.Forms.TextBox();
            this.btnYazici = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.grdSmsMain = new DevExpress.XtraGrid.GridControl();
            this.grdSms = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sfdExcel = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSmsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSms)).BeginInit();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.grdSmsMain);
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
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl4);
            this.splitContainerControl2.Panel1.Controls.Add(this.btnSmsGonder);
            this.splitContainerControl2.Panel1.Controls.Add(this.txtSmsIcerik);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl2.Panel2.Controls.Add(this.btnYazici);
            this.splitContainerControl2.Panel2.Controls.Add(this.btnExcel);
            this.splitContainerControl2.Panel2.Controls.Add(this.btnAra);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(946, 154);
            this.splitContainerControl2.SplitterPosition = 190;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 13);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Sms Mesaj İçeriği :";
            // 
            // btnSmsGonder
            // 
            this.btnSmsGonder.BackgroundImage = global::ProCustomer.Properties.Resources.send_mail;
            this.btnSmsGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSmsGonder.Location = new System.Drawing.Point(380, 92);
            this.btnSmsGonder.Name = "btnSmsGonder";
            this.btnSmsGonder.Size = new System.Drawing.Size(48, 47);
            this.btnSmsGonder.TabIndex = 24;
            this.btnSmsGonder.UseVisualStyleBackColor = true;
            this.btnSmsGonder.Click += new System.EventHandler(this.btnSmsGonder_Click);
            // 
            // txtSmsIcerik
            // 
            this.txtSmsIcerik.Location = new System.Drawing.Point(109, 8);
            this.txtSmsIcerik.Multiline = true;
            this.txtSmsIcerik.Name = "txtSmsIcerik";
            this.txtSmsIcerik.Size = new System.Drawing.Size(256, 131);
            this.txtSmsIcerik.TabIndex = 24;
            // 
            // btnYazici
            // 
            this.btnYazici.BackgroundImage = global::ProCustomer.Properties.Resources.printer;
            this.btnYazici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYazici.Location = new System.Drawing.Point(73, 92);
            this.btnYazici.Name = "btnYazici";
            this.btnYazici.Size = new System.Drawing.Size(48, 47);
            this.btnYazici.TabIndex = 26;
            this.btnYazici.UseVisualStyleBackColor = true;
            this.btnYazici.Click += new System.EventHandler(this.btnYazici_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = global::ProCustomer.Properties.Resources.Excel_icon;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.Location = new System.Drawing.Point(127, 92);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(48, 47);
            this.btnExcel.TabIndex = 24;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackgroundImage = global::ProCustomer.Properties.Resources.search;
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAra.Location = new System.Drawing.Point(19, 92);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(48, 47);
            this.btnAra.TabIndex = 24;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // grdSmsMain
            // 
            this.grdSmsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSmsMain.Location = new System.Drawing.Point(0, 0);
            this.grdSmsMain.LookAndFeel.SkinName = "Black";
            this.grdSmsMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdSmsMain.MainView = this.grdSms;
            this.grdSmsMain.Name = "grdSmsMain";
            this.grdSmsMain.Size = new System.Drawing.Size(950, 256);
            this.grdSmsMain.TabIndex = 0;
            this.grdSmsMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdSms});
            // 
            // grdSms
            // 
            this.grdSms.GridControl = this.grdSmsMain;
            this.grdSms.Name = "grdSms";
            // 
            // sfdExcel
            // 
            this.sfdExcel.FileName = "rapor";
            this.sfdExcel.Filter = "Excel dosyası|*.xls";
            // 
            // _4SmsModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "_4SmsModul";
            this.Size = new System.Drawing.Size(950, 419);
            this.Load += new System.EventHandler(this._4SmsModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSmsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.TextBox txtSmsIcerik;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnSmsGonder;
        private System.Windows.Forms.Button btnAra;
        private DevExpress.XtraGrid.GridControl grdSmsMain;
        private DevExpress.XtraGrid.Views.Grid.GridView grdSms;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.SaveFileDialog sfdExcel;
        private System.Windows.Forms.Button btnYazici;
    }
}
