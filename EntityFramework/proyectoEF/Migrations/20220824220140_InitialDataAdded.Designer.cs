﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proyectoEF;

#nullable disable

namespace proyectoEF.Migrations
{
    [DbContext(typeof(TareasContext))]
    [Migration("20220824220140_InitialDataAdded")]
    partial class InitialDataAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("proyectoEF.Models.Categoria", b =>
                {
                    b.Property<Guid>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria", (string)null);

                    b.HasData(
                        new
                        {
                            CategoriaId = new Guid("2d143e08-b275-425a-b3b0-a3a747ca9834"),
                            Nombre = "Actividades pendientes",
                            Peso = 20
                        },
                        new
                        {
                            CategoriaId = new Guid("df94fd47-243b-4a8b-a438-41734bae8e2d"),
                            Nombre = "Actividades Personales",
                            Peso = 50
                        });
                });

            modelBuilder.Entity("proyectoEF.Models.Tarea", b =>
                {
                    b.Property<Guid>("TareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 8, 25, 0, 1, 39, 421, DateTimeKind.Local).AddTicks(7893));

                    b.Property<string>("PrioridadTarea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("TareaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("tarea", (string)null);

                    b.HasData(
                        new
                        {
                            TareaId = new Guid("f2777a32-663c-4b32-b20c-24170523b98a"),
                            CategoriaId = new Guid("2d143e08-b275-425a-b3b0-a3a747ca9834"),
                            FechaCreacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PrioridadTarea = "Media",
                            Titulo = "Comprar leche y huevos"
                        },
                        new
                        {
                            TareaId = new Guid("f2777a32-663c-4b32-b20c-24170523b98b"),
                            CategoriaId = new Guid("2d143e08-b275-425a-b3b0-a3a747ca9834"),
                            FechaCreacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PrioridadTarea = "Media",
                            Titulo = "Pedir una Micro SD en Amazon"
                        },
                        new
                        {
                            TareaId = new Guid("f2777a32-663c-4b32-b20c-24170523b98c"),
                            CategoriaId = new Guid("df94fd47-243b-4a8b-a438-41734bae8e2d"),
                            FechaCreacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PrioridadTarea = "Alta",
                            Titulo = "Revisar Compra de laptop, llega mañana"
                        },
                        new
                        {
                            TareaId = new Guid("f2777a32-663c-4b32-b20c-24170523b98d"),
                            CategoriaId = new Guid("df94fd47-243b-4a8b-a438-41734bae8e2d"),
                            FechaCreacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PrioridadTarea = "Alta",
                            Titulo = "Terminar Curso de ASP Net"
                        });
                });

            modelBuilder.Entity("proyectoEF.Models.Tarea", b =>
                {
                    b.HasOne("proyectoEF.Models.Categoria", "Categoria")
                        .WithMany("Tareas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("proyectoEF.Models.Categoria", b =>
                {
                    b.Navigation("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}
