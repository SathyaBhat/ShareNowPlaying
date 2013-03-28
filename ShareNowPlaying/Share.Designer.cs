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
            this.charcount = new System.Windows.Forms.Label();
            this.update_completed = new System.Windows.Forms.Label();
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
            this.txtCLT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCLT.Location = new System.Drawing.Point(12, 52);
            this.txtCLT.Name = "txtCLT";
            this.txtCLT.Size = new System.Drawing.Size(552, 20);
            this.txtCLT.TabIndex = 1;
            this.txtCLT.TextChanged += new System.EventHandler(this.txtCLT_TextChanged);
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
            // charcount
            // 
            this.charcount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charcount.AutoSize = true;
            this.charcount.Location = new System.Drawing.Point(539, 80);
            this.charcount.Name = "charcount";
            this.charcount.Size = new System.Drawing.Size(25, 13);
            this.charcount.TabIndex = 5;
            this.charcount.Text = "256";
            // 
            // update_completed
            // 
            this.update_completed.AutoSize = true;
            this.update_completed.Location = new System.Drawing.Point(425, 80);
            this.update_completed.Name = "update_completed";
            this.update_completed.Size = new System.Drawing.Size(79, 13);
            this.update_completed.TabIndex = 6;
            this.update_completed.Text = "Ready to post..";
            // 
            // Share
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 100);
            this.Controls.Add(this.update_completed);
            this.Controls.Add(this.charcount);
            this.Controls.Add(this.picADNShare);
            this.Controls.Add(this.txtCLT);
            this.Controls.Add(this.btnNowPlaying);
            this.Name = "Share";
            this.Text = "Share Now Playing ♫";
            this.Load += new System.EventHandler(this.Share_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picADNShare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNowPlaying;
        private System.Windows.Forms.TextBox txtCLT;
        private System.Windows.Forms.PictureBox picADNShare;
        private System.Windows.Forms.Label charcount;
        private System.Windows.Forms.Label update_completed;
    }
}

