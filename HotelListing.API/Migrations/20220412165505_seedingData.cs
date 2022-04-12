using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.API.Migrations
{
    public partial class seedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { 1, "Jamaica", "JM" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { 2, "Brazil", "BR" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { 3, "England", "ENG" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "42 Chive Road", 3, "Heaney-Pollich", 1.2 },
                    { 2, "9 Aberg Court", 2, "Wuckert Group", 2.1000000000000001 },
                    { 3, "84 Thompson Crossing", 2, "Hermiston-Turcotte", 4.7000000000000002 },
                    { 4, "70 Stephen Place", 1, "Will-Keebler", 3.3999999999999999 },
                    { 5, "52 Stephen Way", 3, "Schuppe-Kovacek", 1.3999999999999999 },
                    { 6, "902 Tony Trail", 3, "Dietrich, Berge and Deckow", 4.5999999999999996 },
                    { 7, "9968 Bayside Alley", 3, "Monahan, O'Reilly and Greenholt", 4.2999999999999998 },
                    { 8, "5846 Debra Plaza", 2, "Christiansen-Huel", 4.9000000000000004 },
                    { 9, "99440 Melrose Crossing", 3, "Emmerich, Gutkowski and MacGyver", 2.8999999999999999 },
                    { 10, "1490 Cardinal Street", 3, "Toy Group", 1.5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
