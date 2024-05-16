using Microsoft.EntityFrameworkCore;

namespace Laboratorium_4_2.Components
{
    public class MovieDB : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public MovieDB()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=movie.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                           new Movie { Id = 1, Title = "The Shawshank Redemption", Description = "Two", Rate = 7 },
                           new Movie { Id = 2, Title = "Baby Shark", Description = "No no no", Rate = 4 },
                           new Movie { Id = 3, Title = "The Challengers", Description = "No", Rate = 5 });
        }
    }
}
