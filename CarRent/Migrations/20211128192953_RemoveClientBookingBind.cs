using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRent.Migrations
{
    public partial class RemoveClientBookingBind : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_client_booking",
                table: "client");



            migrationBuilder.DropColumn(
                name: "bookingId",
                table: "client");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "bookingId",
                table: "client",
                type: "int",
                nullable: false,
                defaultValue: 0);



            migrationBuilder.AddForeignKey(
                name: "FK_client_booking",
                table: "client",
                column: "bookingId",
                principalTable: "booking",
                principalColumn: "bookingId");
        }
    }
}
