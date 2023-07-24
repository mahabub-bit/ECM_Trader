using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECM_ExcellentAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerLandLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerFax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerJobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerHomeNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerZip = table.Column<int>(type: "int", nullable: false),
                    CustomerPan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAccNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerBank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerBankBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerBankDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerGSTIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerDetails1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerDetails2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerDetails3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerDetails4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
