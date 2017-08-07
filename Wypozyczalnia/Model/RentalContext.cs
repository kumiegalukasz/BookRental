namespace Model
{
    using System.Data.Entity;
    using Logic.Model;

    public partial class RentalContext : DbContext
    {
        public RentalContext()
            : base("data source=lukasz;initial catalog=Wypozyczalnia;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public object Order { get; internal set; }
        public virtual DbSet<Orders> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>()
                .Property(e => e.PricePerDay)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Books>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Books)
                .HasForeignKey(e => e.BookID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Code)
                .IsFixedLength();

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customers)
                .HasForeignKey(e => e.CustomerID)
                .WillCascadeOnDelete(false);
        }
    }
}
