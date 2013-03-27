namespace ShareNowPlaying
{
    partial class AppDotNetAuth
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
            this.authbox = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // authbox
            // 
            this.authbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authbox.Location = new System.Drawing.Point(0, 0);
            this.authbox.MinimumSize = new System.Drawing.Size(20, 20);
            this.authbox.Name = "authbox";
            this.authbox.ScriptErrorsSuppressed = true;
            this.authbox.Size = new System.Drawing.Size(443, 405);
            this.authbox.TabIndex = 0;
            this.authbox.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.authbox_DocumentCompleted);
            // 
            // AppDotNetAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(443, 405);
            this.Controls.Add(this.authbox);
            this.Name = "AppDotNetAuth";
            this.Text = "Authenticate App.net";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser authbox;
    }
}