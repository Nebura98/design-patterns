namespace Design_Patterns.src.Behavioral.Command.Domain
{
    public class User
    {
        private Guid Id { get; init; }
        private string Name { get; init; }

        public User(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
