using System.ComponentModel.DataAnnotations;

namespace DiscountPoolBackbone.Models.enums
{
	public enum Documents
	{
		[Display(Name = "Паспорт")] Passport = 1,
		[Display(Name = "Права")] DriverCard = 2,
		[Display(Name = "Студенческий")] StudentCard = 3,
	}
}
