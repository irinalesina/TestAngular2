using Data;
using Microsoft.EntityFrameworkCore;

namespace IPS.Business
{
    public sealed class DataContextFactory
    {
        private static BookStorageContext _bookStorageContext;
        static DataContextFactory()
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookStorageContext>();
            optionsBuilder.UseSqlServer("BookStorage.db");
            _bookStorageContext = new BookStorageContext(optionsBuilder.Options);
        }
        public static BookStorageContext GetBookStorageContext()
        {
            return _bookStorageContext;
        }
    }
}
