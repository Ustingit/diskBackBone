using DiscountPoolBackbone.Models.enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiscountPoolBackbone.Models
{
    public class Trainer
    {
        [Key]
        public int Id { get; set; }
        public string Note { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal SaleSelfCost { get; set; } //себестоимость
        [Column(TypeName = "decimal(18,3)")]
        public decimal SaleTax { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal SaleDelivery { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal SaleOtherCosts { get; set; }
        public string SaleNote { get; set; }
        [Column(TypeName = "int")]
        public TrainerQuality TrainerQuality { get; set; }
        public DateTime SaleDate { get; set; }
        public DateTime PurchaseOrThrowDate { get; set; }
        public int? InstructionId { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal? MaxWeight { get; set; }
        public string VideoDescriptionLink { get; set; }
        public int? PhotoSetId { get; set; }
    }
}
