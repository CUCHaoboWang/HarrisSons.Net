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
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panelHeadBar = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContactList = new System.Windows.Forms.Panel();
            this.dgvContactList = new System.Windows.Forms.DataGridView();
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
            this.panelHeadBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelContactList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            this.tabControlContact.SuspendLayout();
            this.tabPagePersonalContact.SuspendLayout();
            this.tabPageBusinessContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.White;
            this.panelSideBar.Location = new System.Drawing.Point(0, 50);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(200, 630);
            this.panelSideBar.TabIndex = 0;
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
            this.panelContactList.Controls.Add(this.dgvContactList);
            this.panelContactList.Location = new System.Drawing.Point(4, 80);
            this.panelContactList.Name = "panelContactList";
            this.panelContactList.Size = new System.Drawing.Size(1056, 542);
            this.panelContactList.TabIndex = 1;
            // 
            // dgvContactList
            // 
            this.dgvContactList.AllowUserToAddRows = false;
            this.dgvContactList.AllowUserToDeleteRows = false;
            this.dgvContactList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContactList.BackgroundColor = System.Drawing.Color.White;
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Dock = System.Windows.Forms.DockStyle.Fill;

            //this.dgvContactList.Anchor = ((System.Windows.Forms.AnchorStyles)((((
            //    System.Windows.Forms.AnchorStyles.Top 
            //    | System.Windows.Forms.AnchorStyles.Bottom) 
            //    | System.Windows.Forms.AnchorStyles.Left) 
            //    | System.Windows.Forms.AnchorStyles.Right)));

            this.dgvContactList.Location = new System.Drawing.Point(0, 0);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.Size = new System.Drawing.Size(1056, 542);
            this.dgvContactList.TabIndex = 0;
            this.dgvContactList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContactList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            this.dgvContactList.MultiSelect = false;
            this.dgvContactList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactList.SelectionChanged += new System.EventHandler(this.dgvContactList_SelectionChanged);
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
            // DashBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeadBar);
            this.Controls.Add(this.panelSideBar);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.panelHeadBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelContactList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            this.tabControlContact.ResumeLayout(false);
            this.tabPagePersonalContact.ResumeLayout(false);
            this.tabPagePersonalContact.PerformLayout();
            this.tabPageBusinessContact.ResumeLayout(false);
            this.tabPageBusinessContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
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
        private System.Windows.Forms.DataGridView dgvContactList;
        private System.Windows.Forms.Panel panelContactList;
    }
}

