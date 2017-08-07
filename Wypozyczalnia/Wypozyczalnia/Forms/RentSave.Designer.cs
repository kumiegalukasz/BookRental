namespace Library.Forms
{
    partial class RentSave
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.lAvailableBooks = new System.Windows.Forms.Label();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lAuthor = new System.Windows.Forms.Label();
            this.IAddress = new System.Windows.Forms.Label();
            this.ICity = new System.Windows.Forms.Label();
            this.ICode = new System.Windows.Forms.Label();
            this.ITitle = new System.Windows.Forms.Label();
            this.IPublicationDay = new System.Windows.Forms.Label();
            this.IPricePerDay = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(749, 195);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Author:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Title:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Publication day:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(377, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Price per day:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(377, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(494, 138);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(627, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Available books";
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "LastName", true));
            this.lLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lLastName.Location = new System.Drawing.Point(95, 54);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(75, 13);
            this.lLastName.TabIndex = 41;
            this.lLastName.Text = "[Last Name]";
            // 
            // lAvailableBooks
            // 
            this.lAvailableBooks.AutoSize = true;
            this.lAvailableBooks.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Quantity", true));
            this.lAvailableBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lAvailableBooks.Location = new System.Drawing.Point(733, 145);
            this.lAvailableBooks.Name = "lAvailableBooks";
            this.lAvailableBooks.Size = new System.Drawing.Size(105, 13);
            this.lAvailableBooks.TabIndex = 42;
            this.lAvailableBooks.Text = "[Available books]";
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "FirstName", true));
            this.lFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lFirstName.Location = new System.Drawing.Point(98, 25);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(75, 13);
            this.lFirstName.TabIndex = 43;
            this.lFirstName.Text = "[First Name]";
            // 
            // lAuthor
            // 
            this.lAuthor.AutoSize = true;
            this.lAuthor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Author", true));
            this.lAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lAuthor.Location = new System.Drawing.Point(491, 25);
            this.lAuthor.Name = "lAuthor";
            this.lAuthor.Size = new System.Drawing.Size(52, 13);
            this.lAuthor.TabIndex = 44;
            this.lAuthor.Text = "[Author]";
            // 
            // IAddress
            // 
            this.IAddress.AutoSize = true;
            this.IAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.IAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IAddress.Location = new System.Drawing.Point(98, 83);
            this.IAddress.Name = "IAddress";
            this.IAddress.Size = new System.Drawing.Size(60, 13);
            this.IAddress.TabIndex = 45;
            this.IAddress.Text = "[Address]";
            // 
            // ICity
            // 
            this.ICity.AutoSize = true;
            this.ICity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
            this.ICity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ICity.Location = new System.Drawing.Point(98, 112);
            this.ICity.Name = "ICity";
            this.ICity.Size = new System.Drawing.Size(36, 13);
            this.ICity.TabIndex = 46;
            this.ICity.Text = "[City]";
            // 
            // ICode
            // 
            this.ICode.AutoSize = true;
            this.ICode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Code", true));
            this.ICode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ICode.Location = new System.Drawing.Point(98, 141);
            this.ICode.Name = "ICode";
            this.ICode.Size = new System.Drawing.Size(44, 13);
            this.ICode.TabIndex = 47;
            this.ICode.Text = "[Code]";
            // 
            // ITitle
            // 
            this.ITitle.AutoSize = true;
            this.ITitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Title", true));
            this.ITitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ITitle.Location = new System.Drawing.Point(491, 54);
            this.ITitle.Name = "ITitle";
            this.ITitle.Size = new System.Drawing.Size(40, 13);
            this.ITitle.TabIndex = 48;
            this.ITitle.Text = "[Title]";
            // 
            // IPublicationDay
            // 
            this.IPublicationDay.AutoSize = true;
            this.IPublicationDay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "PublicationDate", true));
            this.IPublicationDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IPublicationDay.Location = new System.Drawing.Point(491, 83);
            this.IPublicationDay.Name = "IPublicationDay";
            this.IPublicationDay.Size = new System.Drawing.Size(102, 13);
            this.IPublicationDay.TabIndex = 49;
            this.IPublicationDay.Text = "[Publication day]";
            // 
            // IPricePerDay
            // 
            this.IPricePerDay.AutoSize = true;
            this.IPricePerDay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "PricePerDay", true));
            this.IPricePerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IPricePerDay.Location = new System.Drawing.Point(491, 112);
            this.IPricePerDay.Name = "IPricePerDay";
            this.IPricePerDay.Size = new System.Drawing.Size(90, 13);
            this.IPricePerDay.TabIndex = 50;
            this.IPricePerDay.Text = "[Price per day]";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataSource = typeof(Interfaces.DomainModel.Book);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(Interfaces.DomainModel.Customer);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(Interfaces.DomainModel.Customer);
            // 
            // RentSave
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(876, 259);
            this.Controls.Add(this.IPricePerDay);
            this.Controls.Add(this.IPublicationDay);
            this.Controls.Add(this.ITitle);
            this.Controls.Add(this.ICode);
            this.Controls.Add(this.ICity);
            this.Controls.Add(this.IAddress);
            this.Controls.Add(this.lAuthor);
            this.Controls.Add(this.lFirstName);
            this.Controls.Add(this.lAvailableBooks);
            this.Controls.Add(this.lLastName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "FirstName", true));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "RentSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RentSave";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RentSave_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label lAvailableBooks;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lAuthor;
        private System.Windows.Forms.Label IAddress;
        private System.Windows.Forms.Label ICity;
        private System.Windows.Forms.Label ICode;
        private System.Windows.Forms.Label ITitle;
        private System.Windows.Forms.Label IPublicationDay;
        private System.Windows.Forms.Label IPricePerDay;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}