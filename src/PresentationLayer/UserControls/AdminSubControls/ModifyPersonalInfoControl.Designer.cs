namespace PresentationLayer.UserControls.AdminSubControls
{
    partial class ModifyPersonalInfoControl
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
            this.PageLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainControlHolder = new System.Windows.Forms.Panel();
            this.FileDropDownLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.CloseEditorButton = new System.Windows.Forms.Button();
            this.StudentPersonalInfoButton = new System.Windows.Forms.Button();
            this.StudentAcadInfoButton = new System.Windows.Forms.Button();
            this.InstructorPersonalInfoButton = new System.Windows.Forms.Button();
            this.InstructorAcadInfoButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.InfoTable = new System.Windows.Forms.DataGridView();
            this.SRCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstructorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barangay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municipality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmergencyContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPersonAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPersonNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchUsrCodeButton = new FontAwesome.Sharp.IconButton();
            this.SearchUsrCodeTextbox = new System.Windows.Forms.TextBox();
            this.OpenModifyFormButton = new FontAwesome.Sharp.IconButton();
            this.OpenDropFormButton = new FontAwesome.Sharp.IconButton();
            this.OpenAddFormButton = new FontAwesome.Sharp.IconButton();
            this.FileDropDownButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.MainControlHolder.SuspendLayout();
            this.FileDropDownLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Font = new System.Drawing.Font("Candara Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(145)))), ((int)(((byte)(164)))));
            this.PageLabel.Location = new System.Drawing.Point(4, 5);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(220, 21);
            this.PageLabel.TabIndex = 0;
            this.PageLabel.Text = "Student Personal Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MainControlHolder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1260, 638);
            this.panel1.TabIndex = 1;
            // 
            // MainControlHolder
            // 
            this.MainControlHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.MainControlHolder.Controls.Add(this.FileDropDownLayout);
            this.MainControlHolder.Controls.Add(this.InfoTable);
            this.MainControlHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainControlHolder.Location = new System.Drawing.Point(10, 10);
            this.MainControlHolder.Name = "MainControlHolder";
            this.MainControlHolder.Padding = new System.Windows.Forms.Padding(10);
            this.MainControlHolder.Size = new System.Drawing.Size(1240, 618);
            this.MainControlHolder.TabIndex = 1;
            // 
            // FileDropDownLayout
            // 
            this.FileDropDownLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.FileDropDownLayout.Controls.Add(this.StudentPersonalInfoButton);
            this.FileDropDownLayout.Controls.Add(this.StudentAcadInfoButton);
            this.FileDropDownLayout.Controls.Add(this.InstructorPersonalInfoButton);
            this.FileDropDownLayout.Controls.Add(this.InstructorAcadInfoButton);
            this.FileDropDownLayout.Controls.Add(this.CloseEditorButton);
            this.FileDropDownLayout.Controls.Add(this.ExitButton);
            this.FileDropDownLayout.Location = new System.Drawing.Point(299, 0);
            this.FileDropDownLayout.Name = "FileDropDownLayout";
            this.FileDropDownLayout.Size = new System.Drawing.Size(262, 174);
            this.FileDropDownLayout.TabIndex = 1;
            this.FileDropDownLayout.Visible = false;
            // 
            // CloseEditorButton
            // 
            this.CloseEditorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.CloseEditorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseEditorButton.FlatAppearance.BorderSize = 0;
            this.CloseEditorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseEditorButton.ForeColor = System.Drawing.Color.White;
            this.CloseEditorButton.Location = new System.Drawing.Point(0, 112);
            this.CloseEditorButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseEditorButton.Name = "CloseEditorButton";
            this.CloseEditorButton.Padding = new System.Windows.Forms.Padding(15, 1, 15, 1);
            this.CloseEditorButton.Size = new System.Drawing.Size(259, 28);
            this.CloseEditorButton.TabIndex = 5;
            this.CloseEditorButton.Text = "Close Editor";
            this.CloseEditorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseEditorButton.UseVisualStyleBackColor = false;
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
            this.StudentPersonalInfoButton.TabIndex = 1;
            this.StudentPersonalInfoButton.Text = "Student Personal Information";
            this.StudentPersonalInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentPersonalInfoButton.UseVisualStyleBackColor = false;
            // 
            // StudentAcadInfoButton
            // 
            this.StudentAcadInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.StudentAcadInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StudentAcadInfoButton.FlatAppearance.BorderSize = 0;
            this.StudentAcadInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentAcadInfoButton.ForeColor = System.Drawing.Color.White;
            this.StudentAcadInfoButton.Location = new System.Drawing.Point(0, 28);
            this.StudentAcadInfoButton.Margin = new System.Windows.Forms.Padding(0);
            this.StudentAcadInfoButton.Name = "StudentAcadInfoButton";
            this.StudentAcadInfoButton.Padding = new System.Windows.Forms.Padding(15, 1, 15, 1);
            this.StudentAcadInfoButton.Size = new System.Drawing.Size(259, 28);
            this.StudentAcadInfoButton.TabIndex = 2;
            this.StudentAcadInfoButton.Text = "Student Academic Information";
            this.StudentAcadInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentAcadInfoButton.UseVisualStyleBackColor = false;
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
            this.InstructorPersonalInfoButton.TabIndex = 3;
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
            this.InstructorAcadInfoButton.TabIndex = 4;
            this.InstructorAcadInfoButton.Text = "Instructor Academic Information";
            this.InstructorAcadInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InstructorAcadInfoButton.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(0, 140);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Padding = new System.Windows.Forms.Padding(15, 1, 15, 1);
            this.ExitButton.Size = new System.Drawing.Size(259, 28);
            this.ExitButton.TabIndex = 6;
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
            this.SRCODE,
            this.InstructorCode,
            this.LastName,
            this.FirstName,
            this.MiddleName,
            this.BirthDate,
            this.Gender,
            this.ContactNumber,
            this.EmailAddress,
            this.HouseNumber,
            this.Barangay,
            this.Municipality,
            this.Province,
            this.EmergencyContactPerson,
            this.ContactPersonAddress,
            this.ContactPersonNumber});
            this.InfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoTable.EnableHeadersVisualStyles = false;
            this.InfoTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.InfoTable.Location = new System.Drawing.Point(10, 10);
            this.InfoTable.Name = "InfoTable";
            this.InfoTable.ReadOnly = true;
            this.InfoTable.RowHeadersVisible = false;
            this.InfoTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InfoTable.Size = new System.Drawing.Size(1220, 598);
            this.InfoTable.TabIndex = 0;
            // 
            // SRCODE
            // 
            this.SRCODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SRCODE.HeaderText = "Sr Code";
            this.SRCODE.Name = "SRCODE";
            this.SRCODE.ReadOnly = true;
            // 
            // InstructorCode
            // 
            this.InstructorCode.HeaderText = "Instructor Code";
            this.InstructorCode.Name = "InstructorCode";
            this.InstructorCode.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MiddleName.HeaderText = "Middle Name";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BirthDate.HeaderText = "Birth Date";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // ContactNumber
            // 
            this.ContactNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ContactNumber.HeaderText = "ContactNumber";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            // 
            // EmailAddress
            // 
            this.EmailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmailAddress.HeaderText = "Email Address";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            // 
            // HouseNumber
            // 
            this.HouseNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HouseNumber.HeaderText = "House Number";
            this.HouseNumber.Name = "HouseNumber";
            this.HouseNumber.ReadOnly = true;
            // 
            // Barangay
            // 
            this.Barangay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Barangay.HeaderText = "Barangay";
            this.Barangay.Name = "Barangay";
            this.Barangay.ReadOnly = true;
            // 
            // Municipality
            // 
            this.Municipality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Municipality.HeaderText = "Municipality";
            this.Municipality.Name = "Municipality";
            this.Municipality.ReadOnly = true;
            // 
            // Province
            // 
            this.Province.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Province.HeaderText = "Province";
            this.Province.Name = "Province";
            this.Province.ReadOnly = true;
            // 
            // EmergencyContactPerson
            // 
            this.EmergencyContactPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmergencyContactPerson.HeaderText = "Emergency Contact Person";
            this.EmergencyContactPerson.Name = "EmergencyContactPerson";
            this.EmergencyContactPerson.ReadOnly = true;
            // 
            // ContactPersonAddress
            // 
            this.ContactPersonAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ContactPersonAddress.HeaderText = "Contact Person Address";
            this.ContactPersonAddress.Name = "ContactPersonAddress";
            this.ContactPersonAddress.ReadOnly = true;
            // 
            // ContactPersonNumber
            // 
            this.ContactPersonNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ContactPersonNumber.HeaderText = "Contact Person Number";
            this.ContactPersonNumber.Name = "ContactPersonNumber";
            this.ContactPersonNumber.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SearchUsrCodeButton);
            this.panel2.Controls.Add(this.SearchUsrCodeTextbox);
            this.panel2.Controls.Add(this.OpenModifyFormButton);
            this.panel2.Controls.Add(this.OpenDropFormButton);
            this.panel2.Controls.Add(this.OpenAddFormButton);
            this.panel2.Controls.Add(this.FileDropDownButton);
            this.panel2.Controls.Add(this.PageLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1260, 30);
            this.panel2.TabIndex = 2;
            // 
            // SearchUsrCodeButton
            // 
            this.SearchUsrCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchUsrCodeButton.AutoSize = true;
            this.SearchUsrCodeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchUsrCodeButton.FlatAppearance.BorderSize = 0;
            this.SearchUsrCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchUsrCodeButton.Font = new System.Drawing.Font("Candara Light", 11.25F);
            this.SearchUsrCodeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.SearchUsrCodeButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.SearchUsrCodeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.SearchUsrCodeButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.SearchUsrCodeButton.IconSize = 20;
            this.SearchUsrCodeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchUsrCodeButton.Location = new System.Drawing.Point(802, 1);
            this.SearchUsrCodeButton.Margin = new System.Windows.Forms.Padding(0);
            this.SearchUsrCodeButton.Name = "SearchUsrCodeButton";
            this.SearchUsrCodeButton.Size = new System.Drawing.Size(131, 28);
            this.SearchUsrCodeButton.TabIndex = 6;
            this.SearchUsrCodeButton.Text = "Search Sr-Code";
            this.SearchUsrCodeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchUsrCodeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchUsrCodeButton.UseVisualStyleBackColor = true;
            // 
            // SearchUsrCodeTextbox
            // 
            this.SearchUsrCodeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchUsrCodeTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(73)))), ((int)(((byte)(113)))));
            this.SearchUsrCodeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchUsrCodeTextbox.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchUsrCodeTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.SearchUsrCodeTextbox.Location = new System.Drawing.Point(942, 3);
            this.SearchUsrCodeTextbox.Name = "SearchUsrCodeTextbox";
            this.SearchUsrCodeTextbox.Size = new System.Drawing.Size(307, 26);
            this.SearchUsrCodeTextbox.TabIndex = 5;
            this.SearchUsrCodeTextbox.WordWrap = false;
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
            this.OpenModifyFormButton.Location = new System.Drawing.Point(518, 0);
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
            this.OpenDropFormButton.Location = new System.Drawing.Point(442, 0);
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
            this.OpenAddFormButton.Location = new System.Drawing.Point(374, 0);
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
            this.FileDropDownButton.Location = new System.Drawing.Point(299, 1);
            this.FileDropDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.FileDropDownButton.Name = "FileDropDownButton";
            this.FileDropDownButton.Size = new System.Drawing.Size(75, 25);
            this.FileDropDownButton.TabIndex = 1;
            this.FileDropDownButton.Text = "File";
            this.FileDropDownButton.UseVisualStyleBackColor = true;
            // 
            // ModifyPersonalInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(73)))), ((int)(((byte)(113)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ModifyPersonalInfoControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1280, 688);
            this.panel1.ResumeLayout(false);
            this.MainControlHolder.ResumeLayout(false);
            this.FileDropDownLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton OpenDropFormButton;
        private FontAwesome.Sharp.IconButton OpenAddFormButton;
        private FontAwesome.Sharp.IconButton OpenModifyFormButton;
        private System.Windows.Forms.TextBox SearchUsrCodeTextbox;
        private FontAwesome.Sharp.IconButton SearchUsrCodeButton;
        private System.Windows.Forms.Panel MainControlHolder;
        private System.Windows.Forms.DataGridView InfoTable;
        private FontAwesome.Sharp.IconButton FileDropDownButton;
        private System.Windows.Forms.FlowLayoutPanel FileDropDownLayout;
        private System.Windows.Forms.Button StudentAcadInfoButton;
        private System.Windows.Forms.Button InstructorPersonalInfoButton;
        private System.Windows.Forms.Button InstructorAcadInfoButton;
        private System.Windows.Forms.Button CloseEditorButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstructorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barangay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Municipality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Province;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmergencyContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPersonAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPersonNumber;
        private System.Windows.Forms.Button StudentPersonalInfoButton;
    }
}
