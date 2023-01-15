using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DonationWebApp.Migrations
{
    public partial class Monetary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MoneyDonation",
                columns: table => new
                {
                    DonorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfDonation = table.Column<DateTime>(nullable: false),
                    AmountOfDonation = table.Column<double>(nullable: false),
                    Donor = table.Column<string>(type: "varchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyDonation", x => x.DonorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoneyDonation");
        }
    }
}
