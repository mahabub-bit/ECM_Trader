using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECM_ExcellentAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCompanyTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CBusinessPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CGST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CBank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CBankAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CBankBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CIFSC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CC1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CC2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CC3 = table.Column<int>(type: "int", nullable: true),
                    CC4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
