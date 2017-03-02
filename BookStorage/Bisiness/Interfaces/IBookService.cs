using Data.Entity;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book Get(int id);
        void Add(Book book);
        void Delete(int id);
    }
}
