using Design_Patterns.src.Behavioral.Observer.Shared.Domain;

namespace Design_Patterns.src.Behavioral.Observer.Domain
{
    public class UserSignUpServiceManagerHandler : Observable<UserRegistered>
    {
        private readonly IUserRepository _userRepository;
        public UserSignUpServiceManagerHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        void SignUpAsync( Guid id, string name, string emailAddress, string password )
        {
            var user = new User(id, name, emailAddress, password);
            _userRepository.Save(user);

            var userRegistered = new UserRegistered(id, name, emailAddress, password);
            Nofify(userRegistered);
        }
    }
}
