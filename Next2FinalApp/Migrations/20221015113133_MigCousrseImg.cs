using Microsoft.EntityFrameworkCore.Migrations;

namespace Next2FinalApp.Migrations
{
    public partial class MigCousrseImg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "courseimg",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "courseimg",
                table: "Courses");
        }
    }
}
