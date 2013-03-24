namespace ShareNowPlaying
{
    partial class Share
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Share));
            this.btnNowPlaying = new System.Windows.Forms.Button();
            this.txtCLT = new System.Windows.Forms.TextBox();
            this.picADNShare = new System.Windows.Forms.PictureBox();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.picADNShare)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNowPlaying
            // 
            this.btnNowPlaying.Location = new System.Drawing.Point(12, 9);
            this.btnNowPlaying.Name = "btnNowPlaying";
            this.btnNowPlaying.Size = new System.Drawing.Size(108, 29);
            this.btnNowPlaying.TabIndex = 0;
            this.btnNowPlaying.Text = "What\'s playing? ♫";
            this.btnNowPlaying.UseVisualStyleBackColor = true;
            this.btnNowPlaying.Click += new System.EventHandler(this.GetNowPlaying_Click);
            // 
            // txtCLT
            // 
            this.txtCLT.Location = new System.Drawing.Point(12, 52);
            this.txtCLT.Name = "txtCLT";
            this.txtCLT.Size = new System.Drawing.Size(549, 20);
            this.txtCLT.TabIndex = 1;
            // 
            // picADNShare
            // 
            this.picADNShare.Image = ((System.Drawing.Image)(resources.GetObject("picADNShare.Image")));
            this.picADNShare.InitialImage = null;
            this.picADNShare.Location = new System.Drawing.Point(143, 9);
            this.picADNShare.Name = "picADNShare";
            this.picADNShare.Size = new System.Drawing.Size(33, 29);
            this.picADNShare.TabIndex = 2;
            this.picADNShare.TabStop = false;
            this.picADNShare.Click += new System.EventHandler(this.picADNShare_Click);
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(0, 96);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(580, 341);
            this.browser.TabIndex = 3;
            this.browser.Visible = false;
            this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_DocumentCompleted);
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(580, 96);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // Share
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 437);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.picADNShare);
            this.Controls.Add(this.txtCLT);
            this.Controls.Add(this.btnNowPlaying);
            this.Controls.Add(this.splitter1);
            this.Name = "Share";
            this.Text = "Share Now Playing ♫";
            ((System.ComponentModel.ISupportInitialize)(this.picADNShare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNowPlaying;
        private System.Windows.Forms.TextBox txtCLT;
        private System.Windows.Forms.PictureBox picADNShare;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Splitter splitter1;
    }
}

