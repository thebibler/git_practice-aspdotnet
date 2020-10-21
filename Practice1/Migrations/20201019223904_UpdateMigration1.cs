using Microsoft.EntityFrameworkCore.Migrations;

namespace Practice1.Migrations
{
    public partial class UpdateMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trophy_Franchise_FranchiseID",
                table: "Trophy");

            migrationBuilder.DropIndex(
                name: "IX_Trophy_FranchiseID",
                table: "Trophy");

            migrationBuilder.DropColumn(
                name: "FranchiseID",
                table: "Trophy");

            migrationBuilder.AddColumn<string>(
                name: "TrophyID",
                table: "Franchise",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Franchise_TrophyID",
                table: "Franchise",
                column: "TrophyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Franchise_Trophy_TrophyID",
                table: "Franchise",
                column: "TrophyID",
                principalTable: "Trophy",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Franchise_Trophy_TrophyID",
                table: "Franchise");

            migrationBuilder.DropIndex(
                name: "IX_Franchise_TrophyID",
                table: "Franchise");

            migrationBuilder.DropColumn(
                name: "TrophyID",
                table: "Franchise");

            migrationBuilder.AddColumn<string>(
                name: "FranchiseID",
                table: "Trophy",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trophy_FranchiseID",
                table: "Trophy",
                column: "FranchiseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Trophy_Franchise_FranchiseID",
                table: "Trophy",
                column: "FranchiseID",
                principalTable: "Franchise",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
