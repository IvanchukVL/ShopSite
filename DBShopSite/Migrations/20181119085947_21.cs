using Microsoft.EntityFrameworkCore.Migrations;

namespace DBShopSite.Migrations
{
    public partial class _21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TypeFilter",
                table: "Filters",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TypeFilter",
                table: "Filters",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150);
        }
    }
}
