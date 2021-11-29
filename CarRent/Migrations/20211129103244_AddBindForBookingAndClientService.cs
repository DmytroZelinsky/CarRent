using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRent.Migrations
{
    public partial class AddBindForBookingAndClientService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientServiceId",
                table: "booking",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_booking_ClientServiceId",
                table: "booking",
                column: "ClientServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_booking_clientService_ClientServiceId",
                table: "booking",
                column: "ClientServiceId",
                principalTable: "clientService",
                principalColumn: "clientServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_booking_clientService_ClientServiceId",
                table: "booking");

            migrationBuilder.DropIndex(
                name: "IX_booking_ClientServiceId",
                table: "booking");

            migrationBuilder.DropColumn(
                name: "ClientServiceId",
                table: "booking");
        }
    }
}
