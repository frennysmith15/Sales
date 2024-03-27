using Microsoft.EntityFrameworkCore;
using Sales.Infraestructure.Dao;

namespace Sales.Infraestructure.Context
{
    public partial class SaleContext : DbContext
    {
        public SaleContext(DbContextOptions<SaleContext> options) : base(options)
        {

        }

        #region "DbSet"
        public DbSet<VentaDetalle>? VentaDetalles { get; set; }

        public DbSet<Venta>? Ventas { get; set; }
        public DbSet<Negocio>? Negocios { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            OnModelCreatingGeneratedProcedures(modelBuilder);
        }
    }
}
