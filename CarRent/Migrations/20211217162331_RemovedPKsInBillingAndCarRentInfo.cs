using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRent.Migrations
{
    public partial class RemovedPKsInBillingAndCarRentInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Billing_BillingId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_CarRentInfo_CarRentInfoId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_CarInsurance_CarRentInfo_CarRentInfoId",
                table: "CarInsurance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarRentInfo",
                table: "CarRentInfo");

            migrationBuilder.DropIndex(
                name: "IX_CarInsurance_CarRentInfoId",
                table: "CarInsurance");

            migrationBuilder.DropIndex(
                name: "IX_Car_CarRentInfoId",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Booking_BillingId",
                table: "Booking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Billing",
                table: "Billing");

            migrationBuilder.DropColumn(
                name: "CarRentInfoId",
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
                name: "BillingId",
                table: "Billing");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarRentInfoId",
                table: "CarRentInfo",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

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
                name: "BillingId",
                table: "Billing",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarRentInfo",
                table: "CarRentInfo",
                column: "CarRentInfoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Billing",
                table: "Billing",
                column: "BillingId");

            migrationBuilder.CreateIndex(
                name: "IX_CarInsurance_CarRentInfoId",
                table: "CarInsurance",
                column: "CarRentInfoId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CarInsurance_CarRentInfo_CarRentInfoId",
                table: "CarInsurance",
                column: "CarRentInfoId",
                principalTable: "CarRentInfo",
                principalColumn: "CarRentInfoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
