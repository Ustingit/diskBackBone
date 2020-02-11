using Microsoft.EntityFrameworkCore;

namespace DiscountPoolBackbone.Models
{
	public class DiscountsContext : DbContext
	{
		public DbSet<Client> Clients { get; set; }

		public DiscountsContext(DbContextOptions<DiscountsContext> options)
			: base(options)
		{
			Database.EnsureCreated();
		}
	}
}
