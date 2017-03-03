using System.Collections.Generic;
using Bisiness.Entities;
using Data.Entity;

namespace Business.Interfaces
{
    public interface IGenreService
    {
        List<Genre> GetAll();
        Genre Get(int id);
        void Add(Genre genre);
        void Delete(int id);
    }
}

