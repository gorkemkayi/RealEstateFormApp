using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstate.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AppUsers_AppUserId",
                table: "Customers");

            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId1",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Estate",
                columns: table => new
                {
                    EstateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EstateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estate", x => x.EstateId);
                    table.ForeignKey(
                        name: "FK_Estate_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estate_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EstateImage",
                columns: table => new
                {
                    EstateImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EstateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstateImage", x => x.EstateImageId);
                    table.ForeignKey(
                        name: "FK_EstateImage_Estate_EstateId",
                        column: x => x.EstateId,
                        principalTable: "Estate",
                        principalColumn: "EstateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AppUserId1",
                table: "Customers",
                column: "AppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Estate_AppUserId",
                table: "Estate",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Estate_CustomerId",
                table: "Estate",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_EstateImage_EstateId",
                table: "EstateImage",
                column: "EstateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AppUsers_AppUserId",
                table: "Customers",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AppUsers_AppUserId1",
                table: "Customers",
                column: "AppUserId1",
                principalTable: "AppUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AppUsers_AppUserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AppUsers_AppUserId1",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "EstateImage");

            migrationBuilder.DropTable(
                name: "Estate");

            migrationBuilder.DropIndex(
                name: "IX_Customers_AppUserId1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "Customers");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AppUsers_AppUserId",
                table: "Customers",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
