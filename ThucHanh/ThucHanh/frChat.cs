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

        // Load User Location
        int userLocation_Y = 0;
        // ID of the people who you chat with
        int current_user = 0;
        // Number of messages
        int numMessage = 0;
        // DataTable
        DataTable dt = new DataTable();

        // Exit application
        private void frChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        // Form Load
        private void frChat_Load(object sender, EventArgs e)
        {
            // ID of main user
            int id = Program.ID;

            // Information of main user
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
                // Load another user
                StreamReader sr = new StreamReader("UserList.txt");
                string str;

                while ((str = sr.ReadLine()) != null)
                {
                    string[] userInfo = str.Split('*');
                    string statusPic = (userInfo[4] == "online" ? "StatusImages\\on.png" : "StatusImages\\off.png");
                    dt.Rows.Add(userInfo[0], userInfo[3], userInfo[4], statusPic, userInfo[5]);

                    // Load information of main user
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

            // Load others information
            for (int i = 1; i <= Program.maxID; ++i)
            {
                if (i == id)
                    continue;
                LoadUser(i);
            }
        }

        // Load current user who you chat with
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

            pnContainer.Controls.Clear();
            pnContainer.Controls.Add(flpDisplayIcons);
            pnContainer.Controls.Add(pnStoreData);

            // Highlight user
            foreach (Control control in pnUsers.Controls)
            {
                control.BackColor = Color.Aqua;

                if (control == sender)
                {
                    control.BackColor = Color.Teal;
                }
            }

            loadImage_Video();
        }

        private void loadImage_Video()
        {
            flpImages.Controls.Clear();
            flpVideos.Controls.Clear();

            string path = "ChatData_" + Program.ID.ToString() + "\\" + Program.ID.ToString() + "_to_" + current_user.ToString() + ".txt";

            StreamReader sr = new StreamReader(path);
            string str;

            while ((str = sr.ReadLine()) != null)
            {
                string[] strs = str.Split('*');

                if (strs[0] == "3")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = Image.FromFile(strs[1]);
                    pictureBox.Size = new Size(128, 128);
                    flpImages.Controls.Add(pictureBox);
                }
                else if (strs[0] == "4")
                {
                    AxWMPLib.AxWindowsMediaPlayer video = new AxWMPLib.AxWindowsMediaPlayer();
                    video.URL = strs[1];
                    video.uiMode = "mini";
                    video.Size = new Size(128, 128);
                    flpVideos.Controls.Add(video);
                }
            }
        }

        // Display users
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

        // Send text message
        private void pbSendText_Click(object sender, EventArgs e)
        {
            if (tbSendText.Text.Length > 0)
            {
                SendText();
            }
        }

        // Display your text message on the chat screen
        private void SendText()
        {
            // Display message on the screen chat
            SendText message = new SendText(tbSendText.Text);
            //pnContainer.Controls.Add(message);
            //message.Name = "Message" + numMessage.ToString();
            add_message(message);

            // Save message content into file
            string path = "ChatData_" + Program.ID.ToString() + "\\" + Program.ID.ToString() + "_to_" + current_user.ToString() + ".txt";
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("1*" + message.rtbContent.Text);
            sw.Close();
            tbSendText.Clear();
        }

        // Display emoji table
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
            PictureBox icon = (PictureBox)sender;

            // Create icon message
            SendIcon sendIcon = new SendIcon();
            sendIcon.loadData(pbMainUser.Image, icon.Tag.ToString());

            // Display icon message on chat screen
            add_message(sendIcon);

            // Save the icon into file
            string path = "ChatData_" + Program.ID.ToString() + "\\" + Program.ID.ToString() + "_to_" + current_user.ToString() + ".txt";
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("2*" + icon.Tag.ToString());
            sw.Close();
        }

        // Attach image file, video file
        private void pbAttachFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            //ofd.Filter = "";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] files = ofd.FileNames;

                foreach (string file in files)
                {
                    char c = file[file.Length - 1];

                    if (char.IsDigit(c))
                    {
                        sendVideo(file);
                    }
                    else
                    {
                        sendImage(files);
                        break;
                    }
                }
            }
            else
                MessageBox.Show("Can't open file", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void sendImage(string[] path)
        {
            SendImage sendImage = new SendImage();
            sendImage.loadData(path);
            foreach (string file in path)
            {
                // Save message content into file
                string file_path = "ChatData_" + Program.ID.ToString() + "\\" + Program.ID.ToString() + "_to_" + current_user.ToString() + ".txt";
                StreamWriter sw = new StreamWriter(file_path);
                sw.WriteLine("3*" + file);
                sw.Close();

                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(file_path);
                flpImages.Controls.Add( pictureBox );
            }

            add_message(sendImage);
        }

        private void add_message(Control control)
        {
            pnContainer.Controls.Add(control);
            pnContainer.Controls.SetChildIndex(control, 0);
            control.Dock = DockStyle.Top;
            pnContainer.ScrollControlIntoView(control);
        }

        private void sendVideo(string path)
        {
            SendVideo sendVideo = new SendVideo();
            sendVideo.loadData(pbMainUser.Image, path);
            // Save message content into file
            string file_path = "ChatData_" + Program.ID.ToString() + "\\" + Program.ID.ToString() + "_to_" + current_user.ToString() + ".txt";
            StreamWriter sw = new StreamWriter(file_path);
            sw.WriteLine("4*" + path);
            sw.Close();

            AxWMPLib.AxWindowsMediaPlayer video = new AxWMPLib.AxWindowsMediaPlayer();
            video.URL = path;
            video.uiMode = "mini";
            flpVideos.Controls.Add(video);

            add_message(sendVideo);
        }

        // Send text message using Enter key
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

        // Hide emoji table if necessary
        private void tbSendText_Click(object sender, EventArgs e)
        {
            if (flpDisplayIcons.Visible)
            {
                flpDisplayIcons.Visible = false;
            }
        }

        private void pbOpenImVd_Click(object sender, EventArgs e)
        {
            if (pnStoreData.Visible)
            {
                pnStoreData.Visible = false;
                return;
            }

            pnStoreData.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
