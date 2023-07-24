using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECM_ExcellentAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddPurchaseOrderTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    PO_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    PO_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PO_TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PO_Invoice = table.Column<int>(type: "int", nullable: false),
                    ShippingFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Taxes = table.Column<float>(type: "real", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentType = table.Column<int>(type: "int", nullable: false),
                    ClosedBy = table.Column<int>(type: "int", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpectedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClosedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AddPurchaseColumn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddPurchaseColumn2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddPurchaseColumn3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrdersDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    PurchaseId = table.Column<int>(type: "int", nullable: false),
                    PurchaseOrderId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PodQty = table.Column<int>(type: "int", nullable: false),
                    PodUnitPrice = table.Column<float>(type: "real", nullable: false),
                    PodTotalPrice = table.Column<float>(type: "real", nullable: false),
                    PodDiscount = table.Column<float>(type: "real", nullable: false),
                    PodTaxableValue = table.Column<float>(type: "real", nullable: false),
                    SGst = table.Column<float>(type: "real", nullable: false),
                    CGst = table.Column<float>(type: "real", nullable: false),
                    PodItemAmount = table.Column<float>(type: "real", nullable: false),
                    PodMfgDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PurchaseInvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PodAddInfo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PodAddInfo2 = table.Column<int>(type: "int", nullable: false),
                    PodAddInfo3 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PodAddInfo4 = table.Column<float>(type: "real", nullable: false),
                    PodAddInfo5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PodAddInfo6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PodAddInfo7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PodAddInfo8 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrdersDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrdersDetail_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PurchaseOrdersDetail_PurchaseOrders_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_CompanyId",
                table: "PurchaseOrders",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_ProductId",
                table: "PurchaseOrders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_SupplierId",
                table: "PurchaseOrders",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_UserId",
                table: "PurchaseOrders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrdersDetail_ProductId",
                table: "PurchaseOrdersDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrdersDetail_PurchaseOrderId",
                table: "PurchaseOrdersDetail",
                column: "PurchaseOrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseOrdersDetail");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");
        }
    }
}
