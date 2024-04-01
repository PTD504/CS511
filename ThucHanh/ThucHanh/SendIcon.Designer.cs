namespace ThucHanh
{
    partial class SendIcon
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
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.Purple;
            this.pbIcon.Location = new System.Drawing.Point(535, 10);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(60, 60);
            this.pbIcon.TabIndex = 1;
            this.pbIcon.TabStop = false;
            // 
            // pbUserImage
            // 
            this.pbUserImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbUserImage.Location = new System.Drawing.Point(605, 10);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Size = new System.Drawing.Size(40, 40);
            this.pbUserImage.TabIndex = 0;
            this.pbUserImage.TabStop = false;
            // 
            // SendIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.pbUserImage);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SendIcon";
            this.Size = new System.Drawing.Size(650, 80);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUserImage;
        private System.Windows.Forms.PictureBox pbIcon;
    }
}
