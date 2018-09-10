using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DBShopSite.Migrations
{
    public partial class part3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Users",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "eMail",
                table: "Users",
                maxLength: 70,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Menu",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Command",
                table: "Menu",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Menu",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RoleCode = table.Column<string>(nullable: true),
                    RoleName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsersRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersRoles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleCode", "RoleName", "Status" },
                values: new object[,]
                {
                    { 1, "Admin", "Адміністратор", 1 },
                    { 2, "Guest", "Гість", 1 },
                    { 3, "Client", "Клієнт", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Login", "Name", "Status" },
                values: new object[] { "Guest", "Гість", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Login", "Status" },
                values: new object[] { "VIvanchuk", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_RoleId",
                table: "MenuRole",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRole_Users_MenuId",
                table: "MenuRole",
                column: "MenuId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRole_Roles_RoleId",
                table: "MenuRole",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            return;
            migrationBuilder.DropForeignKey(
                name: "FK_MenuRole_Users_MenuId",
                table: "MenuRole");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuRole_Roles_RoleId",
                table: "MenuRole");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UsersRoles");

            migrationBuilder.DropIndex(
                name: "IX_MenuRole_RoleId",
                table: "MenuRole");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "eMail",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Menu",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Command",
                table: "Menu",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Menu",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Login", "Name", "Status" },
                values: new object[] { "VIvanchuk1", "Іванчук Володимир Львович", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Login", "Status" },
                values: new object[] { "VIvanchuk2", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Login", "Name", "Status" },
                values: new object[] { 3, "VIvanchuk3", "Іванчук Володимир Львович", 0 });
        }
    }
}
