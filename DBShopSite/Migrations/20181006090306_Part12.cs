using Microsoft.EntityFrameworkCore.Migrations;

namespace DBShopSite.Migrations
{
    public partial class Part12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RolesMenu",
                columns: new[] { "Id", "MenuId", "RoleId", "Status" },
                values: new object[,]
                {
                    { 8, 8, 1, 1 },
                    { 9, 9, 1, 1 },
                    { 10, 10, 1, 1 },
                    { 11, 11, 1, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolesMenu",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RolesMenu",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RolesMenu",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RolesMenu",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
