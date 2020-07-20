using Microsoft.EntityFrameworkCore.Migrations;

namespace BreadGiverApp.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_CarroCompra_CarroUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Rol_RolUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_CarroUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_RolUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CarroUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "RolUsuarioId",
                table: "Usuarios");

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(nullable: true),
                    PrecioProducto = table.Column<string>(nullable: true),
                    CantidadProducto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.AddColumn<int>(
                name: "CarroUsuarioId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RolUsuarioId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CarroUsuarioId",
                table: "Usuarios",
                column: "CarroUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolUsuarioId",
                table: "Usuarios",
                column: "RolUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_CarroCompra_CarroUsuarioId",
                table: "Usuarios",
                column: "CarroUsuarioId",
                principalTable: "CarroCompra",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Rol_RolUsuarioId",
                table: "Usuarios",
                column: "RolUsuarioId",
                principalTable: "Rol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
