using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectronicaVentas.Migrations
{
    /// <inheritdoc />
    public partial class DetalleCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetalleCliente",
                columns: table => new
                {
                    DetalleClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    clienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    fecha_nacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    mail = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleCliente", x => x.DetalleClienteId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleCliente");
        }
    }
}
