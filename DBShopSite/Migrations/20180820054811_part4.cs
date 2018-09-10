using Microsoft.EntityFrameworkCore.Migrations;

namespace DBShopSite.Migrations
{
    public partial class part4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuRole_Menu_MenuId",
                table: "MenuRole");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuRole_Users_MenuId",
                table: "MenuRole");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuRole_Roles_RoleId",
                table: "MenuRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuRole",
                table: "MenuRole");

            migrationBuilder.RenameTable(
                name: "MenuRole",
                newName: "RolesMenu");

            migrationBuilder.RenameIndex(
                name: "IX_MenuRole_RoleId",
                table: "RolesMenu",
                newName: "IX_RolesMenu_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuRole_MenuId",
                table: "RolesMenu",
                newName: "IX_RolesMenu_MenuId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RolesMenu",
                table: "RolesMenu",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RolesMenu_Menu_MenuId",
                table: "RolesMenu",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolesMenu_Users_MenuId",
                table: "RolesMenu",
                column: "MenuId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolesMenu_Roles_RoleId",
                table: "RolesMenu",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            return;
            migrationBuilder.DropForeignKey(
                name: "FK_RolesMenu_Menu_MenuId",
                table: "RolesMenu");

            migrationBuilder.DropForeignKey(
                name: "FK_RolesMenu_Users_MenuId",
                table: "RolesMenu");

            migrationBuilder.DropForeignKey(
                name: "FK_RolesMenu_Roles_RoleId",
                table: "RolesMenu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RolesMenu",
                table: "RolesMenu");

            migrationBuilder.RenameTable(
                name: "RolesMenu",
                newName: "MenuRole");

            migrationBuilder.RenameIndex(
                name: "IX_RolesMenu_RoleId",
                table: "MenuRole",
                newName: "IX_MenuRole_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_RolesMenu_MenuId",
                table: "MenuRole",
                newName: "IX_MenuRole_MenuId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuRole",
                table: "MenuRole",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRole_Menu_MenuId",
                table: "MenuRole",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
