using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRent.Migrations
{
    public partial class ChangedClientAdditionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientAddition");

            migrationBuilder.CreateTable(
                name: "ClientOption",
                columns: table => new
                {
                    ClientOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientOption", x => x.ClientOptionId);
                });

            migrationBuilder.CreateTable(
                name: "BookingClientOption",
                columns: table => new
                {
                    BookingsBookingId = table.Column<int>(type: "int", nullable: false),
                    ClientOptionsClientOptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingClientOption", x => new { x.BookingsBookingId, x.ClientOptionsClientOptionId });
                    table.ForeignKey(
                        name: "FK_BookingClientOption_Booking_BookingsBookingId",
                        column: x => x.BookingsBookingId,
                        principalTable: "Booking",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingClientOption_ClientOption_ClientOptionsClientOptionId",
                        column: x => x.ClientOptionsClientOptionId,
                        principalTable: "ClientOption",
                        principalColumn: "ClientOptionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingClientOption_ClientOptionsClientOptionId",
                table: "BookingClientOption",
                column: "ClientOptionsClientOptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingClientOption");

            migrationBuilder.DropTable(
                name: "ClientOption");

            migrationBuilder.CreateTable(
                name: "ClientAddition",
                columns: table => new
                {
                    ClientAdditionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HasChildSeat = table.Column<bool>(type: "bit", nullable: false),
                    HasDriver = table.Column<bool>(type: "bit", nullable: false),
                    HasPhoneHolder = table.Column<bool>(type: "bit", nullable: false),
                    HasUnlimitedMileage = table.Column<bool>(type: "bit", nullable: false),
                    HasVideoRecorder = table.Column<bool>(type: "bit", nullable: false),
                    HasWiFi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientAddition", x => x.ClientAdditionId);
                });
        }
    }
}
