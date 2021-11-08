using Dapper;
using Sennin.API.Infraestrutura;
using Sennin.API.Interfaces;
using Sennin.API.Model;
using Sennin.API.Model.Base;
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
        public async Task<int> DeleteAsync(int Id)
        {
            var entity = await SelectAsync(Id);

            if (entity == null)
                return 0;

            return await session.Connection.DeleteAsync(entity);
        }
        public async Task<int?> SaveAsync(T entity)
        {
            if (typeof(IEmpresaEntity).IsAssignableFrom(typeof(T)))
            {
                ((IEmpresaEntity)entity).EmpresaId = UsuarioLogado.Empresa();
            }
            return await session.Connection.InsertAsync(entity);
        }

        public async Task<T> SelectAsync(int Id)
        {
            if (typeof(IEmpresaEntity).IsAssignableFrom(typeof(T)))
            {
                return await session.Connection.GetAsync<T>(new { Id, EmpresaId = UsuarioLogado.Empresa() });
            }

            return await session.Connection.GetAsync<T>(Id);
        }

        public async Task<IEnumerable<T>> SelectAsync()
        {
            if (typeof(IEmpresaEntity).IsAssignableFrom(typeof(T)))
            {
                return await session.Connection.GetListAsync<T>(new { EmpresaId = UsuarioLogado.Empresa() });
            }
            return await session.Connection.GetListAsync<T>();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            if (typeof(IEmpresaEntity).IsAssignableFrom(typeof(T)))
            {
                ((IEmpresaEntity)entity).EmpresaId = UsuarioLogado.Empresa();
            }
            return await session.Connection.UpdateAsync(entity);
        }
    }
}
