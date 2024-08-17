﻿namespace PresentationLayer.UserControls.MainControls
{
    partial class AdminModifyInfoControl
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
            this.InfoTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchSrCodeTextbox = new System.Windows.Forms.TextBox();
            this.SRCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barangay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municipality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmergencyContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPersonAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPersonNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchSrCodeButton = new FontAwesome.Sharp.IconButton();
            this.OpenModifyFormButton = new FontAwesome.Sharp.IconButton();
            this.OpenDropFormButton = new FontAwesome.Sharp.IconButton();
            this.OpenAddFormButton = new FontAwesome.Sharp.IconButton();
            this.FileDropDownButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.MainControlHolder.SuspendLayout();
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
            this.MainControlHolder.Controls.Add(this.InfoTable);
            this.MainControlHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainControlHolder.Location = new System.Drawing.Point(10, 10);
            this.MainControlHolder.Name = "MainControlHolder";
            this.MainControlHolder.Padding = new System.Windows.Forms.Padding(10);
            this.MainControlHolder.Size = new System.Drawing.Size(1240, 618);
            this.MainControlHolder.TabIndex = 1;
            // 
            // InfoTable
            // 
            this.InfoTable.AllowUserToAddRows = false;
            this.InfoTable.AllowUserToDeleteRows = false;
            this.InfoTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.InfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SRCODE,
            this.LastName,
            this.FirstName,
            this.MiddleName,
            this.BirthDate,
            this.Gender,
            this.ContactNumber,
            this.ZipCode,
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
            // panel2
            // 
            this.panel2.Controls.Add(this.SearchSrCodeButton);
            this.panel2.Controls.Add(this.SearchSrCodeTextbox);
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
            // SearchSrCodeTextbox
            // 
            this.SearchSrCodeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchSrCodeTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(73)))), ((int)(((byte)(113)))));
            this.SearchSrCodeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchSrCodeTextbox.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSrCodeTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.SearchSrCodeTextbox.Location = new System.Drawing.Point(942, 3);
            this.SearchSrCodeTextbox.Name = "SearchSrCodeTextbox";
            this.SearchSrCodeTextbox.Size = new System.Drawing.Size(307, 26);
            this.SearchSrCodeTextbox.TabIndex = 5;
            this.SearchSrCodeTextbox.WordWrap = false;
            // 
            // SRCODE
            // 
            this.SRCODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SRCODE.HeaderText = "Sr Code";
            this.SRCODE.Name = "SRCODE";
            this.SRCODE.ReadOnly = true;
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
            // ZipCode
            // 
            this.ZipCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ZipCode.HeaderText = "Zip Code";
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.ReadOnly = true;
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
            // SearchSrCodeButton
            // 
            this.SearchSrCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchSrCodeButton.AutoSize = true;
            this.SearchSrCodeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchSrCodeButton.FlatAppearance.BorderSize = 0;
            this.SearchSrCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchSrCodeButton.Font = new System.Drawing.Font("Candara Light", 11.25F);
            this.SearchSrCodeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.SearchSrCodeButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.SearchSrCodeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.SearchSrCodeButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.SearchSrCodeButton.IconSize = 20;
            this.SearchSrCodeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchSrCodeButton.Location = new System.Drawing.Point(853, 1);
            this.SearchSrCodeButton.Margin = new System.Windows.Forms.Padding(0);
            this.SearchSrCodeButton.Name = "SearchSrCodeButton";
            this.SearchSrCodeButton.Size = new System.Drawing.Size(80, 28);
            this.SearchSrCodeButton.TabIndex = 6;
            this.SearchSrCodeButton.Text = "Search";
            this.SearchSrCodeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchSrCodeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchSrCodeButton.UseVisualStyleBackColor = true;
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
            this.FileDropDownButton.Location = new System.Drawing.Point(299, 3);
            this.FileDropDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.FileDropDownButton.Name = "FileDropDownButton";
            this.FileDropDownButton.Size = new System.Drawing.Size(75, 25);
            this.FileDropDownButton.TabIndex = 1;
            this.FileDropDownButton.Text = "File";
            this.FileDropDownButton.UseVisualStyleBackColor = true;
            // 
            // AdminModifyInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(73)))), ((int)(((byte)(113)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AdminModifyInfoControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1280, 688);
            this.panel1.ResumeLayout(false);
            this.MainControlHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton FileDropDownButton;
        private FontAwesome.Sharp.IconButton OpenDropFormButton;
        private FontAwesome.Sharp.IconButton OpenAddFormButton;
        private FontAwesome.Sharp.IconButton OpenModifyFormButton;
        private System.Windows.Forms.TextBox SearchSrCodeTextbox;
        private FontAwesome.Sharp.IconButton SearchSrCodeButton;
        private System.Windows.Forms.Panel MainControlHolder;
        private System.Windows.Forms.DataGridView InfoTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barangay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Municipality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Province;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmergencyContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPersonAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPersonNumber;
    }
}