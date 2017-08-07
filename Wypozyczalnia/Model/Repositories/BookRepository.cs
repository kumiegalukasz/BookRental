using System.Collections.Generic;
using System.Linq;
using Interfaces;
using Model;
using Interfaces.DomainModel;
using Logic.Model;

namespace Logic
{
    public class BookRepository: IBookRepository
    {
        RentalContext db = new RentalContext();

        public void Delete(Book obj)
        {
            var entity = db.Books.Where(a => a.ID == obj.ID).FirstOrDefault();

            db.Books.Remove(entity);
            db.SaveChanges();
        }

        public List<Book> GetByFilter(Book filter)
        {
            IQueryable<Books> query = db.Books;

            if(!string.IsNullOrEmpty(filter.Author))
            {
                query = db.Books.Where(a => a.Author.Contains(filter.Author));
            }

            if (!string.IsNullOrEmpty(filter.Title))
            {
                query = db.Books.Where(a => a.Title.Contains(filter.Title));
            }

            if (!string.IsNullOrEmpty(filter.ISBN))
            {
                query = db.Books.Where(a => a.ISBN.Contains(filter.ISBN));
            }

            return query.Select(a => new Book()
            {
                ID = a.ID,
                Author = a.Author,
                ISBN = a.ISBN,
                PricePerDay = a.PricePerDay,
                PublicationDate = a.PublicationDate,
                Quantity = a.Quantity,
                Title = a.Title
            }).ToList();
        }

        public Book GetById(int id)
        {
            return db.Books.Where(a => a.ID == id)
                .Select(a => new Book()
                {
                    ID = a.ID,
                    Author = a.Author,
                    ISBN = a.ISBN,
                    PricePerDay = a.PricePerDay,
                    PublicationDate = a.PublicationDate,
                    Quantity = a.Quantity,
                    Title = a.Title
                }).FirstOrDefault();
        }

        public Book Insert(Book obj)
        {
            db.Books.Add(new Books()
            {
                Author = obj.Author,
                ISBN = obj.ISBN,
                PricePerDay = obj.PricePerDay,
                PublicationDate = obj.PublicationDate,
                Quantity = obj.Quantity,
                Title = obj.Title
            });

            db.SaveChanges();
            return obj;
        }

        public void Update(Book obj)
        {
            var entity = db.Books.Where(a => a.ID == obj.ID).FirstOrDefault();

            entity.Author = obj.Author;
            entity.ISBN = obj.ISBN;
            entity.PricePerDay = obj.PricePerDay;
            entity.PublicationDate = obj.PublicationDate;
            entity.Quantity = obj.Quantity;
            entity.Title = obj.Title;

            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
