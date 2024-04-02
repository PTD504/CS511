using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh
{
    public partial class SendText : UserControl
    {
        public SendText(string message)
        {
            InitializeComponent();
            InitializeUI();

            rtbContent.Text = message;
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy h:mm:ss tt");
            lbTime.Location = new Point(pbUserImage.Location.X - 10 - lbTime.Width, lbTime.Location.Y);
            SetChatboxSize();
        }

        private void InitializeUI()
        {
            rtbContent.Multiline = true;
            rtbContent.WordWrap = true;
        }

        private void SetChatboxSize()
        {
            Size textSize = TextRenderer.MeasureText(rtbContent.Text, rtbContent.Font);

            int height = textSize.Height, width = textSize.Width;
            int W = rtbContent.MaximumSize.Width;

            if (width > W)
            {
                rtbContent.Width = W;
                rtbContent.Height = (height + 1) * (width / W + 1) + 10;
            }
            else
            {
                rtbContent.Width = width;
                rtbContent.Height = height;
            }

            // reset rtbContent Location
            rtbContent.Location = new Point(pbUserImage.Location.X - rtbContent.Width - 8, pbUserImage.Location.Y + 5);

            // resize panel
            this.Size = new Size(this.Width, Math.Max(this.Height, rtbContent.Height));
        }

        private void rtbContent_TextChanged(object sender, EventArgs e)
        {
            SetChatboxSize();
        }

        private void pnSendText_Load(object sender, EventArgs e)
        {

        }
    }
}
