using Microsoft.EntityFrameworkCore;

namespace PineoTest.Models
{
    public class HelloWorldContext : DbContext
    {
        public HelloWorldContext(DbContextOptions<HelloWorldContext> options)
            : base(options)
        {
        }

        public DbSet<HelloWorldItem> HelloWorldItems { get; set; }
    }
}