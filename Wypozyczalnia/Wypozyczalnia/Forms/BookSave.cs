using BusinessLayer;
using Interfaces.DomainModel;
using System;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class BookSave : Form
    {
        bool IsNew;
        public BookSave(Book obj)
        {
            InitializeComponent();
            if (obj == null)
            {
                booksBindingSource.DataSource = new Book();
                IsNew = true;
            }
            else
            {
                booksBindingSource.DataSource = obj;
                IsNew = false;
            }
        }

        private void BookSave_FormClosing(object sender, FormClosingEventArgs e)
        {
            errorProviderBook.Clear();
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtAuthorBook.Text))
                {
                    e.Cancel = true;
                    txtAuthorBook.Focus();
                    errorProviderBook.SetError(txtAuthorBook, "Please enter your Author");
                    return;
                }
                if (string.IsNullOrEmpty(txtTitleBook.Text))
                {
                    e.Cancel = true;
                    txtTitleBook.Focus();
                    errorProviderBook.SetError(txtTitleBook, "Please enter your Title");
                    return;
                }

                if (string.IsNullOrEmpty(txtISBNBook.Text))
                {
                    e.Cancel = true;
                    txtISBNBook.Focus();
                    errorProviderBook.SetError(txtISBNBook, "Please enter your ISBN");
                    return;
                }

                if (string.IsNullOrEmpty(txtPublicationDateBook.Text))
                {
                    e.Cancel = true;
                    txtPublicationDateBook.Focus();
                    errorProviderBook.SetError(txtPublicationDateBook, "Please enter your publication date");
                    return;
                }

                if (string.IsNullOrEmpty(txtPricePerDay.Text))
                {
                    e.Cancel = true;
                    txtPricePerDay.Focus();
                    errorProviderBook.SetError(txtPricePerDay, "Please enter your price per day");
                    return;
                }

                if (string.IsNullOrEmpty(txtQuntity.Text))
                {
                    e.Cancel = true;
                    txtQuntity.Focus();
                    errorProviderBook.SetError(txtQuntity, "Please enter your quantity");
                    return;
                }

                if (IsNew)
                {
                    BookServices.Insert(booksBindingSource.Current as Book);
                }
                else
                {
                    BookServices.Update(booksBindingSource.Current as Book);
                }
            }
        }
    }
}
