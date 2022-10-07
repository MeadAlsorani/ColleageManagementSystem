using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS_BackEnd.Identity.Migrations
{
    public partial class addrefreshtoken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "252c11a8-7035-423e-be2c-85b006a8a8c4",
                column: "ConcurrencyStamp",
                value: "1e6d6f82-e1dd-45e9-b2a9-18fbcf0f25b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ebd984a-45cf-4fcd-b48d-ad6ae71846b1",
                column: "ConcurrencyStamp",
                value: "5241c44b-5eff-4958-8a99-fc5634a154b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a0cc8f0-7259-4684-8b1f-9af5ee16e3bd",
                column: "ConcurrencyStamp",
                value: "0e93fc26-6b9f-4ee7-98db-07fee1dcf326");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dde1228b-9b59-42eb-90cb-a480ff5910a7",
                column: "ConcurrencyStamp",
                value: "7da8a806-842a-417a-b66e-2d3772a9b551");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "079b9eeb-d67c-4f53-b14e-cbbf0739e2bc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c78b28de-a43d-40f4-8e3e-52d1440cce4b", "AQAAAAEAACcQAAAAEOq+zgzMZbHJGvTr8gBSXpI8il2u7EEEwhY5A9JV0mbWol1OEjRCVo30c2gyRmK4Tw==", "8217d443-9f4a-4d33-9875-df18552be324" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09dd9295-5477-4818-8755-f73bfa6b6fc9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7ff6431-7ff5-43fc-957c-96d2165d39be", "AQAAAAEAACcQAAAAEMBbFkMq/kAhNOdOUmWmaOnlFIS/6K+hAJTr9rsSLrFeK/L/NmI2BpFKZj54UDNxyQ==", "c6aa7ca3-8998-4264-a746-a4fd27efd1e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fb55069-1031-49b9-9f43-ee196fb67650",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c6ed9b9-f4a6-402e-85ac-27a9dc378403", "AQAAAAEAACcQAAAAENeAgy2PBDP6PzHkTWJ8Wc/ambHJWhBOhzABrinPYDO0Ix2a5ze1TPhl4To+E4Kw7Q==", "2abae6bd-857a-4c60-ae36-238a93f38698" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8afb94e5-e55e-4479-9b40-8116628c3c82",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42235ced-949a-40b8-95a9-23ad0a31cffe", "AQAAAAEAACcQAAAAEApv9tpc6zqcpkNK0ZoWvupZiKXKjrCYjLM6ck9uAOcS1Nd0wWYQHiAHkxYOWeUDEQ==", "085ea196-a86f-469c-b435-29834c3ac34d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "252c11a8-7035-423e-be2c-85b006a8a8c4",
                column: "ConcurrencyStamp",
                value: "e1bff667-7819-4e1f-8243-9d535bc15a8b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ebd984a-45cf-4fcd-b48d-ad6ae71846b1",
                column: "ConcurrencyStamp",
                value: "3e9690ec-5eb7-43bd-8388-ed94364641f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a0cc8f0-7259-4684-8b1f-9af5ee16e3bd",
                column: "ConcurrencyStamp",
                value: "c4f3d4b0-707d-4321-808b-79208b4d04dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dde1228b-9b59-42eb-90cb-a480ff5910a7",
                column: "ConcurrencyStamp",
                value: "82bc183b-b8ee-4b48-bbed-348217cc2701");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "079b9eeb-d67c-4f53-b14e-cbbf0739e2bc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cfab0b8-2041-47e6-a676-1714d26d8c43", "AQAAAAEAACcQAAAAEN8SDEzDUM5euo90iqdaPZB69ODX9e3ck3LwzMeXGIInXidPpYlhRG0uIddnlSw1Lw==", "8eced4a3-d47e-4e18-9fdb-b6fdf65f2473" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09dd9295-5477-4818-8755-f73bfa6b6fc9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87208784-c0ce-4b9f-842f-2822c80d9dbb", "AQAAAAEAACcQAAAAEM5H4Ibk8FUnIY88quRnAANF6qLzCBbbG2tcPtme1HvrpwhoZJngLoPNKSjFIN6bkQ==", "d46d64b6-6b05-4a22-b4fc-e09c8b0c0a68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fb55069-1031-49b9-9f43-ee196fb67650",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9164922-7909-4f7b-874a-ab671b2cb1b6", "AQAAAAEAACcQAAAAEMwf7A5My6jYLXj/gxLL1QHqcFBKCMGcrUPD/ghYTP2VtwLltI3q6PH+ryvNqq9prQ==", "1475d71e-e082-4e64-b13c-b50d5e839a91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8afb94e5-e55e-4479-9b40-8116628c3c82",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "493e1aa9-07ac-4274-9026-badf415cceee", "AQAAAAEAACcQAAAAEPtiI7ZkUPjuEGg/rnnQJqqTMT5FTsxoOqwLkqdmW3ZjNlh2zaPojv2xqYwFpEWZgw==", "fb206557-5794-4264-a965-b8b6d5cebba3" });
        }
    }
}
