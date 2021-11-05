using Dapper.Contrib.Extensions;
using Sennin.API.Infraestrutura;
using Sennin.API.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sennin.API.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private DbSession session;

        public Repository(DbSession session)
        {
            this.session = session;
        }

        public async Task<bool> DeleteAsync(int Id)
        {
            var entity = await SelectAsync(Id);

            if (entity == null)
                return false;

            return await session.Connection.DeleteAsync(entity);
        }

        public async Task<int> SaveAsync(T entity)
        {
            return await session.Connection.InsertAsync(entity);
        }

        public async Task<T> SelectAsync(int Id)
        {
            return await session.Connection.GetAsync<T>(Id);
        }

        public async Task<IEnumerable<T>> SelectAsync()
        {
            return await session.Connection.GetAllAsync<T>();
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            return await session.Connection.UpdateAsync(entity);
        }
    }
}
