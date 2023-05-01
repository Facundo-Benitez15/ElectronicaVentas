namespace ElectronicaVentas.Models;

public class DetalleVenta
{
    public int DetalleVentaId { get; set; }
    public int ventaId { get; set; }
    public int productoId { get; set; }
}
