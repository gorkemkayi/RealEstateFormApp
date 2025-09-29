using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstate.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AppUsers_AppUserId1",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_AppUserId1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "Customers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId1",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AppUserId1",
                table: "Customers",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AppUsers_AppUserId1",
                table: "Customers",
                column: "AppUserId1",
                principalTable: "AppUsers",
                principalColumn: "Id");
        }
    }
}
