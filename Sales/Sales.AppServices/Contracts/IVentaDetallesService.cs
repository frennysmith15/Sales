using Sales.AppServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.AppServices.Contracts
{
    internal interface IVentaDetallesService
    {
        ServiceResult GetVentaDetalleByVentas(int ventaId);
        ServiceResult GetVentasDetallesByDates(DateTime startDate, DateTime endDate);
        ServiceResult GetVentaDetallesCount();
    }
}
