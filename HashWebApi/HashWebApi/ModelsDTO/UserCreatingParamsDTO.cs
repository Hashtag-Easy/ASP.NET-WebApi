using System.ComponentModel.DataAnnotations;

namespace HashWebApi.ModelsDTO
{
    public class UserCreatingParamsDTO
    {
        [Required]
        [RegularExpression(@"")]
        public string? FirstName { get; set; }

        [Required]
        [RegularExpression(@"")]
        public string? LastName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [RegularExpression(@"")]
        public string? Password { get; set; }

        [Required]
        public DateTime? BirthDay { get; set; }
    }
}
