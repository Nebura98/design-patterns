namespace Design_Patterns.src.Behavioral.Observer.Domain
{
    public class User
    {
        private Guid Id { get; init; }
        private string Name { get; init; }
        private string EmailAddress { get; init; }
        private string Password{ get; init; }

        public User(Guid id, string name, string emailAddress, string password)
        {
            Id = id;
            Name = name;
            EmailAddress = emailAddress;
            Password = password;
        }
    }
}
