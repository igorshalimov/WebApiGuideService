using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiGuideService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atributes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DataType = table.Column<string>(nullable: true),
                    guideStructureId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atributes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "constructionObjects",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ObjectCode = table.Column<string>(nullable: true),
                    Budget = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_constructionObjects", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dataVersions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    VersionType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dataVersions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "guides",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guides", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atributes");

            migrationBuilder.DropTable(
                name: "constructionObjects");

            migrationBuilder.DropTable(
                name: "dataVersions");

            migrationBuilder.DropTable(
                name: "guides");
        }
    }
}
