using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Business;
using Data.Entity;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class GenreController : Controller
    {
        private static GenreService _genreService = new GenreService();


        [HttpGet("[action]")]
        public IEnumerable<Genre> GetAll()
        {
            var genres = _genreService.GetAll();
            return genres;
        }



        [HttpPost("[action]")]
        public bool AddNew([FromBody] Genre genre)
        {
            try
            {
                _genreService.Add(genre);
                return true; ;
            }
            catch
            {
                return false;
            }
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
