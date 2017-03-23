using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Business;
using Data.Entity;
using Bisiness.Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class GenreController : Controller
    {
        private static GenreService _genreService = new GenreService();


        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var genres = _genreService.GetAll();
            return Ok(genres);
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var genre = _genreService.Get(id);
            return Ok(genre);
        }

        [HttpPost("[action]")]
        public IActionResult AddNew([FromBody] Genre genre)
        {
            try
            {
                _genreService.Add(genre);
                return Ok(); ;
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("[action]/{id}")]
        public IActionResult Update([FromRoute]int id, [FromBody] Genre genre)
        {
            try
            {
                _genreService.Update(id, genre);
                return Ok(); ;
            }
            catch
            {
                return BadRequest();
            }
        }


        [HttpDelete("[action]/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                _genreService.Delete(id);
                return Ok(); ;
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
