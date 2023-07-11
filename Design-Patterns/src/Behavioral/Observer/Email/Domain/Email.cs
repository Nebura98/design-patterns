namespace Design_Patterns.src.Behavioral.Observer.Email.Domain
{
    public class Email
    {
        private string To { get; init; }
        private string Subject { get; init; }
        private string Body { get; init; }
        public Email(string to, string subject, string body)
        {
            To = to;
            Subject = subject;
            Body = body;
        }
    }
}
