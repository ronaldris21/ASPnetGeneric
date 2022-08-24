using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoEF.Migrations
{
    public partial class TareaFechaCreacionDefectoDateTimeNow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "tarea",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 24, 23, 35, 0, 398, DateTimeKind.Local).AddTicks(480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "tarea",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 24, 23, 35, 0, 398, DateTimeKind.Local).AddTicks(480));
        }
    }
}
