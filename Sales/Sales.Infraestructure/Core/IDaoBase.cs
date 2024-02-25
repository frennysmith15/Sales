using Sales.Domain.Entities;

namespace Sales.Infraestructure.Core
{
    public interface IDaoBase<TEntity> where TEntity : class 
    {
        void Save(TEntity entity);
        List<TEntity> GetAll();
        void GetById(int id);
        bool Exists(int id);
    }
}
