using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DonationWebApp.Migrations.Goods
{
    public partial class Goods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GoodDonation",
                columns: table => new
                {
                    DonorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfDonation = table.Column<DateTime>(nullable: false),
                    NumberOfItems = table.Column<int>(nullable: false),
                    Category = table.Column<string>(type: "varchar(250)", nullable: false),
                    AddNewCategory = table.Column<string>(type: "varchar(250)", nullable: true),
                    DescriptionOfItem = table.Column<string>(type: "varchar(250)", nullable: false),
                    Donor = table.Column<string>(type: "varchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodDonation", x => x.DonorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodDonation");
        }
    }
}
