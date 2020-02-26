using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscountPoolBackbone.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "AreAllPhotoFromFolder",
                table: "Articles",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "AreAllPhotoFromFolder",
                table: "Articles",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
