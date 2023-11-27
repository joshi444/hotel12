using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelRoomBookingApi.Migrations
{
    public partial class url : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvailableRooms",
                table: "Hotels",
                newName: "Rating");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Hotels");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Hotels",
                newName: "AvailableRooms");
        }
    }
}
