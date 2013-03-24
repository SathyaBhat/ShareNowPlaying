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
using System.Net;
using System.IO;
using RestSharp;

namespace ShareNowPlaying
{
    public partial class Share : Form
    {
        public Share()
        {
            InitializeComponent();
          //  Properties.Settings.Default.apikey = String.Empty;
        }

        private void GetNowPlaying_Click(object sender, EventArgs e)
        {
           
            iTunesApp app = new iTunesApp();
            if (app.CurrentTrack == null)
            {
                MessageBox.Show("Looks like iTunes isn't running or no songs are currently playing..");
                return;
            }
            IITTrack track = app.CurrentTrack;
            txtCLT.Text = "CLT: ♫ \"" + track.Name + "\" by " +  track.Artist + " from the album " + track.Album + " ♫ #ShareNowPlaying";
            Clipboard.SetText(txtCLT.Text);
        }

        private void picADNShare_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Properties.Settings.Default.apikey))
            {

                string api_base = "https://alpha.app.net/oauth/authenticate?client_id=";
                string redirect_url = "http://sbhat.me/auth/";
                browser.Visible = true;
                Uri auth_url = new Uri(api_base + Properties.Settings.Default.clientID + "&response_type=token&redirect_url=" + redirect_url + "&scope=write_post");
                browser.Navigate(auth_url);
            }
            else if (!string.IsNullOrEmpty(Properties.Settings.Default.apikey) &&  !string.IsNullOrEmpty(txtCLT.Text))
            {
                post_to_adn();
            }
        }

  

        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string redirect_url = browser.Url.ToString();
            if (redirect_url.IndexOf("access_token") != -1)
            {
            string access_token = string.Empty;  
            access_token = redirect_url.Substring(35);
            Properties.Settings.Default.apikey = access_token;
                Properties.Settings.Default.Save();
                browser.Visible = false;
            }
        }

        private void post_to_adn()
        {
            string apikey = Properties.Settings.Default.apikey.ToString();
            var client = new RestClient(); 
            var request = new RestRequest("https://alpha-api.app.net/stream/0/posts", Method.POST);
            request.AddParameter("text", txtCLT.Text);
            request.AddParameter("access_token", Properties.Settings.Default.apikey.ToString());
            RestResponse response = (RestResponse)client.Execute(request);
            var content = response.Content;

        }
    }
}
