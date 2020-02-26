using DiscountPoolBackbone.Models.Money;
using Microsoft.EntityFrameworkCore;

namespace DiscountPoolBackbone.Models
{
	public class DiscountsContext : DbContext
	{
		public DbSet<Client> Clients { get; set; }
		public DbSet<ExchangeRate> ExchangeRates { get; set; }
		public DbSet<Sale> Sales { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Trainer> Trainers { get; set; }
		public DbSet<Visit> Visits { get; set; }
		public DbSet<Article> Articles { get; set; }

		public DiscountsContext(DbContextOptions<DiscountsContext> options)
			: base(options)
		{
			//Database.EnsureCreated();
		}
	}
}
