using Microsoft.EntityFrameworkCore.Migrations;

namespace NeperiaDizionarioV2.Migrations
{
    public partial class seventhMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParolaTrovata_Elabors_ElaborId",
                table: "ParolaTrovata");

            migrationBuilder.DropForeignKey(
                name: "FK_ParolaTrovata_Parola_ParolaId",
                table: "ParolaTrovata");

            migrationBuilder.DropColumn(
                name: "IdElabor",
                table: "ParolaTrovata");

            migrationBuilder.DropColumn(
                name: "IdParola",
                table: "ParolaTrovata");

            migrationBuilder.AlterColumn<int>(
                name: "ParolaId",
                table: "ParolaTrovata",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ElaborId",
                table: "ParolaTrovata",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ParolaTrovata_Elabors_ElaborId",
                table: "ParolaTrovata",
                column: "ElaborId",
                principalTable: "Elabors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParolaTrovata_Parola_ParolaId",
                table: "ParolaTrovata",
                column: "ParolaId",
                principalTable: "Parola",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParolaTrovata_Elabors_ElaborId",
                table: "ParolaTrovata");

            migrationBuilder.DropForeignKey(
                name: "FK_ParolaTrovata_Parola_ParolaId",
                table: "ParolaTrovata");

            migrationBuilder.AlterColumn<int>(
                name: "ParolaId",
                table: "ParolaTrovata",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ElaborId",
                table: "ParolaTrovata",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdElabor",
                table: "ParolaTrovata",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdParola",
                table: "ParolaTrovata",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ParolaTrovata_Elabors_ElaborId",
                table: "ParolaTrovata",
                column: "ElaborId",
                principalTable: "Elabors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParolaTrovata_Parola_ParolaId",
                table: "ParolaTrovata",
                column: "ParolaId",
                principalTable: "Parola",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
