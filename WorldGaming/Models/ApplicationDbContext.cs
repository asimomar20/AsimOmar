using Microsoft.EntityFrameworkCore;
using WorldGaming.Models.Data;

namespace WorldGaming.Models.Data
{
    public class ApplicationDbContext : DbContext
    {

        // اكواد ثابتة 

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        // وسيط بين الفريم ورك والجداول تبعي 

        public DbSet<Products> products { get; set; }

        public DbSet<ProductDet> productsDet { get; set; }
    }


}
