using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.Infraestructura.Base
{
    public interface ICrudDao<T>
    {
        void Update(T entity);
        T Insert(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
    }
}
