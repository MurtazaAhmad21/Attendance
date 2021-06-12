using Microsoft.EntityFrameworkCore.Migrations;

namespace AttendanceMgmtFYP.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day1",
                table: "DaysOfWeek");

            migrationBuilder.DropColumn(
                name: "Day2",
                table: "DaysOfWeek");

            migrationBuilder.DropColumn(
                name: "Day3",
                table: "DaysOfWeek");

            migrationBuilder.DropColumn(
                name: "Day4",
                table: "DaysOfWeek");

            migrationBuilder.DropColumn(
                name: "Day5",
                table: "DaysOfWeek");

            migrationBuilder.DropColumn(
                name: "Day6",
                table: "DaysOfWeek");

            migrationBuilder.RenameColumn(
                name: "Day7",
                table: "DaysOfWeek",
                newName: "DayName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DayName",
                table: "DaysOfWeek",
                newName: "Day7");

            migrationBuilder.AddColumn<string>(
                name: "Day1",
                table: "DaysOfWeek",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day2",
                table: "DaysOfWeek",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day3",
                table: "DaysOfWeek",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day4",
                table: "DaysOfWeek",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day5",
                table: "DaysOfWeek",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day6",
                table: "DaysOfWeek",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);
        }
    }
}
