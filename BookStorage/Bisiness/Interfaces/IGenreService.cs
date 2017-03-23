using System.Collections.Generic;
using Bisiness.Entities;
using Data.Entity;

namespace Business.Interfaces
{
    public interface IGenreService
    {
        List<GenreView> GetAll();
        GenreView Get(int id);
        void Add(Genre genre);
        void Delete(int id);
        void Update(int genreId, Genre genre);
    }
}

