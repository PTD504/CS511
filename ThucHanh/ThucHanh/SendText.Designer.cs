namespace ThucHanh
{
    partial class SendText
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
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.pnChText = new System.Windows.Forms.Panel();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.pnChText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbContent
            // 
            this.rtbContent.BackColor = System.Drawing.Color.Blue;
            this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtbContent.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rtbContent.Location = new System.Drawing.Point(76, 0);
            this.rtbContent.MaximumSize = new System.Drawing.Size(500, 1000);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.ReadOnly = true;
            this.rtbContent.Size = new System.Drawing.Size(500, 55);
            this.rtbContent.TabIndex = 1;
            this.rtbContent.Text = "";
            this.rtbContent.TextChanged += new System.EventHandler(this.rtbContent_TextChanged);
            // 
            // pnChText
            // 
            this.pnChText.Controls.Add(this.rtbContent);
            this.pnChText.Location = new System.Drawing.Point(19, 10);
            this.pnChText.Margin = new System.Windows.Forms.Padding(0);
            this.pnChText.Name = "pnChText";
            this.pnChText.Size = new System.Drawing.Size(576, 55);
            this.pnChText.TabIndex = 2;
            // 
            // pbUserImage
            // 
            this.pbUserImage.Image = global::ThucHanh.Properties.Resources.user_6172270;
            this.pbUserImage.Location = new System.Drawing.Point(605, 10);
            this.pbUserImage.Margin = new System.Windows.Forms.Padding(10);
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
            this.lbTime.Location = new System.Drawing.Point(541, 72);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(53, 20);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "label1";
            // 
            // SendText
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.pbUserImage);
            this.Controls.Add(this.pnChText);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(891, 1000);
            this.MinimumSize = new System.Drawing.Size(400, 80);
            this.Name = "SendText";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(650, 99);
            this.Load += new System.EventHandler(this.pnSendText_Load);
            this.pnChText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbUserImage;
        public System.Windows.Forms.RichTextBox rtbContent;
        public System.Windows.Forms.Panel pnChText;
        private System.Windows.Forms.Label lbTime;
    }
}
