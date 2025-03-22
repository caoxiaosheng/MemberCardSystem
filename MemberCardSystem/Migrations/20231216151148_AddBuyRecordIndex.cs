using Microsoft.EntityFrameworkCore.Migrations;

namespace MemberCardSystem.Migrations
{
    public partial class AddBuyRecordIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BuyRecords_CardId",
                table: "BuyRecords",
                column: "CardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BuyRecords_CardId",
                table: "BuyRecords");
        }
    }
}
