using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmoweLove.Models
{
    public class Movie
    {
        public int ID { get; set; }

        public string Nazwa { get; set; }

        public string Dlugosc { get; set; }

        public int? Data { get; set; }

        public int? Ocena { get; set; }

    }
}
