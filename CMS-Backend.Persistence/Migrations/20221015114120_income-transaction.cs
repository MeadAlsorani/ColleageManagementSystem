using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS_Backend.Persistence.Migrations
{
    public partial class incometransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "StudentCourses");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "StudentCourses");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "StudentCourses");

            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "Staffs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "IncomeTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncomeTransactions_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IncomeTransactions_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(83), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(84), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(82), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(87), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(88), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(86), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(91), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(91), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(90), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(94), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(95), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(94), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(98), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(98), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(97), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(101), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(101), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(100), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(5987), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(5988), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(5986), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6007), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6008), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6006), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6011), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6012), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6011), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6016), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6016), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6015), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6020), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6021), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6019), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6024), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6024), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6023), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6027), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6028), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6027), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6031), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6032), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6030), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6035), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6035), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6034), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6039), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6039), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6038), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6043), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6044), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6042), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6047), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6047), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6046), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6051), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6052), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6050), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6055), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6056), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6055), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6059), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6059), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6058), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6062), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6063), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6062), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6066), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6067), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6066), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6070), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6071), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6069), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6074), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6075), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6074), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6078), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6079), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6078), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6083), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6084), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6082), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6087), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6088), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6087), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6092), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6093), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6091), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6096), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6096), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6095), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6100), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6100), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6099), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6104), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6104), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6103), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6107), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6108), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6106), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6111), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6111), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6110), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6116), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6116), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6114), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6119), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6120), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6118), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6123), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6124), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6122), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6127), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6128), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6126), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6131), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6132), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6130), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6135), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6135), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6134), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6138), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6139), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6138), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6142), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6143), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6141), new DateTime(2022, 10, 15, 14, 41, 20, 484, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 483, DateTimeKind.Local).AddTicks(9628), new DateTime(2022, 10, 15, 14, 41, 20, 483, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 483, DateTimeKind.Local).AddTicks(9636), new DateTime(2022, 10, 15, 14, 41, 20, 483, DateTimeKind.Local).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 483, DateTimeKind.Local).AddTicks(9638), new DateTime(2022, 10, 15, 14, 41, 20, 483, DateTimeKind.Local).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 41, 20, 483, DateTimeKind.Local).AddTicks(9640), new DateTime(2022, 10, 15, 14, 41, 20, 483, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.CreateIndex(
                name: "IX_IncomeTransactions_CourseId",
                table: "IncomeTransactions",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeTransactions_StudentId",
                table: "IncomeTransactions",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IncomeTransactions");

            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "StudentCourses",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "StudentCourses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "StudentCourses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "Staffs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
