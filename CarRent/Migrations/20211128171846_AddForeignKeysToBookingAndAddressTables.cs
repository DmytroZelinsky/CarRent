using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRent.Migrations
{
    public partial class AddForeignKeysToBookingAndAddressTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_booking_actualReturnAddressId",
                table: "booking",
                column: "actualReturnAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_booking_receivingAddressId",
                table: "booking",
                column: "receivingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_booking_returnAddressId",
                table: "booking",
                column: "returnAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_booking_address_actualReturnAddressId",
                table: "booking",
                column: "actualReturnAddressId",
                principalTable: "address",
                principalColumn: "addressId");

            migrationBuilder.AddForeignKey(
                name: "FK_booking_address_receivingAddressId",
                table: "booking",
                column: "receivingAddressId",
                principalTable: "address",
                principalColumn: "addressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_booking_address_returnAddressId",
                table: "booking",
                column: "returnAddressId",
                principalTable: "address",
                principalColumn: "addressId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_booking_address_actualReturnAddressId",
                table: "booking");

            migrationBuilder.DropForeignKey(
                name: "FK_booking_address_receivingAddressId",
                table: "booking");

            migrationBuilder.DropForeignKey(
                name: "FK_booking_address_returnAddressId",
                table: "booking");

            migrationBuilder.DropIndex(
                name: "IX_booking_actualReturnAddressId",
                table: "booking");

            migrationBuilder.DropIndex(
                name: "IX_booking_receivingAddressId",
                table: "booking");

            migrationBuilder.DropIndex(
                name: "IX_booking_returnAddressId",
                table: "booking");
        }
    }
}
