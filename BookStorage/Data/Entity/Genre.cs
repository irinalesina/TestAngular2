using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entity
{
    [Table("Genre")]
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
    }
}
