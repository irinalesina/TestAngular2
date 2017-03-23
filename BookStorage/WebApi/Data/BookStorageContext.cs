using Microsoft.EntityFrameworkCore;
using WebApi.Data.Model;


namespace WebApi.Data
{
    public class BookStorageContext : DbContext
    {
        public BookStorageContext(DbContextOptions<BookStorageContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasKey(q => q.Id);
            modelBuilder.Entity<Genre>().HasKey(q => q.Id);
            modelBuilder.Entity<Link_BookGenre>().HasKey(q => q.Id);
        }


        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Link_BookGenre> Link_BookGenres { get; set; }
    }

}