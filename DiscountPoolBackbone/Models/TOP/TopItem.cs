using DiscountPoolBackbone.Models.TOP.enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DiscountPoolBackbone.Models.TOP
{
    public class TopItem
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal PopularRate { get; set; }

        [Column(TypeName = "int")]
        public TopItemType Type { get; set; }
        public string Name { get; set; }
        public string ShorDescription { get; set; }
        public string Description { get; set; }
        public int Author { get; set; }

        [Column(TypeName = "decimal(18,3)")]
        public decimal? LocalPrice { get; set; }

        [Column(TypeName = "decimal(18,3)")]
        public decimal? WorldPrice { get; set; }

        public int? SmallPhotoId { get; set; }
        public int? MainPhotoId { get; set; }
        public string PhotosIds { get; set; }

        [NotMapped]
        public int[] PhotosIdsProxy
        {
            get
            {
                return Array.ConvertAll(PhotosIds.Split(';'), int.Parse);
            }
            set
            {
                PhotosIds = String.Join(";", value.Select(p => p.ToString()).ToArray());
            }
        }

        public string LikedUsersIds { get; set; }

        [NotMapped]
        public int[] LikedUsersIdsProxy
        {
            get
            {
                return Array.ConvertAll(LikedUsersIds.Split(';'), int.Parse);
            }
            set
            {
                LikedUsersIds = String.Join(";", value.Select(p => p.ToString()).ToArray());
            }
        }

        public bool IsActive { get; set; }
        public bool? IsVIP { get; set; }

        public DateTime? VipExpirationDate { get; set; }

        [Column(TypeName = "decimal(18,3)")]
        public decimal? TotalSum { get; set; }

        public string InstagramUrl { get; set; }

        public int? InstagramLikesCount { get; set; }

        public string FacebookUrl { get; set; }

        public int? FacebookLikesCount { get; set; }

        public string VkUrl { get; set; }

        public int? VkLikesCount { get; set; }

        public string PinterestUrl { get; set; }

        public int? PinterestLikesCount { get; set; }

        public string MediumUrl { get; set; }

        public int? MediumLikesCount { get; set; }

        public string AmazonUrl { get; set; }

        public int? AmazonLikesCount { get; set; }

        [Column(TypeName = "decimal(18,3)")]
        public decimal? AmazonPrice { get; set; }

        public string EbayUrl { get; set; }

        public int? EbayLikesCount { get; set; }

        [Column(TypeName = "decimal(18,3)")]
        public decimal? EbayPrice { get; set; }

        public string AvitoUrl { get; set; }

        public int? AvitoLikesCount { get; set; }

        [Column(TypeName = "decimal(18,3)")]
        public decimal? AvitoPrice { get; set; }

        public string OlxUrl { get; set; }

        public int? OlxLikesCount { get; set; }

        [Column(TypeName = "decimal(18,3)")]
        public decimal? OlxPrice { get; set; }

        public string KufarUrl { get; set; }

        public int? KufarLikesCount { get; set; }

        [Column(TypeName = "decimal(18,3)")]
        public decimal? KufarPrice { get; set; }

        public string OnlinerUrl { get; set; }

        public int? OnlinerLikesCount { get; set; }

        [Column(TypeName = "decimal(18,3)")]
        public decimal? OnlinerPrice { get; set; }

        public string vek21Url { get; set; }

        public int? vek21LikesCount { get; set; }

        [Column(TypeName = "decimal(18,3)")]
        public decimal? vek21Price { get; set; }

        public bool? IsAdultContent { get; set; }
    }
}
