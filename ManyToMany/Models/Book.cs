using System.Collections.Generic;

namespace ManyToMany.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<BookGenre> BookGenres { get; set; }

    }
}
