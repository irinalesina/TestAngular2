using System;
using Business.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Data.Entity;
using Data.Repository;
using Bisiness;
using Bisiness.Entities;


namespace Business
{
    public class GenreService : IGenreService
    {
        private IRepository<Genre> _genreRepository = RepositoryFactory.GenreRepository;
        private IRepository<Link_BookGenre> _link_BookGenreRepository = RepositoryFactory.Link_BookGenreRepository;

        public List<GenreView> GetAll()
        {
            return _genreRepository.GetAll()
                .Select(g => new GenreView()
                {
                    Id = g.Id,
                    Name = g.Name
                })
                .ToList();
        }

        public GenreView Get(int id)
        {
            return _genreRepository.GetAll()
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
            _genreRepository.Insert(genre);
        }

        public void Delete(int id)
        {
            foreach (var linkBookGenre in _link_BookGenreRepository.GetAll().Where(l => l.GenreId == id).ToList())
            {
                _link_BookGenreRepository.Delete(linkBookGenre);
            }
            _genreRepository.Delete(_genreRepository.Get(id));
        }

        public void Update(int genreId, Genre genre)
        {
            var dbGenre = _genreRepository.Get(genreId);
            if (dbGenre == null)
            {
                throw new InvalidDataException("Genre doesn't exist.");
            }
            dbGenre.Name = genre.Name;
            _genreRepository.Update(dbGenre);
        }
    }
}
