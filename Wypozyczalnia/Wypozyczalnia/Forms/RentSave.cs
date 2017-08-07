using BusinessLayer;
using System;
using System.Windows.Forms;
using Interfaces.DomainModel;

namespace Library.Forms
{
    public partial class RentSave : Form
    {
        public RentSave(Customer customer, Book book)
        {
            InitializeComponent();

            customersBindingSource.DataSource = customer;
            booksBindingSource.DataSource = book;
        }

        private void RentSave_FormClosing(object sender, FormClosingEventArgs e)
        {
            errorProvider1.Clear();
            if (DialogResult == DialogResult.OK)
            {
                int number;
                var bookToRent = booksBindingSource.Current as Book;
                var customer = customersBindingSource.Current as Customer;
                Int32.TryParse(txtQuantity.Text, out number);
                if (number > bookToRent.Quantity)
                {
                    e.Cancel = true;
                    txtQuantity.Focus();
                    errorProvider1.SetError(txtQuantity, "Not enough books");
                    return;
                }
                else if (number == 0)
                {
                    e.Cancel = true;
                    txtQuantity.Focus();
                    errorProvider1.SetError(txtQuantity, "Type the number of books");
                    return;
                }
                else
                {
                    OrderServices.Insert(bookToRent.ID, customer.ID, number);
                }
            }
        }
    }
}
