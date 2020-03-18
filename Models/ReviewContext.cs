using Microsoft.EntityFrameworkCore;

namespace codefucius_api.Models
{
    public class ReviewContext : DbContext
    {
        public ReviewContext(DbContextOptions<ReviewContext> options)
            : base(options)
        {
        }

        public DbSet<Review> Reviews { get; set; }
        
    }
}
