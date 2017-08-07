namespace Library.Forms
{
    partial class ReturnSave
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.IFirstName = new System.Windows.Forms.Label();
            this.ILastName = new System.Windows.Forms.Label();
            this.IAddress = new System.Windows.Forms.Label();
            this.ICity = new System.Windows.Forms.Label();
            this.ICode = new System.Windows.Forms.Label();
            this.IEmail = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.ITitle = new System.Windows.Forms.Label();
            this.IISBN = new System.Windows.Forms.Label();
            this.IPricePerDay = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lTotalPrice = new System.Windows.Forms.Label();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(445, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Author:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Title:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "ISBN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(330, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Price per day:";
            // 
            // IFirstName
            // 
            this.IFirstName.AutoSize = true;
            this.IFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "FirstName", true));
            this.IFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IFirstName.Location = new System.Drawing.Point(90, 41);
            this.IFirstName.Name = "IFirstName";
            this.IFirstName.Size = new System.Drawing.Size(73, 13);
            this.IFirstName.TabIndex = 21;
            this.IFirstName.Text = "[First name]";
            // 
            // ILastName
            // 
            this.ILastName.AutoSize = true;
            this.ILastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "LastName", true));
            this.ILastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ILastName.Location = new System.Drawing.Point(91, 73);
            this.ILastName.Name = "ILastName";
            this.ILastName.Size = new System.Drawing.Size(73, 13);
            this.ILastName.TabIndex = 22;
            this.ILastName.Text = "[Last name]";
            // 
            // IAddress
            // 
            this.IAddress.AutoSize = true;
            this.IAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "Address", true));
            this.IAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IAddress.Location = new System.Drawing.Point(90, 105);
            this.IAddress.Name = "IAddress";
            this.IAddress.Size = new System.Drawing.Size(60, 13);
            this.IAddress.TabIndex = 23;
            this.IAddress.Text = "[Address]";
            // 
            // ICity
            // 
            this.ICity.AutoSize = true;
            this.ICity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "City", true));
            this.ICity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ICity.Location = new System.Drawing.Point(90, 133);
            this.ICity.Name = "ICity";
            this.ICity.Size = new System.Drawing.Size(36, 13);
            this.ICity.TabIndex = 24;
            this.ICity.Text = "[City]";
            // 
            // ICode
            // 
            this.ICode.AutoSize = true;
            this.ICode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "Code", true));
            this.ICode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ICode.Location = new System.Drawing.Point(90, 157);
            this.ICode.Name = "ICode";
            this.ICode.Size = new System.Drawing.Size(44, 13);
            this.ICode.TabIndex = 25;
            this.ICode.Text = "[Code]";
            // 
            // IEmail
            // 
            this.IEmail.AutoSize = true;
            this.IEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "Email", true));
            this.IEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IEmail.Location = new System.Drawing.Point(90, 185);
            this.IEmail.Name = "IEmail";
            this.IEmail.Size = new System.Drawing.Size(45, 13);
            this.IEmail.TabIndex = 26;
            this.IEmail.Text = "[Email]";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "Author", true));
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Author.Location = new System.Drawing.Point(444, 45);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(52, 13);
            this.Author.TabIndex = 27;
            this.Author.Text = "[Author]";
            // 
            // ITitle
            // 
            this.ITitle.AutoSize = true;
            this.ITitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "Title", true));
            this.ITitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ITitle.Location = new System.Drawing.Point(444, 73);
            this.ITitle.Name = "ITitle";
            this.ITitle.Size = new System.Drawing.Size(40, 13);
            this.ITitle.TabIndex = 28;
            this.ITitle.Text = "[Title]";
            // 
            // IISBN
            // 
            this.IISBN.AutoSize = true;
            this.IISBN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ISBN", true));
            this.IISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IISBN.Location = new System.Drawing.Point(444, 105);
            this.IISBN.Name = "IISBN";
            this.IISBN.Size = new System.Drawing.Size(44, 13);
            this.IISBN.TabIndex = 29;
            this.IISBN.Text = "[ISBN]";
            // 
            // IPricePerDay
            // 
            this.IPricePerDay.AutoSize = true;
            this.IPricePerDay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "PricePerDay", true));
            this.IPricePerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IPricePerDay.Location = new System.Drawing.Point(444, 133);
            this.IPricePerDay.Name = "IPricePerDay";
            this.IPricePerDay.Size = new System.Drawing.Size(90, 13);
            this.IPricePerDay.TabIndex = 30;
            this.IPricePerDay.Text = "[Price per day]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(330, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Total Price [PLN]:";
            // 
            // lTotalPrice
            // 
            this.lTotalPrice.AutoSize = true;
            this.lTotalPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "TotalPrice", true));
            this.lTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lTotalPrice.Location = new System.Drawing.Point(444, 157);
            this.lTotalPrice.Name = "lTotalPrice";
            this.lTotalPrice.Size = new System.Drawing.Size(76, 13);
            this.lTotalPrice.TabIndex = 32;
            this.lTotalPrice.Text = "[Total price]";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(Interfaces.DomainModel.Order);
            // 
            // ReturnSave
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(547, 269);
            this.Controls.Add(this.lTotalPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.IPricePerDay);
            this.Controls.Add(this.IISBN);
            this.Controls.Add(this.ITitle);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.IEmail);
            this.Controls.Add(this.ICode);
            this.Controls.Add(this.ICity);
            this.Controls.Add(this.IAddress);
            this.Controls.Add(this.ILastName);
            this.Controls.Add(this.IFirstName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ReturnSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReturnSave";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReturnSave_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label IFirstName;
        private System.Windows.Forms.Label ILastName;
        private System.Windows.Forms.Label IAddress;
        private System.Windows.Forms.Label ICity;
        private System.Windows.Forms.Label ICode;
        private System.Windows.Forms.Label IEmail;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label ITitle;
        private System.Windows.Forms.Label IISBN;
        private System.Windows.Forms.Label IPricePerDay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lTotalPrice;
    }
}