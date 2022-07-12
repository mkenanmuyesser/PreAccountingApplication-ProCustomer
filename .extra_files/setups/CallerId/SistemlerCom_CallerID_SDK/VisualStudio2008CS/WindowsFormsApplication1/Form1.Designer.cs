namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axCIDv51 = new Axcidv5callerid.AxCIDv5();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lsNumara = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.axCIDv51)).BeginInit();
            this.SuspendLayout();
            // 
            // axCIDv51
            // 
            this.axCIDv51.Location = new System.Drawing.Point(192, 122);
            this.axCIDv51.Name = "axCIDv51";
            this.axCIDv51.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCIDv51.OcxState")));
            this.axCIDv51.Size = new System.Drawing.Size(26, 26);
            this.axCIDv51.TabIndex = 0;
            this.axCIDv51.OnCallerID += new Axcidv5callerid.ICIDv5Events_OnCallerIDEventHandler(this.axCIDv51_OnCallerID);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "???";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lsNumara
            // 
            this.lsNumara.FormattingEnabled = true;
            this.lsNumara.Items.AddRange(new object[] {
            " "});
            this.lsNumara.Location = new System.Drawing.Point(12, 12);
            this.lsNumara.Name = "lsNumara";
            this.lsNumara.Size = new System.Drawing.Size(206, 95);
            this.lsNumara.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 160);
            this.Controls.Add(this.lsNumara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axCIDv51);
            this.Name = "Form1";
            this.Text = "CID Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axCIDv51)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Axcidv5callerid.AxCIDv5 axCIDv51;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lsNumara;
    }
}

