using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanzasAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistorialCrediticios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cedula = table.Column<string>(maxLength: 11, nullable: false),
                    RncEmpresa = table.Column<string>(maxLength: 11, nullable: false),
                    TotalAdeudado = table.Column<float>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialCrediticios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inflacions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Indice = table.Column<float>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inflacions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaludFinancieras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cedula = table.Column<string>(maxLength: 11, nullable: false),
                    Indicador = table.Column<bool>(nullable: false),
                    Comentario = table.Column<string>(nullable: true),
                    TotalAdeudado = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaludFinancieras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TasaCambios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoMoneda = table.Column<string>(maxLength: 3, nullable: false),
                    Cambio = table.Column<float>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasaCambios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistorialCrediticios");

            migrationBuilder.DropTable(
                name: "Inflacions");

            migrationBuilder.DropTable(
                name: "SaludFinancieras");

            migrationBuilder.DropTable(
                name: "TasaCambios");
        }
    }
}
