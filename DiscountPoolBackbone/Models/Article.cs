using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiscountPoolBackbone.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
        public string Header { get; set; }
        public string MainContent { get; set; }
        public int? ImageId { get; set; }
        public string Note { get; set; }
        public bool IsActual { get; set; }
        public bool AreAllPhotoFromFolder { get; set; }
        public int AuthorId { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal? Cost { get; set; }
        public string AdditionalUrl { get; set; }
        public DateTime? PublicationDate { get; set; }
        public string LikedClients { get; set; }
    }
}
