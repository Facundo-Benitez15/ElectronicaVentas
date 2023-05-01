using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ElectronicaVentas.Models;
using VentasElectronica.Models;

namespace VentasElectronica.Data
{
    public class ElectronicaDbContext : DbContext
    {
        public ElectronicaDbContext(DbContextOptions<ElectronicaDbContext> options)
            : base(options)
        {
        }

        public DbSet<ElectronicaVentas.Models.Producto> Producto { get; set; } = default!;

        public DbSet<ElectronicaVentas.Models.Cliente> Cliente { get; set; } = default!;

        public DbSet<VentasElectronica.Models.DetalleCliente> DetalleCliente { get; set; } = default!;

        public DbSet<ElectronicaVentas.Models.Venta> Venta { get; set; } = default!;

        public DbSet<ElectronicaVentas.Models.DetalleVenta> DetalleVenta { get; set; } = default!;

    }
}
