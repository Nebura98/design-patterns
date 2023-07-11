namespace Design_Patterns.src.Behavioral.Observer.Email.Domain
{
    public class Mailer
    {
        public void Send(Email email) => Console.WriteLine(email);
    }
}
