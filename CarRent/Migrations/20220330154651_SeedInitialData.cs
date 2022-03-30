using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRent.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "AddressId", "AddressName", "AddressNumber", "City", "PostCode" },
                values: new object[] { 1, "Address Name", 0, "City", 0 });

            migrationBuilder.InsertData(
                table: "ClientOption",
                columns: new[] { "ClientOptionId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Some WIFI", "WI-FI", 20.0 },
                    { 2, "Some recorder", "Video recorder", 15.0 },
                    { 3, "Some child seat", "Child seat", 15.0 },
                    { 4, "Some mileage", "Unlimited mileage", 30.0 },
                    { 5, "Some phone holder", "Phone holder with power charge", 10.0 }
                });

            migrationBuilder.InsertData(
                table: "AutoPark",
                columns: new[] { "AutoParkId", "AddressId", "CurrentCarCount", "MaxCarCount" },
                values: new object[] { 1, 1, 0, 10 });

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "CarId", "AutoParkId", "Brand", "Class", "DriveType", "EngineVolume", "FuelType", "Geerbox", "Model", "OwnerId", "Type", "Vin" },
                values: new object[] { 1, 1, "Brand", 1, 1, 1.0, 0, 0, "Model", null, "Type", "1234567890" });

            migrationBuilder.InsertData(
                table: "CarRentInfo",
                columns: new[] { "CarId", "Deposit", "DistanceLimit", "IsOccupied", "PricePerDay" },
                values: new object[] { 1, 200, 100, false, 20 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarRentInfo",
                keyColumn: "CarId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClientOption",
                keyColumn: "ClientOptionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClientOption",
                keyColumn: "ClientOptionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClientOption",
                keyColumn: "ClientOptionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClientOption",
                keyColumn: "ClientOptionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClientOption",
                keyColumn: "ClientOptionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "CarId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AutoPark",
                keyColumn: "AutoParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 1);
        }
    }
}
