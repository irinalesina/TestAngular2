using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entity
{
    [Table("Genre")]
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Link_BookGenre> Links_BookGenre { get; set; }

        public Genre()
        {
            Links_BookGenre = new List<Link_BookGenre>();
        }
    }
}
