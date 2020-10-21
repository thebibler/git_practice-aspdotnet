using Microsoft.EntityFrameworkCore.Migrations;

namespace Practice1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Franchise",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    TeamName = table.Column<string>(nullable: true),
                    Opponent = table.Column<string>(nullable: true),
                    Score = table.Column<double>(nullable: true),
                    Stadium = table.Column<string>(nullable: true),
                    Coach = table.Column<string>(nullable: true),
                    Mascot = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Franchise", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Franchise");
        }
    }
}
