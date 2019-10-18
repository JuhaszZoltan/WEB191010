using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB191010.Models
{
    public class Ugyfel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nev { get; set; }
        public bool HirlevelFeliratkozas { get; set; }
        public ElofizetesTipus ElofizetesTipus { get; set; }

    }
}