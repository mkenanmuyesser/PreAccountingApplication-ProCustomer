namespace ProCustomer.UserControls
{
    partial class HastaModul
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.grdKart = new DevExpress.XtraGrid.GridControl();
            this.grdKartMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKartMain)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnRapor);
            this.splitContainer1.Panel1.Controls.Add(this.btnAra);
            this.splitContainer1.Panel1.Controls.Add(this.dtp2);
            this.splitContainer1.Panel1.Controls.Add(this.dtp1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdKart);
            this.splitContainer1.Size = new System.Drawing.Size(950, 419);
            this.splitContainer1.SplitterDistance = 38;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(366, 12);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(63, 23);
            this.btnRapor.TabIndex = 2;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(297, 12);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(63, 23);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(157, 13);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(134, 20);
            this.dtp2.TabIndex = 0;
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(17, 13);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(134, 20);
            this.dtp1.TabIndex = 0;
            // 
            // grdKart
            // 
            this.grdKart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKart.Location = new System.Drawing.Point(0, 0);
            this.grdKart.LookAndFeel.SkinName = "Black";
            this.grdKart.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdKart.MainView = this.grdKartMain;
            this.grdKart.Name = "grdKart";
            this.grdKart.Size = new System.Drawing.Size(950, 377);
            this.grdKart.TabIndex = 0;
            this.grdKart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdKartMain});
            // 
            // grdKartMain
            // 
            this.grdKartMain.GridControl = this.grdKart;
            this.grdKartMain.Name = "grdKartMain";
            this.grdKartMain.OptionsBehavior.Editable = false;
            this.grdKartMain.DoubleClick += new System.EventHandler(this.grdKartMain_DoubleClick);
            // 
            // HastaModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "HastaModul";
            this.Size = new System.Drawing.Size(950, 419);
            this.Load += new System.EventHandler(this.HastaModul_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKartMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private DevExpress.XtraGrid.GridControl grdKart;
        private DevExpress.XtraGrid.Views.Grid.GridView grdKartMain;
        private System.Windows.Forms.Button btnRapor;


    }
}
