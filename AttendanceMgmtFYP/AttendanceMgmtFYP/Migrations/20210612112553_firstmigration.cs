using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AttendanceMgmtFYP.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DaysOfWeek",
                columns: table => new
                {
                    DayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Day2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Day3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Day4 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Day5 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Day6 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Day7 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaysOfWeek", x => x.DayId);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CNIC = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Designation = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Gender = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    DateofBirth = table.Column<DateTime>(type: "datetime", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrignalFileName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FileName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Teachers", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "TimeTable",
                columns: table => new
                {
                    TimeTableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(type: "int", nullable: true),
                    DayId = table.Column<int>(type: "int", nullable: true),
                    _08301000 = table.Column<string>(name: "0830-1000", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    _10001130 = table.Column<string>(name: "1000-1130", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    _11300100 = table.Column<string>(name: "1130-0100", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    _01300300 = table.Column<string>(name: "0130-0300", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    _03000430 = table.Column<string>(name: "0300-0430", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    _06000800 = table.Column<string>(name: "0600-0800", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    _08001000 = table.Column<string>(name: "0800-1000", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeTable", x => x.TimeTableId);
                });

            migrationBuilder.CreateTable(
                name: "TimeTableData",
                columns: table => new
                {
                    TimeTableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeIn08301000 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeOut08301000 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    _08301000 = table.Column<string>(name: "0830-1000", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeIn10001130 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeOut10001130 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    _10001130 = table.Column<string>(name: "10001130", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeIn11300100 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeOut11300100 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    _11300100 = table.Column<string>(name: "1130-0100", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeIn01300300 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeOut01300300 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    _01300300 = table.Column<string>(name: "0130-0300", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeIn03000430 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeOut03000430 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    _03000430 = table.Column<string>(name: "0300-0430", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeIn06000800 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeOut06000800 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    _06000800 = table.Column<string>(name: "0600-0800", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeIn08001000 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeOut08001000 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    _08001000 = table.Column<string>(name: "0800-1000", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeTableData", x => x.TimeTableId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DaysOfWeek");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "TimeTable");

            migrationBuilder.DropTable(
                name: "TimeTableData");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
