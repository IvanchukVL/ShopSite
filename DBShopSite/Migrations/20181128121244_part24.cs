using Microsoft.EntityFrameworkCore.Migrations;

namespace DBShopSite.Migrations
{
    public partial class part24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TovarsAtributes",
                table: "TovarsAtributes");

            migrationBuilder.RenameTable(
                name: "TovarsAtributes",
                newName: "TovarAtributes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TovarAtributes",
                table: "TovarAtributes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TovarAtributes",
                table: "TovarAtributes");

            migrationBuilder.RenameTable(
                name: "TovarAtributes",
                newName: "TovarsAtributes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TovarsAtributes",
                table: "TovarsAtributes",
                column: "Id");
        }
    }
}
