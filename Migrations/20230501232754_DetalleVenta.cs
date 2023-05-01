using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectronicaVentas.Migrations
{
    /// <inheritdoc />
    public partial class DetalleVenta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetalleVenta",
                columns: table => new
                {
                    DetalleVentaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ventaId = table.Column<int>(type: "INTEGER", nullable: false),
                    productoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleVenta", x => x.DetalleVentaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleVenta");
        }
    }
}
