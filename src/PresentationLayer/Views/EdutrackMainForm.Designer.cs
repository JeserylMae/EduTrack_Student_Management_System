// using PresentationLayer.Views.AppHelper;

using PresentationLayer.Views.MainFormConfiguration;

namespace PresentationLayer
{
    partial class EdutrackMainForm
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
            this.MaximizeAppbutton = new FontAwesome.Sharp.IconButton();
            this.MinimizeAppButton = new FontAwesome.Sharp.IconButton();
            this.ExitAppButton = new FontAwesome.Sharp.IconButton();
            this.AppPagesHolderPanel = new System.Windows.Forms.Panel();
            this.TopBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdutrackAppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.TopBarPanel.Controls.Add(this.EdutrackAppTitle);
            this.TopBarPanel.Controls.Add(this.EdutrackAppIcon);
            this.TopBarPanel.Controls.Add(this.MaximizeAppbutton);
            this.TopBarPanel.Controls.Add(this.MinimizeAppButton);
            this.TopBarPanel.Controls.Add(this.ExitAppButton);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(1280, 32);
            this.TopBarPanel.TabIndex = 0;
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
            // MaximizeAppbutton
            // 
            this.MaximizeAppbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeAppbutton.FlatAppearance.BorderSize = 0;
            this.MaximizeAppbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeAppbutton.ForeColor = System.Drawing.Color.Coral;
            this.MaximizeAppbutton.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.MaximizeAppbutton.IconColor = System.Drawing.Color.White;
            this.MaximizeAppbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizeAppbutton.IconSize = 15;
            this.MaximizeAppbutton.Location = new System.Drawing.Point(1185, 3);
            this.MaximizeAppbutton.Name = "MaximizeAppbutton";
            this.MaximizeAppbutton.Size = new System.Drawing.Size(43, 26);
            this.MaximizeAppbutton.TabIndex = 2;
            this.MaximizeAppbutton.UseVisualStyleBackColor = true;
            this.MaximizeAppbutton.Click += new System.EventHandler(this.TopBarButton);
            // 
            // MinimizeAppButton
            // 
            this.MinimizeAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeAppButton.FlatAppearance.BorderSize = 0;
            this.MinimizeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeAppButton.ForeColor = System.Drawing.Color.Coral;
            this.MinimizeAppButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeAppButton.IconColor = System.Drawing.Color.White;
            this.MinimizeAppButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeAppButton.IconSize = 16;
            this.MinimizeAppButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeAppButton.Location = new System.Drawing.Point(1136, 3);
            this.MinimizeAppButton.Name = "MinimizeAppButton";
            this.MinimizeAppButton.Size = new System.Drawing.Size(43, 26);
            this.MinimizeAppButton.TabIndex = 1;
            this.MinimizeAppButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MinimizeAppButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.MinimizeAppButton.UseVisualStyleBackColor = true;
            this.MinimizeAppButton.Click += new System.EventHandler(this.TopBarButton);
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
            this.ExitAppButton.Location = new System.Drawing.Point(1234, 3);
            this.ExitAppButton.Name = "ExitAppButton";
            this.ExitAppButton.Size = new System.Drawing.Size(43, 26);
            this.ExitAppButton.TabIndex = 0;
            this.ExitAppButton.UseVisualStyleBackColor = true;
            this.ExitAppButton.Click += new System.EventHandler(this.TopBarButton);
            // 
            // AppPagesHolderPanel
            // 
            this.AppPagesHolderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppPagesHolderPanel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppPagesHolderPanel.ForeColor = System.Drawing.Color.White;
            this.AppPagesHolderPanel.Location = new System.Drawing.Point(0, 32);
            this.AppPagesHolderPanel.Name = "AppPagesHolderPanel";
            this.AppPagesHolderPanel.Size = new System.Drawing.Size(1280, 688);
            this.AppPagesHolderPanel.TabIndex = 1;
            // 
            // EdutrackMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(73)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.AppPagesHolderPanel);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EdutrackMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdutrackAppIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private FontAwesome.Sharp.IconButton ExitAppButton;
        private FontAwesome.Sharp.IconButton MaximizeAppbutton;
        private FontAwesome.Sharp.IconButton MinimizeAppButton;
        private FontAwesome.Sharp.IconPictureBox EdutrackAppIcon;
        private System.Windows.Forms.Label EdutrackAppTitle;
        private System.Windows.Forms.Panel AppPagesHolderPanel;
    }
}

