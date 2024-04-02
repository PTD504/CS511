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
            this.axwmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.pbControlVideo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axwmpVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbControlVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // axwmpVideo
            // 
            this.axwmpVideo.Enabled = true;
            this.axwmpVideo.Location = new System.Drawing.Point(465, 10);
            this.axwmpVideo.Margin = new System.Windows.Forms.Padding(0);
            this.axwmpVideo.Name = "axwmpVideo";
            this.axwmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axwmpVideo.OcxState")));
            this.axwmpVideo.Size = new System.Drawing.Size(130, 130);
            this.axwmpVideo.TabIndex = 1;
            this.axwmpVideo.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axwmpVideo_PlayStateChange);
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
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTime.Location = new System.Drawing.Point(539, 149);
            this.lbTime.Margin = new System.Windows.Forms.Padding(0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(53, 20);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "label1";
            // 
            // pbControlVideo
            // 
            this.pbControlVideo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pbControlVideo.Image = global::ThucHanh.Properties.Resources.pause_11333378;
            this.pbControlVideo.Location = new System.Drawing.Point(415, 100);
            this.pbControlVideo.Margin = new System.Windows.Forms.Padding(0);
            this.pbControlVideo.Name = "pbControlVideo";
            this.pbControlVideo.Size = new System.Drawing.Size(40, 40);
            this.pbControlVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbControlVideo.TabIndex = 4;
            this.pbControlVideo.TabStop = false;
            this.pbControlVideo.Click += new System.EventHandler(this.pbControlVideo_Click_1);
            // 
            // SendVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.pbControlVideo);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.axwmpVideo);
            this.Controls.Add(this.pbUserImage);
            this.Name = "SendVideo";
            this.Size = new System.Drawing.Size(650, 185);
            ((System.ComponentModel.ISupportInitialize)(this.axwmpVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbControlVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUserImage;
        private AxWMPLib.AxWindowsMediaPlayer axwmpVideo;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox pbControlVideo;
    }
}
