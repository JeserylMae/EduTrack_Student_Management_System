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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerInfoForm));
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.EdutrackAppTitle = new System.Windows.Forms.Label();
            this.EdutrackAppIcon = new FontAwesome.Sharp.IconPictureBox();
            this.ExitAppButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sslCaLabel = new System.Windows.Forms.Label();
            this.sslKeyDialogButton = new FontAwesome.Sharp.IconButton();
            this.sslCertDialogButton = new FontAwesome.Sharp.IconButton();
            this.sslCaDialogButton = new FontAwesome.Sharp.IconButton();
            this.sslKeyLabel = new System.Windows.Forms.Label();
            this.sslCertLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sslCertHolder = new System.Windows.Forms.PictureBox();
            this.sslKeyHolder = new System.Windows.Forms.PictureBox();
            this.sslCaHolder = new System.Windows.Forms.PictureBox();
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
            this.sslCaFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.sslCertFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.sslKeyFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TopBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdutrackAppIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sslCertHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sslKeyHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sslCaHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.sslCaLabel);
            this.panel1.Controls.Add(this.sslKeyDialogButton);
            this.panel1.Controls.Add(this.sslCertDialogButton);
            this.panel1.Controls.Add(this.sslCaDialogButton);
            this.panel1.Controls.Add(this.sslKeyLabel);
            this.panel1.Controls.Add(this.sslCertLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.sslCertHolder);
            this.panel1.Controls.Add(this.sslKeyHolder);
            this.panel1.Controls.Add(this.sslCaHolder);
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
            this.panel1.Location = new System.Drawing.Point(95, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 389);
            this.panel1.TabIndex = 2;
            // 
            // sslCaLabel
            // 
            this.sslCaLabel.AutoEllipsis = true;
            this.sslCaLabel.Font = new System.Drawing.Font("Candara", 11F);
            this.sslCaLabel.ForeColor = System.Drawing.Color.Black;
            this.sslCaLabel.Location = new System.Drawing.Point(103, 203);
            this.sslCaLabel.Name = "sslCaLabel";
            this.sslCaLabel.Size = new System.Drawing.Size(282, 19);
            this.sslCaLabel.TabIndex = 23;
            // 
            // sslKeyDialogButton
            // 
            this.sslKeyDialogButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sslKeyDialogButton.ForeColor = System.Drawing.Color.White;
            this.sslKeyDialogButton.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.sslKeyDialogButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.sslKeyDialogButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sslKeyDialogButton.IconSize = 20;
            this.sslKeyDialogButton.Location = new System.Drawing.Point(391, 279);
            this.sslKeyDialogButton.Name = "sslKeyDialogButton";
            this.sslKeyDialogButton.Size = new System.Drawing.Size(25, 23);
            this.sslKeyDialogButton.TabIndex = 22;
            this.sslKeyDialogButton.UseVisualStyleBackColor = true;
            // 
            // sslCertDialogButton
            // 
            this.sslCertDialogButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sslCertDialogButton.ForeColor = System.Drawing.Color.White;
            this.sslCertDialogButton.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.sslCertDialogButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.sslCertDialogButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sslCertDialogButton.IconSize = 20;
            this.sslCertDialogButton.Location = new System.Drawing.Point(391, 240);
            this.sslCertDialogButton.Name = "sslCertDialogButton";
            this.sslCertDialogButton.Size = new System.Drawing.Size(25, 23);
            this.sslCertDialogButton.TabIndex = 21;
            this.sslCertDialogButton.UseVisualStyleBackColor = true;
            // 
            // sslCaDialogButton
            // 
            this.sslCaDialogButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sslCaDialogButton.ForeColor = System.Drawing.Color.White;
            this.sslCaDialogButton.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.sslCaDialogButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.sslCaDialogButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sslCaDialogButton.IconSize = 20;
            this.sslCaDialogButton.Location = new System.Drawing.Point(391, 201);
            this.sslCaDialogButton.Name = "sslCaDialogButton";
            this.sslCaDialogButton.Size = new System.Drawing.Size(25, 23);
            this.sslCaDialogButton.TabIndex = 20;
            this.sslCaDialogButton.UseVisualStyleBackColor = true;
            // 
            // sslKeyLabel
            // 
            this.sslKeyLabel.AutoEllipsis = true;
            this.sslKeyLabel.Font = new System.Drawing.Font("Candara", 11F);
            this.sslKeyLabel.ForeColor = System.Drawing.Color.Black;
            this.sslKeyLabel.Location = new System.Drawing.Point(157, 281);
            this.sslKeyLabel.Name = "sslKeyLabel";
            this.sslKeyLabel.Size = new System.Drawing.Size(228, 19);
            this.sslKeyLabel.TabIndex = 19;
            // 
            // sslCertLabel
            // 
            this.sslCertLabel.AutoEllipsis = true;
            this.sslCertLabel.Font = new System.Drawing.Font("Candara", 11F);
            this.sslCertLabel.ForeColor = System.Drawing.Color.Black;
            this.sslCertLabel.Location = new System.Drawing.Point(165, 242);
            this.sslCertLabel.Name = "sslCertLabel";
            this.sslCertLabel.Size = new System.Drawing.Size(220, 19);
            this.sslCertLabel.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.label7.Location = new System.Drawing.Point(30, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "SSL CLIENT KEY:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.label6.Location = new System.Drawing.Point(30, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "SSL CLIENT CERT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.label5.Location = new System.Drawing.Point(30, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "SSL CA:";
            // 
            // sslCertHolder
            // 
            this.sslCertHolder.Image = global::PresentationLayer.Properties.Resources.Rectangle_8;
            this.sslCertHolder.Location = new System.Drawing.Point(155, 238);
            this.sslCertHolder.Name = "sslCertHolder";
            this.sslCertHolder.Size = new System.Drawing.Size(264, 27);
            this.sslCertHolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sslCertHolder.TabIndex = 13;
            this.sslCertHolder.TabStop = false;
            // 
            // sslKeyHolder
            // 
            this.sslKeyHolder.Image = global::PresentationLayer.Properties.Resources.Rectangle_8;
            this.sslKeyHolder.Location = new System.Drawing.Point(147, 277);
            this.sslKeyHolder.Name = "sslKeyHolder";
            this.sslKeyHolder.Size = new System.Drawing.Size(272, 27);
            this.sslKeyHolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sslKeyHolder.TabIndex = 12;
            this.sslKeyHolder.TabStop = false;
            // 
            // sslCaHolder
            // 
            this.sslCaHolder.Image = global::PresentationLayer.Properties.Resources.Rectangle_8;
            this.sslCaHolder.Location = new System.Drawing.Point(91, 199);
            this.sslCaHolder.Name = "sslCaHolder";
            this.sslCaHolder.Size = new System.Drawing.Size(328, 27);
            this.sslCaHolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sslCaHolder.TabIndex = 11;
            this.sslCaHolder.TabStop = false;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.PasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextbox.Font = new System.Drawing.Font("Candara", 13F);
            this.PasswordTextbox.Location = new System.Drawing.Point(139, 163);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '•';
            this.PasswordTextbox.Size = new System.Drawing.Size(268, 22);
            this.PasswordTextbox.TabIndex = 10;
            // 
            // ServerTextbox
            // 
            this.ServerTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.ServerTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServerTextbox.Font = new System.Drawing.Font("Candara", 13F);
            this.ServerTextbox.Location = new System.Drawing.Point(123, 124);
            this.ServerTextbox.Name = "ServerTextbox";
            this.ServerTextbox.Size = new System.Drawing.Size(284, 22);
            this.ServerTextbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.label4.Location = new System.Drawing.Point(60, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.label3.Location = new System.Drawing.Point(60, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.label2.Location = new System.Drawing.Point(61, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "User ID:";
            // 
            // UserIdTextbox
            // 
            this.UserIdTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.UserIdTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserIdTextbox.Font = new System.Drawing.Font("Candara", 13F);
            this.UserIdTextbox.Location = new System.Drawing.Point(129, 85);
            this.UserIdTextbox.Name = "UserIdTextbox";
            this.UserIdTextbox.Size = new System.Drawing.Size(278, 22);
            this.UserIdTextbox.TabIndex = 5;
            // 
            // SubmitServerInfoButton
            // 
            this.SubmitServerInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(4)))), ((int)(((byte)(140)))));
            this.SubmitServerInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SubmitServerInfoButton.FlatAppearance.BorderSize = 0;
            this.SubmitServerInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitServerInfoButton.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.SubmitServerInfoButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmitServerInfoButton.IconColor = System.Drawing.Color.Black;
            this.SubmitServerInfoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmitServerInfoButton.Location = new System.Drawing.Point(157, 328);
            this.SubmitServerInfoButton.Name = "SubmitServerInfoButton";
            this.SubmitServerInfoButton.Size = new System.Drawing.Size(134, 29);
            this.SubmitServerInfoButton.TabIndex = 4;
            this.SubmitServerInfoButton.Text = "SUBMIT";
            this.SubmitServerInfoButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(4)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(112, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Web API Information";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(33, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(386, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(386, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.UserId;
            this.pictureBox1.Location = new System.Drawing.Point(33, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sslCaFileDialog
            // 
            this.sslCaFileDialog.FileName = "ca.pem";
            // 
            // sslCertFileDialog
            // 
            this.sslCertFileDialog.FileName = "client-cert.pem";
            // 
            // sslKeyFileDialog
            // 
            this.sslKeyFileDialog.FileName = "client-key.pem";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 409);
            this.panel2.TabIndex = 4;
            // 
            // ServerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(73)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(650, 441);
            this.Controls.Add(this.panel2);
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
            ((System.ComponentModel.ISupportInitialize)(this.sslCertHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sslKeyHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sslCaHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox sslCertHolder;
        private System.Windows.Forms.PictureBox sslKeyHolder;
        private System.Windows.Forms.PictureBox sslCaHolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton sslCaDialogButton;
        private System.Windows.Forms.Label sslKeyLabel;
        private System.Windows.Forms.Label sslCertLabel;
        private System.Windows.Forms.Label sslCaLabel;
        private FontAwesome.Sharp.IconButton sslKeyDialogButton;
        private FontAwesome.Sharp.IconButton sslCertDialogButton;
        private System.Windows.Forms.OpenFileDialog sslCaFileDialog;
        private System.Windows.Forms.OpenFileDialog sslCertFileDialog;
        private System.Windows.Forms.OpenFileDialog sslKeyFileDialog;
        private System.Windows.Forms.Panel panel2;
    }
}