using Microsoft.EntityFrameworkCore.Migrations;

namespace dawns_shop.Migrations
{
    public partial class changedLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Locations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "locationId",
                table: "Locations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_locationId",
                table: "Locations",
                column: "locationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Locations_locationId",
                table: "Locations",
                column: "locationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Locations_locationId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_locationId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "locationId",
                table: "Locations");
        }
    }
}
