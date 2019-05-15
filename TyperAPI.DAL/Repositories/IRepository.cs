using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace TyperAPI.DAL.Repositories
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> RemoveById(int id);
        Task<TEntity> UpdateById(int id);
        Task UpdateMany(IEnumerable<TEntity> entities);
        Task Add(int id);
        Task AddMany(IEnumerable<TEntity> entities);
    }

    public abstract class Entitybase
    {
        [Required]
        public int Id { get; set; }
    }
}
