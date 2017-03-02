using System;
using System.Collections.Generic;


namespace Data.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public int Year { get; set; }

        public List<Link_BookGenre> Links_BookGenre { get; set; }
    }
}
