using System.ComponentModel.DataAnnotations;

namespace Laboratorium_4.Models
{
    public class Details
    {
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Birth { get; set; }
    }
}
