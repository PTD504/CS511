namespace ThucHanh
{
    partial class SaveMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveMedia));
            this.axwmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axwmpVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // axwmpVideo
            // 
            this.axwmpVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.axwmpVideo.Enabled = true;
            this.axwmpVideo.Location = new System.Drawing.Point(0, 0);
            this.axwmpVideo.Name = "axwmpVideo";
            this.axwmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axwmpVideo.OcxState")));
            this.axwmpVideo.Size = new System.Drawing.Size(196, 144);
            this.axwmpVideo.TabIndex = 1;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTime.Location = new System.Drawing.Point(67, 158);
            this.lbTime.Name = "lbTime";
            this.lbTime.Padding = new System.Windows.Forms.Padding(3);
            this.lbTime.Size = new System.Drawing.Size(59, 26);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "label1";
            // 
            // SaveMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.axwmpVideo);
            this.Name = "SaveMedia";
            this.Size = new System.Drawing.Size(196, 189);
            this.Load += new System.EventHandler(this.SaveMedia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axwmpVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axwmpVideo;
        private System.Windows.Forms.Label lbTime;
    }
}
