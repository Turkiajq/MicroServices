using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthService.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonalInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    BloodType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    FitnessLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInfo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PersonalInfo",
                columns: new[] { "Id", "BloodType", "FitnessLevel", "Height", "ProfileId", "Weight" },
                values: new object[] { 1, "O+", 3, 168, 1, 72 });

            migrationBuilder.InsertData(
                table: "PersonalInfo",
                columns: new[] { "Id", "BloodType", "FitnessLevel", "Height", "ProfileId", "Weight" },
                values: new object[] { 2, "O+", 2, 169, 2, 76 });

            migrationBuilder.InsertData(
                table: "PersonalInfo",
                columns: new[] { "Id", "BloodType", "FitnessLevel", "Height", "ProfileId", "Weight" },
                values: new object[] { 3, "A+", 1, 170, 3, 81 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalInfo");
        }
    }
}
