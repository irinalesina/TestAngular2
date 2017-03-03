using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Business;
using Bisiness.Entities;
using Data.Entity;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class GenreController : Controller
    {
        private static GenreService _genreService = new GenreService();

        [HttpGet("[action]")]
        public IEnumerable<Genre> GetAll()
        {
            var genres = _genreService.GetAll();
            return genres;
        }

        [HttpDelete("[action]/{id}")]
        public bool Delete([FromRoute] int id)
        {
            try
            {
                _genreService.Delete(id);
                return true; ;
            }
            catch
            {
                return false;
            }
        }
    }
}
