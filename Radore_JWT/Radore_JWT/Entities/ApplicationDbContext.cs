using Microsoft.EntityFrameworkCore;

namespace Radore_JWT.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("Data Source=jwtSampleRadore.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser { Id = 1, FirstName = "test", Username = "testUser", Password = "testPassword" }
            );
    }
}
