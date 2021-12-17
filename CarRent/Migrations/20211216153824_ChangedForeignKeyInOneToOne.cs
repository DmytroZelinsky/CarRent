using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRent.Migrations
{
    public partial class ChangedForeignKeyInOneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Billing_Booking_BookingId",
                table: "Billing");

            migrationBuilder.DropForeignKey(
                name: "FK_CarRentInfo_Car_CarId",
                table: "CarRentInfo");

            migrationBuilder.DropIndex(
                name: "IX_CarRentInfo_CarId",
                table: "CarRentInfo");

            migrationBuilder.DropIndex(
                name: "IX_Billing_BookingId",
                table: "Billing");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "CarRentInfo");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Billing");

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarRentInfoId",
                table: "Car",
                column: "CarRentInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_BillingId",
                table: "Booking",
                column: "BillingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Billing_BillingId",
                table: "Booking",
                column: "BillingId",
                principalTable: "Billing",
                principalColumn: "BillingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_CarRentInfo_CarRentInfoId",
                table: "Car",
                column: "CarRentInfoId",
                principalTable: "CarRentInfo",
                principalColumn: "CarRentInfoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Billing_BillingId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_CarRentInfo_CarRentInfoId",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_CarRentInfoId",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Booking_BillingId",
                table: "Booking");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "CarRentInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "Billing",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CarRentInfo_CarId",
                table: "CarRentInfo",
                column: "CarId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Billing_BookingId",
                table: "Billing",
                column: "BookingId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Billing_Booking_BookingId",
                table: "Billing",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarRentInfo_Car_CarId",
                table: "CarRentInfo",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
