using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationTask.Migrations
{
    public partial class TFour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fee",
                table: "student",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fee",
                table: "student");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "student");
        }
    }
}
