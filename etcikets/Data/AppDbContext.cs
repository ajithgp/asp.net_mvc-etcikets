using etcikets.Models;
using Microsoft.EntityFrameworkCore;

namespace etcikets.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)   
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movies>().HasKey(am => new
            {
                am.MovieId,
                am.ActorId
            });

            modelBuilder.Entity<Actor_Movies>().HasOne(m => m.Movie).WithMany(am => am.Actors).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movies>().HasOne(m => m.Actor).WithMany(am => am.Movies).HasForeignKey(m => m.ActorId);
        }

        public DbSet<Actor> Actors;
        public DbSet<Producer> Producers;
        public DbSet<Actor_Movies> Actor_Movie;
        public DbSet<Cinema> Cinemas;
        public DbSet<Movie> Movies;

    }
}
