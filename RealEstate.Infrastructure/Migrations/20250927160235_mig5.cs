using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstate.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estate_AppUsers_AppUserId",
                table: "Estate");

            migrationBuilder.DropForeignKey(
                name: "FK_Estate_Customers_CustomerId",
                table: "Estate");

            migrationBuilder.DropForeignKey(
                name: "FK_EstateImage_Estate_EstateId",
                table: "EstateImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstateImage",
                table: "EstateImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estate",
                table: "Estate");

            migrationBuilder.RenameTable(
                name: "EstateImage",
                newName: "EstateImages");

            migrationBuilder.RenameTable(
                name: "Estate",
                newName: "Estates");

            migrationBuilder.RenameIndex(
                name: "IX_EstateImage_EstateId",
                table: "EstateImages",
                newName: "IX_EstateImages_EstateId");

            migrationBuilder.RenameIndex(
                name: "IX_Estate_CustomerId",
                table: "Estates",
                newName: "IX_Estates_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Estate_AppUserId",
                table: "Estates",
                newName: "IX_Estates_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstateImages",
                table: "EstateImages",
                column: "EstateImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estates",
                table: "Estates",
                column: "EstateId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstateImages_Estates_EstateId",
                table: "EstateImages",
                column: "EstateId",
                principalTable: "Estates",
                principalColumn: "EstateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estates_AppUsers_AppUserId",
                table: "Estates",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estates_Customers_CustomerId",
                table: "Estates",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstateImages_Estates_EstateId",
                table: "EstateImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Estates_AppUsers_AppUserId",
                table: "Estates");

            migrationBuilder.DropForeignKey(
                name: "FK_Estates_Customers_CustomerId",
                table: "Estates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estates",
                table: "Estates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstateImages",
                table: "EstateImages");

            migrationBuilder.RenameTable(
                name: "Estates",
                newName: "Estate");

            migrationBuilder.RenameTable(
                name: "EstateImages",
                newName: "EstateImage");

            migrationBuilder.RenameIndex(
                name: "IX_Estates_CustomerId",
                table: "Estate",
                newName: "IX_Estate_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Estates_AppUserId",
                table: "Estate",
                newName: "IX_Estate_AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_EstateImages_EstateId",
                table: "EstateImage",
                newName: "IX_EstateImage_EstateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estate",
                table: "Estate",
                column: "EstateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstateImage",
                table: "EstateImage",
                column: "EstateImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estate_AppUsers_AppUserId",
                table: "Estate",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estate_Customers_CustomerId",
                table: "Estate",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EstateImage_Estate_EstateId",
                table: "EstateImage",
                column: "EstateId",
                principalTable: "Estate",
                principalColumn: "EstateId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
