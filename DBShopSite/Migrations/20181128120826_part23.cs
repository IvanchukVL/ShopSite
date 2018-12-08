using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DBShopSite.Migrations
{
    public partial class part23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TovarsFilterAtributes");

            migrationBuilder.CreateTable(
                name: "TovarsAtributes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Kind = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TovarsAtributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TovarValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    TovarId = table.Column<int>(nullable: false),
                    AtributeId = table.Column<int>(nullable: false),
                    Code = table.Column<string>(maxLength: 32, nullable: true),
                    Flag = table.Column<int>(nullable: true),
                    Amount = table.Column<decimal>(nullable: true),
                    Info = table.Column<string>(nullable: true),
                    FilterId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TovarValues", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TovarsAtributes");

            migrationBuilder.DropTable(
                name: "TovarValues");

            migrationBuilder.CreateTable(
                name: "TovarsFilterAtributes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    FilterId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    TovarId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TovarsFilterAtributes", x => x.Id);
                });
        }
    }
}
