using Interfaces.DomainModel;
using System.Collections.Generic;

namespace Interfaces
{
   public interface ICustomerRepository
    {
        List<Customer> GetByFilter(Customer filter);

        Customer GetById(int id);

        Customer Insert(Customer obj);

        void Update(Customer obj);

        void Delete(Customer obj);
    }
}
