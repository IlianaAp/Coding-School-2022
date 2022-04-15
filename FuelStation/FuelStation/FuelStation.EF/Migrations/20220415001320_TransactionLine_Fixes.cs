using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuelStation.EF.Migrations
{
    public partial class TransactionLine_Fixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLines_Items_ItemID",
                table: "TransactionLines");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLines_Items_ItemID",
                table: "TransactionLines",
                column: "ItemID",
                principalTable: "Items",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLines_Items_ItemID",
                table: "TransactionLines");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLines_Items_ItemID",
                table: "TransactionLines",
                column: "ItemID",
                principalTable: "Items",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
