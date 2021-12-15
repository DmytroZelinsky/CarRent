using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRent.Migrations
{
    public partial class DroppedForeignKeyInClientAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientAddition_Booking_BookingId",
                table: "ClientAddition");

            migrationBuilder.DropIndex(
                name: "IX_ClientAddition_BookingId",
                table: "ClientAddition");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "ClientAddition");

            migrationBuilder.DropColumn(
                name: "ClientAdditionId",
                table: "Booking");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "ClientAddition",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClientAdditionId",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ClientAddition_BookingId",
                table: "ClientAddition",
                column: "BookingId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientAddition_Booking_BookingId",
                table: "ClientAddition",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
