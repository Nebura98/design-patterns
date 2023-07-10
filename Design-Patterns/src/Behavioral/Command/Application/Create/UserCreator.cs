using Design_Patterns.src.Behavioral.Command.Domain;

namespace Design_Patterns.src.Behavioral.Command.Application.Create
{
    public class UserCreator
    {
        private readonly UserRepository _repository;

        public UserCreator(UserRepository repository)
        {
            _repository = repository;
        }
        
        public void Create(Guid Id,string Name)
        {
            var user = new User(Id, Name);
            _repository.Save(user);
        }
    }
}
