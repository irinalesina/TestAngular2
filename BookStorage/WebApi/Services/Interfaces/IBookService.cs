using System.Collections.Generic;
using WebApi.Data.Model;
using WebApi.ViewModels;


namespace WebApi.Services.Interfaces
{
    public interface IBookService
    {
        List<BookView> GetAll();
        BookView GetById(int id);
        void Add(Book book);
        void Delete(int id);
    }
}
