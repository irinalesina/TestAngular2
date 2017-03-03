using System.ComponentModel.DataAnnotations.Schema;


namespace Data.Entity
{
    [Table("Book")]
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public int Year { get; set; }
    }
}
