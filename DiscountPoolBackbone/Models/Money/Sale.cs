using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiscountPoolBackbone.Models.Money
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime SellDate { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public Currencies Currencies { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int EmployeeId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,3)")]
        public decimal Sum { get; set; }
        [Required]
        public string Note { get; set; }
        public int? OrderId { get; set; }
        public int? GoodId { get; set; } // в случае если был приобретен товар
        public int? ClientId { get; set; }
        [Column(TypeName = "int")]
        public SaleType? SaleType { get; set; }
    }
}
