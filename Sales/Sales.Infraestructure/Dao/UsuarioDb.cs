using Sales.Domain.Entities;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class UsuarioDb : IUsuarioDb
    {
        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
