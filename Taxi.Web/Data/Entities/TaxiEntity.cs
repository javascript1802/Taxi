﻿namespace Taxi.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class TaxiEntity
    { 
        public int Id { get; set; }
        [RegularExpression(@"^([A-Za-z]{3}\d{3})$", ErrorMessage = "The field {0} must starts with three characters and ends with numbers.")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "The {0} field must have {1} characters.")]
        [Required(ErrorMessage ="The field {0} is mandatory.")]
        public string Plaque { get; set; }
    }
}
