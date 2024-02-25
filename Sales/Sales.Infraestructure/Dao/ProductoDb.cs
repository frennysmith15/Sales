using Sales.Domain.Entities;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class ProductoDb : IProductoDb
    {
        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        public List<Producto> GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Producto entity)
        {
            throw new NotImplementedException();
        }
    }
}
