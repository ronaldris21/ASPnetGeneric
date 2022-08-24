using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoEF.Migrations
{
    public partial class InitialDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "tarea",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 25, 0, 1, 39, 421, DateTimeKind.Local).AddTicks(7893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 24, 23, 35, 0, 398, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Description", "Nombre", "Peso" },
                values: new object[] { new Guid("2d143e08-b275-425a-b3b0-a3a747ca9834"), null, "Actividades pendientes", 20 });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Description", "Nombre", "Peso" },
                values: new object[] { new Guid("df94fd47-243b-4a8b-a438-41734bae8e2d"), null, "Actividades Personales", 50 });

            migrationBuilder.InsertData(
                table: "tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "PrioridadTarea", "Titulo" },
                values: new object[,]
                {
                    { new Guid("f2777a32-663c-4b32-b20c-24170523b98a"), new Guid("2d143e08-b275-425a-b3b0-a3a747ca9834"), null, "Media", "Comprar leche y huevos" },
                    { new Guid("f2777a32-663c-4b32-b20c-24170523b98b"), new Guid("2d143e08-b275-425a-b3b0-a3a747ca9834"), null, "Media", "Pedir una Micro SD en Amazon" },
                    { new Guid("f2777a32-663c-4b32-b20c-24170523b98c"), new Guid("df94fd47-243b-4a8b-a438-41734bae8e2d"), null, "Alta", "Revisar Compra de laptop, llega mañana" },
                    { new Guid("f2777a32-663c-4b32-b20c-24170523b98d"), new Guid("df94fd47-243b-4a8b-a438-41734bae8e2d"), null, "Alta", "Terminar Curso de ASP Net" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("f2777a32-663c-4b32-b20c-24170523b98a"));

            migrationBuilder.DeleteData(
                table: "tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("f2777a32-663c-4b32-b20c-24170523b98b"));

            migrationBuilder.DeleteData(
                table: "tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("f2777a32-663c-4b32-b20c-24170523b98c"));

            migrationBuilder.DeleteData(
                table: "tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("f2777a32-663c-4b32-b20c-24170523b98d"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("2d143e08-b275-425a-b3b0-a3a747ca9834"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("df94fd47-243b-4a8b-a438-41734bae8e2d"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "tarea",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 24, 23, 35, 0, 398, DateTimeKind.Local).AddTicks(480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 25, 0, 1, 39, 421, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
