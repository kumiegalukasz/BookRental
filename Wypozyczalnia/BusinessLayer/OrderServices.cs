using System.Collections.Generic;
using Logic;
using Interfaces;
using Interfaces.DomainModel;

namespace BusinessLayer
{
    public static class OrderServices
    {
        static IOrderRepository Orepository;
        static OrderServices()
        {
            Orepository = new OrderRepository();
        }

        public static List<Order> GetByFilter(Order filter)
        {
            return Orepository.GetByFilter(filter);
        }
        public static List<Order> GetBooksToReturnByFilter(Order filter)
        {
            return Orepository.GetBooksToReturnByFilter(filter);
        }
        public static Order GetById(int id)
        {
            return Orepository.GetById(id);
        }
        public static void Insert(int bookId, int customerId, int quantity)
        {
            Orepository.Insert(bookId, customerId, quantity);
        }
        public static void Update(Order obj)
        {
            Orepository.Update(obj);
        }

        public static List<Book> GetBooksToRentByFilter(Book filter)
        {
            return Orepository.GetBooksToRentByFilter(filter);
        }
        public static List<Customer> GetCustomersToRentByFilter(Customer filter)
        {
            return Orepository.GetCustomersToRentByFilter(filter);
        }

        public static bool OrderExist(Order order)
        {
            return Orepository.OrderExist(order);
        }
    }
}
