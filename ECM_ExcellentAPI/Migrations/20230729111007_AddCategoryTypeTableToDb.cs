﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECM_ExcellentAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryTypeTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CatTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatTypeDesc2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatTypeDesc3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatTypeDesc4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryTypes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTypes_CategoryId",
                table: "CategoryTypes",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryTypes");
        }
    }
}
