using Bisiness.Entities;
using Data.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IBookService
    {
        List<BookView> GetAll();
        Book Get(int id);
        void Add(Book book);
        void Delete(int id);
    }
}
