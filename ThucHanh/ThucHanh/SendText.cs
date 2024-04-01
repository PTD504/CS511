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
    public partial class pnSendText : UserControl
    {
        public pnSendText(string message)
        {
            InitializeComponent();
            InitializeUI();

            rtbContent.Text = message;
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
            rtbContent.Location = new Point(pbProfilePic.Location.X - rtbContent.Width - 8, pbProfilePic.Location.Y + 5);

            // set BackColor for rtbContent
            rtbContent.BackColor = Color.AliceBlue;

            // resize panel
            this.Size = new Size(this.Width, Math.Max(this.Height, rtbContent.Height));
            //Size textSize = TextRenderer.MeasureText(rtbTest.Text, rtbTest.Font);
            //int height = textSize.Height, width = textSize.Width;
            //int W = rtbTest.MaximumSize.Width, H = 0;
            //lbCheck.Text = height.ToString() + ", " + width.ToString();

            //if (width > W)
            //{
            //    rtbTest.Width = W;
            //    rtbTest.Height = (height + 8) * (width / W + 1);
            //}
            //else
            //{
            //    rtbTest.Width = width;
            //    rtbTest.Height = height + 8;
            //}
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
