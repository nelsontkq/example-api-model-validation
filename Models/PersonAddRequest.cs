using System.ComponentModel.DataAnnotations;

namespace ModelValidationExampleApi.Models
{
    public class PersonAddRequest
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}