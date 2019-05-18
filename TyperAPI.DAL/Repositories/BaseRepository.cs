using TyperAPI.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace TyperAPI.DAL.Repositories
{
    public class BaseRepository
    {
        public Seeder seeder;
        public TyperContext context;
        public BaseRepository() { }
        public BaseRepository(TyperContext context)
        {
            this.context = context;
            context.Database.Migrate();
            context.Database.EnsureCreated();
            seeder = new Seeder();
        }
       
    }
}
