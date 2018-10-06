using Microsoft.EntityFrameworkCore.Migrations;

namespace DBShopSite.Migrations
{
    public partial class part11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Code", "Command", "Name", "ParentId", "Status", "Url" },
                values: new object[] { 10, "FeederReelsBT", "FeederReelsBT", "З бертранером", 7, 1, null });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Code", "Command", "Name", "ParentId", "Status", "Url" },
                values: new object[] { 11, "FeederReelsWBT", "FeederReelsWBT", "Без бертранером", 7, 1, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
