using System.Collections.Generic;
using Bisiness.Entities;
using Business;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private static BookService _bookService = new BookService();

        [HttpGet("[action]")]
        public IEnumerable<BookView> GetAll()
        {
            var books = _bookService.GetAll();
            return books;
        }

        [HttpDelete("[action]/{id}")]
        public bool Delete([FromRoute] int id)
        {
            try
            {
                _bookService.Delete(id);
                return true; ;
            }
            catch
            {
                return false;
            }
        }
    }
}
