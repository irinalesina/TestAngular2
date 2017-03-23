using System.Collections.Generic;
using System.IO;
using System.Linq;
using WebApi.Data;
using WebApi.Data.Model;
using WebApi.Services.Interfaces;
using WebApi.ViewModels;


namespace WebApi.Services
{
    public class GenreService : IGenreService
    {
        private BookStorageContext _dbContext;

        public GenreService(BookStorageContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<GenreView> GetAll()
        {
            return _dbContext.Genres
                .Select(g => new GenreView()
                {
                    Id = g.Id,
                    Name = g.Name
                })
                .ToList();
        }

        public GenreView Get(int id)
        {
            return _dbContext.Genres
                .Where(g => g.Id == id)
                .Select(g => new GenreView()
                {
                    Id = g.Id,
                    Name = g.Name
                })
                .FirstOrDefault();
        }

        public void Add(Genre genre)
        {
            _dbContext.Genres.Add(genre);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            foreach (var linkBookGenre in _dbContext.Link_BookGenres.Where(l => l.GenreId == id).ToList())
            {
                _dbContext.Link_BookGenres.Remove(linkBookGenre);
                _dbContext.SaveChanges();
            }
            _dbContext.Genres.Remove(_dbContext.Genres.FirstOrDefault(g => g.Id == id));
            _dbContext.SaveChanges();
        }

        public void Update(int genreId, Genre genre)
        {
            var dbGenre = _dbContext.Genres.FirstOrDefault(g => g.Id == genreId);
            if (dbGenre == null)
            {
                throw new InvalidDataException("Genre doesn't exist.");
            }
            dbGenre.Name = genre.Name;
            _dbContext.SaveChanges();
        }
    }
}
