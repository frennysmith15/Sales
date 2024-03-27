using Microsoft.Extensions.Logging;
using Sales.AppServices.Contracts;
using Sales.AppServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.AppServices.Service
{
    public class VentaService : IVentaService
    {
        private readonly IVentaDb ventaDb;
        private readonly ILogger<VentaService> logger;
        private readonly ICourseDb ventaDb;
        private readonly ILogger<CourseService> logger;

        public CourseService(ICourseDb ventaDb, ILogger<CourseService> logger)
        {
            this.ventaDb = ventaDb;
            this.logger = logger;
        }

        public ServiceResult GetCourseCount()
        {
            ServiceResult result = new ServiceResult();
            try
            {


                result.Data = this.ventaDb.GetCourseCount();

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error obteniendo los Ventas";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult GetVentasByDates(DateTime startDate, DateTime endDate)
        {
            ServiceResult result = new ServiceResult();
            try
            {


                result.Data = this.ventaDb.GetVentasByDates(startDate, endDate);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error obteniendo los Ventas";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult GetVentasByDepartment(int departmentId)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = this.ventaDb.GetVentasByDepartmentId(departmentId);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error obteniendo los Ventas";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }
    }
}
