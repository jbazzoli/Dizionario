using Microsoft.EntityFrameworkCore.Migrations;

namespace NeperiaDizionarioV2.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parola",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Termo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parola", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sinonimi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Termo = table.Column<string>(nullable: true),
                    ParolaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinonimi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sinonimi_Parola_ParolaId",
                        column: x => x.ParolaId,
                        principalTable: "Parola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sinonimi_ParolaId",
                table: "Sinonimi",
                column: "ParolaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sinonimi");

            migrationBuilder.DropTable(
                name: "Parola");
        }
    }
}
