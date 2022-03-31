using System.ComponentModel.DataAnnotations;

namespace HashWebApi.ModelsDTO;

public class UserDTO
{
	[Required]
	[Range(2, 50)]
	public string? FirstName { get; set; }
	
	[Required]
	[Range(2, 50)]
	public string? LastName { get; set; }
	
	[Required]
	[Range(2, 256)]
	public string? Email { get; set; }
	
	[Required]
	[Range(8, 30)]
	public string? Password { get; set; }
}