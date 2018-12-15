using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DBShopSite.Migrations
{
    public partial class part29 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberColumns",
                table: "TovarGroups",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TovarPhoto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    TovarId = table.Column<int>(nullable: false),
                    Photo = table.Column<byte[]>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TovarPhoto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TovarPhoto_Tovars_TovarId",
                        column: x => x.TovarId,
                        principalTable: "Tovars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TovarPhoto_TovarId",
                table: "TovarPhoto",
                column: "TovarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TovarPhoto");

            migrationBuilder.DropColumn(
                name: "NumberColumns",
                table: "TovarGroups");
        }
    }
}
