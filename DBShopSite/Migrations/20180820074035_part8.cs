using Microsoft.EntityFrameworkCore.Migrations;

namespace DBShopSite.Migrations
{
    public partial class part8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            return;
            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Code", "Command", "Name", "ParentId", "Status", "Url" },
                values: new object[] { 10, "SpiningReels111", "SpiningReels", "Тягові катушки", 3, 1, null });
        }
    }
}
