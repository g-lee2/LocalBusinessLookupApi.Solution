using Microsoft.EntityFrameworkCore;

namespace BusinessApi.Models
{
  public class BusinessApiContext : DbContext
  {
    public DbSet<Business> Businesses { get; set; }

    public BusinessApiContext(DbContextOptions<BusinessApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
        .HasData(
          new Business { BusinessId = 1, Name = "Starz Restaurant", Address = "123 Moole Street", Description = "Fancy american restaurant", Rating = 4.6, Review = "Pricy and need to make reservations" },
          new Business { BusinessId = 2, Name = "Rexie's Bookstore", Address = "124 Moole Street", Description = "Antique bookstore", Rating = 3.1, Review = "Not a lot of books" },
          new Business { BusinessId = 3, Name = "Matilda Jewlers", Address = "125 Moole Street", Description = "Local handmande jewlery shop", Rating = 5.0, Review = "Has a variety of jewlery and can customize" },
          new Business { BusinessId = 4, Name = "Pip's Ice Cream", Address = "126 Moole Street", Description = "Unique ice cream flavor shop", Rating = 4.1, Review = "Can try all flavors" },
          new Business { BusinessId = 5, Name = "Over the Sea", Address = "127 Moole Street", Description = "Pet Shop", Rating = 2.5, Review = "Employee don't help out" }
        );
    }
  }
}
