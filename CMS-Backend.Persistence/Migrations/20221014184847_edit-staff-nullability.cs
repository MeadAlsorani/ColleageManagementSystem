using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS_Backend.Persistence.Migrations
{
    public partial class editstaffnullability : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9219), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9220), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9219), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9223), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9223), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9222), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9225), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9226), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9225), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9228), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9229), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9228), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9231), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9231), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9230), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9233), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9234), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9233), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9236), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9236), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9235), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9239), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9239), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9238), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9241), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9242), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9241), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9244), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9244), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9243), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9246), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9247), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9246), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9249), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9249), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9248), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9252), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9252), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9251), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9254), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9255), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9254), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9258), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9258), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9257), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9260), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9261), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9260), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9263), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9263), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9262), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9265), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9265), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9268), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9268), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9267), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9270), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9271), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9270), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9273), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9273), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9272), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9276), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9276), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9275), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9278), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9279), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9278), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9281), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9281), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9280), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9283), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9284), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9283), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9286), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9286), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9285), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9289), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9289), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9288), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9299), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9299), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9298), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9301), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9302), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9301), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9304), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9305), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9304), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9307), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9307), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9306), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9309), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9310), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9309), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9312), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9312), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9311), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9314), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9315), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9314), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9317), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9317), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9316), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9319), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9320), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9319), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9322), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9322), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9321), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9325), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9326), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9325), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9328), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9328), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9327), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9330), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9331), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9330), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9333), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9333), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9332), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9335), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9336), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9335), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(8942), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(8945), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(8947), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(8948), new DateTime(2022, 10, 14, 21, 48, 46, 894, DateTimeKind.Local).AddTicks(8949) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6355), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6356), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6354), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6358), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6359), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6358), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6361), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6362), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6361), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6364), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6364), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6363), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6367), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6367), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6367), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6370), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6370), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6369), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6372), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6373), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6372), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6375), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6375), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6374), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6377), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6378), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6377), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6380), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6380), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6379), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6382), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6383), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6382), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6385), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6385), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6384), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6387), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6388), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6387), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6390), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6390), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6389), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6392), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6393), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6392), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6395), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6396), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6395), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6398), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6399), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6397), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6401), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6402), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6401), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6404), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6404), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6403), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6406), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6407), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6406), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6405) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6409), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6409), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6408), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6411), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6412), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6411), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6414), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6414), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6413), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6417), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6417), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6416), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6419), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6420), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6419), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6422), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6422), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6421), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6424), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6425), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6424), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6427), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6427), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6426), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6429), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6430), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6429), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6432), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6433), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6431), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6436), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6436), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6435), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6440), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6440), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6439), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6442), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6443), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6442), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6445), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6446), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6445), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6450), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6451), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6449), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6454), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6455), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6453), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6457), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6457), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6456), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6459), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6460), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6459), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6462), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6462), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6461), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6464), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6465), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6464), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6467), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6467), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6466), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6469), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6470), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6469), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6113), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6115), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6123), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6125), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6125) });
        }
    }
}
