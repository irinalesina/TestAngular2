using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Data.Model;
using WebApi.Services.Interfaces;
using WebApi.ViewModels;


namespace WebApi.Services
{
    public class BookService : IBookService
    {
        private readonly BookStorageContext _dbContext;

        public BookService(BookStorageContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<BookView> GetAll()
        {
            var books = _dbContext.Books
                .Include(b => b.Links_BookGenre)
                .ThenInclude(b => b.Genre)
                .Select(b => new BookView()
                {
                    Id = b.Id,
                    Name = b.Name,
                    Text = b.Text,
                    Year = b.Year,
                    Genres = b.Links_BookGenre.Select(l => new GenreView()
                    {
                        Id = l.Genre.Id,
                        Name = l.Genre.Name
                    }).ToList()
                })
                .ToList();
            return books;
        }

        public BookView GetById(int id)
        {
            var book = _dbContext.Books
                .Include(b => b.Links_BookGenre)
                .ThenInclude(b => b.Genre)
                .Where(b => b.Id == id)
                .Select(b => new BookView()
                {
                    Id = b.Id,
                    Name = b.Name,
                    Text = b.Text,
                    Year = b.Year,
                    Genres = b.Links_BookGenre.Select(l => new GenreView()
                    {
                        Id = l.Genre.Id,
                        Name = l.Genre.Name
                    }).ToList()
                })
                .FirstOrDefault();
            return book;
        }

        public void Add(Book book)
        {
            //change getted model
            // add insert genres  

        }

        public void Delete(int id)
        {
            foreach (var linkBookGenre in _dbContext.Link_BookGenres.Where(l => l.BookId == id).ToList())
            {
                _dbContext.Link_BookGenres.Remove(linkBookGenre);
            }
            _dbContext.Books.Remove(_dbContext.Books.FirstOrDefault(b => b.Id == id));
        }
    }
}
