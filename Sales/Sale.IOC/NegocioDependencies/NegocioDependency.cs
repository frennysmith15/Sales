using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.IOC.NegocioDependencies
{
    public static class NegocioDependency
    {
        public static void AddCourseDependency(this IServiceCollection services)
        {
            services.AddScoped<INegocioDb, NegocioDb>();
            services.AddTransient<INegocioService, NegocioService>();
        }
    }
}
