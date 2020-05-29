﻿// <auto-generated />
using System;
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datos.Migrations
{
    [DbContext(typeof(DatosContext))]
    partial class DatosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Panela", b =>
                {
                    b.Property<string>("Idregistro")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Cantidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Etapas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumeroLote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroLoteAgricola")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsable")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Idregistro");

                    b.ToTable("AlmacenamientoProducto");
                });

            modelBuilder.Entity("Entity.Productor", b =>
                {
                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Actividad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Afiliacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoProductor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefonico")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cedula");

                    b.ToTable("Productores");
                });
#pragma warning restore 612, 618
        }
    }
}