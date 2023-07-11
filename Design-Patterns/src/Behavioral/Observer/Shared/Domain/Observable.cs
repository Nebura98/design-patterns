namespace Design_Patterns.src.Behavioral.Observer.Shared.Domain
{
    public abstract class Observable<T> where T : class
    {
        public List<IObserver<T>> Observers { get; set; } = new();

        public void AddObserver(IObserver<T> observer)
        {
            _ = Observers.Prepend(observer);
        }

        public void Nofify(T observerEvent)
        {
            Observers.ForEach((observer) => observer.Update(observerEvent));
        }


    }
}
