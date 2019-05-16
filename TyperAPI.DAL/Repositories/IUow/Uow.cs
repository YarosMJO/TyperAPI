using System.Threading.Tasks;
using TyperAPI.DAL.Models;

namespace TyperAPI.DAL.Repositories.IUow
{
    public class Uow : IUow
    {
        private TyperContext context;

        public Uow(TyperContext context)
        {
            this.context = context;
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            switch (typeof(T).Name)
            {
                case "User":
                    return (IRepository<T>) userRepository;
                case "Score":
                    return (IRepository<T>) scoreRpository;       
            }
            return (IRepository<T>)wordRepository;
        }

        private IRepository<User> userRepository;
        public IRepository<User> UserRepository
        {
            get
            {
                if (UserRepository==null)
                {
                    userRepository = new UserRepository(context);
                }

                return userRepository;
            }
        }

        private IRepository<Score> scoreRpository;
        public IRepository<Score> ScoreRpository
        {
            get
            {
                if (ScoreRpository == null)
                {
                    scoreRpository = new ScoreRepository(context);
                }

                return scoreRpository;
            }
        }

        private IRepository<Word> wordRepository;
        public IRepository<Word> WordRepository
        {
            get
            {
                if (WordRepository == null)
                {
                    wordRepository = new WordRepository(context);
                }

                return wordRepository;
            }
        }

        public Task SaveChangesAsync() => context.SaveChangesAsync();
    }
}
