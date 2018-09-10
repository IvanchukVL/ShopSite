using Microsoft.EntityFrameworkCore.Migrations;

namespace DBShopSite.Migrations
{
    public partial class part5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Menu",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Code", "Command", "Name", "ParentId", "Status", "Url" },
                values: new object[,]
                {
                    { 1, "main", "Main", "Головна", 0, 1, null },
                    { 2, "Rods", "", "Вудилища", 0, 1, null },
                    { 3, "Reels", "", "Катушки", 0, 1, null },
                    { 4, "Accessories", "", "Аксесуари", 0, 1, null },
                    { 5, "FeederRods", "FeederRods", "Фідерні удилища", 2, 1, null },
                    { 6, "SpiningRods", "SpiningRods", "Спінінгові удилища", 2, 1, null },
                    { 7, "FloadRods", "FloadRods", "Поплавочні удилища", 2, 1, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            return;
            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Menu");
        }
    }
}
