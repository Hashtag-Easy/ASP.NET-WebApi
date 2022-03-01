using System.ComponentModel.DataAnnotations;

namespace HashWebApi.Models
{
    public class UserCreationParams
    {
        [Required]
        [RegularExpression(@"")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"")]
        public string Password { get; set; }

        [Required]
        public DateTime BirthDat { get; set; }

        public UserCreationParams()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
        }
    }
}
