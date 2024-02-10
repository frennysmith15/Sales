namespace Sales.Domain.Entities
{
    public class Venta : Core.BaseEntity
    {
        public int Id { get; set; }
        public string? Numeroventa { get; set; }
        public int? IdTipoDocumentoVenta { get; set; }
        public int? IdUsuario { get; set; }
        public string? CocumentoCliente { get; set; }
        public double? SubTotal { get; set; }
        public double? ImpuestoTotal { get; set; }
        public double? Total { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
