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
        public int Id { get; set; }  // TODO: use Guid Id ??
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
        public bool IsVIP { get; set; }

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

        public bool IsAdultContent { get; set; }
    }
}


/*
 CREATE TABLE TopItems 
(
    Id int IDENTITY(1,1) PRIMARY KEY,
    PopularRate decimal(18,3) NOT NULL DEFAULT(0),
    [Type] int NOT NULL,
    [Name] nvarchar(200) NOT NULL,
    ShorDescription nvarchar(500) NULL,
    Description nvarchar(MAX) NOT NULL,
    Author int NOT NULL,
    LocalPrice decimal(18,3) NULL,
    WorldPrice decimal(18,3) NULL,
    SmallPhotoId int NULL,
    MainPhotoId int NULL,
    PhotosIds nvarchar(MAX) NULL,
    LikedUsersIds nvarchar(MAX) NULL,
    IsActive int NOT NULL,
    IsVIP int NULL,
    VipExpirationDate datetime NULL,
    TotalSum decimal(18,3) NULL DEFAULT(0),
    InstagramUrl nvarchar(200) NULL,
    InstagramLikesCount int NULL,
    FacebookUrl nvarchar(200) NULL,
    FacebookLikesCount int NULL,
    VkUrl nvarchar(200) NULL,
    VkLikesCount int NULL,
    PinterestUrl nvarchar(200) NULL,
    PinterestLikesCount int NULL,
    MediumUrl nvarchar(200) NULL,
    MediumLikesCount int NULL,
    AmazonUrl nvarchar(200) NULL,
    AmazonLikesCount int NULL,
    AmazonPrice decimal(18,3) NULL,
    EbayUrl nvarchar(200) NULL,
    EbayLikesCount int NULL,
    EbayPrice decimal(18,3) NULL,
    AvitoUrl nvarchar(200) NULL,
    AvitoLikesCount int NULL,
    AvitoPrice decimal(18,3) NULL,
    OlxUrl nvarchar(200) NULL,
    OlxLikesCount int NULL,
    OlxPrice decimal(18,3) NULL,
    KufarUrl nvarchar(200) NULL,
    KufarLikesCount int NULL,
    KufarPrice decimal(18,3) NULL,
    OnlinerUrl nvarchar(200) NULL,
    OnlinerLikesCount int NULL,
    OnlinerPrice decimal(18,3) NULL,
    vek21Url nvarchar(200) NULL,
    vek21LikesCount int NULL,
    vek21Price decimal(18,3) NULL,
    IsAdultContent int NOT NULL
)


    ALTER TABLE TopItems
           ALTER COLUMN IsAdultContent bit NOT NULL;
           ALTER TABLE TopItems
           ALTER COLUMN IsActive bit NOT NULL;
           ALTER TABLE TopItems
           ALTER COLUMN IsVIP bit NULL;
   
    
    INSERT INTO TopItems (PopularRate, Type, Name, Description, Author, IsActive, IsVIP, IsAdultContent)
VALUES (0, 4, 'картина 5', 'почти как айвазовски ёпт 1', 1, 1, 0, 0);
 */
