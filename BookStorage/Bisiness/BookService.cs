using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Data.Entity;
using Data.Repository;
using Bisiness;

namespace Business
{
    public class BookService : IBookService
    {
        IRepository<Book> _bookRepository = RepositoryFactory.BookRepository;
        public List<Book> GetAll()
        {
            var books = _bookRepository.GetAll().ToList();
            return books;
        }

        public Book Get(int id)
        {
            return _bookRepository.Get(id);
        }

        public void Add(Book book)
        {
            try
            {
                _bookRepository.Insert(book);
            }
            catch
            {
                throw;
            }

            //var genres = book.Genres;
            //book.Genres.Clear();

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
            try
            {
                _bookRepository.Delete(_bookRepository.Get(id));
            }
            catch
            {
                throw;
            }
        }
    }
}
