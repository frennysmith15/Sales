using Sales.Domain.Entities;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class CategoriasDb : ICategoriasDb

    {
        /*
        private readonly List<Categorias> categorias;

        public CategoriasDb()
        {
            this.categorias = new List<Categorias>();
        }

        public bool Exist(int id)
        {
            return this.categorias.Any(cd => cd.CategoriasId == id);
        }

        public List<Categorias> GetAll()
        {
            return this.categorias.Where(cd => !cd.Eliminado).ToList();
        }

        public void GetById(int categoriaId)
        {
            this.categorias.SingleOrDefault(cd => cd.CategoriasId == categoriaId);

        }

        public void Save(Categorias categoria)
        {
            this.categorias.Add(categoria);
        }

        public void Update(Categorias categoria)
        {
            this.categorias.Add(categoria);
        }*/
        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        public List<Categorias> GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Categorias entity)
        {
            throw new NotImplementedException();
        }
    }
}
