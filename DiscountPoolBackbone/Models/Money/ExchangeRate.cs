using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiscountPoolBackbone.Models.Money
{
    public class ExchangeRate
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal BynToUsdRate { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal UsdToBynRate { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal? UsdToRusRubRate { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal? RusRubToUsdRate { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal? RusRubToBynRate { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal? BynToRusRubRate { get; set; }
    }
}
