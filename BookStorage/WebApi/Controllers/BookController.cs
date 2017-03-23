using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Services.Interfaces;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

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
