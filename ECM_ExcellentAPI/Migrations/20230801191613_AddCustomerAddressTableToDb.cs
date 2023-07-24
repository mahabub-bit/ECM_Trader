using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECM_ExcellentAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerAddressTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomersAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ShipHNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipStreet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipCol1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipCol2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipCol3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomersAddress_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomersAddress_CustomerId",
                table: "CustomersAddress",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomersAddress");
        }
    }
}
