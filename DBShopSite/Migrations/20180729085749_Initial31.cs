using Microsoft.EntityFrameworkCore.Migrations;

namespace DBShopSite.Migrations
{
    public partial class Initial31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age2",
                table: "Users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age2",
                table: "Users");
        }
    }
}
