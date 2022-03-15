using Backend.Domain.Entities.Movie;
using Backend.Repository.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class BackendContext : DbContext
    {
        public BackendContext(DbContextOptions<BackendContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseNpgsql("server=localhost;userid=postgres;password=1910710;database=dsmovie");
        public DbSet<Movie> DbMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MovieMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
