namespace PresentationLayer.UserControls.HomeSubControls
{
    partial class StudItrHomeBottomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentInfoButton = new FontAwesome.Sharp.IconButton();
            this.GradeButton = new FontAwesome.Sharp.IconButton();
            this.AttendanceButton = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // StudentInfoButton
            // 
            this.StudentInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.StudentInfoButton.FlatAppearance.BorderSize = 0;
            this.StudentInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentInfoButton.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentInfoButton.ForeColor = System.Drawing.Color.Black;
            this.StudentInfoButton.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.StudentInfoButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.StudentInfoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StudentInfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentInfoButton.Location = new System.Drawing.Point(17, 6);
            this.StudentInfoButton.Name = "StudentInfoButton";
            this.StudentInfoButton.Size = new System.Drawing.Size(95, 39);
            this.StudentInfoButton.TabIndex = 0;
            this.StudentInfoButton.Text = "STUDENT";
            this.StudentInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StudentInfoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StudentInfoButton.UseVisualStyleBackColor = false;
            // 
            // GradeButton
            // 
            this.GradeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GradeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.GradeButton.FlatAppearance.BorderSize = 0;
            this.GradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GradeButton.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeButton.ForeColor = System.Drawing.Color.Black;
            this.GradeButton.IconChar = FontAwesome.Sharp.IconChar.RankingStar;
            this.GradeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.GradeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GradeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GradeButton.Location = new System.Drawing.Point(249, 6);
            this.GradeButton.Name = "GradeButton";
            this.GradeButton.Size = new System.Drawing.Size(85, 39);
            this.GradeButton.TabIndex = 1;
            this.GradeButton.Text = "GRADE";
            this.GradeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GradeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GradeButton.UseVisualStyleBackColor = false;
            // 
            // AttendanceButton
            // 
            this.AttendanceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.AttendanceButton.FlatAppearance.BorderSize = 0;
            this.AttendanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttendanceButton.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceButton.ForeColor = System.Drawing.Color.Black;
            this.AttendanceButton.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.AttendanceButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.AttendanceButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AttendanceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AttendanceButton.Location = new System.Drawing.Point(122, 6);
            this.AttendanceButton.Name = "AttendanceButton";
            this.AttendanceButton.Size = new System.Drawing.Size(117, 39);
            this.AttendanceButton.TabIndex = 2;
            this.AttendanceButton.Text = "ATTENDANCE";
            this.AttendanceButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AttendanceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AttendanceButton.UseVisualStyleBackColor = false;
            // 
            // StudItrHomeBottomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.AttendanceButton);
            this.Controls.Add(this.GradeButton);
            this.Controls.Add(this.StudentInfoButton);
            this.Name = "StudItrHomeBottomControl";
            this.Size = new System.Drawing.Size(414, 61);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton StudentInfoButton;
        private FontAwesome.Sharp.IconButton GradeButton;
        private FontAwesome.Sharp.IconButton AttendanceButton;
    }
}
