using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracticeMidTerm.Migrations
{
    public partial class BirthdayField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Students",
                type: "datetime(6)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Students");
        }
    }
}
