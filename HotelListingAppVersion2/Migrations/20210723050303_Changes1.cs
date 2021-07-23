using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListingAppVersion2.Migrations
{
    public partial class Changes1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Hotels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Countries",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Hotels",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Countries",
                newName: "id");
        }
    }
}
