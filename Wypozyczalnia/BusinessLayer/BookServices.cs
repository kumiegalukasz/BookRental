using System.Collections.Generic;
using Logic;
using Interfaces;
using Interfaces.DomainModel;

namespace BusinessLayer
{
    public static class BookServices
    {
        static IBookRepository bRepository;
        static BookServices()
        {
            bRepository = new BookRepository();
        }
        public static List<Book> GetByFilter(Book filter)
        {
            return bRepository.GetByFilter(filter);
        }
        public static Book GetById(int id)
        {
            return bRepository.GetById(id);
        }
        public static Book Insert(Book obj)
        {
            return bRepository.Insert(obj);
        }
        public static void Update(Book obj)
        {
            bRepository.Update(obj);
        }
        public static void Delete(Book obj)
        {
            bRepository.Delete(obj);
        }
    }
}
