using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class BookStorageContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Link_BookGenre> Link_BookGenres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasKey(q => q.Id);
            modelBuilder.Entity<Genre>().HasKey(q => q.Id);
            modelBuilder.Entity<Link_BookGenre>().HasKey(q => q.Id);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=BookStorage;Trusted_Connection=True;");
        }
    }

}