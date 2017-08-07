namespace Library.Forms
{
    partial class BookSave
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAuthorBook = new System.Windows.Forms.TextBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTitleBook = new System.Windows.Forms.TextBox();
            this.txtISBNBook = new System.Windows.Forms.TextBox();
            this.txtPublicationDateBook = new System.Windows.Forms.TextBox();
            this.txtPricePerDay = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProviderBook = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuntity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Author:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ISBN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Publication date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price per day:";
            // 
            // txtAuthorBook
            // 
            this.txtAuthorBook.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Author", true));
            this.txtAuthorBook.Location = new System.Drawing.Point(133, 28);
            this.txtAuthorBook.Name = "txtAuthorBook";
            this.txtAuthorBook.Size = new System.Drawing.Size(214, 20);
            this.txtAuthorBook.TabIndex = 0;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataSource = typeof(Interfaces.DomainModel.Book);
            // 
            // txtTitleBook
            // 
            this.txtTitleBook.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Title", true));
            this.txtTitleBook.Location = new System.Drawing.Point(133, 56);
            this.txtTitleBook.Name = "txtTitleBook";
            this.txtTitleBook.Size = new System.Drawing.Size(214, 20);
            this.txtTitleBook.TabIndex = 1;
            // 
            // txtISBNBook
            // 
            this.txtISBNBook.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "ISBN", true));
            this.txtISBNBook.Location = new System.Drawing.Point(133, 84);
            this.txtISBNBook.Name = "txtISBNBook";
            this.txtISBNBook.Size = new System.Drawing.Size(214, 20);
            this.txtISBNBook.TabIndex = 2;
            // 
            // txtPublicationDateBook
            // 
            this.txtPublicationDateBook.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "PublicationDate", true));
            this.txtPublicationDateBook.Location = new System.Drawing.Point(133, 112);
            this.txtPublicationDateBook.Name = "txtPublicationDateBook";
            this.txtPublicationDateBook.Size = new System.Drawing.Size(137, 20);
            this.txtPublicationDateBook.TabIndex = 3;
            // 
            // txtPricePerDay
            // 
            this.txtPricePerDay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "PricePerDay", true));
            this.txtPricePerDay.Location = new System.Drawing.Point(133, 140);
            this.txtPricePerDay.Name = "txtPricePerDay";
            this.txtPricePerDay.Size = new System.Drawing.Size(137, 20);
            this.txtPricePerDay.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(258, 215);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 33);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // errorProviderBook
            // 
            this.errorProviderBook.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quntity";
            // 
            // txtQuntity
            // 
            this.txtQuntity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Quantity", true));
            this.txtQuntity.Location = new System.Drawing.Point(133, 167);
            this.txtQuntity.Name = "txtQuntity";
            this.txtQuntity.Size = new System.Drawing.Size(100, 20);
            this.txtQuntity.TabIndex = 5;
            // 
            // BookSave
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(372, 267);
            this.Controls.Add(this.txtQuntity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPricePerDay);
            this.Controls.Add(this.txtPublicationDateBook);
            this.Controls.Add(this.txtISBNBook);
            this.Controls.Add(this.txtTitleBook);
            this.Controls.Add(this.txtAuthorBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BookSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BookSave";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookSave_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAuthorBook;
        private System.Windows.Forms.TextBox txtTitleBook;
        private System.Windows.Forms.TextBox txtISBNBook;
        private System.Windows.Forms.TextBox txtPublicationDateBook;
        private System.Windows.Forms.TextBox txtPricePerDay;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.ErrorProvider errorProviderBook;
        private System.Windows.Forms.TextBox txtQuntity;
        private System.Windows.Forms.Label label6;
    }
}