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
    public partial class SendIcon : UserControl
    {
        public SendIcon()
        {
            InitializeComponent();
        }

        public void loadData(Image img, string Icon) 
        {
            pbUserImage.Image = img;
            pbIcon.Image = Image.FromFile(Icon);
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy h:mm:ss tt");
            lbTime.Location = new Point(pbUserImage.Location.X - 10 - lbTime.Width, lbTime.Location.Y);
        }
    }
}
