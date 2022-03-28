namespace HashWebApi.Entities;

public class User
{
	public int Id { get; set; }
	public int BillingCardId { get; set; }
	public int AddressId { get; set; }
	public int ContactDetailsId { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public Sex Sex { get; set; }
	public DateTime CreatedDate { get; set; }
	public bool IsDeleted { get; set; }
}