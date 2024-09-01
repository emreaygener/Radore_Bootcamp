using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Radore_Identity.Models;

namespace Radore_Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
