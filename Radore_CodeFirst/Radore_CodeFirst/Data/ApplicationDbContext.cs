using Microsoft.EntityFrameworkCore;
using Radore_CodeFirst.Models;

namespace Radore_CodeFirst.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Türediğimiz classın constructorına base ile parametre gönderiyoruz.
        // Application Db Context classımız databasedeki her tablodan sorumlu olacak.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        public DbSet<Kitap> Kitap { get; set; }
    }
}
