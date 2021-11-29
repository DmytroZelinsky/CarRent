using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRent.Migrations
{
    public partial class AddOneToManyForCarBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "booking",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_booking_CarId",
                table: "booking",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_booking_car_CarId",
                table: "booking",
                column: "CarId",
                principalTable: "car",
                principalColumn: "carId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_booking_car_CarId",
                table: "booking");

            migrationBuilder.DropIndex(
                name: "IX_booking_CarId",
                table: "booking");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "booking");
        }
    }
}
