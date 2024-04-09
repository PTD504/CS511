using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh
{
    public partial class frLogin : Form
    {
        public frLogin()
        {
            InitializeComponent();

            // The maximum number of users
            StreamReader sr = new StreamReader("UserList.txt");
            string str;

            while ((str = sr.ReadLine()) != null) 
            {
                string[] strs = str.Split('*');
                Program.maxID = Math.Max(Program.maxID, int.Parse(strs[0]));
            }

            sr.Close();
        }

        private int ID = Program.maxID;
        private string profileImage = "";

        //private void label4_Paint(object sender, PaintEventArgs e)
        //{
        //    if (label4.BorderStyle == BorderStyle.FixedSingle)
        //    {
        //        int thickness = 2;//it's up to you
        //        int halfThickness = thickness / 2;
        //        using (Pen p = new Pen(Color.Red, thickness))
        //        {
        //            e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
        //            halfThickness,
        //            label4.ClientSize.Width - thickness,
        //            label4.ClientSize.Height - thickness));
        //        }
        //    }
        //}

        private void btLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void llbForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MailMessage mail = new MailMessage();
            mail.From = new System.Net.Mail.MailAddress(tbUsername.Text);
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(mail.From.Address, "");
            smtp.Host = "smtp.gmail.com";

            //recipient
            mail.To.Add(new MailAddress(tbUsername.Text));
            mail.IsBodyHtml = true;
            mail.Subject = "Reset Password";
            mail.Body = "Your new pass: dang2415";

            // Save new pass


            // Send mail
            smtp.Send(mail);
            MessageBox.Show("Email sent sucessfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string path = "UserList.txt";
            int id = checkUser(path);
            if (id > 0)
            {
                this.Hide();
                frChat frChat = new frChat();
                Program.ID = id;
                frChat.Show();
            }
            else
            {
                MessageBox.Show("Your email address or your password is not correct", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //this.Hide();
            //frChat frChat = new frChat();
            //frChat.Show();
        }

        private int checkUser(string path)
        {
            StreamReader sr = new StreamReader(path);
            string str;

            while ((str = sr.ReadLine()) != null)
            {
                string[] st = str.Split('*');
                if (tbUsername.Text == st[1] && tbPass.Text == st[2])
                    return int.Parse(st[0]);
            }

            sr.Close();

            return -1;
        }

        private void llbSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnSignUp.Visible = true;
            pnLogin.Visible = false;
        }

        private void pbProfilePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                profileImage = file.FileName;
                tbprofile.Text = profileImage;
                pbProfilePicture.Image = Image.FromFile(profileImage);
            }
            else
                MessageBox.Show("Your profile image hasn't not been chosen", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btSignup_Click(object sender, EventArgs e)
        {
            string Name = tbName.Text;
            string EmailAddress = tbEmail.Text;
            string Password = tbPassword.Text;
            string dirProfilePicture = profileImage;

            if (Name.Length == 0 || EmailAddress.Length == 0 || Password.Length == 0 || dirProfilePicture.Length == 0)
            {
                MessageBox.Show("Fill out all the neccessary information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int var = WriteNewUserInformation(Name, EmailAddress, Password, dirProfilePicture);

            if (var == 1)
                MessageBox.Show("Your email has registered, please move to Login form", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (var == 2)
            {
                MessageBox.Show("Successful account registration");
                this.Hide();
                frChat frChat = new frChat();
                frChat.Show();
            }
            else
                MessageBox.Show("Registration failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int WriteNewUserInformation(string Username, string EmailAddress, string Password, string dirProfilePicture)
        {
            // Check if the email address has signed up before
            StreamReader sr = new StreamReader("UserList.txt");
            string str;

            while ((str = sr.ReadLine()) != null)
            {
                string[] st = str.Split('*');
                if (st[1] == EmailAddress)
                    return 1;
            }
            sr.Close();

            // Write user information into UserInformationDetail.txt
            try
            {
                StreamWriter sw = new StreamWriter("UserList.txt", true);
                ID++;
                Random rd = new Random();
                Program.ID = ID;
                Program.maxID = ID;
                string info = ID.ToString() + "*" + EmailAddress + "*" + Password + "*" + Username + "*" + ((rd.Next(100, 1000) % 2 == 1) ? "online" : "offline") + "*" + dirProfilePicture;
                sw.WriteLine(info);
                sw.Close();
                return 2;
            }
            catch
            {
                return 3;
            }
        }

        private void llbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnLogin.Visible = true;
            pnSignUp.Visible = false;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
