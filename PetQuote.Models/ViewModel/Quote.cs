using System;
using System.ComponentModel.DataAnnotations;


namespace PetQuote.Models.ViewModel
{
    public class Quote
    {
        [Required(ErrorMessage ="Pet name cannot be empty.")]
        public string PetName { get; set; }

        [Required(ErrorMessage = "Please gender.")]
        public int PetType { get; set; }

        [Required(ErrorMessage = "Please gender.")]
        public bool IsMale { get; set; }

        [Required(ErrorMessage = "Please choose Pet's age.")]
        public string PetAge { get; set; }

        [Required(ErrorMessage = "Please choose Breed.")]
        public string Breed { get; set; }

        [Required(ErrorMessage = "Zipcode format is not correct")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Email format is not correct.")]
        public string Email { get; set; }
    }
}
