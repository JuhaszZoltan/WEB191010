using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB191010.Models
{
    public class Min18EvesHaElofizeto : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ugyfel = (Ugyfel)validationContext.ObjectInstance;

            if(ugyfel.ElofizetesTipusId == Ugyfel.Ismeretlen || 
                ugyfel.ElofizetesTipusId == Ugyfel.Nincs)
                return ValidationResult.Success;

            if (ugyfel.SzuletesiDatum == null)
                return new ValidationResult("A születési dátum megadása kötelező!");

            var kor = DateTime.Today.Year - ugyfel.SzuletesiDatum.Value.Year;

            return (kor >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("csíra vagy még ehhez gyerek!");
        }
    }
}