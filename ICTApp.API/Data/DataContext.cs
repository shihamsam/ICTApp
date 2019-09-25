using ICTApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ICTApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Value> Values{set; get;}

    }
}