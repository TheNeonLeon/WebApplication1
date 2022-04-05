using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class addedseeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Weather_WeatherId",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_WeatherId",
                table: "Country",
                newName: "IX_Country_WeatherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "CountryId");

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "CountryName", "WeatherId" },
                values: new object[] { 1, "Sweden", 1 });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "CountryName", "WeatherId" },
                values: new object[] { 2, "Spain", 2 });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "CountryName", "WeatherId" },
                values: new object[] { 3, "Norway", 3 });

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Weather_WeatherId",
                table: "Country",
                column: "WeatherId",
                principalTable: "Weather",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Country_Weather_WeatherId",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.RenameIndex(
                name: "IX_Country_WeatherId",
                table: "Countries",
                newName: "IX_Countries_WeatherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Weather_WeatherId",
                table: "Countries",
                column: "WeatherId",
                principalTable: "Weather",
                principalColumn: "Id");
        }
    }
}
