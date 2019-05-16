using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TyperAPI.BL.Services
{
    public class BaseService
    {
        private IUow repositories;
        public BaseService(IUow uow)
        {
            repositories = uow;
        }

        public async Task<IEnumerable<T>> GetAll<T>() where T : class
        {
            return await Task.Run(() => repositories.GetRepository<T>().GetAll());
        }
        public async Task<T> GetById<T>(int id) where T : class
        {
            return await Task.Run(() => repositories.GetRepository<T>().GetById(id));

        }

        public async Task Add<T>(T item) where T : class
        {
            await Task.Run(() => repositories.GetRepository<T>().Add(item));
        }

        public async Task Update<T>(T item) where T : class
        {
            await Task.Run(() => repositories.GetRepository<T>().Update(item));
        }

        public async Task Remove<T>(int id) where T : class
        {
            await Task.Run(() => repositories.GetRepository<T>().Remove(id));
        }

        public async Task SaveChangesAsync()
        {
            await repositories.SaveChangesAsync();
        }

    }
}
