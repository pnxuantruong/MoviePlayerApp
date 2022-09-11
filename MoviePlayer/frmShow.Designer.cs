
namespace MoviePlayer
{
    partial class frmShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShow));
            this.WMP_Show = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.WMP_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP_Show
            // 
            this.WMP_Show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WMP_Show.Enabled = true;
            this.WMP_Show.Location = new System.Drawing.Point(0, 0);
            this.WMP_Show.Name = "WMP_Show";
            this.WMP_Show.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP_Show.OcxState")));
            this.WMP_Show.Size = new System.Drawing.Size(800, 450);
            this.WMP_Show.TabIndex = 0;
            // 
            // frmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WMP_Show);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShow";
            this.Text = "frmShow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmShow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmShow_FormClosed);
            this.Load += new System.EventHandler(this.frmShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMP_Show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP_Show;
    }
}