using Microsoft.EntityFrameworkCore.Migrations;

namespace BreadGiverApp.Server.Migrations
{
    public partial class initla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarroCompra",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorTotal = table.Column<string>(nullable: true),
                    IVA = table.Column<string>(nullable: true),
                    CantidadTotal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarroCompra", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(nullable: true),
                    PrecioProducto = table.Column<string>(nullable: true),
                    CantidadProducto = table.Column<int>(nullable: false),
                    ImagenProducto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoRol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarroCompra_Has_Producto",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carroCompraIdId = table.Column<int>(nullable: true),
                    productoIdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarroCompra_Has_Producto", x => x.id);
                    table.ForeignKey(
                        name: "FK_CarroCompra_Has_Producto_CarroCompra_carroCompraIdId",
                        column: x => x.carroCompraIdId,
                        principalTable: "CarroCompra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarroCompra_Has_Producto_Producto_productoIdId",
                        column: x => x.productoIdId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RunUsuario = table.Column<string>(nullable: true),
                    NombreUsuario = table.Column<string>(nullable: true),
                    ApellidoUsuario = table.Column<string>(nullable: true),
                    CorreoUsuario = table.Column<string>(nullable: true),
                    NumeroUsuario = table.Column<string>(nullable: true),
                    PasswordUsuario = table.Column<string>(nullable: true),
                    DireccionUsuario = table.Column<string>(nullable: true),
                    RutUsuario = table.Column<string>(nullable: true),
                    RolUsuarioId = table.Column<int>(nullable: true),
                    CarroUsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_CarroCompra_CarroUsuarioId",
                        column: x => x.CarroUsuarioId,
                        principalTable: "CarroCompra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuario_Rol_RolUsuarioId",
                        column: x => x.RolUsuarioId,
                        principalTable: "Rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cotizacion",
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
                    table.PrimaryKey("PK_Cotizacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cotizacion_Usuario_UsuarioCotizacionId",
                        column: x => x.UsuarioCotizacionId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cotizacion_Has_Producto",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cotizacionIdId = table.Column<int>(nullable: true),
                    productoIdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotizacion_Has_Producto", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cotizacion_Has_Producto_Cotizacion_cotizacionIdId",
                        column: x => x.cotizacionIdId,
                        principalTable: "Cotizacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cotizacion_Has_Producto_Producto_productoIdId",
                        column: x => x.productoIdId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarroCompra_Has_Producto_carroCompraIdId",
                table: "CarroCompra_Has_Producto",
                column: "carroCompraIdId");

            migrationBuilder.CreateIndex(
                name: "IX_CarroCompra_Has_Producto_productoIdId",
                table: "CarroCompra_Has_Producto",
                column: "productoIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizacion_UsuarioCotizacionId",
                table: "Cotizacion",
                column: "UsuarioCotizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizacion_Has_Producto_cotizacionIdId",
                table: "Cotizacion_Has_Producto",
                column: "cotizacionIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizacion_Has_Producto_productoIdId",
                table: "Cotizacion_Has_Producto",
                column: "productoIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_CarroUsuarioId",
                table: "Usuario",
                column: "CarroUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_RolUsuarioId",
                table: "Usuario",
                column: "RolUsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarroCompra_Has_Producto");

            migrationBuilder.DropTable(
                name: "Cotizacion_Has_Producto");

            migrationBuilder.DropTable(
                name: "MetodoPago");

            migrationBuilder.DropTable(
                name: "Cotizacion");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "CarroCompra");

            migrationBuilder.DropTable(
                name: "Rol");
        }
    }
}
