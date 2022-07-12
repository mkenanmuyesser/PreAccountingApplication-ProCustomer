namespace ProCustomer.Forms
{
    partial class _24SmsForm
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMesajIcerik = new System.Windows.Forms.TextBox();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(93, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 13);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Sms Mesaj İçeriği :";
            // 
            // txtMesajIcerik
            // 
            this.txtMesajIcerik.Location = new System.Drawing.Point(13, 32);
            this.txtMesajIcerik.Multiline = true;
            this.txtMesajIcerik.Name = "txtMesajIcerik";
            this.txtMesajIcerik.Size = new System.Drawing.Size(256, 131);
            this.txtMesajIcerik.TabIndex = 26;
            // 
            // btniptal
            // 
            this.btniptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btniptal.Location = new System.Drawing.Point(146, 169);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(75, 23);
            this.btniptal.TabIndex = 31;
            this.btniptal.Text = "İptal Et";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(64, 169);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 23);
            this.btnGonder.TabIndex = 30;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // _24SmsForm
            // 
            this.AcceptButton = this.btnGonder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(279, 197);
            this.ControlBox = false;
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtMesajIcerik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "_24SmsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtMesajIcerik;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnGonder;
    }
}