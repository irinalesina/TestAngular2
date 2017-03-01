using Data.Entity;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Data
{
    public class BookStorageContext : DbContext
    {
        public BookStorageContext() : base("DbConnection") { }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
    }
}
