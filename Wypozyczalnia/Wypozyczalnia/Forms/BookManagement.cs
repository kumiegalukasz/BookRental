using BusinessLayer;
using System;
using System.Windows.Forms;
using Library.Forms;
using Interfaces;
using Interfaces.DomainModel;

namespace Library
{
    public partial class BookManagement : Form
    {
        private IBookRepository _bookRepository;

        public BookManagement()
        {
            InitializeComponent();
        }

        public BookManagement(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        private void BookManagement_Load(object sender, EventArgs e)
        {
                booksBindingSource.DataSource = BookServices.GetByFilter(new Book());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (BookSave frm = new BookSave(null))
            {
                frm.Text = "Add Book";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    booksBindingSource.DataSource = BookServices.GetByFilter(new Book());
                    lblMessage.Text = "Add SUCCESS";
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (booksBindingSource.Current == null)
                return;

            using (BookSave frm = new BookSave(booksBindingSource.Current as Book))
            {
                frm.Text = "Edit Book";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    booksBindingSource.DataSource = BookServices.GetByFilter(new Book());
                    lblMessage.Text = "Edit SUCCESS";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (booksBindingSource.Current == null)
                return;

            var answer = MessageBox.Show("Are you sure want to delete this record?",
                "Mesage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            Book book = booksBindingSource.Current as Book;
            
            bool bookExist = OrderServices.OrderExist(new Order() { BookId = book.ID });

            if(bookExist)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Can not delete because the book is in use";
                return;
            }
            
            if (answer == DialogResult.Yes)
            {
                BookServices.Delete(book);
                booksBindingSource.RemoveCurrent();
                lblMessage.Text = "Delete SUCCESS";
                lblMessage.ForeColor = System.Drawing.Color.ForestGreen;
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            booksBindingSource.DataSource = BookServices.GetByFilter(new Book()
            {
                Author = txtAuthor.Text,
                Title = txtTitle.Text,
                ISBN = txtISBN.Text
            });
        }
    }
}
