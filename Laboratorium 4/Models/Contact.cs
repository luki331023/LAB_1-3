using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_4.Models
{
    public class Contact
    {
        [HiddenInput]
        public int id { get; set; }

        [Required(ErrorMessage = "Musisz podac imie")]
        [StringLength(maximumLength: 50, ErrorMessage = "Zbyt długie imie")]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [RegularExpression("^[0-9]{9,9}$", ErrorMessage = "Pole musi zawierac cyfry (9)")]
        public string Phone { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Birth { get; set; }

        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }
    }
}
