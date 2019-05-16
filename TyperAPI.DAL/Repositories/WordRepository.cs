using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TyperAPI.DAL.Models;

namespace TyperAPI.DAL.Repositories
{
    public class WordRepository: BaseRepository, IRepository<Word>, IWordRepository
    {
        public WordRepository(TyperContext context) : base(context)
        {

        }

        public Task<Word> GetById(int id)
        {
            return context.Words.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<Word> GetByMatchedChars(string word)
        {
            return context.Words.FirstOrDefaultAsync(x => x.WordValue.Contains(word));
        }

        public async Task<IEnumerable<Word>> GetAll()
        {
            return await context.Words.ToListAsync();
        }

        public async void Add(Word entity)
        {
            await context.Words.AddAsync(entity);
        }

        public async void AddMany(IEnumerable<Word> entities)
        {
            foreach (var entity in entities)
            {
                await context.Words.AddAsync(entity);
            }
        }

        public async void RemoveById(int id)
        {
            var removedItem = await context.Words.FirstOrDefaultAsync(x => x.Id == id);
            if (removedItem == null)
            {
                return;
            }
            context.Words.Remove(removedItem);
        }

        public void UpdateById(Word entity)
        {
            context.Words.Update(entity);
        }

        public void UpdateMany(IEnumerable<Word> entities)
        {
            foreach (var entity in entities)
            {
                context.Words.Update(entity);
            }
        }
    }
}
