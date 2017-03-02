using Data;
using Microsoft.EntityFrameworkCore;

namespace IPS.Business
{
    public sealed class DataContextFactory
    {
        private static BookStorageContext _bookStorageContext = new BookStorageContext();
        //static DataContextFactory()
        //{
        //    var optionsBuilder = new DbContextOptionsBuilder<BookStorageContext>();
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BookStorage;Trusted_Connection=True;");
        //    _bookStorageContext = new BookStorageContext(optionsBuilder.Options);
        //}
        public static BookStorageContext GetBookStorageContext()
        {
            return _bookStorageContext;
        }
    }
}
