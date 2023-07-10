using Design_Patterns.src.Behavioral.Command.Domain;

namespace Design_Patterns.src.Behavioral.Command.Infrastruture.Persistence
{
    public class InMemoryUserRepository : UserRepository
    {
        public void Save(User user)
        {
            throw new NotImplementedException();
        }
    }
}
