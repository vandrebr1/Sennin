using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sennin.API.Infraestrutura.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();
        void Save(T entity);
    }
}
