using System;
using System.ComponentModel.DataAnnotations;
namespace FizzBuzzWeb.Models

{
    public class FizzBuzz
    {
        [Display(Name = "Twój szczęsliwy numerek")]
        public int Number { get; set; }
    }
}

