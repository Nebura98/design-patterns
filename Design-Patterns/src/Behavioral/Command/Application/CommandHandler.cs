namespace Design_Patterns.src.Behavioral.Command.Application
{
    public abstract class CommandHandler<T> where T : Command
    {
        public void Execute(T command)
        {
            Run(command);
            Log(command);
        }

        abstract protected void Log(T command);
        abstract protected void Run(T command);
    }
}
