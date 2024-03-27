using Microsoft.Extensions.Logging;
using Sales.AppServices.Contracts;
using Sales.AppServices.Core;
using Sales.AppServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.AppServices.Service
{
    public class NegocioService : INegocioService
    {
        private readonly INegocioDb negocioDb;
        private readonly ILogger<NegocioService> logger;

        public NegocioService(INegocioDb negocioDb, ILogger<NegocioService> logger)
        {
            this.negocioDb = negocioDb;
            this.logger = logger;
        }
        
        public async Task<ServiceResult> AddNegocio(NegocioAddNegocio negocioAddNegocio)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                OutputParameter<string> resp = new OutputParameter<string>();

                await this.departmentDb.AgregarDepartamentoAsync(
                    negocioAddDto.Name,
                    negocioAddDto.Budget,
                    negocioAddDto.StartDate,
                    negocioAddDto.Administrator,
                    negocioAddDto.CreateUser, resp);


                if (resp.Value.Equals("Ok"))
                    result.Message = "Negocio creado correctamente.";
                else
                {
                    result.Message = resp.Value;
                    result.Success = false;
                }

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = $"Error agregando el departamento {ex.Message}.";
            }
            return result;
        }

        public async Task<ServiceResult> INegocioService.GetNegocioByName(string name)
        {
            ServiceResult result = new ServiceResult();

            try
            {

                result.Data = (await this.negocioDb.ObtenerDepartamentosPorNombreAsync(name))
                                                      .Select(cd => new Models.NegocioModel()
                                                      {
                                                          DepartmentId = cd.NegocioID,
                                                          Budget = cd.Budget,
                                                          Name = cd.Name,
                                                          StartDate = cd.StartDate,
                                                          CreationDate = cd.CreationDate
                                                      }).FirstOrDefault();
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = $"Error obteniendo el negocio. {ex.Message}";
            }

            return result;
        }
    }

        public asyncTask<ServiceResult> INegocioService.GetNegocios()
        {
            ServiceResult result = new ServiceResult();

            try
            {

                //LINQ
                var query = (from negocio in await this.negocioDb.GetAll()
                             where negocio.Deleted == false
                             orderby negocio.CreationDate descending
                             select new Models.NegocioModel()
                             {
                                 Budget = negocio.Budget,
                                 CreationDate = negocio.CreationDate,
                                 DepartmentId = negocio.NegoioID,
                                 Name = negocio.Name

                             }).ToList();


                result.Data = query;

            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }

            return result;
        }
    }
}
