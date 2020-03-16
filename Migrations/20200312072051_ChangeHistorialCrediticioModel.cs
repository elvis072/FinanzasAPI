using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanzasAPI.Migrations
{
    public partial class ChangeHistorialCrediticioModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConceptoDeuda",
                table: "HistorialCrediticio",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConceptoDeuda",
                table: "HistorialCrediticio");
        }
    }
}
