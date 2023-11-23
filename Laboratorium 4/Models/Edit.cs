using System.ComponentModel.DataAnnotations;

namespace Laboratorium_4.Models
{
    public class Edit
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name is too long")]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [RegularExpression("^[0-9]{9,9}$", ErrorMessage = "Pole musi zawierac cyfry (9)")]
        public string Phone { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Birth { get; set; }
    }
}
