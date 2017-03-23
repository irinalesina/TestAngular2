using System.Collections.Generic;
using Bisiness.Entities;
using Business;
using Data.Entity;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private static BookService _bookService = new BookService();

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var books = _bookService.GetAll();
            return Ok(books);
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetById(int id)
        {
            var book = _bookService.GetById(id);
            return Ok(book);
        }

        [HttpDelete("[action]/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                _bookService.Delete(id);
                return Ok(); ;
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
