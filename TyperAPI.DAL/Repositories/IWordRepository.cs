using System.Threading.Tasks;
using TyperAPI.DAL.Models;

namespace TyperAPI.DAL.Repositories
{
    public interface IWordRepository
    {
        Task<Word> GetByMatchedChars(string word);
    }
}
