namespace Sales.Domain.Core
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            this.FechaDeRegistro = DateTime.Now;
            this.Eliminado = false;
        }
        public string? Descripcion { get; set; }
        public Boolean? EsActivo { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? IdUsuarioModificacion { get; set; }
        public int? IdUsuarioElimino { get; set; }
        public DateTime FechaElimino { get; set; }
        public Boolean Eliminado {  get; set; }

    }
}
