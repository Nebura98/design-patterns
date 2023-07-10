using Design_Patterns.src.Behavioral.Command.Domain;

namespace Design_Patterns.src.Behavioral.Command.Application.Create
{
    public class CreateUserCommandHandler : CommandHandler<CreateUserCommand>
    {
        private readonly UserCreator _userCreator;
        private readonly ILogger<User> _logger;

        public CreateUserCommandHandler(UserCreator userCreator, ILogger<User> logger)
        {
            _userCreator = userCreator;
            _logger = logger;
        }

        protected override void Log(CreateUserCommand command)
        {

            _logger.LogInformation($"User created: {command.Id}");
        }

        protected override void Run(CreateUserCommand command)
        {
            _userCreator.Create(command.Id,command.Name);
        }
    }
}
