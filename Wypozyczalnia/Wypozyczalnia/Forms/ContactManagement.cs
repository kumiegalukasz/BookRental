using BusinessLayer;
using Interfaces;
using Interfaces.DomainModel;
using System;
using System.Windows.Forms;

namespace Library
{
    public partial class MainForm : Form
    {
        ICustomerRepository _customerRepository;
        public MainForm(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customerBindingSource.DataSource = CustomerServices.GetByFilter(new Customer());
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            customerBindingSource.DataSource = CustomerServices.GetByFilter(new Customer()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                Code = txtCode.Text
            });
        }

        private void add_Click(object sender, EventArgs e)
        {
            using (ClientForm frm = new ClientForm(null))
            {
                frm.Text = "Add Client";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    customerBindingSource.DataSource = CustomerServices.GetByFilter(new Customer());
                    lblMessage.Text = "Add SUCCESS";
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (customerBindingSource.Current == null)
                return;
            using (ClientForm frm = new ClientForm(customerBindingSource.Current as Customer))
            {
                frm.Text = "Edit Contact";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    customerBindingSource.DataSource = CustomerServices.GetByFilter(new Customer());
                    lblMessage.Text = "Edit SUCCESS";
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (customerBindingSource.Current == null)
                return;
            
            var answer = MessageBox.Show("Are you sure want to delete this record?",
                "Mesage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            Customer customer = customerBindingSource.Current as Customer;

            bool bookExist = OrderServices.OrderExist(new Order() { CustomerId = customer.ID });
            if (bookExist)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "You can't delete the client because he has borrowed the book";
                return;
            }

            if (answer == DialogResult.Yes)
            {
                CustomerServices.Delete(customer);
                customerBindingSource.RemoveCurrent();
                lblMessage.Text = "Delete SUCCESS";
                lblMessage.ForeColor = System.Drawing.Color.ForestGreen;
            }
        }
    }
}
