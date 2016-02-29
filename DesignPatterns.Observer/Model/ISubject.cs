namespace DesignPatterns.Observer.Model
{
    public interface ISubject
    {
        void Register(IObserver observer);
        
        void Unregister(IObserver observer);

        void NotifyAll();

        void AcceptBid(double value);
    }
}