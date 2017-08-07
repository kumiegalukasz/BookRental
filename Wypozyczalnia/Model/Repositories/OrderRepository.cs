using System.Collections.Generic;
using System.Linq;
using Interfaces;
using Model;
using Interfaces.DomainModel;
using System;
using Logic.Model;

namespace Logic
{
    public class OrderRepository : IOrderRepository
    {
        RentalContext db = new RentalContext();

        public List<Order> GetBooksToReturnByFilter(Order filter)
        {           
            return db.Orders
                .Where(a=>!a.DateOfReturn.HasValue).ToList()
                .Select(a => new Order()
                {
                    FirstName = a.Customers.FirstName,
                    LastName = a.Customers.LastName,
                    Address = a.Customers.Address,
                    City = a.Customers.City,
                    Code = a.Customers.Code,
                    Email = a.Customers.Email,
                    Id = a.ID,
                    Author = a.Books.Author,
                    DateOfRental = a.DateOfRental,
                    ISBN = a.Books.ISBN,
                    Title = a.Books.Title,
                    PricePerDay = a.Books.PricePerDay,
                    TotalPrice = Convert.ToInt32((DateTime.Now - a.DateOfRental).TotalDays) * a.Books.PricePerDay
                }).ToList();
        }

        public Order GetById(int id)
        {
            return db.Orders.Where(a => a.ID == id)
                .Select(a => new Order()
                {
                    Id = a.ID,
                    Author = a.Books.Author,
                    DateOfRental = a.DateOfRental,
                    ISBN = a.Books.ISBN,
                    Title = a.Books.Title,
                    PricePerDay = a.Books.PricePerDay,
                    FirstName = a.Customers.FirstName,
                    LastName = a.Customers.LastName,
                    Email = a.Customers.Email
                })
                .FirstOrDefault();
        }

        public void Insert(int bookId, int customerId, int quantity)
        {
            List<Orders> orders = new List<Orders>();

            for(int i = 0; i < quantity; i++)
            {
                orders.Add(new Orders()
                {
                    BookID = bookId,
                    CustomerID = customerId,
                    DateOfRental = DateTime.Now    
                });
            }

            db.Orders.AddRange(orders);
            db.SaveChanges();
        }

        public void Update(Order obj)
        {
            var entity = db.Orders.Where(a => a.ID == obj.Id).FirstOrDefault();

            entity.DateOfReturn = DateTime.Now;
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public List<Book> GetBooksToRentByFilter(Book filter)
        {
            IQueryable<Books> query = db.Books;

            if(!string.IsNullOrEmpty(filter.Author))
            {
                query = query.Where(a => a.Author.Contains(filter.Author));
            }

            if (!string.IsNullOrEmpty(filter.Title))
            {
                query = query.Where(a => a.Title.Contains(filter.Title));
            }

            if (!string.IsNullOrEmpty(filter.ISBN))
            {
                query = query.Where(a => a.ISBN.Contains(filter.ISBN));
            }

            return query
                .Select(a => new Book()
                {
                    ID = a.ID,
                    Author = a.Author,
                    ISBN = a.ISBN,
                    PricePerDay = a.PricePerDay,
                    PublicationDate = a.PublicationDate,
                    Title = a.Title,
                    Quantity = a.Quantity - (db.Orders.Where(b => b.BookID == a.ID).Count() 
                    - db.Orders.Where(b => b.BookID == a.ID
                    && b.DateOfReturn.HasValue).Count())
                }).ToList();
        }

        public List<Order> GetByFilter(Order filter)
        {
            IQueryable<Orders> query = db.Orders;

            if (!string.IsNullOrEmpty(filter.FirstName))
            {
                query = query.Where(a => a.Customers.FirstName.Contains(filter.FirstName));
            }

            if (!string.IsNullOrEmpty(filter.LastName))
            {
                query = query.Where(a => a.Customers.LastName.Contains(filter.LastName));
            }

            if (!string.IsNullOrEmpty(filter.Address))
            {
                query = query.Where(a => a.Customers.Address.Contains(filter.Address));
            }

            if (!string.IsNullOrEmpty(filter.City))
            {
                query = query.Where(a => a.Customers.City.Contains(filter.City));
            }

            if (!string.IsNullOrEmpty(filter.Code))
            {
                query = query.Where(a => a.Customers.Code.Contains(filter.Code));
            }

            return query
                .Where(a => !a.DateOfReturn.HasValue).Select(a => new Order()
                {
                    FirstName = a.Customers.FirstName,
                    LastName = a.Customers.LastName,
                    Address = a.Customers.Address,
                    City = a.Customers.City,
                    Code = a.Customers.Code,
                    Email = a.Customers.Email,
                    Id = a.ID,
                    Author = a.Books.Author,
                    DateOfRental = a.DateOfRental,
                    ISBN = a.Books.ISBN,
                    Title = a.Books.Title,
                    PricePerDay = a.Books.PricePerDay
                }).ToList();
        }

        public List<Customer> GetCustomersToRentByFilter(Customer filter)
        {
            IQueryable<Customers> query = db.Customers;

            if (!string.IsNullOrEmpty(filter.FirstName))
            {
                query = query.Where(a => a.FirstName.Contains(filter.FirstName));
            }

            if (!string.IsNullOrEmpty(filter.LastName))
            {
                query = query.Where(a => a.LastName.Contains(filter.LastName));
            }

            if (!string.IsNullOrEmpty(filter.Address))
            {
                query = query.Where(a => a.Address.Contains(filter.Address));
            }

            if (!string.IsNullOrEmpty(filter.City))
            {
                query = query.Where(a => a.City.Contains(filter.City));
            }

            if (!string.IsNullOrEmpty(filter.Code))
            {
                query = query.Where(a => a.Code.Contains(filter.Code));
            }

            return query
                .Select(a => new Customer()
                {
                    ID = a.ID,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Address = a.Address,
                    City = a.City,
                    Code = a.Code,
                    Email = a.Email,
                    PhoneNumber = a.PhoneNumber
                }).ToList();
        }

        public bool OrderExist(Order order)
        {
            IQueryable<Orders> query = db.Orders;

            if(order.BookId.HasValue)
            {
                query = query.Where(a => a.BookID == order.BookId);
            }

            if(order.CustomerId.HasValue)
            {
                query = query.Where(a => a.CustomerID == order.CustomerId);
            }

            return query.FirstOrDefault() == null ? false : true;            
        }
    }
}
