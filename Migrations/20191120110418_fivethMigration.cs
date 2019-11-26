using Microsoft.EntityFrameworkCore.Migrations;

namespace NeperiaDizionarioV2.Migrations
{
    public partial class fivethMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameFile",
                table: "Elabors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameFile",
                table: "Elabors");
        }
    }
}
