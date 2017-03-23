using System.ComponentModel.DataAnnotations.Schema;


namespace Data.Entity
{
    [Table("Link_BookGenre")]
    public class Link_BookGenre : BaseEntity
    {
        public int BookId { get; set; }
        public int GenreId { get; set; }

        public Book Book { get; set; }
        public Genre Genre { get; set; }
    }
}
