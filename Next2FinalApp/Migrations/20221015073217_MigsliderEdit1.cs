using Microsoft.EntityFrameworkCore.Migrations;

namespace Next2FinalApp.Migrations
{
    public partial class MigsliderEdit1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sliderbesc",
                table: "Sliders",
                newName: "Sliderdesc");

            migrationBuilder.AddColumn<string>(
                name: "SliderImg",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SliderImg",
                table: "Sliders");

            migrationBuilder.RenameColumn(
                name: "Sliderdesc",
                table: "Sliders",
                newName: "Sliderbesc");
        }
    }
}
