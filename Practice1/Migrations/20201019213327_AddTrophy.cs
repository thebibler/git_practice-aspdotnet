using Microsoft.EntityFrameworkCore.Migrations;

namespace Practice1.Migrations
{
    public partial class AddTrophy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trophy",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    TrophyName = table.Column<string>(nullable: true),
                    TrophyPhotoPath = table.Column<string>(nullable: true),
                    FranchiseID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trophy", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Trophy_Franchise_FranchiseID",
                        column: x => x.FranchiseID,
                        principalTable: "Franchise",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trophy_FranchiseID",
                table: "Trophy",
                column: "FranchiseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trophy");
        }
    }
}
