using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS_Backend.Persistence.Migrations
{
    public partial class addeducationclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Staffs_StaffId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "StaffId",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EducationClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationClass", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EducationClass",
                columns: new[] { "Id", "CreationDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 9, 21, 38, 56, 105, DateTimeKind.Local).AddTicks(4227), new DateTime(2022, 10, 9, 21, 38, 56, 105, DateTimeKind.Local).AddTicks(4228), "Kindergarten" },
                    { 2, new DateTime(2022, 10, 9, 21, 38, 56, 105, DateTimeKind.Local).AddTicks(4231), new DateTime(2022, 10, 9, 21, 38, 56, 105, DateTimeKind.Local).AddTicks(4232), "Program support" },
                    { 3, new DateTime(2022, 10, 9, 21, 38, 56, 105, DateTimeKind.Local).AddTicks(4233), new DateTime(2022, 10, 9, 21, 38, 56, 105, DateTimeKind.Local).AddTicks(4234), "Music " },
                    { 4, new DateTime(2022, 10, 9, 21, 38, 56, 105, DateTimeKind.Local).AddTicks(4235), new DateTime(2022, 10, 9, 21, 38, 56, 105, DateTimeKind.Local).AddTicks(4236), "Languages" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ClassId",
                table: "Courses",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_EducationClass_ClassId",
                table: "Courses",
                column: "ClassId",
                principalTable: "EducationClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Staffs_StaffId",
                table: "Courses",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_EducationClass_ClassId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Staffs_StaffId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "EducationClass");

            migrationBuilder.DropIndex(
                name: "IX_Courses_ClassId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "StaffId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Staffs_StaffId",
                table: "Courses",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
