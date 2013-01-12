using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using iTunesLib;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareNowPlaying
{
    public partial class Share : Form
    {
        public Share()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            iTunesApp app = new iTunesApp();
            IITTrack track = app.CurrentTrack;
           txtCLT.Text = "\"" + track.Name + "\" by " +  track.Artist;

        } 
    }
}
