using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CargoTrack.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedCities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "PlateCode", "Region", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adana", 1, 3, null },
                    { 2, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adıyaman", 2, 7, null },
                    { 3, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Afyonkarahisar", 3, 2, null },
                    { 4, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Ağrı", 4, 6, null },
                    { 5, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Amasya", 5, 5, null },
                    { 6, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Ankara", 6, 4, null },
                    { 7, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Antalya", 7, 3, null },
                    { 8, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Artvin", 8, 5, null },
                    { 9, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Aydın", 9, 2, null },
                    { 10, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Balıkesir", 10, 1, null },
                    { 11, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Bilecik", 11, 1, null },
                    { 12, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Bingöl", 12, 6, null },
                    { 13, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Bitlis", 13, 6, null },
                    { 14, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Bolu", 14, 5, null },
                    { 15, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Burdur", 15, 3, null },
                    { 16, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Bursa", 16, 1, null },
                    { 17, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Çanakkale", 17, 1, null },
                    { 18, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Çankırı", 18, 4, null },
                    { 19, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Çorum", 19, 5, null },
                    { 20, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Denizli", 20, 2, null },
                    { 21, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Diyarbakır", 21, 7, null },
                    { 22, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Edirne", 22, 1, null },
                    { 23, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Elazığ", 23, 6, null },
                    { 24, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Erzincan", 24, 6, null },
                    { 25, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Erzurum", 25, 6, null },
                    { 26, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Eskişehir", 26, 4, null },
                    { 27, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Gaziantep", 27, 7, null },
                    { 28, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Giresun", 28, 5, null },
                    { 29, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Gümüşhane", 29, 5, null },
                    { 30, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Hakkari", 30, 6, null },
                    { 31, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Hatay", 31, 3, null },
                    { 32, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Isparta", 32, 3, null },
                    { 33, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Mersin", 33, 3, null },
                    { 34, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "İstanbul", 34, 1, null },
                    { 35, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "İzmir", 35, 2, null },
                    { 36, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kars", 36, 6, null },
                    { 37, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kastamonu", 37, 5, null },
                    { 38, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kayseri", 38, 4, null },
                    { 39, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kırklareli", 39, 1, null },
                    { 40, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kırşehir", 40, 4, null },
                    { 41, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kocaeli", 41, 1, null },
                    { 42, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Konya", 42, 4, null },
                    { 43, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kütahya", 43, 2, null },
                    { 44, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Malatya", 44, 6, null },
                    { 45, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Manisa", 45, 2, null },
                    { 46, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kahramanmaraş", 46, 3, null },
                    { 47, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Mardin", 47, 7, null },
                    { 48, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Muğla", 48, 2, null },
                    { 49, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Muş", 49, 6, null },
                    { 50, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Nevşehir", 50, 4, null },
                    { 51, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Niğde", 51, 4, null },
                    { 52, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Ordu", 52, 5, null },
                    { 53, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Rize", 53, 5, null },
                    { 54, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Sakarya", 54, 1, null },
                    { 55, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Samsun", 55, 5, null },
                    { 56, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Siirt", 56, 7, null },
                    { 57, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Sinop", 57, 5, null },
                    { 58, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Sivas", 58, 4, null },
                    { 59, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tekirdağ", 59, 1, null },
                    { 60, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tokat", 60, 5, null },
                    { 61, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Trabzon", 61, 5, null },
                    { 62, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tunceli", 62, 6, null },
                    { 63, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Şanlıurfa", 63, 7, null },
                    { 64, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Uşak", 64, 2, null },
                    { 65, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Van", 65, 6, null },
                    { 66, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Yozgat", 66, 4, null },
                    { 67, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Zonguldak", 67, 5, null },
                    { 68, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Aksaray", 68, 4, null },
                    { 69, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Bayburt", 69, 5, null },
                    { 70, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Karaman", 70, 4, null },
                    { 71, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kırıkkale", 71, 4, null },
                    { 72, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Batman", 72, 7, null },
                    { 73, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Şırnak", 73, 7, null },
                    { 74, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Bartın", 74, 5, null },
                    { 75, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Ardahan", 75, 6, null },
                    { 76, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Iğdır", 76, 6, null },
                    { 77, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Yalova", 77, 1, null },
                    { 78, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Karabük", 78, 5, null },
                    { 79, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kilis", 79, 7, null },
                    { 80, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Osmaniye", 80, 3, null },
                    { 81, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Düzce", 81, 5, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 81);
        }
    }
}
