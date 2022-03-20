using System;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Twój szczęsliwy numerek")]
        [Required(ErrorMessage = "Wymagane!"), Range(1, 1000, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}")]

        public int? Number { get; set; }
    }
}

