using Microsoft.EntityFrameworkCore;

namespace HashWebApi.Entities
{
	public class HashDbContext : DbContext
	{
		private string m_connectionString =
			"<connection-string>";

		public DbSet<User> Users { get; set; }
		public DbSet<BillingCard> BillingCards { get; set; }
		public DbSet<ContactDetails> ContactDetails { get; set; }
		public DbSet<Address> Addresses { get; set; }
			 
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			var userBuilder = modelBuilder.Entity<User>();
			userBuilder.Property(p => p.FirstName).IsRequired().HasMaxLength(50);
			userBuilder.Property(p => p.LastName).IsRequired().HasMaxLength(50);
			userBuilder.Property(p => p.Sex).IsRequired().HasMaxLength(1);
			userBuilder.Property(p => p.CreatedDate).IsRequired();
			userBuilder.Property(p => p.IsDeleted).IsRequired().HasDefaultValue(false);

			var billingCardBuilder = modelBuilder.Entity<BillingCard>();
			billingCardBuilder.Property(p => p.OwnerFirstName).HasMaxLength(50);
			billingCardBuilder.Property(p => p.OwnerLastName).HasMaxLength(50);
			billingCardBuilder.Property(p => p.Number).HasMaxLength(16);
			billingCardBuilder.Property(p => p.Ccv).HasMaxLength(3);

			var contactDetailsBuilder = modelBuilder.Entity<ContactDetails>();
			contactDetailsBuilder.Property(p => p.Email).IsRequired().HasMaxLength(256);
			contactDetailsBuilder.Property(p => p.PhoneNumberAreaCode).HasMaxLength(2);
			contactDetailsBuilder.Property(p => p.PhoneNumber).HasMaxLength(9);

			var addressBuilder = modelBuilder.Entity<Address>();
			addressBuilder.Property(p => p.Country).HasMaxLength(95);
			addressBuilder.Property(p => p.City).HasMaxLength(35);
			addressBuilder.Property(p => p.ZipCode).HasMaxLength(6);
			addressBuilder.Property(p => p.Street).HasMaxLength(35);
			addressBuilder.Property(p => p.BuildingNumber).HasMaxLength(10);
		}
	}
}
