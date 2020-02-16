using System;
using System.ComponentModel.DataAnnotations;

namespace DiscountPoolBackbone.Models
{
    public class Visit
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan Duration { get; set; }
        public string Note { get; set; }
        public int? CoachId { get; set; }
    }
}
