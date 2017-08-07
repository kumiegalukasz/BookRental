using Interfaces;
using System;
using Library.Forms;

namespace Library
{
    public partial class PanelForm : MetroFramework.Forms.MetroForm
    {
        ICustomerRepository _customerRepository;
        IOrderRepository _orderRepository;

        public PanelForm(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            InitializeComponent();
        }
        public PanelForm(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
            InitializeComponent();
        }
        public PanelForm()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            using (MainForm fm = new MainForm(_customerRepository))
            {
                fm.ShowDialog();
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            using (BookManagement fm = new BookManagement())
            {
                fm.ShowDialog();
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            using (RentalManagement fm = new RentalManagement(_orderRepository))
            {
                fm.ShowDialog();
            }
        }

        private void metroTile4_Click_1(object sender, EventArgs e)
        {
            using (ReturnManagement fm = new ReturnManagement())
            {
                fm.ShowDialog();
            }
        }
    }
}
