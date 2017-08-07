using System.Collections.Generic;
using Logic;
using Interfaces;
using Interfaces.DomainModel;

namespace BusinessLayer
{
    public static class CustomerServices
    {
        static ICustomerRepository repository;
        static CustomerServices()
        {
            repository = new CustomerRepository();
        }
        public static List<Customer> GetByFilter(Customer filter)
        {
            return repository.GetByFilter(filter);
        }
        public static Customer GetById(int id)
        {
            return repository.GetById(id);
        }
        public static Customer Insert(Customer obj)
        {
            return repository.Insert(obj);
        }
        public static void Update(Customer obj)
        {
            repository.Update(obj);
        }
        public static void Delete(Customer obj)
        {
            repository.Delete(obj);
        }
    }    
}
