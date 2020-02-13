using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscountPoolBackbone.Migrations
{
    public partial class Initialcreatingwithcleintmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PassportAddresss = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Discount = table.Column<int>(nullable: true),
                    TotalPurchases = table.Column<int>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: true),
                    DocumentNumber = table.Column<string>(nullable: true),
                    DocumentFrom = table.Column<DateTime>(nullable: true),
                    DocumentTo = table.Column<DateTime>(nullable: true),
                    IsVip = table.Column<bool>(nullable: true),
                    ConfigurationId = table.Column<int>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Language = table.Column<int>(nullable: false),
                    Sex = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    LastVisit = table.Column<DateTime>(nullable: true),
                    CurrentCoachId = table.Column<int>(nullable: true),
                    CoachNote = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
