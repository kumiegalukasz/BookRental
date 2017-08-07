using System.Collections.Generic;
using Interfaces;
using Model;
using Interfaces.DomainModel;
using System;
using Logic.Model;
using System.Linq;

namespace Logic
{
    public class CustomerRepository : ICustomerRepository
    {
        RentalContext db = new RentalContext();

        public void Delete(Customer obj)
        {
            var entity = db.Customers.Where(a => a.ID == obj.ID).FirstOrDefault();

            db.Customers.Remove(entity);
            db.SaveChanges();
        }

        public List<Customer> GetByFilter(Customer filter)
        {
            IQueryable<Customers> query = db.Customers;

            if (!string.IsNullOrEmpty(filter.FirstName))
            {
                query = db.Customers.Where(a => a.FirstName.Contains(filter.FirstName));
            }

            if (!string.IsNullOrEmpty(filter.LastName))
            {
                query = db.Customers.Where(a => a.LastName.Contains(filter.LastName));
            }

            if (!string.IsNullOrEmpty(filter.Address))
            {
                query = db.Customers.Where(a => a.Address.Contains(filter.Address));
            }

            if (!string.IsNullOrEmpty(filter.City))
            {
                query = db.Customers.Where(a => a.City.Contains(filter.City));
            }

            if (!string.IsNullOrEmpty(filter.Code))
            {
                query = db.Customers.Where(a => a.Code.Contains(filter.Code));
            }

            return query.Select(a => new Customer()
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

        public Customer GetById(int id)
        {
            return db.Customers.Where(a => a.ID == id)
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
               }).FirstOrDefault();
        }

        public Customer Insert(Customer obj)
        {
            db.Customers.Add(new Customers()
            {
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                Address = obj.Address,
                City = obj.City,
                Code = obj.Code,
                Email = obj.Email,
                PhoneNumber = obj.PhoneNumber
            });

            db.SaveChanges();
            return obj;
        }

        public void Update(Customer obj)
        {
            var entity = db.Customers.Where(a => a.ID == obj.ID).FirstOrDefault();

            entity.FirstName = obj.FirstName;
            entity.LastName = obj.LastName;
            entity.Address = obj.Address;
            entity.City = obj.City;
            entity.Code = obj.Code;
            entity.Email = obj.Email;
            entity.PhoneNumber = obj.PhoneNumber;

            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
