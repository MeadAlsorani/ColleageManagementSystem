using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS_Backend.Persistence.Migrations
{
    public partial class ADD_BALANCE_TO_STUDENT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Balance",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Students");
        }
    }
}
