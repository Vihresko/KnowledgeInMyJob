using KIJ.Data.DBModels;
using Microsoft.EntityFrameworkCore;

namespace KIJ.Data.DBContexts
{
    public class DbContextSQL : DbContext
    {
        public DbContextSQL(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Algorithm> Algorithmes { get; set; }
    }
}
