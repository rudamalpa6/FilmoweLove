using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmoweLove.Models
{
    public class NewSeries
    {
        public int ID { get; set; }

        public string Nazwa_serialu { get; set; }

        public int ilosc_sezonow { get; set; }

        public int Data_wydania { get; set; }

        public string okladka { get; set; }

        public string info { get; set; }

    }
}

