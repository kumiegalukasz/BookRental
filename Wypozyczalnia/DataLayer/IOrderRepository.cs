using System.Collections.Generic;
using Interfaces.DomainModel;

namespace Interfaces
{
    public interface IOrderRepository
    {
        List<Order> GetBooksToReturnByFilter(Order filter);

        List<Order> GetByFilter(Order filter);

        Order GetById(int id);

        void Insert(int bookId, int customerId, int quantity);

        void Update(Order obj);

        List<Book> GetBooksToRentByFilter(Book filter);
        List<Customer> GetCustomersToRentByFilter(Customer filter);

        bool OrderExist(Order order);
    }
}
