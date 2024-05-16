using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Laboratorium_4_2.Components;

namespace Laboratorium_4_2.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Laboratorium_4_2.Components.Movie> Movie { get; set; } = default!;
    }
}
