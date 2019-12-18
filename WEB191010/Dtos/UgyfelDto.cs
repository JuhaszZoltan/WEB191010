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
        public string Nev { get; set; }
        public DateTime? SzuletesiDatum { get; set; }
        public bool HirlevelFeliratkozas { get; set; }
        public int ElofizetesTipusId { get; set; }
    }
}