using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRent.Migrations
{
    public partial class AddOneToManyForClientBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "booking",
                type: "int",
                nullable: false,
                defaultValue: 24);

            migrationBuilder.CreateIndex(
                name: "IX_booking_ClientId",
                table: "booking",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_booking_client_ClientId",
                table: "booking",
                column: "ClientId",
                principalTable: "client",
                principalColumn: "clientId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_booking_client_ClientId",
                table: "booking");

            migrationBuilder.DropIndex(
                name: "IX_booking_ClientId",
                table: "booking");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "booking");
        }
    }
}
