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
        }

        private void authenticate_app_dot_net()
        {
            AppDotNetAuth appdotnetauthform = new AppDotNetAuth();
            appdotnetauthform.Show();

        }

        private void GetNowPlaying_Click(object sender, EventArgs e)
        {
            get_current_playing();

        }

        private void get_current_playing()
        {
            iTunesApp app = new iTunesApp();
            if (app.CurrentTrack == null)
            {
                MessageBox.Show("Looks like iTunes isn't running or no songs are currently playing..");
                return;
            }
            IITTrack track = app.CurrentTrack;
            txtCLT.Text = "CLT: ♫ \"" + track.Name + "\" by " + track.Artist + " from the album " + track.Album + " ♫ #ShareNowPlaying";
            Clipboard.SetText(txtCLT.Text);
        }

        private void picADNShare_Click(object sender, EventArgs e)
        {
   
            if (!string.IsNullOrEmpty(Properties.Settings.Default.apikey) &&  !string.IsNullOrEmpty(txtCLT.Text))
            {
                post_to_adn();
            }
        }
        private void post_to_adn()
        {
            string apikey = Properties.Settings.Default.apikey.ToString();
            string update_message;
            var request = new RestRequest("https://alpha-api.app.net/stream/0/posts", Method.POST);
            update_completed.Text = "Updating to App.net";
            if (txtCLT.TextLength > 256)
            {
                update_message = txtCLT.Text.Substring(255);
            }
            else
            {
                update_message = txtCLT.Text;
            }
                
            request.AddParameter("text", update_message);
            request.AddParameter("access_token", Properties.Settings.Default.apikey.ToString());
            bwpost.RunWorkerAsync(request);

        }

        private void Share_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.apikey))
            {
                authenticate_app_dot_net();
            }
        }

        private void txtCLT_TextChanged(object sender, EventArgs e)
        {
            charcount.Text = (256 - txtCLT.Text.Length).ToString();
        }

        private void bwpost_DoWork(object sender, DoWorkEventArgs e)
        {
            var client = new RestClient(); 
            RestRequest request = e.Argument as RestRequest;
            RestResponse response = (RestResponse)client.Execute(request);
            var content = response.Content;
            e.Result = content;
        }

        private void bwpost_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var content = e.Result;
            update_completed.Text = "Updated to App.net!";

        }
    }
}
