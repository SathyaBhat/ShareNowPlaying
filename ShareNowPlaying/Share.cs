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
            txtCLT.Text = "♫ \"" + track.Name + "\" by " +  track.Artist + " ♫";
            Clipboard.SetText(txtCLT.Text);
            getlyrics();
        }

        public void getlyrics()
        {
            string baseURL = "http://www.lyrdb.com/lookup.php?q=query&for=";
            string agent = "ShareNowPlaying";
            string requestURL;
            string field;

         /*   field = "trackname=" + track.Name + "&

            requestURL = baseURL + "agent

            */
        }

        private void picADNShare_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Properties.Settings.Default.apikey))
            {
                string api_base = "https://alpha.app.net/oauth/authenticate?client_id=";
                string redirect_url = "http://sbhat.me/auth/";
                browser.Visible = true;
                Uri auth_url = new Uri(api_base + Properties.Settings.Default.clientID + "&response_type=token&redirect_url=" + redirect_url);
                browser.Navigate(auth_url);
                
            }
            browser.Visible = false;
            post_to_adn();
        }

  

        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string redirect_url = browser.Url.ToString();
            string access_token = Properties.Settings.Default.apikey;
            if (String.IsNullOrEmpty(access_token) && redirect_url.IndexOf("access_token") != 0)
            {
                Properties.Settings.Default.apikey = redirect_url.Substring(35);
                Properties.Settings.Default.Save();
            }
        }

        private void post_to_adn()
        {
            
        }
    }
}
