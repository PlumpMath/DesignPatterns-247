using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer.Model
{
    class Auctioneer : ISubject
    {
        private List<IObserver> _observerList = new List<IObserver>();

        private double _currentBid;

        public void Register(IObserver observer)
        {
            this._observerList.Add(observer);
            Console.WriteLine("Observer added");
        }

        public void Unregister(IObserver observer)
        {
            this._observerList.Remove(observer);
            Console.WriteLine("Observer removed");
        }

        public void NotifyAll()
        {
            foreach (IObserver observer in this._observerList)
            {
                observer.Update(this._currentBid);
            }
        }

        public void AcceptBid(double newBid)
        {
            this._currentBid = newBid;
            this.NotifyAll();
        }
    }
}