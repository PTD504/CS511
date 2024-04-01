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
    public partial class UserDisplay : UserControl
    {   
        public UserDisplay()
        {
            InitializeComponent();
        }

        public void loadData(string Username, string status, string profileImage) 
        {
            this.lbUsername.Text = Username;
            this.lbUserStatus.Text = status;
            if (status == "online")
                this.pbUserStatus.Image = Image.FromFile("StatusImages\\on.png");
            else
                this.pbUserStatus.Image = Image.FromFile("StatusImages\\off.png");

            try
            {
                this.pbUserImage.Image = Image.FromFile(profileImage);
            }
            catch 
            {
                this.pbUserImage.Image = Image.FromFile("UserImages\\ava.png");
            }
        }

        private void UserDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
