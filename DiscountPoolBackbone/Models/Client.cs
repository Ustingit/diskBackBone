using System;

namespace DiscountPoolBackbone.Models
{
	public class Client
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FatherName { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }
		public string PassportAddress { get; set; }
		public DateTime DateOfBirth { get; set; }
		public DateTime CreatedDate { get; set; }
		public int Discount { get; set; }
		public int TotalPurchases { get; set; }
		public int DepartmentId { get; set; }
		public string DocumentId { get; set; }
		public DateTime DocumentFrom { get; set; }
		public DateTime DocumentTo { get; set; }
		public bool IsVip { get; set; }
		public int ConfigurationId { get; set; }
		public string Note { get; set; }
		public Languages Language { get; set; }
		public Sex Sex { get; set; }
		public bool IsActive { get; set; }
		public DateTime LastVisit { get; set; }
		public int CurrentCoachId { get; set; }
		public string CoachNote { get; set; }

		public string GetFullName()
		{
			return $"{LastName} {FirstName} {FatherName}";
		}
	}
}
