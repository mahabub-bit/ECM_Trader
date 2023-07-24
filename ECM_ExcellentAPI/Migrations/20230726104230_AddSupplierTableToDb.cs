using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECM_ExcellentAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSupplierTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Supplier_Company_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Supplier_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Supplier_JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_Pan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_Webpage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_Business_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_Home_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_Moblie_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_D = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suppliers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_CompanyId",
                table: "Suppliers",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
