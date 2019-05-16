using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TyperAPI.DAL.Models;

namespace TyperAPI.DAL.Repositories
{
    public class UserRepository :BaseRepository , IRepository<User>
    {
        public UserRepository(TyperContext context): base(context)
        {
            
        }

        public Task<User> GetById(int id)
        {
            return context.Users.Include(y => y.Scores).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await context.Users.Include(x => x.Scores).ToListAsync();
        }

        public async void Add(User entity)
        {
           await context.Users.AddAsync(entity);
        }

        public async void AddMany(IEnumerable<User> entities)
        {
            foreach (var entity in entities)
            {
                await context.Users.AddAsync(entity);
            }
        }
        
        public async void RemoveById(int id)
        {
            var removedItem = await context.Users.Include(y => y.Scores).FirstOrDefaultAsync(x => x.Id == id);
            if (removedItem == null)
            {
                return;
            }
            context.Users.Remove(removedItem);
        }

        public void UpdateById(User entity)
        {
             context.Users.Update(entity);
        }

        public void UpdateMany(IEnumerable<User> entities)
        {
            foreach (var entity in entities)
            {
                context.Users.Update(entity);
            }
        }
    }
}
