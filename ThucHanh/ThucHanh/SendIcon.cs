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

        public void loadData(string UserImage, string Icon) 
        {
            pbUserImage.Image = Image.FromFile(UserImage);
            pbIcon.Image = Image.FromFile(Icon);
        }
    }
}
