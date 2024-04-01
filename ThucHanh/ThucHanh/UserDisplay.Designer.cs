namespace ThucHanh
{
    partial class UserDisplay
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.pbUserStatus = new System.Windows.Forms.PictureBox();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.lbUserStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Britannic Bold", 15F);
            this.lbUsername.Location = new System.Drawing.Point(96, 15);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(123, 27);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "UserName";
            // 
            // pbUserStatus
            // 
            this.pbUserStatus.Image = global::ThucHanh.Properties.Resources.On;
            this.pbUserStatus.Location = new System.Drawing.Point(106, 52);
            this.pbUserStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pbUserStatus.Name = "pbUserStatus";
            this.pbUserStatus.Size = new System.Drawing.Size(35, 35);
            this.pbUserStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserStatus.TabIndex = 2;
            this.pbUserStatus.TabStop = false;
            // 
            // pbUserImage
            // 
            this.pbUserImage.Image = global::ThucHanh.Properties.Resources.user_6172270;
            this.pbUserImage.Location = new System.Drawing.Point(10, 15);
            this.pbUserImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Size = new System.Drawing.Size(70, 70);
            this.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserImage.TabIndex = 0;
            this.pbUserImage.TabStop = false;
            // 
            // lbUserStatus
            // 
            this.lbUserStatus.AutoSize = true;
            this.lbUserStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lbUserStatus.Location = new System.Drawing.Point(150, 57);
            this.lbUserStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lbUserStatus.Name = "lbUserStatus";
            this.lbUserStatus.Size = new System.Drawing.Size(69, 25);
            this.lbUserStatus.TabIndex = 3;
            this.lbUserStatus.Text = "Online";
            // 
            // UserDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.lbUserStatus);
            this.Controls.Add(this.pbUserStatus);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.pbUserImage);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserDisplay";
            this.Size = new System.Drawing.Size(367, 100);
            this.Click += new System.EventHandler(this.UserDisplay_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbUserImage;
        public System.Windows.Forms.Label lbUsername;
        public System.Windows.Forms.PictureBox pbUserStatus;
        public System.Windows.Forms.Label lbUserStatus;
    }
}
