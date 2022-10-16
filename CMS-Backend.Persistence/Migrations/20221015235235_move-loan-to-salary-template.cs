using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS_Backend.Persistence.Migrations
{
    public partial class moveloantosalarytemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Staffs_StaffId",
                table: "Loans");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "Loans",
                newName: "SalaryTemplateId");

            migrationBuilder.RenameIndex(
                name: "IX_Loans_StaffId",
                table: "Loans",
                newName: "IX_Loans_SalaryTemplateId");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6490), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6490), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6489), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6494), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6494), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6493), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6497), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6498), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6497), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6501), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6502), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6500), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6506), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6506), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6505), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6508), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6508), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6508), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6510), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6511), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6510), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6514), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6514), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6513), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6516), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6516), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6516), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6519), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6519), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6518), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6521), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6521), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6520), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6523), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6524), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6523), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6526), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6526), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6526), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6529), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6530), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6529), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6532), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6532), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6531), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6534), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6535), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6534), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6537), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6538), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6537), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6540), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6540), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6539), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6542), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6543), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6542), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6545), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6545), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6544), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6549), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6549), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6548), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6551), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6552), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6551), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6554), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6554), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6553), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6556), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6557), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6556), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6559), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6559), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6558), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6561), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6561), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6561), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6564), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6565), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6564), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6567), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6567), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6566), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6570), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6570), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6569), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6572), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6573), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6572), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6575), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6575), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6574), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6577), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6577), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6577), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6580), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6580), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6579), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6582), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6583), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6582), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6585), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6585), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6584), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6584) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6587), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6588), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6587), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6590), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6590), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6589), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6589) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6599), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6599), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6602), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6602), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6601), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6604), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6605), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6604), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6607), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6607), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6606), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6609), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6610), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6609), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6271), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6273), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6275), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6277), new DateTime(2022, 10, 16, 2, 52, 35, 270, DateTimeKind.Local).AddTicks(6279) });

            migrationBuilder.CreateIndex(
                name: "IX_SalaryTemplates_StaffId",
                table: "SalaryTemplates",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_SalaryTemplates_SalaryTemplateId",
                table: "Loans",
                column: "SalaryTemplateId",
                principalTable: "SalaryTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryTemplates_Staffs_StaffId",
                table: "SalaryTemplates",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_SalaryTemplates_SalaryTemplateId",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_SalaryTemplates_Staffs_StaffId",
                table: "SalaryTemplates");

            migrationBuilder.DropIndex(
                name: "IX_SalaryTemplates_StaffId",
                table: "SalaryTemplates");

            migrationBuilder.RenameColumn(
                name: "SalaryTemplateId",
                table: "Loans",
                newName: "StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_Loans_SalaryTemplateId",
                table: "Loans",
                newName: "IX_Loans_StaffId");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6891), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6892), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6891), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6901), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6901), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6900), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6903), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6904), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6903), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6907), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6907), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6907), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6911), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6913), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6913), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6912), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6916), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6916), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6915), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6918), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6918), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6918), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6921), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6921), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6920), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6923), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6924), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6923), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6926), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6926), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6925), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6928), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6929), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6928), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6931), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6931), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6933), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6934), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6933), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6936), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6936), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6935), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6938), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6939), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6938), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6941), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6941), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6940), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6946), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6947), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6946), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6949), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6949), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6948), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6951), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6952), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6951), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6954), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6954), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6953), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6956), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6957), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6956), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6955) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6959), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6959), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6958), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6961), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6962), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6961), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6964), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6964), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6963), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6966), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6967), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6966), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6969), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6969), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6968), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6971), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6972), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6971), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6974), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6974), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6973), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6977), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6977), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6977), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6979), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6980), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6979), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6982), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6982), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6981), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6984), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6985), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6984), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6987), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6987), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6986), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6989), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6990), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6989), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6992), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6992), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6991), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6994), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6995), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6994), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6997), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6997), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6996), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6999), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(7000), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6999), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(7002), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(7002), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(7001), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(7004), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(7005), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(7004), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(7007), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(7007), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(7006), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6640), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6643), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6645), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6647), new DateTime(2022, 10, 15, 19, 22, 52, 905, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Staffs_StaffId",
                table: "Loans",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
