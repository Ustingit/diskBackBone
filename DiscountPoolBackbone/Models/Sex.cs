using System.ComponentModel.DataAnnotations;

namespace DiscountPoolBackbone.Models
{
	public enum Sex
	{
		[Display(Name = "Мужской")] Male = 1,
		[Display(Name = "Женский")] Female = 2,
		[Display(Name = "Прочее")] Other = 3
	}
}
