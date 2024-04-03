namespace ThucHanh
{
    partial class SendVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendVideo));
            this.lbTime = new System.Windows.Forms.Label();
            this.flpStoreVideos = new System.Windows.Forms.FlowLayoutPanel();
            this.axwmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.flpStoreVideos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axwmpVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTime.Location = new System.Drawing.Point(533, 169);
            this.lbTime.Margin = new System.Windows.Forms.Padding(0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(53, 20);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "label1";
            // 
            // flpStoreVideos
            // 
            this.flpStoreVideos.AutoSize = true;
            this.flpStoreVideos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpStoreVideos.Controls.Add(this.axwmpVideo);
            this.flpStoreVideos.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpStoreVideos.Location = new System.Drawing.Point(432, 10);
            this.flpStoreVideos.Margin = new System.Windows.Forms.Padding(0);
            this.flpStoreVideos.Name = "flpStoreVideos";
            this.flpStoreVideos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpStoreVideos.Size = new System.Drawing.Size(163, 148);
            this.flpStoreVideos.TabIndex = 5;
            // 
            // axwmpVideo
            // 
            this.axwmpVideo.Enabled = true;
            this.axwmpVideo.Location = new System.Drawing.Point(3, 3);
            this.axwmpVideo.Name = "axwmpVideo";
            this.axwmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axwmpVideo.OcxState")));
            this.axwmpVideo.Size = new System.Drawing.Size(157, 142);
            this.axwmpVideo.TabIndex = 0;
            // 
            // pbUserImage
            // 
            this.pbUserImage.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pbUserImage.Location = new System.Drawing.Point(605, 10);
            this.pbUserImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Size = new System.Drawing.Size(40, 40);
            this.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserImage.TabIndex = 0;
            this.pbUserImage.TabStop = false;
            // 
            // SendVideo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.flpStoreVideos);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.pbUserImage);
            this.Name = "SendVideo";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(650, 195);
            this.flpStoreVideos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axwmpVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUserImage;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.FlowLayoutPanel flpStoreVideos;
        private AxWMPLib.AxWindowsMediaPlayer axwmpVideo;
    }
}
