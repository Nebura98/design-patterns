namespace Design_Patterns.src.Behavioral.Command.Application.Create
{
    public readonly record struct CreateUserCommand(Guid Id, string Name) : Command
    {
    }
}
