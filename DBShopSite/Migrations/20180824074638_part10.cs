using Microsoft.EntityFrameworkCore.Migrations;

namespace DBShopSite.Migrations
{
    public partial class part10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "RoleId", "Status", "UserId" },
                values: new object[] { 1, 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UsersRoles",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
