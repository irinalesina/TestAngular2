using System;
using System.Collections.Generic;


namespace Data.Entity
{
    public class Book
    {
        public Book()
        {
            this.Genres = new HashSet<Genre>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Year { get; set; }

        public virtual ICollection<Genre> Genres { get; set; }
    }
}
