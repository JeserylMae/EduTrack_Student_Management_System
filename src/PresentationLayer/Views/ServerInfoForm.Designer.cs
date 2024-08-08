namespace PresentationLayer.Views
{
    partial class ServerInfoForm
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
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.EdutrackAppTitle = new System.Windows.Forms.Label();
            this.EdutrackAppIcon = new FontAwesome.Sharp.IconPictureBox();
            this.ExitAppButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.ServerTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserIdTextbox = new System.Windows.Forms.TextBox();
            this.SubmitServerInfoButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdutrackAppIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.TopBarPanel.Controls.Add(this.EdutrackAppTitle);
            this.TopBarPanel.Controls.Add(this.EdutrackAppIcon);
            this.TopBarPanel.Controls.Add(this.ExitAppButton);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(650, 32);
            this.TopBarPanel.TabIndex = 1;
            // 
            // EdutrackAppTitle
            // 
            this.EdutrackAppTitle.AutoSize = true;
            this.EdutrackAppTitle.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdutrackAppTitle.ForeColor = System.Drawing.Color.White;
            this.EdutrackAppTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EdutrackAppTitle.Location = new System.Drawing.Point(39, 8);
            this.EdutrackAppTitle.Name = "EdutrackAppTitle";
            this.EdutrackAppTitle.Size = new System.Drawing.Size(67, 18);
            this.EdutrackAppTitle.TabIndex = 4;
            this.EdutrackAppTitle.Text = "EduTrack";
            // 
            // EdutrackAppIcon
            // 
            this.EdutrackAppIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.EdutrackAppIcon.IconChar = FontAwesome.Sharp.IconChar.Servicestack;
            this.EdutrackAppIcon.IconColor = System.Drawing.Color.White;
            this.EdutrackAppIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EdutrackAppIcon.Location = new System.Drawing.Point(3, 0);
            this.EdutrackAppIcon.Name = "EdutrackAppIcon";
            this.EdutrackAppIcon.Size = new System.Drawing.Size(34, 32);
            this.EdutrackAppIcon.TabIndex = 3;
            this.EdutrackAppIcon.TabStop = false;
            // 
            // ExitAppButton
            // 
            this.ExitAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitAppButton.FlatAppearance.BorderSize = 0;
            this.ExitAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitAppButton.ForeColor = System.Drawing.Color.Coral;
            this.ExitAppButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.ExitAppButton.IconColor = System.Drawing.Color.White;
            this.ExitAppButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitAppButton.IconSize = 17;
            this.ExitAppButton.Location = new System.Drawing.Point(604, 3);
            this.ExitAppButton.Name = "ExitAppButton";
            this.ExitAppButton.Size = new System.Drawing.Size(43, 26);
            this.ExitAppButton.TabIndex = 0;
            this.ExitAppButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.PasswordTextbox);
            this.panel1.Controls.Add(this.ServerTextbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.UserIdTextbox);
            this.panel1.Controls.Add(this.SubmitServerInfoButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(99, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 349);
            this.panel1.TabIndex = 2;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.PasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextbox.Location = new System.Drawing.Point(147, 223);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(260, 19);
            this.PasswordTextbox.TabIndex = 10;
            // 
            // ServerTextbox
            // 
            this.ServerTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.ServerTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServerTextbox.Location = new System.Drawing.Point(123, 168);
            this.ServerTextbox.Name = "ServerTextbox";
            this.ServerTextbox.Size = new System.Drawing.Size(284, 19);
            this.ServerTextbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.label4.Location = new System.Drawing.Point(60, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.label3.Location = new System.Drawing.Point(60, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.label2.Location = new System.Drawing.Point(61, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "User ID:";
            // 
            // UserIdTextbox
            // 
            this.UserIdTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.UserIdTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserIdTextbox.Location = new System.Drawing.Point(129, 113);
            this.UserIdTextbox.Name = "UserIdTextbox";
            this.UserIdTextbox.Size = new System.Drawing.Size(278, 19);
            this.UserIdTextbox.TabIndex = 5;
            // 
            // SubmitServerInfoButton
            // 
            this.SubmitServerInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(4)))), ((int)(((byte)(140)))));
            this.SubmitServerInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SubmitServerInfoButton.FlatAppearance.BorderSize = 0;
            this.SubmitServerInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitServerInfoButton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitServerInfoButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmitServerInfoButton.IconColor = System.Drawing.Color.Black;
            this.SubmitServerInfoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmitServerInfoButton.Location = new System.Drawing.Point(159, 277);
            this.SubmitServerInfoButton.Name = "SubmitServerInfoButton";
            this.SubmitServerInfoButton.Size = new System.Drawing.Size(134, 34);
            this.SubmitServerInfoButton.TabIndex = 4;
            this.SubmitServerInfoButton.Text = "SUBMIT";
            this.SubmitServerInfoButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(4)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(112, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Web API Information";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PresentationLayer.Properties.Resources.service_info_password;
            this.pictureBox3.Location = new System.Drawing.Point(33, 215);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(386, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PresentationLayer.Properties.Resources.service_info_server;
            this.pictureBox2.Location = new System.Drawing.Point(33, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(386, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.service_info_uid;
            this.pictureBox1.Location = new System.Drawing.Point(33, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ServerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(73)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(650, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopBarPanel);
            this.Font = new System.Drawing.Font("Candara", 11.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServerInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServerForm";
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdutrackAppIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Label EdutrackAppTitle;
        private FontAwesome.Sharp.IconPictureBox EdutrackAppIcon;
        private FontAwesome.Sharp.IconButton ExitAppButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserIdTextbox;
        private FontAwesome.Sharp.IconButton SubmitServerInfoButton;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox ServerTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}