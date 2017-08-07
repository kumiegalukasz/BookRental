namespace Logic.Model
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Orders
    {
        public int ID { get; set; }

        public int CustomerID { get; set; }

        public int BookID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DateOfRental { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateOfReturn { get; set; }

        //public int? Quantity { get; set; }

        public virtual Books Books { get; set; }

        public virtual Customers Customers { get; set; }
    }
}
