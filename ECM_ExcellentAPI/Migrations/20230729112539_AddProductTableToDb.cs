using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECM_ExcellentAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddProductTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    PCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryTypeId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    QtyPerUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackageSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetailerPrice = table.Column<double>(type: "float", nullable: false),
                    MRPPrice = table.Column<double>(type: "float", nullable: false),
                    Gst = table.Column<double>(type: "float", nullable: false),
                    GstSlab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discontinued = table.Column<bool>(type: "bit", nullable: false),
                    CostPrice = table.Column<double>(type: "float", nullable: false),
                    PDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PAddColumn1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAddColumn2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAddColumn3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAddColumn4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAddColumn5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAddColumn6 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Products_CategoryTypes_CategoryTypeId",
                        column: x => x.CategoryTypeId,
                        principalTable: "CategoryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Products_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryTypeId",
                table: "Products",
                column: "CategoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyId",
                table: "Products",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
