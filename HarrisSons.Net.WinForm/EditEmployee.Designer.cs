﻿namespace HarrisSons.Net.WinForm
{
    partial class EditEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployee));
            this.panelHeading = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tbDepartment = new System.Windows.Forms.ComboBox();
            this.tbPosition = new System.Windows.Forms.ComboBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbAddressLine2 = new System.Windows.Forms.TextBox();
            this.tbAddressLine1 = new System.Windows.Forms.TextBox();
            this.tbBusinessTelephone = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbBirthDate = new System.Windows.Forms.DateTimePicker();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelBusinessTele = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.labelAddressLine2 = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelAddressLine1 = new System.Windows.Forms.Label();
            this.labelTele = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.panelHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeading
            // 
            this.panelHeading.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelHeading.Controls.Add(this.btnSave);
            this.panelHeading.Controls.Add(this.pictureBoxLogo);
            this.panelHeading.Location = new System.Drawing.Point(0, 0);
            this.panelHeading.Name = "panelHeading";
            this.panelHeading.Size = new System.Drawing.Size(752, 45);
            this.panelHeading.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(647, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(198, 45);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Controls.Add(this.labelBusinessTele);
            this.panelBody.Controls.Add(this.tbDepartment);
            this.panelBody.Controls.Add(this.tbPosition);
            this.panelBody.Controls.Add(this.labelDepartment);
            this.panelBody.Controls.Add(this.labelPosition);
            this.panelBody.Controls.Add(this.tbPostalCode);
            this.panelBody.Controls.Add(this.tbCountry);
            this.panelBody.Controls.Add(this.tbState);
            this.panelBody.Controls.Add(this.tbCity);
            this.panelBody.Controls.Add(this.tbAddressLine2);
            this.panelBody.Controls.Add(this.tbAddressLine1);
            this.panelBody.Controls.Add(this.tbBusinessTelephone);
            this.panelBody.Controls.Add(this.tbTelephone);
            this.panelBody.Controls.Add(this.tbEmail);
            this.panelBody.Controls.Add(this.tbBirthDate);
            this.panelBody.Controls.Add(this.labelLastName);
            this.panelBody.Controls.Add(this.tbLastName);
            this.panelBody.Controls.Add(this.labelAddressLine2);
            this.panelBody.Controls.Add(this.labelPostalCode);
            this.panelBody.Controls.Add(this.labelCountry);
            this.panelBody.Controls.Add(this.labelState);
            this.panelBody.Controls.Add(this.labelCity);
            this.panelBody.Controls.Add(this.labelAddressLine1);
            this.panelBody.Controls.Add(this.labelTele);
            this.panelBody.Controls.Add(this.labelEmail);
            this.panelBody.Controls.Add(this.tbFirstName);
            this.panelBody.Controls.Add(this.labelBirthDate);
            this.panelBody.Controls.Add(this.labelFirstName);
            this.panelBody.Location = new System.Drawing.Point(0, 45);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(752, 400);
            this.panelBody.TabIndex = 1;
            // 
            // tbDepartment
            // 
            this.tbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbDepartment.BackColor = System.Drawing.Color.White;
            this.tbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbDepartment.Enabled = false;
            this.tbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbDepartment.FormattingEnabled = true;
            this.tbDepartment.Location = new System.Drawing.Point(532, 129);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(204, 29);
            this.tbDepartment.TabIndex = 4;
            // 
            // tbPosition
            // 
            this.tbPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbPosition.BackColor = System.Drawing.Color.White;
            this.tbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbPosition.FormattingEnabled = true;
            this.tbPosition.Location = new System.Drawing.Point(136, 129);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(204, 29);
            this.tbPosition.TabIndex = 3;
            this.tbPosition.SelectedValueChanged += new System.EventHandler(this.tbPosition_SelectedValueChanged);
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(370, 132);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(102, 21);
            this.labelDepartment.TabIndex = 0;
            this.labelDepartment.Text = "Department:";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(16, 132);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(72, 21);
            this.labelPosition.TabIndex = 0;
            this.labelPosition.Text = "Position:";
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(532, 337);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(204, 29);
            this.tbPostalCode.TabIndex = 1;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(136, 337);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(204, 29);
            this.tbCountry.TabIndex = 1;
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(532, 285);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(204, 29);
            this.tbState.TabIndex = 1;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(136, 285);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(204, 29);
            this.tbCity.TabIndex = 1;
            // 
            // tbAddressLine2
            // 
            this.tbAddressLine2.Location = new System.Drawing.Point(532, 233);
            this.tbAddressLine2.Name = "tbAddressLine2";
            this.tbAddressLine2.Size = new System.Drawing.Size(204, 29);
            this.tbAddressLine2.TabIndex = 1;
            // 
            // tbAddressLine1
            // 
            this.tbAddressLine1.Location = new System.Drawing.Point(136, 233);
            this.tbAddressLine1.Name = "tbAddressLine1";
            this.tbAddressLine1.Size = new System.Drawing.Size(204, 29);
            this.tbAddressLine1.TabIndex = 1;
            // 
            // tbBusinessTelephone
            // 
            this.tbBusinessTelephone.Location = new System.Drawing.Point(532, 181);
            this.tbBusinessTelephone.Name = "tbBusinessTelephone";
            this.tbBusinessTelephone.Size = new System.Drawing.Size(204, 29);
            this.tbBusinessTelephone.TabIndex = 1;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(136, 181);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(204, 29);
            this.tbTelephone.TabIndex = 1;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(532, 79);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(204, 29);
            this.tbEmail.TabIndex = 1;
            // 
            // tbBirthDate
            // 
            this.tbBirthDate.Location = new System.Drawing.Point(136, 76);
            this.tbBirthDate.Name = "tbBirthDate";
            this.tbBirthDate.Size = new System.Drawing.Size(204, 29);
            this.tbBirthDate.TabIndex = 2;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(370, 30);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(90, 21);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelBusinessTele
            // 
            this.labelBusinessTele.AutoSize = true;
            this.labelBusinessTele.Location = new System.Drawing.Point(370, 184);
            this.labelBusinessTele.Name = "labelBusinessTele";
            this.labelBusinessTele.Size = new System.Drawing.Size(156, 21);
            this.labelBusinessTele.TabIndex = 0;
            this.labelBusinessTele.Text = "Business Telephone:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(532, 27);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(204, 29);
            this.tbLastName.TabIndex = 1;
            // 
            // labelAddressLine2
            // 
            this.labelAddressLine2.AutoSize = true;
            this.labelAddressLine2.Location = new System.Drawing.Point(370, 236);
            this.labelAddressLine2.Name = "labelAddressLine2";
            this.labelAddressLine2.Size = new System.Drawing.Size(117, 21);
            this.labelAddressLine2.TabIndex = 0;
            this.labelAddressLine2.Text = "Address Line2:";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(370, 340);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(100, 21);
            this.labelPostalCode.TabIndex = 0;
            this.labelPostalCode.Text = "Postal Code:";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(16, 340);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(73, 21);
            this.labelCountry.TabIndex = 0;
            this.labelCountry.Text = "Country:";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(370, 288);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(52, 21);
            this.labelState.TabIndex = 0;
            this.labelState.Text = "State:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(16, 288);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(42, 21);
            this.labelCity.TabIndex = 0;
            this.labelCity.Text = "City:";
            // 
            // labelAddressLine1
            // 
            this.labelAddressLine1.AutoSize = true;
            this.labelAddressLine1.Location = new System.Drawing.Point(16, 236);
            this.labelAddressLine1.Name = "labelAddressLine1";
            this.labelAddressLine1.Size = new System.Drawing.Size(114, 21);
            this.labelAddressLine1.TabIndex = 0;
            this.labelAddressLine1.Text = "Address Line1:";
            // 
            // labelTele
            // 
            this.labelTele.AutoSize = true;
            this.labelTele.Location = new System.Drawing.Point(16, 184);
            this.labelTele.Name = "labelTele";
            this.labelTele.Size = new System.Drawing.Size(90, 21);
            this.labelTele.TabIndex = 0;
            this.labelTele.Text = "Telephone:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(370, 82);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 21);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(136, 27);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(204, 29);
            this.tbFirstName.TabIndex = 1;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(16, 82);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(87, 21);
            this.labelBirthDate.TabIndex = 0;
            this.labelBirthDate.Text = "Birth Date:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(16, 30);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(92, 21);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            // 
            // EditEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(752, 445);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeading);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EditEmployee";
            this.Text = "Edit Employee";
            this.panelHeading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeading;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.DateTimePicker tbBirthDate;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.TextBox tbAddressLine1;
        private System.Windows.Forms.Label labelAddressLine2;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox tbAddressLine2;
        private System.Windows.Forms.Label labelAddressLine1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label labelBusinessTele;
        private System.Windows.Forms.TextBox tbBusinessTelephone;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Label labelTele;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox tbDepartment;
        private System.Windows.Forms.ComboBox tbPosition;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelPosition;
    }
}