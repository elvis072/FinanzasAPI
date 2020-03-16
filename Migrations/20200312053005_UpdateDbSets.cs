using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanzasAPI.Migrations
{
    public partial class UpdateDbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TasaCambios",
                table: "TasaCambios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaludFinancieras",
                table: "SaludFinancieras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inflacions",
                table: "Inflacions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistorialCrediticios",
                table: "HistorialCrediticios");

            migrationBuilder.RenameTable(
                name: "TasaCambios",
                newName: "TasaCambio");

            migrationBuilder.RenameTable(
                name: "SaludFinancieras",
                newName: "SaludFinanciera");

            migrationBuilder.RenameTable(
                name: "Inflacions",
                newName: "Inflacion");

            migrationBuilder.RenameTable(
                name: "HistorialCrediticios",
                newName: "HistorialCrediticio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TasaCambio",
                table: "TasaCambio",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaludFinanciera",
                table: "SaludFinanciera",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inflacion",
                table: "Inflacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistorialCrediticio",
                table: "HistorialCrediticio",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TasaCambio",
                table: "TasaCambio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaludFinanciera",
                table: "SaludFinanciera");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inflacion",
                table: "Inflacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistorialCrediticio",
                table: "HistorialCrediticio");

            migrationBuilder.RenameTable(
                name: "TasaCambio",
                newName: "TasaCambios");

            migrationBuilder.RenameTable(
                name: "SaludFinanciera",
                newName: "SaludFinancieras");

            migrationBuilder.RenameTable(
                name: "Inflacion",
                newName: "Inflacions");

            migrationBuilder.RenameTable(
                name: "HistorialCrediticio",
                newName: "HistorialCrediticios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TasaCambios",
                table: "TasaCambios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaludFinancieras",
                table: "SaludFinancieras",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inflacions",
                table: "Inflacions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistorialCrediticios",
                table: "HistorialCrediticios",
                column: "Id");
        }
    }
}
