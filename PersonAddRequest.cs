using System.ComponentModel.DataAnnotations;

namespace test_webapi
{
    public class PersonAddRequest
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}