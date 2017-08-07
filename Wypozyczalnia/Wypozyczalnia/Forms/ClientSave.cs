using BusinessLayer;
using Interfaces.DomainModel;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Library
{
    public partial class ClientForm : Form
    {
        bool IsNew;

        public ClientForm(Customer obj)
        {
            InitializeComponent();
            if (obj == null)
            {
                customerBindingSource.DataSource = new Customer();
                IsNew = true;
            }
            else
            {
                customerBindingSource.DataSource = obj;
                IsNew = false;
            }
        }

        private void AddEditClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            errorProvider.Clear();
            if (DialogResult == DialogResult.OK)
            {
                Regex rx = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Regex phone = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");
                Regex code = new Regex(@"^[0-9]{2}\-[0-9]{3}$");

                if (string.IsNullOrEmpty(txtFirstNameCustomer.Text))
                {
                    e.Cancel = true;
                    txtFirstNameCustomer.Focus();
                    errorProvider.SetError(txtFirstNameCustomer, "Please enter your first name");
                    return;
                }

                 if (string.IsNullOrEmpty(txtLastNameCustomer.Text))
                {
                    e.Cancel = true;
                    txtLastNameCustomer.Focus();
                    errorProvider.SetError(txtLastNameCustomer, "Please enter your last name");
                    return;
                }

                 if (string.IsNullOrEmpty(txtAddressCustomer.Text))
                {
                    e.Cancel = true;
                    txtAddressCustomer.Focus();
                    errorProvider.SetError(txtAddressCustomer, "Please enter your address");
                    return;
                }

                 if (string.IsNullOrEmpty(txtCityCustomer.Text))
                {
                    e.Cancel = true;
                    txtCityCustomer.Focus();
                    errorProvider.SetError(txtCityCustomer, "Please enter your city");
                    return;
                }

                 if ((string.IsNullOrEmpty(txtCodeCustomer.Text)) || (!code.IsMatch(txtCodeCustomer.Text)))
                {
                    e.Cancel = true;
                    txtCodeCustomer.Focus();
                    errorProvider.SetError(txtCodeCustomer, "Please enter your code");
                    return;
                }

                 if ((string.IsNullOrEmpty(txtPhoneNumberCustomer.Text)) || (!phone.IsMatch(txtPhoneNumberCustomer.Text)))
                {
                    e.Cancel = true;
                    txtPhoneNumberCustomer.Focus();
                    errorProvider.SetError(txtPhoneNumberCustomer, "Please enter your phone number");
                    return;
                }

                 if ((string.IsNullOrEmpty(txtEmailCustomer.Text)) || (!rx.IsMatch(txtEmailCustomer.Text)))
                {
                    e.Cancel = true;
                    txtEmailCustomer.Focus();
                    errorProvider.SetError(txtEmailCustomer, "Please enter your email");
                    return;
                }

                if (IsNew)
                {
                    CustomerServices.Insert(customerBindingSource.Current as Customer);
                }
                else
                {
                    CustomerServices.Update(customerBindingSource.Current as Customer);
                }
            }
        }
    }
}
