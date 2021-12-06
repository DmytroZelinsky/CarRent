using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRent.Migrations
{
    public partial class AddFieldsToClientService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "oneWay",
                table: "clientService",
                newName: "HasVideoRecorder");

            migrationBuilder.AddColumn<bool>(
                name: "HasPhoneHolder",
                table: "clientService",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasUnlimitedMileage",
                table: "clientService",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasPhoneHolder",
                table: "clientService");

            migrationBuilder.DropColumn(
                name: "HasUnlimitedMileage",
                table: "clientService");

            migrationBuilder.RenameColumn(
                name: "HasVideoRecorder",
                table: "clientService",
                newName: "oneWay");
        }
    }
}
