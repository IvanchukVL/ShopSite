using Microsoft.EntityFrameworkCore.Migrations;

namespace DBShopSite.Migrations
{
    public partial class Part13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TovarGroupId",
                table: "Menu",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TovarGroupId",
                table: "Menu");
        }
    }
}
