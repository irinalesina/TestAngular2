using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Data.Entity
{
    [Table("Book")]
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public int Year { get; set; }
        public virtual ICollection<Link_BookGenre> Links_BookGenre { get; set; }

        public Book()
        {
            Links_BookGenre = new List<Link_BookGenre>();
        }
    }
}
