using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovamenteDenovo.Migrations
{
    /// <inheritdoc />
    public partial class SeedingService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Sale_SalesId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Seller_SellerId",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_SalesId",
                table: "Sale");

            migrationBuilder.RenameColumn(
                name: "SalesId",
                table: "Sale",
                newName: "Status");

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Sale",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Seller_SellerId",
                table: "Sale",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Seller_SellerId",
                table: "Sale");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Sale",
                newName: "SalesId");

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Sale",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_SalesId",
                table: "Sale",
                column: "SalesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Sale_SalesId",
                table: "Sale",
                column: "SalesId",
                principalTable: "Sale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Seller_SellerId",
                table: "Sale",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id");
        }
    }
}
