using Microsoft.EntityFrameworkCore.Migrations;

namespace DBShopSite.Migrations
{
    public partial class part2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Age2",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Age3",
                table: "Users",
                newName: "Status");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Users",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Login", "Name" },
                values: new object[] { "VIvanchuk1", "Іванчук Володимир Львович" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Login", "Name" },
                values: new object[] { "VIvanchuk2", "Іванчук Володимир Львович" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Login", "Name" },
                values: new object[] { "VIvanchuk3", "Іванчук Володимир Львович" });

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_MenuId",
                table: "MenuRole",
                column: "MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRole_Menu_MenuId",
                table: "MenuRole",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_MenuRole_Menu_MenuId",
            //    table: "MenuRole");

            //migrationBuilder.DropIndex(
            //    name: "IX_MenuRole_MenuId",
            //    table: "MenuRole");

            //migrationBuilder.DropColumn(
            //    name: "Login",
            //    table: "Users");

            //migrationBuilder.RenameColumn(
            //    name: "Status",
            //    table: "Users",
            //    newName: "Age3");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "Users",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldMaxLength: 70);

            //migrationBuilder.AddColumn<int>(
            //    name: "Age",
            //    table: "Users",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AddColumn<int>(
            //    name: "Age2",
            //    table: "Users",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.UpdateData(
            //    table: "Users",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "Age", "Name" },
            //    values: new object[] { 42, "VIvanchuk1" });

            //migrationBuilder.UpdateData(
            //    table: "Users",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "Age", "Name" },
            //    values: new object[] { 42, "VIvanchuk2" });

            //migrationBuilder.UpdateData(
            //    table: "Users",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "Age", "Name" },
            //    values: new object[] { 42, "VIvanchuk3" });
        }
    }
}
