using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sales.Domain.Core;

namespace Sales.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public int IdMenu { get; set; }
        public int IdMenuPadre { get; set; }
        public string? Icono { get; set; }
        public string? Controlador { get; set; }
        public string? PaginaAccion { get; set; }
    }
}
