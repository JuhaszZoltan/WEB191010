using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WEB191010.Models;

namespace WEB191010.Dtos
{
    public class UgyfelDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A név megadása kötelező!")]
        [StringLength(50)]
        public string Nev { get; set; }
        [Min18EvesHaElofizeto]
        public DateTime? SzuletesiDatum { get; set; }
        public bool HirlevelFeliratkozas { get; set; }

        [Required(ErrorMessage = "Válassz előfizetés típust!")]
        public int ElofizetesTipusId { get; set; }
    }
}