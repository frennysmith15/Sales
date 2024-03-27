using Sales.AppServices.Core;
using Sales.AppServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.AppServices.Contracts
{
    internal interface INegocioService
    {
        public Task<ServiceResult> GetNegocios();
        public Task<ServiceResult> GetNegocioByName(string name);
        public Task<ServiceResult> AddNegocio(NegocioAddNegocio negocioAddNegocio);
    }
}
