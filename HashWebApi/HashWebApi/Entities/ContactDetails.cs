namespace HashWebApi.Entities;

public class ContactDetails
{
	public int Id { get; set; }
	public int UserId { get; set; }
	public string Email { get; set; }
	public string PhoneNumberAreaCode { get; set; }
	public string PhoneNumber { get; set; }
}