namespace ProCustomer.Forms
{
    partial class RandevuListeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuListeForm));
            this.RListe = new DevExpress.XtraGrid.GridControl();
            this.RListeView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dtpRandevu = new System.Windows.Forms.DateTimePicker();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RListeView)).BeginInit();
            this.SuspendLayout();
            // 
            // RListe
            // 
            this.RListe.Location = new System.Drawing.Point(-1, 32);
            this.RListe.MainView = this.RListeView;
            this.RListe.Name = "RListe";
            this.RListe.Size = new System.Drawing.Size(751, 416);
            this.RListe.TabIndex = 0;
            this.RListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.RListeView});
            // 
            // RListeView
            // 
            this.RListeView.GridControl = this.RListe;
            this.RListeView.Name = "RListeView";
            this.RListeView.OptionsBehavior.Editable = false;
            // 
            // dtpRandevu
            // 
            this.dtpRandevu.CustomFormat = "dd.MM.yyyy";
            this.dtpRandevu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRandevu.Location = new System.Drawing.Point(12, 5);
            this.dtpRandevu.Name = "dtpRandevu";
            this.dtpRandevu.Size = new System.Drawing.Size(98, 21);
            this.dtpRandevu.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(116, 4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(45, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // RandevuListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 447);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.dtpRandevu);
            this.Controls.Add(this.RListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "RandevuListeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RandevuListeForm";
            this.Load += new System.EventHandler(this.RandevuListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RListeView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl RListe;
        private DevExpress.XtraGrid.Views.Grid.GridView RListeView;
        private System.Windows.Forms.DateTimePicker dtpRandevu;
        private System.Windows.Forms.Button btnAra;
    }
}