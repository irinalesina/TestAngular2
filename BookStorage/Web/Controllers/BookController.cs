using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Data.Entity;
using Business;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private static BookService _bookService = new BookService();

        [HttpGet("[action]")]
        public IEnumerable<Book> GetAll()
        {
            var books = _bookService.GetAll();
            return books;
        }
    }
}
