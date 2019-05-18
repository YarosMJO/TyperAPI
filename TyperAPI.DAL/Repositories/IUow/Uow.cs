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
                    return (IRepository<T>) UserRepository;
                case "Score":
                    return (IRepository<T>) ScoreRepository;       
            }
            return (IRepository<T>)WordRepository;
        }

        private UserRepository userRepository;
        public IRepository<User> UserRepository
        {
            get
            {
                if (userRepository==null)
                {
                    userRepository = new UserRepository(context);
                }

                return userRepository;
            }
        }

        private ScoreRepository scoreRpository;
        public IRepository<Score> ScoreRepository
        {
            get
            {
                if (scoreRpository == null)
                {
                    scoreRpository = new ScoreRepository(context);
                }

                return scoreRpository;
            }
        }

        private WordRepository wordRepository;
        public IRepository<Word> WordRepository
        {
            get
            {
                if (wordRepository == null)
                {
                    wordRepository = new WordRepository(context);
                }

                return wordRepository;
            }
        }

        public Task SaveChangesAsync() => context.SaveChangesAsync();
    }
}
