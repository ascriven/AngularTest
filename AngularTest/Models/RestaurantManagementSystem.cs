namespace AngularTest
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantManagementSystem : DbContext
    {
        public RestaurantManagementSystem()
            : base("name=RestaurantManagementSystem")
        {
        }

        public virtual DbSet<MenuItem> MenuItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuItem>()
                .Property(e => e.Price)
                .HasPrecision(18, 6);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.Cost)
                .HasPrecision(18, 6);
        }
    }
}
