using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sales.Domain.Core;

namespace Sales.Domain.Entities
{
    public class Producto : BaseEntity
    {
        public int Id { get; set; }
        public string? CodigoDeBarras { get; set; }
        public int? IdCategoria { get; set; }
        public int? Stock { get; set; }
        public string? UrlImage { get; set; }
        public string? NombreImagen { get; set; }
        public int? Precio { get; set; }
    }
}
