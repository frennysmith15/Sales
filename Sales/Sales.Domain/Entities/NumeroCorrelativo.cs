using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sales.Domain.Core;

namespace Sales.Domain.Entities
{
    public class NumeroCorrelativo : BaseEntity
    {
        public int IdNumeroCorrelatiov { get; set; }
        public int? UltimoNumero { get; set; }
        public int? CantidadDigitos { get; set; }
        public string? Gestion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
