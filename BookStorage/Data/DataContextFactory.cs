using Data;


namespace Data
{
    public sealed class DataContextFactory
    {
        private static BookStorageContext _bookStorageContext = new BookStorageContext();

        public static BookStorageContext GetBookStorageContext()
        {
            return _bookStorageContext;
        }
    }
}
