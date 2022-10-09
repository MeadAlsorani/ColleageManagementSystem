using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS_Backend.Persistence.Migrations
{
    public partial class coursesvalues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "ClassId", "CreationDate", "EndDate", "LessonDuration", "ModificationDate", "Name", "Price", "StaffId", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6355), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6356), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6354), "KG1", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6354) },
                    { 2, 1, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6358), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6359), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6358), "KG2", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6357) },
                    { 3, 1, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6361), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6362), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6361), "KG3", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6360) },
                    { 4, 2, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6364), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6364), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6363), "Level 1", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6363) },
                    { 5, 2, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6367), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6367), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6367), "Level 2", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6366) },
                    { 6, 2, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6370), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6370), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6369), "Level 3", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6369) },
                    { 7, 2, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6372), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6373), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6372), "Level 4", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6371) },
                    { 8, 2, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6375), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6375), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6374), "Level 5", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6374) },
                    { 9, 2, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6377), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6378), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6377), "Level 6", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6376) },
                    { 10, 2, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6380), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6380), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6379), "Level 7", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6379) },
                    { 11, 2, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6382), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6383), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6382), "Level 8", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6382) },
                    { 12, 3, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6385), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6385), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6384), "Music", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6384) },
                    { 13, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6387), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6388), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6387), "German A1", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6386) },
                    { 14, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6390), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6390), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6389), "German A2", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6389) },
                    { 15, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6392), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6393), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6392), "German B1", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6391) },
                    { 16, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6395), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6396), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6395), "German B2", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6394) },
                    { 17, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6398), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6399), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6397), "German C1", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6397) },
                    { 18, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6401), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6402), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6401), "German C2", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6400) },
                    { 19, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6404), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6404), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6403), "German Conversation Course", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6403) },
                    { 20, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6406), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6407), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6406), "Turkish A1", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6405) },
                    { 21, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6409), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6409), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6408), "Turkish A2", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6408) },
                    { 22, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6411), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6412), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6411), "Turkish B1", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6410) },
                    { 23, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6414), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6414), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6413), "Turkish B2", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6413) },
                    { 24, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6417), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6417), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6416), "Turkish C1", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6416) },
                    { 25, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6419), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6420), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6419), "Turkish C2", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6418) },
                    { 26, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6422), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6422), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6421), "Turkish Conversation Course", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6421) },
                    { 27, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6424), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6425), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6424), "Arabic A1", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6423) },
                    { 28, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6427), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6427), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6426), "Arabic A2", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6426) },
                    { 29, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6429), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6430), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6429), "Arabic B1", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6428) },
                    { 30, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6432), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6433), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6431), "French A1", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6431) },
                    { 31, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6436), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6436), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6435), "French A2", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6435) },
                    { 32, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6440), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6440), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6439), "French B1", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6439) },
                    { 33, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6442), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6443), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6442), "French B2", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6442) },
                    { 34, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6445), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6446), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6445), "French C1", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6444) },
                    { 35, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6450), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6451), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6449), "French C2", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6448) },
                    { 36, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6454), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6455), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6453), "English A1", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6452) },
                    { 37, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6457), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6457), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6456), "English A2", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6456) },
                    { 38, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6459), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6460), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6459), "English B1", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6458) },
                    { 39, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6462), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6462), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6461), "English B2", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6461) },
                    { 40, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6464), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6465), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6464), "English C1", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6463) },
                    { 41, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6467), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6467), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6466), "English C2", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6466) },
                    { 42, 4, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6469), new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6470), 0, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6469), "English Conversation Course", 0, null, new DateTime(2022, 10, 9, 21, 47, 0, 776, DateTimeKind.Local).AddTicks(6468) }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 38, 56, 105, DateTimeKind.Local).AddTicks(4227), new DateTime(2022, 10, 9, 21, 38, 56, 105, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 38, 56, 105, DateTimeKind.Local).AddTicks(4231), new DateTime(2022, 10, 9, 21, 38, 56, 105, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 38, 56, 105, DateTimeKind.Local).AddTicks(4233), new DateTime(2022, 10, 9, 21, 38, 56, 105, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "EducationClass",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 38, 56, 105, DateTimeKind.Local).AddTicks(4235), new DateTime(2022, 10, 9, 21, 38, 56, 105, DateTimeKind.Local).AddTicks(4236) });
        }
    }
}
