using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Data.Entity;

namespace Business
{
    public class BookService : BaseService, IBookService
    {
        public List<Book> GetAll()
        {
            return _bookStorageContext.Books.ToList();
        }

        public Book Get(int id)
        {
            return _bookStorageContext.Books.Where(b => b.Id == id).FirstOrDefault();
        }

        public void Add(Book book)
        {
            if (_bookStorageContext.Books.Any(b => b.Id == book.Id))
            {
                throw new InvalidOperationException("Book already exist");
            }

            book.Id = 0;
            //var genres = book.Genres;
            //book.Genres.Clear();
            _bookStorageContext.Books.Add(book);
            _bookStorageContext.SaveChanges();

            //if (genres != null && genres.Count > 0)
            //{
            //    foreach (var genre in genres)
            //    {
            //        var dbGenre = _bookStorageContext.Genres.Where(g => g.Id == genre.Id).FirstOrDefault();
            //        if (dbGenre == null)
            //        {
            //            _bookStorageContext.Genres.Add(genre);
            //            _bookStorageContext.SaveChanges();
            //            dbGenre = genre;
            //        }
            //        book.Genres.Add(genre);
            //    }
            //}
            //_bookStorageContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var dbBook = _bookStorageContext.Genres.Where(b => b.Id == id).FirstOrDefault();
            if (dbBook == null)
            {
                throw new InvalidOperationException("Book dousn't exist");
            }
            _bookStorageContext.Genres.Remove(dbBook);
        }
    }
}
