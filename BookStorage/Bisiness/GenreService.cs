using Business.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Data.Entity;
using Data.Repository;
using Bisiness;
using Bisiness.Entities;


namespace Business
{
    public class GenreService : IGenreService
    {
        IRepository<Genre> _genreRepository = RepositoryFactory.GenreRepository;

        public List<Genre> GetAll()
        {
            return _genreRepository.GetAll().ToList();
        }

        public Genre Get(int id)
        {
            return _genreRepository.Get(id);
        }

        public void Add(Genre genre)
        {
            try
            {
                _genreRepository.Insert(genre);
            }
            catch
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                _genreRepository.Delete(_genreRepository.Get(id));
            }
            catch
            {
                throw;
            }
        }
    }
}
