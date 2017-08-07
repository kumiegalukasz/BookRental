using Interfaces.DomainModel;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetByFilter(Book filter);

        Book GetById(int id);

        Book Insert(Book obj);

        void Update(Book obj);

        void Delete(Book obj);
    }
}
