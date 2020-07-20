using Microsoft.EntityFrameworkCore.Migrations;

namespace BreadGiverApp.Server.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cotizaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorTotal = table.Column<string>(nullable: true),
                    IVA = table.Column<string>(nullable: true),
                    CantidadTotal = table.Column<string>(nullable: true),
                    UsuarioCotizacionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotizaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cotizaciones_Usuarios_UsuarioCotizacionId",
                        column: x => x.UsuarioCotizacionId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MetodoPago",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreMetodo = table.Column<string>(nullable: true),
                    bancoAsociado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodoPago", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cotizaciones_UsuarioCotizacionId",
                table: "Cotizaciones",
                column: "UsuarioCotizacionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cotizaciones");

            migrationBuilder.DropTable(
                name: "MetodoPago");
        }
    }
}
