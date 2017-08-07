using System;
using System.ComponentModel.DataAnnotations;

namespace Interfaces.DomainModel
{
    public class Book
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string ISBN { get; set; }

        public int PublicationDate { get; set; }

        public decimal PricePerDay { get; set; }

        public int? Quantity { get; set; }
    }
}
