using Business.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Data.Entity;
using Data.Repository;
using Bisiness;
using Bisiness.Entities;
using Microsoft.EntityFrameworkCore;


namespace Business
{
    public class BookService : IBookService
    {
        private IRepository<Book> _bookRepository;
        private IRepository<Link_BookGenre> _link_BookGenreRepository;

        public BookService(IRepository<Book> bookRepository, IRepository<Link_BookGenre> link_BookGenreRepository)
        {
            _bookRepository = bookRepository;
            _link_BookGenreRepository = link_BookGenreRepository;
        }

        public List<BookView> GetAll()
        {
            var books = _bookRepository.GetAll()
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
            var book = _bookRepository.GetAll()
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
            _bookRepository.Insert(book);
            // add insert genres  

        }

        public void Delete(int id)
        {
            foreach (var linkBookGenre in _link_BookGenreRepository.GetAll().Where(l => l.BookId == id).ToList())
            {
                _link_BookGenreRepository.Delete(linkBookGenre);
            }
            _bookRepository.Delete(_bookRepository.Get(id));
        }
    }
}
