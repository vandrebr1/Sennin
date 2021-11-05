using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sennin.API.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> SelectAsync(int Id);

        Task<IEnumerable<T>> SelectAsync();

        Task<int> SaveAsync(T entity);

        Task<bool> UpdateAsync(T entity);

        Task<bool> DeleteAsync(int Id);
    }
}
