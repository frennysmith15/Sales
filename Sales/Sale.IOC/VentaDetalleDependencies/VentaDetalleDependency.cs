using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.IOC.VentaDetalleDependencies
{
    public static class VentaDetalleDependency
    {
        public static void AddVentaDetalleDependency(this IServiceCollection services)
        {
            services.AddScoped<IVentaDetalleDb, VentaDetalleDb>();
            services.AddTransient<IVentaDetalleService, VentaDetalleService>();
        }
    }
}
