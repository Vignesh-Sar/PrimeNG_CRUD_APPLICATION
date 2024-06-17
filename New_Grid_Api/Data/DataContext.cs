

using Microsoft.EntityFrameworkCore;
using New_Grid_Api.Model;

namespace New_Grid_Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Product> product_Details{get;set;}
    }
}
