using BusinessLayer;
using System;
using System.Windows.Forms;
using Interfaces.DomainModel;

namespace Library.Forms
{
    public partial class ReturnManagement : Form
    {
        public ReturnManagement()
        {
            InitializeComponent();
        }

        private void ReturnManagement_Load(object sender, EventArgs e)
        {           
            orderBindingSource.DataSource = OrderServices.GetBooksToReturnByFilter(new Order());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (orderBindingSource.Current == null)
                return;

            using (ReturnSave frm = new ReturnSave(orderBindingSource.Current as Order))
            {
                frm.Text = "Edit Return";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    orderBindingSource.DataSource = OrderServices.GetBooksToReturnByFilter(new Order());
                    label6.Text = "Return SUCCESS";
                }
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = OrderServices.GetByFilter(new Order()
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
