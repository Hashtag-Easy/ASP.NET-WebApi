namespace HashWebApi.Entities;

public class BillingCard
{
	public int Id { get; set; }
	public int UserId { get; set; }
	public string OwnerFirstName { get; set; }
	public string OwnerLastName { get; set; }
	public string Number { get; set; }
	public DateTime ExpiredDate { get; set; }
	public string Ccv { get; set; }
}