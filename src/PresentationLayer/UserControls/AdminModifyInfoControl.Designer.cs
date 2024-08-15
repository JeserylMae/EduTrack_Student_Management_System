namespace PresentationLayer.UserControls
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.InfoTable = new System.Windows.Forms.DataGridView();
            this.SrCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarangayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MunicipalityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvinceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmerNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmerAddressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmerContNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(145)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Personal Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1260, 638);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButton5);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.iconButton4);
            this.panel2.Controls.Add(this.iconButton3);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1260, 30);
            this.panel2.TabIndex = 2;
            // 
            // iconButton5
            // 
            this.iconButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton5.AutoSize = true;
            this.iconButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Candara Light", 11.25F);
            this.iconButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton5.IconSize = 20;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(853, 1);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(80, 28);
            this.iconButton5.TabIndex = 6;
            this.iconButton5.Text = "Search";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(73)))), ((int)(((byte)(113)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.textBox1.Location = new System.Drawing.Point(942, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.WordWrap = false;
            // 
            // iconButton4
            // 
            this.iconButton4.AutoSize = true;
            this.iconButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Candara Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconButton4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton4.IconSize = 20;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(518, 0);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(89, 31);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.Text = "Modify";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.AutoSize = true;
            this.iconButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Candara Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton3.IconSize = 20;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(442, 0);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(76, 31);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.Text = "Drop";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.AutoSize = true;
            this.iconButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Candara Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 20;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(374, 0);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(68, 31);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "Add";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Candara Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(299, 3);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 25);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "File";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.panel3.Controls.Add(this.InfoTable);
            this.panel3.Location = new System.Drawing.Point(13, 13);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(1234, 612);
            this.panel3.TabIndex = 1;
            // 
            // InfoTable
            // 
            this.InfoTable.AllowUserToAddRows = false;
            this.InfoTable.AllowUserToDeleteRows = false;
            this.InfoTable.AllowUserToResizeColumns = false;
            this.InfoTable.AllowUserToResizeRows = false;
            this.InfoTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.InfoTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.InfoTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InfoTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InfoTable.ColumnHeadersHeight = 38;
            this.InfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrCodeCol,
            this.LastNameCol,
            this.FirstNameCol,
            this.MiddleNameCol,
            this.BirthDateCol,
            this.GenderCol,
            this.ContactNumberCol,
            this.ZipCodeCol,
            this.BarangayCol,
            this.MunicipalityCol,
            this.ProvinceCol,
            this.EmerNameCol,
            this.EmerAddressCol,
            this.EmerContNumCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(4)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InfoTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.InfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.InfoTable.EnableHeadersVisualStyles = false;
            this.InfoTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.InfoTable.Location = new System.Drawing.Point(10, 10);
            this.InfoTable.Margin = new System.Windows.Forms.Padding(10);
            this.InfoTable.MultiSelect = false;
            this.InfoTable.Name = "InfoTable";
            this.InfoTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.InfoTable.RowHeadersVisible = false;
            this.InfoTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(4)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InfoTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.InfoTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InfoTable.Size = new System.Drawing.Size(1214, 592);
            this.InfoTable.TabIndex = 1;
            // 
            // SrCodeCol
            // 
            this.SrCodeCol.DividerWidth = 8;
            this.SrCodeCol.Frozen = true;
            this.SrCodeCol.HeaderText = "SR CODE";
            this.SrCodeCol.MinimumWidth = 20;
            this.SrCodeCol.Name = "SrCodeCol";
            this.SrCodeCol.ReadOnly = true;
            // 
            // LastNameCol
            // 
            this.LastNameCol.DividerWidth = 8;
            this.LastNameCol.FillWeight = 180F;
            this.LastNameCol.Frozen = true;
            this.LastNameCol.HeaderText = "LAST NAME";
            this.LastNameCol.MinimumWidth = 100;
            this.LastNameCol.Name = "LastNameCol";
            this.LastNameCol.ReadOnly = true;
            this.LastNameCol.Width = 180;
            // 
            // FirstNameCol
            // 
            this.FirstNameCol.DividerWidth = 8;
            this.FirstNameCol.FillWeight = 180F;
            this.FirstNameCol.Frozen = true;
            this.FirstNameCol.HeaderText = "FIRST NAME";
            this.FirstNameCol.MinimumWidth = 100;
            this.FirstNameCol.Name = "FirstNameCol";
            this.FirstNameCol.ReadOnly = true;
            this.FirstNameCol.Width = 180;
            // 
            // MiddleNameCol
            // 
            this.MiddleNameCol.DividerWidth = 8;
            this.MiddleNameCol.FillWeight = 180F;
            this.MiddleNameCol.Frozen = true;
            this.MiddleNameCol.HeaderText = "MIDDLE NAME";
            this.MiddleNameCol.MinimumWidth = 100;
            this.MiddleNameCol.Name = "MiddleNameCol";
            this.MiddleNameCol.Width = 180;
            // 
            // BirthDateCol
            // 
            this.BirthDateCol.DividerWidth = 8;
            this.BirthDateCol.FillWeight = 150F;
            this.BirthDateCol.Frozen = true;
            this.BirthDateCol.HeaderText = "BIRTH DATE";
            this.BirthDateCol.MinimumWidth = 100;
            this.BirthDateCol.Name = "BirthDateCol";
            this.BirthDateCol.ReadOnly = true;
            this.BirthDateCol.Width = 150;
            // 
            // GenderCol
            // 
            this.GenderCol.DividerWidth = 8;
            this.GenderCol.Frozen = true;
            this.GenderCol.HeaderText = "GENDER";
            this.GenderCol.MinimumWidth = 80;
            this.GenderCol.Name = "GenderCol";
            // 
            // ContactNumberCol
            // 
            this.ContactNumberCol.DividerWidth = 8;
            this.ContactNumberCol.FillWeight = 170F;
            this.ContactNumberCol.Frozen = true;
            this.ContactNumberCol.HeaderText = "CONTACT NUMBER";
            this.ContactNumberCol.MinimumWidth = 100;
            this.ContactNumberCol.Name = "ContactNumberCol";
            this.ContactNumberCol.Width = 170;
            // 
            // ZipCodeCol
            // 
            this.ZipCodeCol.DividerWidth = 8;
            this.ZipCodeCol.FillWeight = 120F;
            this.ZipCodeCol.Frozen = true;
            this.ZipCodeCol.HeaderText = "ZIP CODE";
            this.ZipCodeCol.MinimumWidth = 100;
            this.ZipCodeCol.Name = "ZipCodeCol";
            this.ZipCodeCol.Width = 120;
            // 
            // BarangayCol
            // 
            this.BarangayCol.DividerWidth = 8;
            this.BarangayCol.FillWeight = 150F;
            this.BarangayCol.Frozen = true;
            this.BarangayCol.HeaderText = "BARANGAY";
            this.BarangayCol.MinimumWidth = 100;
            this.BarangayCol.Name = "BarangayCol";
            this.BarangayCol.Width = 150;
            // 
            // MunicipalityCol
            // 
            this.MunicipalityCol.DividerWidth = 8;
            this.MunicipalityCol.FillWeight = 180F;
            this.MunicipalityCol.Frozen = true;
            this.MunicipalityCol.HeaderText = "MUNICIPALITY";
            this.MunicipalityCol.MinimumWidth = 100;
            this.MunicipalityCol.Name = "MunicipalityCol";
            this.MunicipalityCol.Width = 180;
            // 
            // ProvinceCol
            // 
            this.ProvinceCol.DividerWidth = 8;
            this.ProvinceCol.FillWeight = 180F;
            this.ProvinceCol.Frozen = true;
            this.ProvinceCol.HeaderText = "PROVINCE";
            this.ProvinceCol.MinimumWidth = 100;
            this.ProvinceCol.Name = "ProvinceCol";
            this.ProvinceCol.Width = 180;
            // 
            // EmerNameCol
            // 
            this.EmerNameCol.DividerWidth = 8;
            this.EmerNameCol.FillWeight = 200F;
            this.EmerNameCol.Frozen = true;
            this.EmerNameCol.HeaderText = "EMERGENCY CONTACT NAME";
            this.EmerNameCol.MinimumWidth = 100;
            this.EmerNameCol.Name = "EmerNameCol";
            this.EmerNameCol.Width = 200;
            // 
            // EmerAddressCol
            // 
            this.EmerAddressCol.DividerWidth = 8;
            this.EmerAddressCol.FillWeight = 200F;
            this.EmerAddressCol.Frozen = true;
            this.EmerAddressCol.HeaderText = "EMERGENCY CONTACT ADDRESS";
            this.EmerAddressCol.MinimumWidth = 100;
            this.EmerAddressCol.Name = "EmerAddressCol";
            this.EmerAddressCol.Width = 200;
            // 
            // EmerContNumCol
            // 
            this.EmerContNumCol.DividerWidth = 8;
            this.EmerContNumCol.FillWeight = 170F;
            this.EmerContNumCol.Frozen = true;
            this.EmerContNumCol.HeaderText = "EMERGENCY CONTACT NUMBER";
            this.EmerContNumCol.MinimumWidth = 100;
            this.EmerContNumCol.Name = "EmerContNumCol";
            this.EmerContNumCol.Width = 170;
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView InfoTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarangayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MunicipalityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvinceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmerNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmerAddressCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmerContNumCol;
    }
}
