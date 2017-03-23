using System.Collections.Generic;


namespace WebApi.ViewModels
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
