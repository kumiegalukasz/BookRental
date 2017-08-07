namespace Library
{
    partial class ClientForm
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
            this.components = new System.ComponentModel.Container();
            this.FirstName = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LastName = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstNameCustomer = new System.Windows.Forms.TextBox();
            this.txtLastNameCustomer = new System.Windows.Forms.TextBox();
            this.txtAddressCustomer = new System.Windows.Forms.TextBox();
            this.txtCityCustomer = new System.Windows.Forms.TextBox();
            this.txtPhoneNumberCustomer = new System.Windows.Forms.TextBox();
            this.txtEmailCustomer = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCodeCustomer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(25, 23);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(60, 13);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First Name:";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Interfaces.DomainModel.Customer);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(25, 54);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(61, 13);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name:";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(25, 228);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(79, 13);
            this.PhoneNumber.TabIndex = 4;
            this.PhoneNumber.Text = "Phone number:";
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Location = new System.Drawing.Point(25, 197);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(35, 13);
            this.Code.TabIndex = 10;
            this.Code.Text = "Code:";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(25, 166);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(27, 13);
            this.City.TabIndex = 8;
            this.City.Text = "City:";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(25, 85);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(48, 13);
            this.Address.TabIndex = 6;
            this.Address.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email:";
            // 
            // txtFirstNameCustomer
            // 
            this.txtFirstNameCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "FirstName", true));
            this.txtFirstNameCustomer.Location = new System.Drawing.Point(147, 23);
            this.txtFirstNameCustomer.Name = "txtFirstNameCustomer";
            this.txtFirstNameCustomer.Size = new System.Drawing.Size(214, 20);
            this.txtFirstNameCustomer.TabIndex = 13;
            // 
            // txtLastNameCustomer
            // 
            this.txtLastNameCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "LastName", true));
            this.txtLastNameCustomer.Location = new System.Drawing.Point(148, 54);
            this.txtLastNameCustomer.Name = "txtLastNameCustomer";
            this.txtLastNameCustomer.Size = new System.Drawing.Size(213, 20);
            this.txtLastNameCustomer.TabIndex = 14;
            // 
            // txtAddressCustomer
            // 
            this.txtAddressCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
            this.txtAddressCustomer.Location = new System.Drawing.Point(147, 85);
            this.txtAddressCustomer.Multiline = true;
            this.txtAddressCustomer.Name = "txtAddressCustomer";
            this.txtAddressCustomer.Size = new System.Drawing.Size(213, 66);
            this.txtAddressCustomer.TabIndex = 15;
            // 
            // txtCityCustomer
            // 
            this.txtCityCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "City", true));
            this.txtCityCustomer.Location = new System.Drawing.Point(147, 166);
            this.txtCityCustomer.Name = "txtCityCustomer";
            this.txtCityCustomer.Size = new System.Drawing.Size(213, 20);
            this.txtCityCustomer.TabIndex = 16;
            // 
            // txtPhoneNumberCustomer
            // 
            this.txtPhoneNumberCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "PhoneNumber", true));
            this.txtPhoneNumberCustomer.Location = new System.Drawing.Point(147, 228);
            this.txtPhoneNumberCustomer.Name = "txtPhoneNumberCustomer";
            this.txtPhoneNumberCustomer.Size = new System.Drawing.Size(213, 20);
            this.txtPhoneNumberCustomer.TabIndex = 18;
            // 
            // txtEmailCustomer
            // 
            this.txtEmailCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Email", true));
            this.txtEmailCustomer.Location = new System.Drawing.Point(147, 259);
            this.txtEmailCustomer.Name = "txtEmailCustomer";
            this.txtEmailCustomer.Size = new System.Drawing.Size(213, 20);
            this.txtEmailCustomer.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(271, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 33);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtCodeCustomer
            // 
            this.txtCodeCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Code", true));
            this.txtCodeCustomer.Location = new System.Drawing.Point(147, 197);
            this.txtCodeCustomer.Name = "txtCodeCustomer";
            this.txtCodeCustomer.Size = new System.Drawing.Size(213, 20);
            this.txtCodeCustomer.TabIndex = 17;
            // 
            // ClientForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 351);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmailCustomer);
            this.Controls.Add(this.txtPhoneNumberCustomer);
            this.Controls.Add(this.txtCodeCustomer);
            this.Controls.Add(this.txtCityCustomer);
            this.Controls.Add(this.txtAddressCustomer);
            this.Controls.Add(this.txtLastNameCustomer);
            this.Controls.Add(this.txtFirstNameCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditClient_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstNameCustomer;
        private System.Windows.Forms.TextBox txtLastNameCustomer;
        private System.Windows.Forms.TextBox txtAddressCustomer;
        private System.Windows.Forms.TextBox txtCityCustomer;
        private System.Windows.Forms.TextBox txtPhoneNumberCustomer;
        private System.Windows.Forms.TextBox txtEmailCustomer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtCodeCustomer;
    }
}