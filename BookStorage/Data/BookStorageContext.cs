using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class BookStorageContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Link_BookGenre>()
                .HasKey(t => new { t.BookId, t.GenreId });

            modelBuilder.Entity<Link_BookGenre>()
                .HasOne(pt => pt.Book)
                .WithMany(p => p.Links_BookGenre)
                .HasForeignKey(pt => pt.BookId);

            modelBuilder.Entity<Link_BookGenre>()
                .HasOne(pt => pt.Genre)
                .WithMany(t => t.Links_BookGenre)
                .HasForeignKey(pt => pt.GenreId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=BookStorage;Trusted_Connection=True;");
        }
    }
}
