using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.IOC.VentaDependencies
{
    public static class VentaDependency
    {
        public static void AddVentaDependency(this IServiceCollection services)
        {
            services.AddScoped<IVentaDb, VentaDb>();
            services.AddTransient<IVentaService, VentaService>();
        }
    }
}
