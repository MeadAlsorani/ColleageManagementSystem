using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS_Backend.Persistence.Migrations
{
    public partial class Student_NationalId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Students",
                newName: "NationalId");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Students",
                newName: "Name");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NationalId",
                table: "Students",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "FirstName");

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
        }
    }
}
