using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sales.Domain.Core;

namespace Sales.Domain.Entities
{
    public class Negocio : BaseEntity
    {
        public int IdNegocio { get; set; }
        public string? UrlLogo { get; set; }
        public string? NombreLogo { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public double PorcentajeDeImpuesto { get; set; }
        public string? SimboloMoneda { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
