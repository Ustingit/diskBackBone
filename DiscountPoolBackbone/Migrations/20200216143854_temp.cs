using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscountPoolBackbone.Migrations
{
    public partial class temp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Header = table.Column<string>(nullable: true),
                    MainContent = table.Column<string>(nullable: true),
                    ImageId = table.Column<int>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    IsActual = table.Column<bool>(nullable: false),
                    AreAllPhotoFromFolder = table.Column<bool>(nullable: true),
                    AuthorId = table.Column<int>(nullable: false),
                    Cost = table.Column<decimal>(nullable: true),
                    AdditionalUrl = table.Column<string>(nullable: true),
                    PublicationDate = table.Column<DateTime>(nullable: true),
                    LikedClients = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
