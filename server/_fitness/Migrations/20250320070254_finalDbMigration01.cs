using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _fitness.Migrations
{
    /// <inheritdoc />
    public partial class finalDbMigration01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CaloriesConsumed = table.Column<int>(type: "int", nullable: false),
                    CaloriesBurned = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    DailyGoal = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calorie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trend",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    Weight = table.Column<double>(type: "float", maxLength: 50, nullable: false),
                    BMI = table.Column<double>(type: "float", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trend", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workout",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    Excercise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Duration = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    CaloriesBurned = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workout", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calorie");

            migrationBuilder.DropTable(
                name: "Trend");

            migrationBuilder.DropTable(
                name: "Workout");
        }
    }
}
