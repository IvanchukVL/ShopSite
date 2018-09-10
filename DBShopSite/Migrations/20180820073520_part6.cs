using Microsoft.EntityFrameworkCore.Migrations;

namespace DBShopSite.Migrations
{
    public partial class part6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "Command", "Name", "ParentId" },
                values: new object[] { "FeederReels", "FeederReels", "Фідерні катушки", 3 });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Code", "Command", "Name", "ParentId", "Status", "Url" },
                values: new object[] { 8, "FloadReels", "FloadReels", "Поплавочні катушки", 3, 1, null });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Code", "Command", "Name", "ParentId", "Status", "Url" },
                values: new object[] { 9, "SpiningReels", "SpiningReels", "Спінінгові катушки", 3, 1, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            return;
            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "Command", "Name", "ParentId" },
                values: new object[] { "FloadRods", "FloadRods", "Поплавочні удилища", 2 });
        }
    }
}
