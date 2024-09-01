using Microsoft.EntityFrameworkCore;

namespace Article.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Article>().HasData(
                new Models.Article
                {
                    Id = 1,
                    Title = "Article 1",
                    LastUpdate = DateTime.Now,
                    WriterId = 1
                },
                new Models.Article
                {
                    Id = 2,
                    Title = "Article 2",
                    LastUpdate = DateTime.Now,
                    WriterId = 2
                },
                new Models.Article
                {
                    Id = 3,
                    Title = "Article 3",
                    LastUpdate = DateTime.Now,
                    WriterId = 3
                }
            );
        }
    }
}
