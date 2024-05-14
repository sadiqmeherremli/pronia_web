using Microsoft.EntityFrameworkCore;
using pronia_web.Models;
using System.CodeDom;

namespace pronia_web.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
       public DbSet<Category> Categories { get; set; }
       public DbSet<Product> Products  { get; set; }

}
}
