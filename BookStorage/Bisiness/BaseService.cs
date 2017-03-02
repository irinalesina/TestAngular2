using Data;
using IPS.Business;

namespace Business
{
    public class BaseService
    {
        protected BookStorageContext _bookStorageContext { get; set; }
        public BaseService()
        {
            _bookStorageContext = DataContextFactory.GetBookStorageContext();
        }
    }
}
