using AxWMPLib;
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
    public partial class SendVideo : UserControl
    {
        public SendVideo()
        {
            InitializeComponent();
            //axwmpVideo.uiMode = "none";
            axwmpVideo.uiMode = "mini";
        }

        public void loadData(Image image, string path)
        {
            pbUserImage.Image = image;
            //AxWMPLib.AxWindowsMediaPlayer video = new AxWMPLib.AxWindowsMediaPlayer();
            axwmpVideo.URL = path;

            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy h:mm:ss tt");
            lbTime.Location = new Point(pbUserImage.Location.X - 10 - lbTime.Width, lbTime.Location.Y);
        }

        private void axwmpVideo_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //WMPLib.WMPPlayState newState = (WMPLib.WMPPlayState)e.newState;

            //if (newState == WMPLib.WMPPlayState.wmppsMediaEnded || newState == WMPLib.WMPPlayState.wmppsPaused)
            //{
            //    pbControlVideo.Visible = true;
            //}
        }

        private void pbControlVideo_Click_1(object sender, EventArgs e)
        {
            //AxWMPLib.WMPPlayState currentState = axwmpVideo.playState;
            axwmpVideo.Ctlcontrols.play();

            if (axwmpVideo.playState == WMPLib.WMPPlayState.wmppsPaused || axwmpVideo.playState == WMPLib.WMPPlayState.wmppsUndefined)
            {
                axwmpVideo.Ctlcontrols.play();
            }
            else if (axwmpVideo.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axwmpVideo.Ctlcontrols.pause();
            }
        }
    }
}
