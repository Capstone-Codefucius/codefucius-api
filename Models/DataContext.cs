using Microsoft.EntityFrameworkCore;

namespace codefucius_api.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
