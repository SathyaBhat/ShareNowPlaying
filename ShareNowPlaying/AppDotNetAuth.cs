using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareNowPlaying
{
    public partial class AppDotNetAuth : Form
    {
        public AppDotNetAuth()
        {
            InitializeComponent();
            string api_base = "https://alpha.app.net/oauth/authenticate?client_id=";
            string redirect_url = "http://sbhat.me/auth/";
            authbox.Visible = true;
            this.TopMost = true;
            
            Uri auth_url = new Uri(api_base + Properties.Settings.Default.clientID + "&response_type=token&redirect_url=" + redirect_url + "&scope=write_post");
            authbox.Navigate(auth_url);
        }

        private void authbox_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string redirect_url = authbox.Url.ToString();
            if (redirect_url.IndexOf("access_token") != -1)
            {
                string access_token = string.Empty;
                access_token = redirect_url.Substring(35);
                Properties.Settings.Default.apikey = access_token;
                Properties.Settings.Default.Save();
                authbox.Visible = false;
                this.Close();
            }
        }
    }
}
