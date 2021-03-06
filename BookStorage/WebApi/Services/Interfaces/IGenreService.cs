﻿using System.Collections.Generic;
using WebApi.Data.Model;
using WebApi.ViewModels;


namespace WebApi.Services.Interfaces
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

