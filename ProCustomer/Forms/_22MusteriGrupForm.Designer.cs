namespace ProCustomer.Forms
{
    partial class _22MusteriGrupForm
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
            this.txtGrupTanim = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGrupSil = new System.Windows.Forms.Button();
            this.btnAltGrupEkle = new System.Windows.Forms.Button();
            this.btnAnaGrupEkle = new System.Windows.Forms.Button();
            this.treMusteri = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // txtGrupTanim
            // 
            this.txtGrupTanim.Location = new System.Drawing.Point(13, 32);
            this.txtGrupTanim.Name = "txtGrupTanim";
            this.txtGrupTanim.Size = new System.Drawing.Size(100, 21);
            this.txtGrupTanim.TabIndex = 8;
            // 
            // btnCikis
            // 
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.Location = new System.Drawing.Point(291, 390);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Tag = "";
            this.btnCikis.Text = "Kapat";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGrupSil
            // 
            this.btnGrupSil.Location = new System.Drawing.Point(290, 10);
            this.btnGrupSil.Name = "btnGrupSil";
            this.btnGrupSil.Size = new System.Drawing.Size(75, 43);
            this.btnGrupSil.TabIndex = 7;
            this.btnGrupSil.Text = "Grup Sil";
            this.btnGrupSil.UseVisualStyleBackColor = true;
            this.btnGrupSil.Click += new System.EventHandler(this.btnGrupSil_Click);
            // 
            // btnAltGrupEkle
            // 
            this.btnAltGrupEkle.Location = new System.Drawing.Point(209, 10);
            this.btnAltGrupEkle.Name = "btnAltGrupEkle";
            this.btnAltGrupEkle.Size = new System.Drawing.Size(75, 43);
            this.btnAltGrupEkle.TabIndex = 4;
            this.btnAltGrupEkle.Text = "Alt Grup Ekle";
            this.btnAltGrupEkle.UseVisualStyleBackColor = true;
            this.btnAltGrupEkle.Click += new System.EventHandler(this.btnAltGrupEkle_Click);
            // 
            // btnAnaGrupEkle
            // 
            this.btnAnaGrupEkle.Location = new System.Drawing.Point(128, 10);
            this.btnAnaGrupEkle.Name = "btnAnaGrupEkle";
            this.btnAnaGrupEkle.Size = new System.Drawing.Size(75, 43);
            this.btnAnaGrupEkle.TabIndex = 5;
            this.btnAnaGrupEkle.Text = "Ana Grup Ekle";
            this.btnAnaGrupEkle.UseVisualStyleBackColor = true;
            this.btnAnaGrupEkle.Click += new System.EventHandler(this.btnAnaGrupEkle_Click);
            // 
            // treMusteri
            // 
            this.treMusteri.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.treMusteri.FullRowSelect = true;
            this.treMusteri.HideSelection = false;
            this.treMusteri.Location = new System.Drawing.Point(13, 59);
            this.treMusteri.Name = "treMusteri";
            this.treMusteri.Size = new System.Drawing.Size(353, 325);
            this.treMusteri.TabIndex = 3;
            // 
            // _22MusteriGrupForm
            // 
            this.AcceptButton = this.btnAnaGrupEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(379, 422);
            this.ControlBox = false;
            this.Controls.Add(this.txtGrupTanim);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGrupSil);
            this.Controls.Add(this.btnAltGrupEkle);
            this.Controls.Add(this.btnAnaGrupEkle);
            this.Controls.Add(this.treMusteri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "_22MusteriGrupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Grup Ekle / Değiştir";
            this.Load += new System.EventHandler(this._22MusteriGrupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGrupTanim;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGrupSil;
        private System.Windows.Forms.Button btnAltGrupEkle;
        private System.Windows.Forms.Button btnAnaGrupEkle;
        private System.Windows.Forms.TreeView treMusteri;
    }
}