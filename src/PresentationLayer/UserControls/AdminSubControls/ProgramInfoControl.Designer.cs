namespace PresentationLayer.UserControls.AdminSubControls
{
    partial class ProgramInfoControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchProgramIdButton = new FontAwesome.Sharp.IconButton();
            this.SearchProgramIdTextbox = new System.Windows.Forms.TextBox();
            this.OpenModifyFormButton = new FontAwesome.Sharp.IconButton();
            this.OpenDropFormButton = new FontAwesome.Sharp.IconButton();
            this.OpenAddFormButton = new FontAwesome.Sharp.IconButton();
            this.FileDropDownButton = new FontAwesome.Sharp.IconButton();
            this.PageLabel = new System.Windows.Forms.Label();
            this.MainControlHolder = new System.Windows.Forms.Panel();
            this.FileDropDownLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.StudentPersonalInfoButton = new System.Windows.Forms.Button();
            this.StudentAcademicInfoButton = new System.Windows.Forms.Button();
            this.InstructorPersonalInfoButton = new System.Windows.Forms.Button();
            this.InstructorAcadInfoButton = new System.Windows.Forms.Button();
            this.ProgramInfoButton = new System.Windows.Forms.Button();
            this.CloseEditorButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.InfoTable = new System.Windows.Forms.DataGridView();
            this.ProgramId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.MainControlHolder.SuspendLayout();
            this.FileDropDownLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SearchProgramIdButton);
            this.panel2.Controls.Add(this.SearchProgramIdTextbox);
            this.panel2.Controls.Add(this.OpenModifyFormButton);
            this.panel2.Controls.Add(this.OpenDropFormButton);
            this.panel2.Controls.Add(this.OpenAddFormButton);
            this.panel2.Controls.Add(this.FileDropDownButton);
            this.panel2.Controls.Add(this.PageLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 30);
            this.panel2.TabIndex = 0;
            // 
            // SearchProgramIdButton
            // 
            this.SearchProgramIdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchProgramIdButton.AutoSize = true;
            this.SearchProgramIdButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchProgramIdButton.FlatAppearance.BorderSize = 0;
            this.SearchProgramIdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchProgramIdButton.Font = new System.Drawing.Font("Candara Light", 11.25F);
            this.SearchProgramIdButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.SearchProgramIdButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.SearchProgramIdButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.SearchProgramIdButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.SearchProgramIdButton.IconSize = 20;
            this.SearchProgramIdButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchProgramIdButton.Location = new System.Drawing.Point(800, 5);
            this.SearchProgramIdButton.Margin = new System.Windows.Forms.Padding(0);
            this.SearchProgramIdButton.Name = "SearchProgramIdButton";
            this.SearchProgramIdButton.Size = new System.Drawing.Size(153, 28);
            this.SearchProgramIdButton.TabIndex = 5;
            this.SearchProgramIdButton.Text = "Search Program ID";
            this.SearchProgramIdButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchProgramIdButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchProgramIdButton.UseVisualStyleBackColor = true;
            // 
            // SearchProgramIdTextbox
            // 
            this.SearchProgramIdTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchProgramIdTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(73)))), ((int)(((byte)(113)))));
            this.SearchProgramIdTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchProgramIdTextbox.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProgramIdTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.SearchProgramIdTextbox.Location = new System.Drawing.Point(962, 7);
            this.SearchProgramIdTextbox.Name = "SearchProgramIdTextbox";
            this.SearchProgramIdTextbox.Size = new System.Drawing.Size(307, 26);
            this.SearchProgramIdTextbox.TabIndex = 6;
            this.SearchProgramIdTextbox.WordWrap = false;
            // 
            // OpenModifyFormButton
            // 
            this.OpenModifyFormButton.AutoSize = true;
            this.OpenModifyFormButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenModifyFormButton.FlatAppearance.BorderSize = 0;
            this.OpenModifyFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenModifyFormButton.Font = new System.Drawing.Font("Candara Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenModifyFormButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.OpenModifyFormButton.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.OpenModifyFormButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.OpenModifyFormButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.OpenModifyFormButton.IconSize = 20;
            this.OpenModifyFormButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenModifyFormButton.Location = new System.Drawing.Point(518, 4);
            this.OpenModifyFormButton.Margin = new System.Windows.Forms.Padding(0);
            this.OpenModifyFormButton.Name = "OpenModifyFormButton";
            this.OpenModifyFormButton.Size = new System.Drawing.Size(89, 31);
            this.OpenModifyFormButton.TabIndex = 4;
            this.OpenModifyFormButton.Text = "Modify";
            this.OpenModifyFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenModifyFormButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OpenModifyFormButton.UseVisualStyleBackColor = true;
            // 
            // OpenDropFormButton
            // 
            this.OpenDropFormButton.AutoSize = true;
            this.OpenDropFormButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenDropFormButton.FlatAppearance.BorderSize = 0;
            this.OpenDropFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDropFormButton.Font = new System.Drawing.Font("Candara Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenDropFormButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.OpenDropFormButton.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.OpenDropFormButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.OpenDropFormButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.OpenDropFormButton.IconSize = 20;
            this.OpenDropFormButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenDropFormButton.Location = new System.Drawing.Point(442, 4);
            this.OpenDropFormButton.Margin = new System.Windows.Forms.Padding(0);
            this.OpenDropFormButton.Name = "OpenDropFormButton";
            this.OpenDropFormButton.Size = new System.Drawing.Size(76, 31);
            this.OpenDropFormButton.TabIndex = 3;
            this.OpenDropFormButton.Text = "Drop";
            this.OpenDropFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenDropFormButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OpenDropFormButton.UseVisualStyleBackColor = true;
            // 
            // OpenAddFormButton
            // 
            this.OpenAddFormButton.AutoSize = true;
            this.OpenAddFormButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenAddFormButton.FlatAppearance.BorderSize = 0;
            this.OpenAddFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenAddFormButton.Font = new System.Drawing.Font("Candara Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenAddFormButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.OpenAddFormButton.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.OpenAddFormButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.OpenAddFormButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.OpenAddFormButton.IconSize = 20;
            this.OpenAddFormButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenAddFormButton.Location = new System.Drawing.Point(374, 4);
            this.OpenAddFormButton.Margin = new System.Windows.Forms.Padding(0);
            this.OpenAddFormButton.Name = "OpenAddFormButton";
            this.OpenAddFormButton.Size = new System.Drawing.Size(68, 31);
            this.OpenAddFormButton.TabIndex = 2;
            this.OpenAddFormButton.Text = "Add";
            this.OpenAddFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenAddFormButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OpenAddFormButton.UseVisualStyleBackColor = true;
            // 
            // FileDropDownButton
            // 
            this.FileDropDownButton.FlatAppearance.BorderSize = 0;
            this.FileDropDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileDropDownButton.Font = new System.Drawing.Font("Candara Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileDropDownButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.FileDropDownButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.FileDropDownButton.IconColor = System.Drawing.Color.Black;
            this.FileDropDownButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FileDropDownButton.Location = new System.Drawing.Point(299, 5);
            this.FileDropDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.FileDropDownButton.Name = "FileDropDownButton";
            this.FileDropDownButton.Size = new System.Drawing.Size(75, 25);
            this.FileDropDownButton.TabIndex = 1;
            this.FileDropDownButton.Text = "File";
            this.FileDropDownButton.UseVisualStyleBackColor = true;
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Font = new System.Drawing.Font("Candara Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(145)))), ((int)(((byte)(164)))));
            this.PageLabel.Location = new System.Drawing.Point(6, 9);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(161, 21);
            this.PageLabel.TabIndex = 0;
            this.PageLabel.Text = "Program Information";
            // 
            // MainControlHolder
            // 
            this.MainControlHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.MainControlHolder.Controls.Add(this.FileDropDownLayout);
            this.MainControlHolder.Controls.Add(this.InfoTable);
            this.MainControlHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainControlHolder.Location = new System.Drawing.Point(0, 30);
            this.MainControlHolder.Name = "MainControlHolder";
            this.MainControlHolder.Padding = new System.Windows.Forms.Padding(10);
            this.MainControlHolder.Size = new System.Drawing.Size(1280, 658);
            this.MainControlHolder.TabIndex = 0;
            // 
            // FileDropDownLayout
            // 
            this.FileDropDownLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.FileDropDownLayout.Controls.Add(this.StudentPersonalInfoButton);
            this.FileDropDownLayout.Controls.Add(this.StudentAcademicInfoButton);
            this.FileDropDownLayout.Controls.Add(this.InstructorPersonalInfoButton);
            this.FileDropDownLayout.Controls.Add(this.InstructorAcadInfoButton);
            this.FileDropDownLayout.Controls.Add(this.ProgramInfoButton);
            this.FileDropDownLayout.Controls.Add(this.CloseEditorButton);
            this.FileDropDownLayout.Controls.Add(this.ExitButton);
            this.FileDropDownLayout.Location = new System.Drawing.Point(299, 0);
            this.FileDropDownLayout.Name = "FileDropDownLayout";
            this.FileDropDownLayout.Size = new System.Drawing.Size(262, 203);
            this.FileDropDownLayout.TabIndex = 1;
            this.FileDropDownLayout.Visible = false;
            // 
            // StudentPersonalInfoButton
            // 
            this.StudentPersonalInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.StudentPersonalInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StudentPersonalInfoButton.FlatAppearance.BorderSize = 0;
            this.StudentPersonalInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentPersonalInfoButton.ForeColor = System.Drawing.Color.White;
            this.StudentPersonalInfoButton.Location = new System.Drawing.Point(0, 0);
            this.StudentPersonalInfoButton.Margin = new System.Windows.Forms.Padding(0);
            this.StudentPersonalInfoButton.Name = "StudentPersonalInfoButton";
            this.StudentPersonalInfoButton.Padding = new System.Windows.Forms.Padding(15, 1, 15, 1);
            this.StudentPersonalInfoButton.Size = new System.Drawing.Size(259, 28);
            this.StudentPersonalInfoButton.TabIndex = 7;
            this.StudentPersonalInfoButton.Text = "Student Personal Information";
            this.StudentPersonalInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentPersonalInfoButton.UseVisualStyleBackColor = false;
            // 
            // StudentAcademicInfoButton
            // 
            this.StudentAcademicInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.StudentAcademicInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StudentAcademicInfoButton.FlatAppearance.BorderSize = 0;
            this.StudentAcademicInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentAcademicInfoButton.ForeColor = System.Drawing.Color.White;
            this.StudentAcademicInfoButton.Location = new System.Drawing.Point(0, 28);
            this.StudentAcademicInfoButton.Margin = new System.Windows.Forms.Padding(0);
            this.StudentAcademicInfoButton.Name = "StudentAcademicInfoButton";
            this.StudentAcademicInfoButton.Padding = new System.Windows.Forms.Padding(15, 1, 15, 1);
            this.StudentAcademicInfoButton.Size = new System.Drawing.Size(259, 28);
            this.StudentAcademicInfoButton.TabIndex = 8;
            this.StudentAcademicInfoButton.Text = "Student Academic Information";
            this.StudentAcademicInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentAcademicInfoButton.UseVisualStyleBackColor = false;
            // 
            // InstructorPersonalInfoButton
            // 
            this.InstructorPersonalInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.InstructorPersonalInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InstructorPersonalInfoButton.FlatAppearance.BorderSize = 0;
            this.InstructorPersonalInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstructorPersonalInfoButton.ForeColor = System.Drawing.Color.White;
            this.InstructorPersonalInfoButton.Location = new System.Drawing.Point(0, 56);
            this.InstructorPersonalInfoButton.Margin = new System.Windows.Forms.Padding(0);
            this.InstructorPersonalInfoButton.Name = "InstructorPersonalInfoButton";
            this.InstructorPersonalInfoButton.Padding = new System.Windows.Forms.Padding(15, 1, 15, 1);
            this.InstructorPersonalInfoButton.Size = new System.Drawing.Size(259, 28);
            this.InstructorPersonalInfoButton.TabIndex = 9;
            this.InstructorPersonalInfoButton.Text = "Instructor Personal Information";
            this.InstructorPersonalInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InstructorPersonalInfoButton.UseVisualStyleBackColor = false;
            // 
            // InstructorAcadInfoButton
            // 
            this.InstructorAcadInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.InstructorAcadInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InstructorAcadInfoButton.FlatAppearance.BorderSize = 0;
            this.InstructorAcadInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstructorAcadInfoButton.ForeColor = System.Drawing.Color.White;
            this.InstructorAcadInfoButton.Location = new System.Drawing.Point(0, 84);
            this.InstructorAcadInfoButton.Margin = new System.Windows.Forms.Padding(0);
            this.InstructorAcadInfoButton.Name = "InstructorAcadInfoButton";
            this.InstructorAcadInfoButton.Padding = new System.Windows.Forms.Padding(15, 1, 15, 1);
            this.InstructorAcadInfoButton.Size = new System.Drawing.Size(259, 28);
            this.InstructorAcadInfoButton.TabIndex = 10;
            this.InstructorAcadInfoButton.Text = "Instructor Academic Information";
            this.InstructorAcadInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InstructorAcadInfoButton.UseVisualStyleBackColor = false;
            // 
            // ProgramInfoButton
            // 
            this.ProgramInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.ProgramInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProgramInfoButton.FlatAppearance.BorderSize = 0;
            this.ProgramInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProgramInfoButton.ForeColor = System.Drawing.Color.White;
            this.ProgramInfoButton.Location = new System.Drawing.Point(0, 112);
            this.ProgramInfoButton.Margin = new System.Windows.Forms.Padding(0);
            this.ProgramInfoButton.Name = "ProgramInfoButton";
            this.ProgramInfoButton.Padding = new System.Windows.Forms.Padding(15, 1, 15, 1);
            this.ProgramInfoButton.Size = new System.Drawing.Size(259, 28);
            this.ProgramInfoButton.TabIndex = 11;
            this.ProgramInfoButton.Text = "Program Information";
            this.ProgramInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProgramInfoButton.UseVisualStyleBackColor = false;
            // 
            // CloseEditorButton
            // 
            this.CloseEditorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.CloseEditorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseEditorButton.FlatAppearance.BorderSize = 0;
            this.CloseEditorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseEditorButton.ForeColor = System.Drawing.Color.White;
            this.CloseEditorButton.Location = new System.Drawing.Point(0, 140);
            this.CloseEditorButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseEditorButton.Name = "CloseEditorButton";
            this.CloseEditorButton.Padding = new System.Windows.Forms.Padding(15, 1, 15, 1);
            this.CloseEditorButton.Size = new System.Drawing.Size(259, 28);
            this.CloseEditorButton.TabIndex = 13;
            this.CloseEditorButton.Text = "Close Editor";
            this.CloseEditorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseEditorButton.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(0, 168);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Padding = new System.Windows.Forms.Padding(15, 1, 15, 1);
            this.ExitButton.Size = new System.Drawing.Size(259, 28);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // InfoTable
            // 
            this.InfoTable.AllowUserToAddRows = false;
            this.InfoTable.AllowUserToDeleteRows = false;
            this.InfoTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.InfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProgramId,
            this.ProgramName,
            this.DepartmentId,
            this.DepartmentName});
            this.InfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoTable.EnableHeadersVisualStyles = false;
            this.InfoTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.InfoTable.Location = new System.Drawing.Point(10, 10);
            this.InfoTable.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.InfoTable.Name = "InfoTable";
            this.InfoTable.ReadOnly = true;
            this.InfoTable.RowHeadersVisible = false;
            this.InfoTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InfoTable.Size = new System.Drawing.Size(1260, 638);
            this.InfoTable.TabIndex = 0;
            // 
            // ProgramId
            // 
            this.ProgramId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProgramId.HeaderText = "Program ID";
            this.ProgramId.Name = "ProgramId";
            this.ProgramId.ReadOnly = true;
            // 
            // ProgramName
            // 
            this.ProgramName.HeaderText = "Program Name";
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.ReadOnly = true;
            // 
            // DepartmentId
            // 
            this.DepartmentId.HeaderText = "Department ID";
            this.DepartmentId.Name = "DepartmentId";
            this.DepartmentId.ReadOnly = true;
            // 
            // DepartmentName
            // 
            this.DepartmentName.HeaderText = "Department Name";
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.ReadOnly = true;
            // 
            // ProgramInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(73)))), ((int)(((byte)(113)))));
            this.Controls.Add(this.MainControlHolder);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Candara Light", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProgramInfoControl";
            this.Size = new System.Drawing.Size(1280, 688);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MainControlHolder.ResumeLayout(false);
            this.FileDropDownLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton SearchProgramIdButton;
        private System.Windows.Forms.TextBox SearchProgramIdTextbox;
        private FontAwesome.Sharp.IconButton OpenModifyFormButton;
        private FontAwesome.Sharp.IconButton OpenDropFormButton;
        private FontAwesome.Sharp.IconButton OpenAddFormButton;
        private FontAwesome.Sharp.IconButton FileDropDownButton;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Panel MainControlHolder;
        private System.Windows.Forms.FlowLayoutPanel FileDropDownLayout;
        private System.Windows.Forms.Button StudentPersonalInfoButton;
        private System.Windows.Forms.Button StudentAcademicInfoButton;
        private System.Windows.Forms.Button InstructorPersonalInfoButton;
        private System.Windows.Forms.Button InstructorAcadInfoButton;
        private System.Windows.Forms.Button CloseEditorButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView InfoTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.Button ProgramInfoButton;
    }
}
