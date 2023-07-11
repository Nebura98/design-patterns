namespace Design_Patterns.src.Behavioral.Observer.Domain
{
    public class UserRegistered
    {
        public UserRegistered(Guid id, string name, string emailAddress, string password)
        {
            Id = id;
            Name = name;
            EmailAddress = emailAddress;
            Password = password;
        }

        public Guid Id { get; init; }
        public string Name { get; init; }
        public string EmailAddress { get; init; }
        public string Password { get; init; } 
    }
}
