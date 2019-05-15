using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TyperAPI.DAL.Models;

namespace TyperAPI.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        public UserRepository(TyperContext context): base(context)
        {
        }

        public Task Add(int id)
        {
            throw new NotImplementedException();
        }

        public Task AddMany(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> RemoveById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMany(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }
    }
}
