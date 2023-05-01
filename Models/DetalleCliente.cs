namespace VentasElectronica.Models;

public class DetalleCliente
{

    public int DetalleClienteId { get; set; }
    public int clienteId { get; set; }
    public DateTime fecha_nacimiento { get; set; }
    public string mail { get; set; }
}
