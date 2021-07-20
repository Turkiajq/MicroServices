using Microsoft.EntityFrameworkCore.Migrations;

namespace ProfileService.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhonrNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Points = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "FirstName", "LastName", "PhonrNumber", "ScoreId" },
                values: new object[] { 1, "Turki", "Alqurashi", "05050505050", 0 });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "FirstName", "LastName", "PhonrNumber", "ScoreId" },
                values: new object[] { 2, "Ahmed", "Alzubaidi", "05858585858", 0 });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "FirstName", "LastName", "PhonrNumber", "ScoreId" },
                values: new object[] { 3, "Abdulrahman", "Sarawiq", "05858585858", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Scores");
        }
    }
}
