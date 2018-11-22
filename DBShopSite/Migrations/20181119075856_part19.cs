using Microsoft.EntityFrameworkCore.Migrations;

namespace DBShopSite.Migrations
{
    public partial class part19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "FiltersAtributes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataType",
                table: "Atributes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "FiltersAtributes");

            migrationBuilder.DropColumn(
                name: "DataType",
                table: "Atributes");
        }
    }
}
