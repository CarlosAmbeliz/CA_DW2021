using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.Dominio.Base
{
    public interface ICrudRepository<T>
    {
        void Modify(T entity);
        T Save(T entity);
        void Remove(T entity);
        IEnumerable<T> GetAll();
    }
}
