namespace HarrisSons.Net.WinForm
{
    partial class DashBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panelAddress1 = new System.Windows.Forms.Panel();
            this.richTextBoxAddressLine1 = new System.Windows.Forms.RichTextBox();
            this.labelAddressLine1 = new System.Windows.Forms.Label();
            this.panelHeadBar = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContactList = new System.Windows.Forms.Panel();
            this.dgvContactTable = new System.Windows.Forms.DataGridView();
            this.tabControlContact = new System.Windows.Forms.TabControl();
            this.tabPagePersonalContact = new System.Windows.Forms.TabPage();
            this.textBoxPersonContactSearch = new System.Windows.Forms.TextBox();
            this.btnPersonalContactSearch = new System.Windows.Forms.Button();
            this.btnPersonalContactDelete = new System.Windows.Forms.Button();
            this.btnPersonalContactEdit = new System.Windows.Forms.Button();
            this.btnPersonalContactAdd = new System.Windows.Forms.Button();
            this.panelPersonalContactOperation = new System.Windows.Forms.Panel();
            this.tabPageBusinessContact = new System.Windows.Forms.TabPage();
            this.btnBusinessContactSearch = new System.Windows.Forms.Button();
            this.textBoxBusinessContactSearch = new System.Windows.Forms.TextBox();
            this.btnBusinessContactDelete = new System.Windows.Forms.Button();
            this.btnBusinessContactEdit = new System.Windows.Forms.Button();
            this.btnBusinessContactAdd = new System.Windows.Forms.Button();
            this.panelBusinessContactOperation = new System.Windows.Forms.Panel();
            this.labelAddressLine2 = new System.Windows.Forms.Label();
            this.panelAddress2 = new System.Windows.Forms.Panel();
            this.richTextBoxAddressLine2 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCity = new System.Windows.Forms.RichTextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.panelAddress3 = new System.Windows.Forms.Panel();
            this.richTextBoxState = new System.Windows.Forms.RichTextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.panelAddress4 = new System.Windows.Forms.Panel();
            this.richTextBoxCountry = new System.Windows.Forms.RichTextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.panelAddress5 = new System.Windows.Forms.Panel();
            this.richTextBoxPostalCode = new System.Windows.Forms.RichTextBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.panelAddress6 = new System.Windows.Forms.Panel();
            this.panelAddress1.SuspendLayout();
            this.panelHeadBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelContactList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactTable)).BeginInit();
            this.tabControlContact.SuspendLayout();
            this.tabPagePersonalContact.SuspendLayout();
            this.tabPageBusinessContact.SuspendLayout();
            this.panelAddress2.SuspendLayout();
            this.panelAddress3.SuspendLayout();
            this.panelAddress4.SuspendLayout();
            this.panelAddress5.SuspendLayout();
            this.panelAddress6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddress1
            // 
            this.panelAddress1.BackColor = System.Drawing.Color.White;
            this.panelAddress1.Controls.Add(this.richTextBoxAddressLine1);
            this.panelAddress1.Controls.Add(this.labelAddressLine1);
            this.panelAddress1.Location = new System.Drawing.Point(0, 50);
            this.panelAddress1.Name = "panelAddress1";
            this.panelAddress1.Size = new System.Drawing.Size(200, 104);
            this.panelAddress1.TabIndex = 0;
            // 
            // richTextBoxAddressLine1
            // 
            this.richTextBoxAddressLine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxAddressLine1.Enabled = false;
            this.richTextBoxAddressLine1.Location = new System.Drawing.Point(12, 27);
            this.richTextBoxAddressLine1.Name = "richTextBoxAddressLine1";
            this.richTextBoxAddressLine1.Size = new System.Drawing.Size(180, 60);
            this.richTextBoxAddressLine1.TabIndex = 1;
            this.richTextBoxAddressLine1.Text = "";
            // 
            // labelAddressLine1
            // 
            this.labelAddressLine1.AutoSize = true;
            this.labelAddressLine1.Location = new System.Drawing.Point(12, 3);
            this.labelAddressLine1.Name = "labelAddressLine1";
            this.labelAddressLine1.Size = new System.Drawing.Size(118, 21);
            this.labelAddressLine1.TabIndex = 0;
            this.labelAddressLine1.Text = "Address Line 1:";
            // 
            // panelHeadBar
            // 
            this.panelHeadBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelHeadBar.Controls.Add(this.pictureBoxLogo);
            this.panelHeadBar.Location = new System.Drawing.Point(0, 0);
            this.panelHeadBar.Name = "panelHeadBar";
            this.panelHeadBar.Size = new System.Drawing.Size(1264, 50);
            this.panelHeadBar.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(200, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelContactList);
            this.panelMain.Controls.Add(this.tabControlContact);
            this.panelMain.Location = new System.Drawing.Point(200, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1064, 630);
            this.panelMain.TabIndex = 2;
            // 
            // panelContactList
            // 
            this.panelContactList.Controls.Add(this.dgvContactTable);
            this.panelContactList.Location = new System.Drawing.Point(4, 80);
            this.panelContactList.Name = "panelContactList";
            this.panelContactList.Size = new System.Drawing.Size(1056, 542);
            this.panelContactList.TabIndex = 1;
            // 
            // dgvContactTable
            // 
            this.dgvContactTable.AllowUserToAddRows = false;
            this.dgvContactTable.AllowUserToDeleteRows = false;
            this.dgvContactTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContactTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvContactTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContactTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContactTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            this.dgvContactTable.Location = new System.Drawing.Point(0, 0);
            this.dgvContactTable.MultiSelect = false;
            this.dgvContactTable.Name = "dgvContactTable";
            this.dgvContactTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactTable.Size = new System.Drawing.Size(1056, 542);
            this.dgvContactTable.TabIndex = 0;
            this.dgvContactTable.SelectionChanged += new System.EventHandler(this.dgvContactTable_SelectionChanged);
            // 
            // tabControlContact
            // 
            this.tabControlContact.Controls.Add(this.tabPagePersonalContact);
            this.tabControlContact.Controls.Add(this.tabPageBusinessContact);
            this.tabControlContact.ItemSize = new System.Drawing.Size(140, 26);
            this.tabControlContact.Location = new System.Drawing.Point(0, 0);
            this.tabControlContact.Name = "tabControlContact";
            this.tabControlContact.SelectedIndex = 0;
            this.tabControlContact.Size = new System.Drawing.Size(1064, 74);
            this.tabControlContact.TabIndex = 0;
            this.tabControlContact.SelectedIndexChanged += new System.EventHandler(this.tabControlContact_SelectedIndexChanged);
            // 
            // tabPagePersonalContact
            // 
            this.tabPagePersonalContact.Controls.Add(this.textBoxPersonContactSearch);
            this.tabPagePersonalContact.Controls.Add(this.btnPersonalContactSearch);
            this.tabPagePersonalContact.Controls.Add(this.btnPersonalContactDelete);
            this.tabPagePersonalContact.Controls.Add(this.btnPersonalContactEdit);
            this.tabPagePersonalContact.Controls.Add(this.btnPersonalContactAdd);
            this.tabPagePersonalContact.Controls.Add(this.panelPersonalContactOperation);
            this.tabPagePersonalContact.Location = new System.Drawing.Point(4, 30);
            this.tabPagePersonalContact.Name = "tabPagePersonalContact";
            this.tabPagePersonalContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalContact.Size = new System.Drawing.Size(1056, 40);
            this.tabPagePersonalContact.TabIndex = 0;
            this.tabPagePersonalContact.Text = "Personal Contacts";
            this.tabPagePersonalContact.UseVisualStyleBackColor = true;
            // 
            // textBoxPersonContactSearch
            // 
            this.textBoxPersonContactSearch.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPersonContactSearch.Location = new System.Drawing.Point(776, 0);
            this.textBoxPersonContactSearch.Multiline = true;
            this.textBoxPersonContactSearch.Name = "textBoxPersonContactSearch";
            this.textBoxPersonContactSearch.Size = new System.Drawing.Size(140, 40);
            this.textBoxPersonContactSearch.TabIndex = 4;
            // 
            // btnPersonalContactSearch
            // 
            this.btnPersonalContactSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonalContactSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalContactSearch.Location = new System.Drawing.Point(916, 0);
            this.btnPersonalContactSearch.Name = "btnPersonalContactSearch";
            this.btnPersonalContactSearch.Size = new System.Drawing.Size(140, 40);
            this.btnPersonalContactSearch.TabIndex = 3;
            this.btnPersonalContactSearch.Text = "  Search";
            this.btnPersonalContactSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonalContactSearch.UseVisualStyleBackColor = false;
            this.btnPersonalContactSearch.Click += new System.EventHandler(this.btnPersonalContactSearch_Click);
            // 
            // btnPersonalContactDelete
            // 
            this.btnPersonalContactDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalContactDelete.Location = new System.Drawing.Point(280, 0);
            this.btnPersonalContactDelete.Name = "btnPersonalContactDelete";
            this.btnPersonalContactDelete.Size = new System.Drawing.Size(140, 40);
            this.btnPersonalContactDelete.TabIndex = 2;
            this.btnPersonalContactDelete.Text = "  Delete";
            this.btnPersonalContactDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonalContactDelete.UseVisualStyleBackColor = true;
            this.btnPersonalContactDelete.Click += new System.EventHandler(this.btnPersonalContactDelete_Click);
            // 
            // btnPersonalContactEdit
            // 
            this.btnPersonalContactEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalContactEdit.Location = new System.Drawing.Point(140, 0);
            this.btnPersonalContactEdit.Name = "btnPersonalContactEdit";
            this.btnPersonalContactEdit.Size = new System.Drawing.Size(140, 40);
            this.btnPersonalContactEdit.TabIndex = 1;
            this.btnPersonalContactEdit.Text = "  Edit";
            this.btnPersonalContactEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonalContactEdit.UseVisualStyleBackColor = true;
            this.btnPersonalContactEdit.Click += new System.EventHandler(this.btnPersonalContactEdit_Click);
            // 
            // btnPersonalContactAdd
            // 
            this.btnPersonalContactAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalContactAdd.Location = new System.Drawing.Point(0, 0);
            this.btnPersonalContactAdd.Name = "btnPersonalContactAdd";
            this.btnPersonalContactAdd.Size = new System.Drawing.Size(140, 40);
            this.btnPersonalContactAdd.TabIndex = 1;
            this.btnPersonalContactAdd.Text = "  Add";
            this.btnPersonalContactAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonalContactAdd.UseVisualStyleBackColor = true;
            this.btnPersonalContactAdd.Click += new System.EventHandler(this.btnPersonalContactAdd_Click);
            // 
            // panelPersonalContactOperation
            // 
            this.panelPersonalContactOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPersonalContactOperation.Location = new System.Drawing.Point(0, 0);
            this.panelPersonalContactOperation.Name = "panelPersonalContactOperation";
            this.panelPersonalContactOperation.Size = new System.Drawing.Size(1056, 40);
            this.panelPersonalContactOperation.TabIndex = 0;
            // 
            // tabPageBusinessContact
            // 
            this.tabPageBusinessContact.Controls.Add(this.btnBusinessContactSearch);
            this.tabPageBusinessContact.Controls.Add(this.textBoxBusinessContactSearch);
            this.tabPageBusinessContact.Controls.Add(this.btnBusinessContactDelete);
            this.tabPageBusinessContact.Controls.Add(this.btnBusinessContactEdit);
            this.tabPageBusinessContact.Controls.Add(this.btnBusinessContactAdd);
            this.tabPageBusinessContact.Controls.Add(this.panelBusinessContactOperation);
            this.tabPageBusinessContact.Location = new System.Drawing.Point(4, 30);
            this.tabPageBusinessContact.Name = "tabPageBusinessContact";
            this.tabPageBusinessContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBusinessContact.Size = new System.Drawing.Size(1056, 40);
            this.tabPageBusinessContact.TabIndex = 1;
            this.tabPageBusinessContact.Text = "Business Contacts";
            this.tabPageBusinessContact.UseVisualStyleBackColor = true;
            // 
            // btnBusinessContactSearch
            // 
            this.btnBusinessContactSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusinessContactSearch.Location = new System.Drawing.Point(916, 0);
            this.btnBusinessContactSearch.Name = "btnBusinessContactSearch";
            this.btnBusinessContactSearch.Size = new System.Drawing.Size(140, 40);
            this.btnBusinessContactSearch.TabIndex = 5;
            this.btnBusinessContactSearch.Text = "  Search";
            this.btnBusinessContactSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusinessContactSearch.UseVisualStyleBackColor = true;
            this.btnBusinessContactSearch.Click += new System.EventHandler(this.btnBusinessContactSearch_Click);
            // 
            // textBoxBusinessContactSearch
            // 
            this.textBoxBusinessContactSearch.Location = new System.Drawing.Point(776, 0);
            this.textBoxBusinessContactSearch.Multiline = true;
            this.textBoxBusinessContactSearch.Name = "textBoxBusinessContactSearch";
            this.textBoxBusinessContactSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxBusinessContactSearch.Size = new System.Drawing.Size(140, 40);
            this.textBoxBusinessContactSearch.TabIndex = 4;
            // 
            // btnBusinessContactDelete
            // 
            this.btnBusinessContactDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusinessContactDelete.Location = new System.Drawing.Point(280, 0);
            this.btnBusinessContactDelete.Name = "btnBusinessContactDelete";
            this.btnBusinessContactDelete.Size = new System.Drawing.Size(140, 40);
            this.btnBusinessContactDelete.TabIndex = 3;
            this.btnBusinessContactDelete.Text = "  Delete";
            this.btnBusinessContactDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusinessContactDelete.UseVisualStyleBackColor = true;
            this.btnBusinessContactDelete.Click += new System.EventHandler(this.btnBusinessContactDelete_Click);
            // 
            // btnBusinessContactEdit
            // 
            this.btnBusinessContactEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusinessContactEdit.Location = new System.Drawing.Point(140, 0);
            this.btnBusinessContactEdit.Name = "btnBusinessContactEdit";
            this.btnBusinessContactEdit.Size = new System.Drawing.Size(140, 40);
            this.btnBusinessContactEdit.TabIndex = 2;
            this.btnBusinessContactEdit.Text = "  Edit";
            this.btnBusinessContactEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusinessContactEdit.UseVisualStyleBackColor = true;
            this.btnBusinessContactEdit.Click += new System.EventHandler(this.btnBusinessContactEdit_Click);
            // 
            // btnBusinessContactAdd
            // 
            this.btnBusinessContactAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusinessContactAdd.Location = new System.Drawing.Point(0, 0);
            this.btnBusinessContactAdd.Name = "btnBusinessContactAdd";
            this.btnBusinessContactAdd.Size = new System.Drawing.Size(140, 40);
            this.btnBusinessContactAdd.TabIndex = 1;
            this.btnBusinessContactAdd.Text = "  Add";
            this.btnBusinessContactAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusinessContactAdd.UseVisualStyleBackColor = true;
            this.btnBusinessContactAdd.Click += new System.EventHandler(this.btnBusinessContactAdd_Click);
            // 
            // panelBusinessContactOperation
            // 
            this.panelBusinessContactOperation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelBusinessContactOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBusinessContactOperation.Location = new System.Drawing.Point(0, 0);
            this.panelBusinessContactOperation.Name = "panelBusinessContactOperation";
            this.panelBusinessContactOperation.Size = new System.Drawing.Size(1056, 40);
            this.panelBusinessContactOperation.TabIndex = 0;
            // 
            // labelAddressLine2
            // 
            this.labelAddressLine2.AutoSize = true;
            this.labelAddressLine2.Location = new System.Drawing.Point(12, 3);
            this.labelAddressLine2.Name = "labelAddressLine2";
            this.labelAddressLine2.Size = new System.Drawing.Size(121, 21);
            this.labelAddressLine2.TabIndex = 0;
            this.labelAddressLine2.Text = "Address Line 2:";
            // 
            // panelAddress2
            // 
            this.panelAddress2.BackColor = System.Drawing.Color.White;
            this.panelAddress2.Controls.Add(this.richTextBoxAddressLine2);
            this.panelAddress2.Controls.Add(this.labelAddressLine2);
            this.panelAddress2.Location = new System.Drawing.Point(0, 155);
            this.panelAddress2.Name = "panelAddress2";
            this.panelAddress2.Size = new System.Drawing.Size(200, 104);
            this.panelAddress2.TabIndex = 0;
            // 
            // richTextBoxAddressLine2
            // 
            this.richTextBoxAddressLine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxAddressLine2.Enabled = false;
            this.richTextBoxAddressLine2.Location = new System.Drawing.Point(12, 27);
            this.richTextBoxAddressLine2.Name = "richTextBoxAddressLine2";
            this.richTextBoxAddressLine2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxAddressLine2.Size = new System.Drawing.Size(180, 60);
            this.richTextBoxAddressLine2.TabIndex = 1;
            this.richTextBoxAddressLine2.Text = "";
            // 
            // richTextBoxCity
            // 
            this.richTextBoxCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxCity.Enabled = false;
            this.richTextBoxCity.Location = new System.Drawing.Point(12, 27);
            this.richTextBoxCity.Name = "richTextBoxCity";
            this.richTextBoxCity.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxCity.Size = new System.Drawing.Size(180, 60);
            this.richTextBoxCity.TabIndex = 1;
            this.richTextBoxCity.Text = "";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(12, 3);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(42, 21);
            this.labelCity.TabIndex = 0;
            this.labelCity.Text = "City:";
            // 
            // panelAddress3
            // 
            this.panelAddress3.BackColor = System.Drawing.Color.White;
            this.panelAddress3.Controls.Add(this.richTextBoxCity);
            this.panelAddress3.Controls.Add(this.labelCity);
            this.panelAddress3.Location = new System.Drawing.Point(0, 260);
            this.panelAddress3.Name = "panelAddress3";
            this.panelAddress3.Size = new System.Drawing.Size(200, 104);
            this.panelAddress3.TabIndex = 0;
            // 
            // richTextBoxState
            // 
            this.richTextBoxState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxState.Enabled = false;
            this.richTextBoxState.Location = new System.Drawing.Point(12, 27);
            this.richTextBoxState.Name = "richTextBoxState";
            this.richTextBoxState.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxState.Size = new System.Drawing.Size(180, 60);
            this.richTextBoxState.TabIndex = 1;
            this.richTextBoxState.Text = "";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(12, 3);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(52, 21);
            this.labelState.TabIndex = 0;
            this.labelState.Text = "State:";
            // 
            // panelAddress4
            // 
            this.panelAddress4.BackColor = System.Drawing.Color.White;
            this.panelAddress4.Controls.Add(this.richTextBoxState);
            this.panelAddress4.Controls.Add(this.labelState);
            this.panelAddress4.Location = new System.Drawing.Point(0, 365);
            this.panelAddress4.Name = "panelAddress4";
            this.panelAddress4.Size = new System.Drawing.Size(200, 104);
            this.panelAddress4.TabIndex = 0;
            // 
            // richTextBoxCountry
            // 
            this.richTextBoxCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxCountry.Enabled = false;
            this.richTextBoxCountry.Location = new System.Drawing.Point(12, 27);
            this.richTextBoxCountry.Name = "richTextBoxCountry";
            this.richTextBoxCountry.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxCountry.Size = new System.Drawing.Size(180, 60);
            this.richTextBoxCountry.TabIndex = 1;
            this.richTextBoxCountry.Text = "";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(12, 3);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(73, 21);
            this.labelCountry.TabIndex = 0;
            this.labelCountry.Text = "Country:";
            // 
            // panelAddress5
            // 
            this.panelAddress5.BackColor = System.Drawing.Color.White;
            this.panelAddress5.Controls.Add(this.richTextBoxCountry);
            this.panelAddress5.Controls.Add(this.labelCountry);
            this.panelAddress5.Location = new System.Drawing.Point(0, 470);
            this.panelAddress5.Name = "panelAddress5";
            this.panelAddress5.Size = new System.Drawing.Size(200, 104);
            this.panelAddress5.TabIndex = 0;
            // 
            // richTextBoxPostalCode
            // 
            this.richTextBoxPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxPostalCode.Enabled = false;
            this.richTextBoxPostalCode.Location = new System.Drawing.Point(12, 27);
            this.richTextBoxPostalCode.Name = "richTextBoxPostalCode";
            this.richTextBoxPostalCode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxPostalCode.Size = new System.Drawing.Size(180, 60);
            this.richTextBoxPostalCode.TabIndex = 1;
            this.richTextBoxPostalCode.Text = "";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(12, 3);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(100, 21);
            this.labelPostalCode.TabIndex = 0;
            this.labelPostalCode.Text = "Postal Code:";
            // 
            // panelAddress6
            // 
            this.panelAddress6.BackColor = System.Drawing.Color.White;
            this.panelAddress6.Controls.Add(this.richTextBoxPostalCode);
            this.panelAddress6.Controls.Add(this.labelPostalCode);
            this.panelAddress6.Location = new System.Drawing.Point(0, 575);
            this.panelAddress6.Name = "panelAddress6";
            this.panelAddress6.Size = new System.Drawing.Size(200, 104);
            this.panelAddress6.TabIndex = 0;
            // 
            // DashBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelAddress6);
            this.Controls.Add(this.panelAddress5);
            this.Controls.Add(this.panelAddress4);
            this.Controls.Add(this.panelAddress3);
            this.Controls.Add(this.panelAddress2);
            this.Controls.Add(this.panelAddress1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeadBar);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DashBoard";
            this.Text = "Dashboard";
            this.panelAddress1.ResumeLayout(false);
            this.panelAddress1.PerformLayout();
            this.panelHeadBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelContactList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactTable)).EndInit();
            this.tabControlContact.ResumeLayout(false);
            this.tabPagePersonalContact.ResumeLayout(false);
            this.tabPagePersonalContact.PerformLayout();
            this.tabPageBusinessContact.ResumeLayout(false);
            this.tabPageBusinessContact.PerformLayout();
            this.panelAddress2.ResumeLayout(false);
            this.panelAddress2.PerformLayout();
            this.panelAddress3.ResumeLayout(false);
            this.panelAddress3.PerformLayout();
            this.panelAddress4.ResumeLayout(false);
            this.panelAddress4.PerformLayout();
            this.panelAddress5.ResumeLayout(false);
            this.panelAddress5.PerformLayout();
            this.panelAddress6.ResumeLayout(false);
            this.panelAddress6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeadBar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TabControl tabControlContact;
        private System.Windows.Forms.TabPage tabPagePersonalContact;
        private System.Windows.Forms.TabPage tabPageBusinessContact;
        private System.Windows.Forms.Panel panelPersonalContactOperation;
        private System.Windows.Forms.Panel panelBusinessContactOperation;
        private System.Windows.Forms.Button btnPersonalContactAdd;
        private System.Windows.Forms.Button btnPersonalContactEdit;
        private System.Windows.Forms.Button btnPersonalContactSearch;
        private System.Windows.Forms.Button btnPersonalContactDelete;
        private System.Windows.Forms.TextBox textBoxPersonContactSearch;
        private System.Windows.Forms.Button btnBusinessContactAdd;
        private System.Windows.Forms.Button btnBusinessContactEdit;
        private System.Windows.Forms.Button btnBusinessContactDelete;
        private System.Windows.Forms.Button btnBusinessContactSearch;
        private System.Windows.Forms.TextBox textBoxBusinessContactSearch;
        private System.Windows.Forms.DataGridView dgvContactTable;
        private System.Windows.Forms.Panel panelContactList;
        private System.Windows.Forms.Panel panelAddress1;
        private System.Windows.Forms.Panel panelAddress2;
        private System.Windows.Forms.Panel panelAddress3;
        private System.Windows.Forms.Panel panelAddress4;
        private System.Windows.Forms.Panel panelAddress5;
        private System.Windows.Forms.Panel panelAddress6;
        private System.Windows.Forms.Label labelAddressLine1;
        private System.Windows.Forms.Label labelAddressLine2;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.RichTextBox richTextBoxAddressLine1;
        private System.Windows.Forms.RichTextBox richTextBoxAddressLine2;
        private System.Windows.Forms.RichTextBox richTextBoxCity;
        private System.Windows.Forms.RichTextBox richTextBoxState;
        private System.Windows.Forms.RichTextBox richTextBoxCountry;
        private System.Windows.Forms.RichTextBox richTextBoxPostalCode;
    }
}

