using Microsoft.EntityFrameworkCore;

namespace Mission11_Edgerton.Models
{
    public class AmazonContext : DbContext
    {
        public AmazonContext(DbContextOptions<AmazonContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
    }
}
