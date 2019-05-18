using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace TyperAPI.DAL.Repositories
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();
        void RemoveById(int id);
        void UpdateById(TEntity entity);
        void UpdateMany(IEnumerable<TEntity> entities);
        void Add(TEntity entity);
        void AddMany(IEnumerable<TEntity> entities);

        void SetAll(List<TEntity> entities);
    }

    public abstract class Entitybase
    {
        [Required]
        public int Id { get; set; }
    }
}
