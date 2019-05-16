using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TyperAPI.DAL.Models;

namespace TyperAPI.DAL.Repositories
{
    public class ScoreRepository: BaseRepository, IRepository<Score>
    {
        public ScoreRepository(TyperContext context) : base(context)
        {
            //Seeder
            context.SaveChangesAsync();
        }

        public Task<Score> GetById(int id)
        {
            return context.Scores.Include(y => y.User).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Score>> GetAll()
        {
            return await context.Scores.Include(x => x.User).ToListAsync();
        }

        public async void Add(Score entity)
        {
            await context.Scores.AddAsync(entity);
        }

        public async void AddMany(IEnumerable<Score> entities)
        {
            foreach (var entity in entities)
            {
                await context.Scores.AddAsync(entity);
            }
        }

        public async void RemoveById(int id)
        {
            var removedItem = await context.Scores.Include(y => y.User).FirstOrDefaultAsync(x => x.Id == id);
            if (removedItem == null)
            {
                return;
            }
            context.Scores.Remove(removedItem);
        }

        public void UpdateById(Score entity)
        {
            context.Scores.Update(entity);
        }

        public void UpdateMany(IEnumerable<Score> entities)
        {
            foreach (var entity in entities)
            {
                context.Scores.Update(entity);
            }
        }
    }
}
