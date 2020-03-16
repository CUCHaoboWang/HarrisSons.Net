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
            this.tabControlContact = new System.Windows.Forms.TabControl();
            this.tabPagePersonalContact = new System.Windows.Forms.TabPage();
            this.tabPageBusinessContact = new System.Windows.Forms.TabPage();
            this.panelPersonalContactOperation = new System.Windows.Forms.Panel();
            this.panelBusinessContactOperation = new System.Windows.Forms.Panel();
            this.btnPersonalContactAdd = new System.Windows.Forms.Button();
            this.panelHeadBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelMain.SuspendLayout();
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
            this.panelMain.Controls.Add(this.tabControlContact);
            this.panelMain.Location = new System.Drawing.Point(200, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1064, 630);
            this.panelMain.TabIndex = 2;
            // 
            // tabControlContact
            // 
            this.tabControlContact.Controls.Add(this.tabPagePersonalContact);
            this.tabControlContact.Controls.Add(this.tabPageBusinessContact);
            this.tabControlContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlContact.Location = new System.Drawing.Point(0, 0);
            this.tabControlContact.Name = "tabControlContact";
            this.tabControlContact.SelectedIndex = 0;
            this.tabControlContact.Size = new System.Drawing.Size(1064, 630);
            this.tabControlContact.TabIndex = 0;
            // 
            // tabPagePersonalContact
            // 
            this.tabPagePersonalContact.Controls.Add(this.btnPersonalContactAdd);
            this.tabPagePersonalContact.Controls.Add(this.panelPersonalContactOperation);
            this.tabPagePersonalContact.Location = new System.Drawing.Point(4, 30);
            this.tabPagePersonalContact.Name = "tabPagePersonalContact";
            this.tabPagePersonalContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalContact.Size = new System.Drawing.Size(1056, 596);
            this.tabPagePersonalContact.TabIndex = 0;
            this.tabPagePersonalContact.Text = "Personal Contacts";
            this.tabPagePersonalContact.UseVisualStyleBackColor = true;
            // 
            // tabPageBusinessContact
            // 
            this.tabPageBusinessContact.Controls.Add(this.panelBusinessContactOperation);
            this.tabPageBusinessContact.Location = new System.Drawing.Point(4, 30);
            this.tabPageBusinessContact.Name = "tabPageBusinessContact";
            this.tabPageBusinessContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBusinessContact.Size = new System.Drawing.Size(1056, 596);
            this.tabPageBusinessContact.TabIndex = 1;
            this.tabPageBusinessContact.Text = "Business Contacts";
            this.tabPageBusinessContact.UseVisualStyleBackColor = true;
            // 
            // panelPersonalContactOperation
            // 
            this.panelPersonalContactOperation.Location = new System.Drawing.Point(0, 0);
            this.panelPersonalContactOperation.Name = "panelPersonalContactOperation";
            this.panelPersonalContactOperation.Size = new System.Drawing.Size(1056, 40);
            this.panelPersonalContactOperation.TabIndex = 0;
            // 
            // panelBusinessContactOperation
            // 
            this.panelBusinessContactOperation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelBusinessContactOperation.Location = new System.Drawing.Point(0, 0);
            this.panelBusinessContactOperation.Name = "panelBusinessContactOperation";
            this.panelBusinessContactOperation.Size = new System.Drawing.Size(1056, 40);
            this.panelBusinessContactOperation.TabIndex = 0;
            // 
            // btnPersonalContactAdd
            // 
            this.btnPersonalContactAdd.Location = new System.Drawing.Point(0, 0);
            this.btnPersonalContactAdd.Name = "btnPersonalContactAdd";
            this.btnPersonalContactAdd.Size = new System.Drawing.Size(140, 40);
            this.btnPersonalContactAdd.TabIndex = 1;
            this.btnPersonalContactAdd.Text = "Add New";
            this.btnPersonalContactAdd.UseVisualStyleBackColor = true;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeadBar);
            this.Controls.Add(this.panelSideBar);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.panelHeadBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.tabControlContact.ResumeLayout(false);
            this.tabPagePersonalContact.ResumeLayout(false);
            this.tabPageBusinessContact.ResumeLayout(false);
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
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.TabPage PersonalContact;
    }
}

