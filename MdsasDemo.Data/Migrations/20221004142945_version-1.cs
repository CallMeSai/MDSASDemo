using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MdsasDemo.Data.Migrations
{
    public partial class version1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Forename = table.Column<string>(maxLength: 255, nullable: true),
                    Surname = table.Column<string>(maxLength: 255, nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    UniqueNumber = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}