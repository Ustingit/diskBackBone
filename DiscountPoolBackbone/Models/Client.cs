using System;
using System.ComponentModel.DataAnnotations;

namespace DiscountPoolBackbone.Models
{
	public class Client
	{
		[Key]
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FatherName { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }
		public string PassportAddresss { get; set; }
		[DataType(DataType.Date)]
		public DateTime DateOfBirth { get; set; }
		public DateTime CreatedDate { get; set; }
		public int? Discount { get; set; }
		public int? TotalPurchases { get; set; }
		public int? DepartmentId { get; set; }
		public string DocumentNumber { get; set; }
		[DataType(DataType.Date)]
		public DateTime? DocumentFrom { get; set; }
		[DataType(DataType.Date)]
		public DateTime? DocumentTo { get; set; }
		public bool? IsVip { get; set; }
		public int? ConfigurationId { get; set; }
		public string? Note { get; set; }
		public int Language { get; set; }
		public int Sex { get; set; }
		public bool? IsActive { get; set; }
		public DateTime? LastVisit { get; set; }
		public int? CurrentCoachId { get; set; }
		public string? CoachNote { get; set; }

		public string GetFullName()
		{
			return $"{LastName} {FirstName} {FatherName}";
		}
	}
}

/* 
 * 
 CREATE TABLE Clients
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	FirstName varchar(20) NOT NULL,
	LastName varchar(20) NOT NULL,
	FatherName varchar(20) NOT NULL,
	Phone varchar(15) NOT NULL,
	Address varchar(50) NOT NULL,
	PassportAddresss varchar(50) NOT NULL,
	DocumentNumber varchar(15) NOT NULL,
	DocumentFrom datetime NULL,
	DocumentTo datetime NULL,
	DateOfBirth datetime NOT NULL,
	CreatedDate datetime NOT NULL,
	Discount int NULL,
	TotalPurchases bigint NULL,
	DepartmentId int NOT NULL,
	IsVip bit NULL,
	ConfigurationId int NULL,
	Note varchar(MAX) NULL,
	Language smallint NULL,
	Sex int NOT NULL,
	IsActive bit NOT NULL,
	LastVisit datetime NULL,
	CurrentCoachId int NULL,
	CoachNote varchar(MAX) NULL
)
	 */
