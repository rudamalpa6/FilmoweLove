using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmoweLove.Models
{
    public class Series
    {
        public int ID { get; set; }

        public string Nazwa { get; set; }

        public int LiczbaSezonow { get; set; }

        public int Data { get; set; }

        public int Ocena { get; set; }
    }
}
