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
    public partial class SaveMedia : UserControl
    {
        public SaveMedia()
        {
            InitializeComponent();
        }

        private void SaveMedia_Load(object sender, EventArgs e)
        {

        }

        public void loadData(string path)
        {
            axwmpVideo.URL = path;
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
