using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoEF.Migrations
{
    public partial class TareaPropiedadMaxLength10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PrioridadTarea",
                table: "tarea",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "tarea",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 25, 0, 8, 48, 585, DateTimeKind.Local).AddTicks(8373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 25, 0, 1, 39, 421, DateTimeKind.Local).AddTicks(7893));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PrioridadTarea",
                table: "tarea",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "tarea",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 25, 0, 1, 39, 421, DateTimeKind.Local).AddTicks(7893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 25, 0, 8, 48, 585, DateTimeKind.Local).AddTicks(8373));
        }
    }
}
