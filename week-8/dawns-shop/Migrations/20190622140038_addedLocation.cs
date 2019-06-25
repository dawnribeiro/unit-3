using Microsoft.EntityFrameworkCore.Migrations;

namespace dawns_shop.Migrations
{
    public partial class addedLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Plants",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Plants_LocationId",
                table: "Plants",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_Locations_LocationId",
                table: "Plants",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plants_Locations_LocationId",
                table: "Plants");

            migrationBuilder.DropIndex(
                name: "IX_Plants_LocationId",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Plants");
        }
    }
}
