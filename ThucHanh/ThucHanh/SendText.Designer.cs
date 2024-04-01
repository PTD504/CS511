namespace ThucHanh
{
    partial class pnSendText
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
            this.pbProfilePic = new System.Windows.Forms.PictureBox();
            this.pnChText = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.pnChText.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbContent
            // 
            this.rtbContent.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtbContent.Location = new System.Drawing.Point(76, 0);
            this.rtbContent.MaximumSize = new System.Drawing.Size(500, 1000);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.ReadOnly = true;
            this.rtbContent.Size = new System.Drawing.Size(500, 55);
            this.rtbContent.TabIndex = 1;
            this.rtbContent.Text = "";
            this.rtbContent.TextChanged += new System.EventHandler(this.rtbContent_TextChanged);
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Image = global::ThucHanh.Properties.Resources.user_6172270;
            this.pbProfilePic.Location = new System.Drawing.Point(605, 10);
            this.pbProfilePic.Margin = new System.Windows.Forms.Padding(10);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(40, 40);
            this.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePic.TabIndex = 0;
            this.pbProfilePic.TabStop = false;
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
            // pnSendText
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.pbProfilePic);
            this.Controls.Add(this.pnChText);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(891, 1000);
            this.MinimumSize = new System.Drawing.Size(400, 80);
            this.Name = "pnSendText";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(650, 80);
            this.Load += new System.EventHandler(this.pnSendText_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.pnChText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pbProfilePic;
        public System.Windows.Forms.RichTextBox rtbContent;
        public System.Windows.Forms.Panel pnChText;
    }
}
