using Sales.Domain.Entities;
using Sales.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Infraestructure.Dao
{
    public class MenuDb : IMenuDb
    {
        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Menu entity)
        {
            throw new NotImplementedException();
        }
    }
}
