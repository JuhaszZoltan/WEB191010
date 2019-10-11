using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB191010.Models
{
    public class Ugyfel
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public bool HirlevelFeliratkozas { get; set; }
        public ElofizetesTipus ElofizetesTipus { get; set; }

    }
}