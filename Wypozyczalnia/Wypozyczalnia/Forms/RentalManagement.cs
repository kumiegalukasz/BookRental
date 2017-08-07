using BusinessLayer;
using Interfaces;
using Interfaces.DomainModel;
using System;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class RentalManagement : Form
    {
        IOrderRepository _orderRepository;
        public RentalManagement(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
            InitializeComponent();
        }

        private void RentalManagement_Load(object sender, EventArgs e)
        {
            booksBindingSource.DataSource = OrderServices.GetBooksToRentByFilter(new Book());
            customersBindingSource.DataSource = CustomerServices.GetByFilter(new Customer());
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            using (RentSave frm = new RentSave(customersBindingSource.Current as Customer,
                booksBindingSource.Current as Book))
            {
                frm.Text = "Add Rent";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    booksBindingSource.DataSource = OrderServices.GetBooksToRentByFilter(new Book());
                    label9.Text = "Rent a book SUCCESS";
                }
            }
        }

        private void orderFilter_TextChanged(object sender, EventArgs e)
        {
           booksBindingSource.DataSource = OrderServices.GetBooksToRentByFilter(new Book()
            {
                Author = txtAuthor.Text,
                Title = txtTitle.Text,
                ISBN = txtISBN.Text
            });

            customersBindingSource.DataSource = OrderServices.GetCustomersToRentByFilter(new Customer()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                Code = txtCode.Text
            });
        }
    }
}
