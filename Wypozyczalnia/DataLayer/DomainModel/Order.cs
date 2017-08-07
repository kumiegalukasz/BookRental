using System;

namespace Interfaces.DomainModel
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime DateOfRental { get; set; }

        public string Author { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public decimal PricePerDay { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Code { get; set; }

        public string Email { get; set; }

        public int? Quantity { get; set; }

        public int? BookId { get; set; }

        public int? CustomerId { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
