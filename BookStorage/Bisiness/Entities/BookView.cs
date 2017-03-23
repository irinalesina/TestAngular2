using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bisiness.Entities
{
    public class BookView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public int Year { get; set; }
        public List<GenreView> Genres { get; set; }
    }
}
