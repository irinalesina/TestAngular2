using System.Collections.Generic;


namespace Data.Entity
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Link_BookGenre> Links_BookGenre { get; set; }
    }
}
