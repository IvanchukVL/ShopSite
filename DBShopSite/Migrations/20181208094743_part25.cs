using Microsoft.EntityFrameworkCore.Migrations;

namespace DBShopSite.Migrations
{
    public partial class part25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeFilter",
                table: "Filters");

            migrationBuilder.AddColumn<int>(
                name: "Kind",
                table: "Filters",
                maxLength: 150,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kind",
                table: "Filters");

            migrationBuilder.AddColumn<string>(
                name: "TypeFilter",
                table: "Filters",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }
    }
}
