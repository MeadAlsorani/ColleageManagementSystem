using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS_Backend.Persistence.Migrations
{
    public partial class Student_CoursesContent_Attendance_Description : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoursesContent",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Attendances",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4276), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4276), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4275), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4286), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4287), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4286), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4289), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4289), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4288), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4291), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4292), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4291), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4294), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4294), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4293), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4297), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4297), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4296), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4301), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4303), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4303), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4302), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4305), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4306), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4305), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4308), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4308), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4307), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4310), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4311), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4310), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4313), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4313), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4313), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4316), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4316), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4315), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4319), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4320), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4319), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4322), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4322), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4321), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4324), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4325), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4324), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4327), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4327), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4326), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4326) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4329), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4330), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4329), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4332), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4332), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4331), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4334), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4335), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4334), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4333) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4337), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4337), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4336), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4339), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4340), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4339), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4342), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4342), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4341), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4344), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4345), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4344), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4347), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4347), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4346), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4349), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4351), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4349), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4353), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4353), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4352), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4355), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4356), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4355), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4358), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4358), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4357), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4360), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4360), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4360), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4363), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4363), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4362), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4365), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4365), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4365), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4368), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4368), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4367), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4370), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4370), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4370), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4372), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4372), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4375), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4375), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4375), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4378), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4378), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4377), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4380), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4381), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4380), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4383), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4383), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4382), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4385), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4386), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4385), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4388), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4388), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4387), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4390), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4391), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4390), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4009), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4012), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4014), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4015), new DateTime(2022, 10, 31, 2, 18, 22, 909, DateTimeKind.Local).AddTicks(4016) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoursesContent",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Attendances");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2774), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2774), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2773), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2777), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2778), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2777), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2780), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2780), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2779), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2782), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2783), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2782), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2785), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2785), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2784), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2787), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2788), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2787), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2790), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2790), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2790), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2793), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2794), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2793), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2796), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2796), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2795), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2799), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2799), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2798), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2802), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2802), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2802), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2805), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2806), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2805), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2808), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2808), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2807), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2810), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2810), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2810), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2813), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2813), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2812), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2815), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2816), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2815), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2818), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2818), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2817), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2820), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2821), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2820), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2823), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2823), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2822), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2826), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2827), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2826), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2829), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2829), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2828), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2831), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2832), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2831), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2834), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2834), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2833), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2836), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2837), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2836), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2839), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2839), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2838), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2841), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2842), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2841), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2844), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2844), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2843), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2846), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2847), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2846), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2849), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2849), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2848), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2851), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2852), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2851), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2854), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2854), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2853), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2856), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2857), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2856), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2859), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2859), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2858), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2861), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2862), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2861), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2864), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2864), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2863), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2868), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2868), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2867), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2870), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2871), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2870), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2873), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2873), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2872), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2875), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2876), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2875), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2878), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2878), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2877), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2881), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2881), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2880), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2883), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2884), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2883), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2545), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2548), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2550), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2552), new DateTime(2022, 10, 30, 23, 0, 3, 630, DateTimeKind.Local).AddTicks(2552) });
        }
    }
}
