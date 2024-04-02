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
    public partial class SendImage : UserControl
    {
        public SendImage()
        {
            InitializeComponent();
        }

        public void loadData(string[] paths)
        {
            flpImageContainer.Controls.Clear();
            
            foreach (string path in paths)
            {   
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(path);
                pictureBox.Size = new Size(80, 80);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                flpImageContainer.Controls.Add(pictureBox);
            }
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy h:mm:ss tt");
            lbTime.Location = new Point(pbUserImage.Location.X - 10 - lbTime.Width, lbTime.Location.Y);
        }
    }
}
