using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEB191010.Models;

namespace WEB191010.Models
{
    public class RandomFilmViewModel
    {
        public Film Film { get; set; }
        public List<Ugyfel> Kolcsonzok { get; set; }
    }
}