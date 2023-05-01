using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectronicaVentas.Migrations
{
    /// <inheritdoc />
    public partial class VentaCamposOk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "apellido",
                table: "Venta");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "apellido",
                table: "Venta",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
