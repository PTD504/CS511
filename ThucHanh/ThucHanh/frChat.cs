using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh
{
    public partial class frChat : Form
    {
        public frChat()
        {
            InitializeComponent();
        }

        // Common Variables
        int userLocation_Y = 0;
        int TextMessage_Y = 0;
        int numMessage = 0;
        int current_user = 0;
        DataTable dt = new DataTable();

        private void frChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        
        private void frChat_Load(object sender, EventArgs e)
        {
            int id = Program.ID;

            dt.Clear();

            //ID*Email*Password*Username*Status*dirProfileImage
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("picStatus", typeof(string));
            dt.Columns.Add("profileImage", typeof(string));
            dt.Rows.Add("0", "", "", "", "");
            
            try
            {
                StreamReader sr = new StreamReader("UserList.txt");
                string str;

                while ((str = sr.ReadLine()) != null)
                {
                    string[] userInfo = str.Split('*');
                    string statusPic = (userInfo[4] == "online" ? "StatusImages\\on.png" : "StatusImages\\off.png");
                    dt.Rows.Add(userInfo[0], userInfo[3], userInfo[4], statusPic, userInfo[5]);

                    if (int.Parse(userInfo[0]) == id)
                    {
                        pbMainUser.Image = Image.FromFile(dt.Rows[id]["profileImage"].ToString());
                        lbMainUser.Text = userInfo[3];
                        lbMainStatus.Text = userInfo[4];
                        pbMainStatus.Image = Image.FromFile(dt.Rows[id]["picStatus"].ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Can't load your profile image!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 1; i <= Program.maxID; ++i)
            {
                if (i == id)
                    continue;
                LoadUser(i);
            }
            pnContainer.Controls.Add(CreateChat());
        }

        private Panel CreateChat()
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.AutoScroll = true;
            panel.BackColor = System.Drawing.Color.White;
            panel.ForeColor = System.Drawing.Color.Red;
            panel.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            return panel;
        }

        private void loadUserChat(object sender, EventArgs e)
        {
            UserDisplay us = (UserDisplay)sender;
            string name = us.Name;
            int ID = int.Parse(name.Substring(4));

            current_user = ID;
            pbUser.Image = us.pbUserImage.Image;
            lbUsername.Text = us.lbUsername.Text;
            lbUserStatus.Text = us.lbUserStatus.Text;
            pbUserStatus.Image = us.pbUserStatus.Image;

            us.BackColor = Color.Teal;

            foreach (Control control in pnContainer.Controls)
            {
                if (control == flpDisplayIcons)
                    continue;
                else
                    pnContainer.Controls.Remove(control);
            }
        }

        void LoadUser(int ID)
        {
            UserDisplay nus = new UserDisplay();
            nus.loadData(dt.Rows[ID]["Name"].ToString(), dt.Rows[ID]["Status"].ToString(), dt.Rows[ID]["profileImage"].ToString());
            this.pnUsers.Controls.Add(nus);
            nus.Location = new System.Drawing.Point(0, userLocation_Y);
            nus.Name = "User" + ID.ToString();
            userLocation_Y += 70;
            nus.BackColor = Color.Transparent;
            nus.Click += new EventHandler(loadUserChat);
        }

        private void pbSendText_Click(object sender, EventArgs e)
        {
            if (tbSendText.Text.Length > 0)
            {
                SendText();
            }
        }

        private void SendText()
        {
            // Display message on the screen chat
            pnSendText message = new pnSendText(tbSendText.Text);
            pnContainer.Controls[0].Controls.Add(message);
            //message.Location = new System.Drawing.Point(0, TextMessage_Y);
            message.Name = "Message" + numMessage.ToString();
            //TextMessage_Y += 80;
            (pnContainer.Controls[0] as Panel).ScrollControlIntoView(message);

            // Save message content into file
            string path = "ChatData_" + Program.ID.ToString() + "\\" + Program.ID.ToString() + "_to_" + current_user.ToString() + ".txt";
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(message.rtbContent.Text);
            sw.Close();
            tbSendText.Text = "";
        }

        private void pbSendEmo_Click(object sender, EventArgs e)
        {
            if (flpDisplayIcons.Visible == true)
            {
                flpDisplayIcons.Visible = false;
                return;
            }
            else
            {
                flpDisplayIcons.Visible = true;
                flpDisplayIcons.BringToFront();

                pbIcon1.Click += new EventHandler(IconClick);
                pbIcon2.Click += new EventHandler(IconClick);
                pbIcon3.Click += new EventHandler(IconClick);
                pbIcon4.Click += new EventHandler(IconClick);
                pbIcon5.Click += new EventHandler(IconClick);
                pbIcon6.Click += new EventHandler(IconClick);
                pbIcon7.Click += new EventHandler(IconClick);
                pbIcon8.Click += new EventHandler(IconClick);
                pbIcon9.Click += new EventHandler(IconClick);
                pbIcon10.Click += new EventHandler(IconClick);
                pbIcon11.Click += new EventHandler(IconClick);
                pbIcon12.Click += new EventHandler(IconClick);
            }
        }

        private void IconClick(object sender, EventArgs e)
        {

        }

        void sendIcon(object sender, EventArgs e)
        {

        }

        private void pbAttachFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void flpIconEmo_Paint(object sender, PaintEventArgs e)
        {
            PictureBox icon1 = new PictureBox();

            icon1.Click += new EventHandler(sendIcon);
        }

        private void tbSendText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (tbSendText.Text.Length > 0)
                {
                    e.Handled = true;
                    
                    SendText();
                }
            }
        }

        private void tbSendText_Click(object sender, EventArgs e)
        {
            if (flpDisplayIcons.Visible)
            {
                flpDisplayIcons.Visible = false;
            }
        }
    }
}
