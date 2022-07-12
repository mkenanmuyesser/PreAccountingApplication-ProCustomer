namespace ProCustomer.Forms
{
    partial class _23EPostaForm
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
            this.txtMesajIcerik = new System.Windows.Forms.TextBox();
            this.txtMesajKonu = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMesajIcerik
            // 
            this.txtMesajIcerik.Location = new System.Drawing.Point(100, 34);
            this.txtMesajIcerik.Multiline = true;
            this.txtMesajIcerik.Name = "txtMesajIcerik";
            this.txtMesajIcerik.Size = new System.Drawing.Size(256, 106);
            this.txtMesajIcerik.TabIndex = 1;
            // 
            // txtMesajKonu
            // 
            this.txtMesajKonu.Location = new System.Drawing.Point(100, 8);
            this.txtMesajKonu.Name = "txtMesajKonu";
            this.txtMesajKonu.Size = new System.Drawing.Size(256, 21);
            this.txtMesajKonu.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 13);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Mesaj İçeriği :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Mesaj Konusu :";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(147, 146);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 23);
            this.btnGonder.TabIndex = 2;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btniptal
            // 
            this.btniptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btniptal.Location = new System.Drawing.Point(229, 146);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(75, 23);
            this.btniptal.TabIndex = 3;
            this.btniptal.Text = "İptal Et";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // _23EPostaForm
            // 
            this.AcceptButton = this.btnGonder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(363, 175);
            this.ControlBox = false;
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtMesajIcerik);
            this.Controls.Add(this.txtMesajKonu);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "_23EPostaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPosta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMesajIcerik;
        private System.Windows.Forms.TextBox txtMesajKonu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btniptal;
    }
}