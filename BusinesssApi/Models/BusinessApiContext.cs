using Microsoft.EntityFrameworkCore;

namespace BusinessApi.Models
{
  public class BusinessApiContext : DbContext
  {
    public DbSet<Business> Businesses { get; set; }

    public BusinessApiContext(DbContextOptions<BusinessApiContext> options) : base(options)
    {
    }
  }
}
