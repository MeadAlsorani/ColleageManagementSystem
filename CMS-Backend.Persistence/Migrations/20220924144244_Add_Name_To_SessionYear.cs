using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS_Backend.Persistence.Migrations
{
    public partial class Add_Name_To_SessionYear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "SessionYears",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "SessionYears");
        }
    }
}
