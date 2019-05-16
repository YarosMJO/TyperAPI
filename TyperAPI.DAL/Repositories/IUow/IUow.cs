using System.Threading.Tasks;

namespace TyperAPI.DAL.Repositories.IUow
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T : class;
        Task SaveChangesAsync();
    }
}
