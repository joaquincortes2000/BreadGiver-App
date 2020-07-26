﻿// <auto-generated />
using System;
using BreadGiverApp.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BreadGiverApp.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200726005005_initMigration")]
    partial class initMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BreadGiverApp.Shared.CarroCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CantidadTotal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IVA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValorTotal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarroCompra");
                });

            modelBuilder.Entity("BreadGiverApp.Shared.CarroCompra_has_Producto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("carroCompraIdId")
                        .HasColumnType("int");

                    b.Property<int?>("productoIdId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("carroCompraIdId");

                    b.HasIndex("productoIdId");

                    b.ToTable("CarroCompra_Has_Producto");
                });

            modelBuilder.Entity("BreadGiverApp.Shared.Cotizacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CantidadTotal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IVA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioCotizacionId")
                        .HasColumnType("int");

                    b.Property<string>("ValorTotal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioCotizacionId");

                    b.ToTable("Cotizacion");
                });

            modelBuilder.Entity("BreadGiverApp.Shared.Cotizacion_has_Producto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("cotizacionIdId")
                        .HasColumnType("int");

                    b.Property<int?>("productoIdId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("cotizacionIdId");

                    b.HasIndex("productoIdId");

                    b.ToTable("Cotizacion_Has_Producto");
                });

            modelBuilder.Entity("BreadGiverApp.Shared.MetodoPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bancoAsociado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreMetodo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MetodoPago");
                });

            modelBuilder.Entity("BreadGiverApp.Shared.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantidadProducto")
                        .HasColumnType("int");

                    b.Property<string>("NombreProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrecioProducto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("BreadGiverApp.Shared.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipoRol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("BreadGiverApp.Shared.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CarroUsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("CorreoUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DireccionUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RolUsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("RunUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RutUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarroUsuarioId");

                    b.HasIndex("RolUsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("BreadGiverApp.Shared.CarroCompra_has_Producto", b =>
                {
                    b.HasOne("BreadGiverApp.Shared.CarroCompra", "carroCompraId")
                        .WithMany()
                        .HasForeignKey("carroCompraIdId");

                    b.HasOne("BreadGiverApp.Shared.Producto", "productoId")
                        .WithMany()
                        .HasForeignKey("productoIdId");
                });

            modelBuilder.Entity("BreadGiverApp.Shared.Cotizacion", b =>
                {
                    b.HasOne("BreadGiverApp.Shared.Usuario", "UsuarioCotizacion")
                        .WithMany()
                        .HasForeignKey("UsuarioCotizacionId");
                });

            modelBuilder.Entity("BreadGiverApp.Shared.Cotizacion_has_Producto", b =>
                {
                    b.HasOne("BreadGiverApp.Shared.Cotizacion", "cotizacionId")
                        .WithMany()
                        .HasForeignKey("cotizacionIdId");

                    b.HasOne("BreadGiverApp.Shared.Producto", "productoId")
                        .WithMany()
                        .HasForeignKey("productoIdId");
                });

            modelBuilder.Entity("BreadGiverApp.Shared.Usuario", b =>
                {
                    b.HasOne("BreadGiverApp.Shared.CarroCompra", "CarroUsuario")
                        .WithMany()
                        .HasForeignKey("CarroUsuarioId");

                    b.HasOne("BreadGiverApp.Shared.Rol", "RolUsuario")
                        .WithMany()
                        .HasForeignKey("RolUsuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}