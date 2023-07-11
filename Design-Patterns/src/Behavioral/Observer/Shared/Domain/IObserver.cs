namespace Design_Patterns.src.Behavioral.Observer.Shared.Domain
{
    public interface IObserver<T>
    {
        void Update(T ObserveEvent);
    }
}
