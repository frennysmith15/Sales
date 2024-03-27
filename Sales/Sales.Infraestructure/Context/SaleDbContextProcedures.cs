using Microsoft.EntityFrameworkCore;
using School.Infraestructure.Models;

namespace Sales.Infraestructure.Context
{
    public partial class SaleContext
    {
        protected void OnModelCreatingGeneratedProcedures(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ObtenerVentas>().HasNoKey().ToView(null);


        }
    }
}
