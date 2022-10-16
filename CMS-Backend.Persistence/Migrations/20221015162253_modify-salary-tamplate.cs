using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS_Backend.Persistence.Migrations
{
    public partial class modifysalarytamplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OverTimePerHour",
                table: "SalaryTemplates",
                newName: "SalaryPerHour");

            migrationBuilder.AddColumn<int>(
                name: "BasicSalary",
                table: "SalaryTemplates",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasicSalary",
                table: "SalaryTemplates");

            migrationBuilder.RenameColumn(
                name: "SalaryPerHour",
                table: "SalaryTemplates",
                newName: "OverTimePerHour");

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
        }
    }
}
