using BusinessLayer;
using Interfaces.DomainModel;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class ReturnSave : Form
    {
        public ReturnSave(Order obj)
        {
            InitializeComponent();

            ordersBindingSource.DataSource = obj;
        }

        private void ReturnSave_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                OrderServices.Update(ordersBindingSource.Current as Order);
            }
        }
    }
}
