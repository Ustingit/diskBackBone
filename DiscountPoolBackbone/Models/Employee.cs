using DiscountPoolBackbone.Models.enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiscountPoolBackbone.Models
{
    public class Employee
    {
		[Key]
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FatherName { get; set; }
		public string Phone { get; set; }
		[Column(TypeName = "int")]
		public EmployeeType EmployeeType { get; set; }
		public string Address { get; set; }
		public string PassportAddresss { get; set; }
		[DataType(DataType.Date)]
		public DateTime DateOfBirth { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime FireDate { get; set; } // дата увольнение
		public string FireReasonAndNote { get; set; }  // причина увольнения
		public int? DepartmentId { get; set; }
		public string DocumentNumber { get; set; }
		[DataType(DataType.Date)]
		public DateTime? DocumentFrom { get; set; }
		[DataType(DataType.Date)]
		public DateTime? DocumentTo { get; set; }
		public int? ConfigurationId { get; set; }
		public string? Note { get; set; }
		public string Languages { get; set; }
		public int Sex { get; set; }
		public bool? IsActive { get; set; }
		public int SmallPhotoId { get; set; }
		public int LargePhotoId { get; set; }
		public int VideoPortfolioId { get; set; }
		public int PhotoPortfolioId { get; set; }
		public int VkId { get; set; }
		public int InstagrammId { get; set; }
		public int FacebookId { get; set; }
		public int OdnoklassnikiId { get; set; }
		public int PinterestId { get; set; }
		public int TwitterId { get; set; }
		[Column(TypeName = "decimal(18,3)")]
		public decimal TotalEarned { get; set; } // всего прибыли принёс компании
		[Column(TypeName = "decimal(18,3)")]
		public decimal Salary { get; set; } // зарплата в долларах на данный момент
		[Column(TypeName = "decimal(18,3)")]
		public decimal ConsultationCost { get; set; }
	}
}
