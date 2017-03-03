using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Link_BookGenre
    {
        public int BookId { get; set; }
        public int GenreId { get; set; }
    }
}
