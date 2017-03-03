using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Entity;
using Data.Repository;

namespace Bisiness
{
    public static class RepositoryFactory
    {
        private static IRepository<Book> _bookRepository;
        private static IRepository<Genre> _genreRepository;
        private static IRepository<Link_BookGenre> _link_BookGenreRepository;
        public static IRepository<Book> BookRepository
        {
            get
            {
                if(_bookRepository == null)
                {
                    _bookRepository = new Repository<Book>();
                }
                return _bookRepository;
            }
        }

        public static IRepository<Genre> GenreRepository
        {
            get
            {
                if (_genreRepository == null)
                {
                    _genreRepository = new Repository<Genre>();
                }
                return _genreRepository;
            }
        }

        public static IRepository<Link_BookGenre> Link_BookGenreRepository
        {
            get
            {
                if (_link_BookGenreRepository == null)
                {
                    _link_BookGenreRepository = new Repository<Link_BookGenre>();
                }
                return _link_BookGenreRepository;
            }
        }
    }
}
