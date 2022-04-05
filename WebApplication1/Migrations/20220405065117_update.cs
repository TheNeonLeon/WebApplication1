using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: 1,
                column: "Temperature",
                value: 10);

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "Id", "Temperature", "WeatherName" },
                values: new object[] { 2, 20, "Sunny" });

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "Id", "Temperature", "WeatherName" },
                values: new object[] { 3, 0, "Snowy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: 1,
                column: "Temperature",
                value: 5);
        }
    }
}
