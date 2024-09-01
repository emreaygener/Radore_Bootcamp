using Microsoft.EntityFrameworkCore;

namespace Writer.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Writer> Writers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Writer>().HasData(
                new Models.Writer
                {
                    Id = 1,
                    name = "Writer 1"
                },
                new Models.Writer
                {
                    Id = 2,
                    name = "Writer 2"
                },
                new Models.Writer
                {
                    Id = 3,
                    name = "Writer 3"
                }
            );

           
        }
    }
}
