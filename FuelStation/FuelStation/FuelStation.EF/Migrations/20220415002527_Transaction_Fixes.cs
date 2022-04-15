using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuelStation.EF.Migrations
{
    public partial class Transaction_Fixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLines_Transactions_TransactionID",
                table: "TransactionLines");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLines_Transactions_TransactionID",
                table: "TransactionLines",
                column: "TransactionID",
                principalTable: "Transactions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLines_Transactions_TransactionID",
                table: "TransactionLines");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLines_Transactions_TransactionID",
                table: "TransactionLines",
                column: "TransactionID",
                principalTable: "Transactions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
