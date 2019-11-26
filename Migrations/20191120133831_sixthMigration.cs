using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NeperiaDizionarioV2.Migrations
{
    public partial class sixthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParolaId",
                table: "Elabors");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataStart",
                table: "Elabors",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ParolaTrovata",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdParola = table.Column<int>(nullable: false),
                    IdElabor = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    ParolaId = table.Column<int>(nullable: true),
                    ElaborId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParolaTrovata", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParolaTrovata_Elabors_ElaborId",
                        column: x => x.ElaborId,
                        principalTable: "Elabors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParolaTrovata_Parola_ParolaId",
                        column: x => x.ParolaId,
                        principalTable: "Parola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParolaTrovata_ElaborId",
                table: "ParolaTrovata",
                column: "ElaborId");

            migrationBuilder.CreateIndex(
                name: "IX_ParolaTrovata_ParolaId",
                table: "ParolaTrovata",
                column: "ParolaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParolaTrovata");

            migrationBuilder.DropColumn(
                name: "DataStart",
                table: "Elabors");

            migrationBuilder.AddColumn<int>(
                name: "ParolaId",
                table: "Elabors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
