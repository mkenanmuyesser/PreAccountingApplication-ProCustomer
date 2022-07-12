namespace ProCustomer.Forms
{
    partial class _25EsDurum
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
            this.label1 = new System.Windows.Forms.Label();
            this.grdEsMain = new DevExpress.XtraGrid.GridControl();
            this.grdEs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAylik = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdEsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Türü :";
            // 
            // grdEsMain
            // 
            this.grdEsMain.Location = new System.Drawing.Point(9, 49);
            this.grdEsMain.MainView = this.grdEs;
            this.grdEsMain.Name = "grdEsMain";
            this.grdEsMain.Size = new System.Drawing.Size(522, 330);
            this.grdEsMain.TabIndex = 26;
            this.grdEsMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdEs});
            // 
            // grdEs
            // 
            this.grdEs.GridControl = this.grdEsMain;
            this.grdEs.Name = "grdEs";
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(51, 11);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(131, 21);
            this.cmbTur.TabIndex = 28;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(398, 9);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(37, 23);
            this.btnAra.TabIndex = 29;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Location = new System.Drawing.Point(456, 9);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 30;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Aylık :";
            // 
            // txtAylik
            // 
            this.txtAylik.Location = new System.Drawing.Point(246, 11);
            this.txtAylik.Name = "txtAylik";
            this.txtAylik.Size = new System.Drawing.Size(76, 21);
            this.txtAylik.TabIndex = 31;
            // 
            // _25EsDurum
            // 
            this.AcceptButton = this.btnAra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(540, 388);
            this.ControlBox = false;
            this.Controls.Add(this.txtAylik);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdEsMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "_25EsDurum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Es Listesi";
            this.Load += new System.EventHandler(this._25EsDurum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl grdEsMain;
        private DevExpress.XtraGrid.Views.Grid.GridView grdEs;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAylik;
    }
}