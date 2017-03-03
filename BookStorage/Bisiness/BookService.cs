using Business.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Data.Entity;
using Data.Repository;
using Bisiness;
using Bisiness.Entities;


namespace Business
{
    public class BookService : IBookService
    {
        IRepository<Book> _bookRepository = RepositoryFactory.BookRepository;
        IRepository<Link_BookGenre> _link_BookGenreRepository = RepositoryFactory.Link_BookGenreRepository;
        IRepository<Genre> _genreRepository = RepositoryFactory.GenreRepository;

        public List<BookView> GetAll()
        {
            var books = _bookRepository.GetAll().ToList()
                .Join(_link_BookGenreRepository.GetAll(), b => b.Id, lbg => lbg.BookId, (b, lbg) => new { book = b, genreId = lbg.GenreId })
                .Join(_genreRepository.GetAll(), b => b.genreId, g => g.Id, (b, g) => new { book = b.book, genre = g })
                .GroupBy(b => b.book, b => b.genre)
                .Select(b => new BookView()
                {
                    Id = b.Key.Id,
                    Name = b.Key.Name,
                    Text = b.Key.Text,
                    Year = b.Key.Year,
                    Genres = b.Select(genre => genre.Name).ToList()
                })
                .ToList();
            return books;
        }

        public Book Get(int id)
        {
            return _bookRepository.Get(id);
        }

        public void Add(Book book)
        {
            //change getted model
            try
            {
                _bookRepository.Insert(book);
                // add insert genres
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
                foreach (var linkBookGenre in _link_BookGenreRepository.GetAll().Where(l => l.BookId == id).ToList())
                {
                    _link_BookGenreRepository.Delete(linkBookGenre);
                }
                _bookRepository.Delete(_bookRepository.Get(id));
            }
            catch 
            {
                throw;
            }
        }
    }
}
