using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRent.Migrations
{
    public partial class FixedOneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "CarRentInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CarRentInfoId",
                table: "CarInsurance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CarRentInfoId",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BillingId",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "Billing",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarRentInfo",
                table: "CarRentInfo",
                column: "CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Billing",
                table: "Billing",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_CarInsurance_CarRentInfoId",
                table: "CarInsurance",
                column: "CarRentInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Billing_Booking_BookingId",
                table: "Billing",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarInsurance_CarRentInfo_CarRentInfoId",
                table: "CarInsurance",
                column: "CarRentInfoId",
                principalTable: "CarRentInfo",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarRentInfo_Car_CarId",
                table: "CarRentInfo",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Billing_Booking_BookingId",
                table: "Billing");

            migrationBuilder.DropForeignKey(
                name: "FK_CarInsurance_CarRentInfo_CarRentInfoId",
                table: "CarInsurance");

            migrationBuilder.DropForeignKey(
                name: "FK_CarRentInfo_Car_CarId",
                table: "CarRentInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarRentInfo",
                table: "CarRentInfo");

            migrationBuilder.DropIndex(
                name: "IX_CarInsurance_CarRentInfoId",
                table: "CarInsurance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Billing",
                table: "Billing");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "CarRentInfo");

            migrationBuilder.DropColumn(
                name: "CarRentInfoId",
                table: "CarInsurance");

            migrationBuilder.DropColumn(
                name: "CarRentInfoId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "BillingId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Billing");
        }
    }
}
