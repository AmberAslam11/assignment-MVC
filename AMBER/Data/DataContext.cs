using AMBER.Models;
using Microsoft.EntityFrameworkCore;

namespace amber.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<login> login { get; set; }
    }
}
