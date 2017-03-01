using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPS.Business
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
