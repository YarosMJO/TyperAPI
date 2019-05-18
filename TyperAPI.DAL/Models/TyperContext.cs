using Microsoft.EntityFrameworkCore;

namespace TyperAPI.DAL.Models
{
    public sealed class TyperContext : DbContext
    {
        public TyperContext(DbContextOptions<TyperContext> options) :
            base(options)
        { }
        public TyperContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(p => p.Scores);

            modelBuilder.Entity<Score>()
                .HasOne(p => p.User);

            modelBuilder.Entity<Word>();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Word> Words { get; set; }
    }
}
