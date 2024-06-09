using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_library.Films
{
    public class Film
    {

        public int Id { get; }
        public string Name = "Movie";

        public string? Description { get; set; }
        public string? Genre { get; set; }
        public string? Director { get; set; }
        public string? ReleaseYear { get; set; }
        public int? Rating { get; set; }
        public TimeSpan? Duration { get; set; }


        public override string ToString() => $"{Id}. {Name}";

    }
}
