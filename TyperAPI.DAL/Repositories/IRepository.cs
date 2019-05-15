using System.ComponentModel.DataAnnotations;

namespace TyperAPI.DAL.Repositories
{
    public interface IRepository
    {
        
    }

    public abstract class Entitybase
    {
        [Required]
        public int Id { get; set; }
    }
}
