using System;
using DesignPatterns.Observer.Model;

namespace DesignPatterns.Observer
{
    class Program
    {
        public static void Main(string[] args)
        {
            ISubject auctioneer = new Auctioneer();
            auctioneer.Register(new Bidder("Geoff", 1));
            auctioneer.AcceptBid(50.0d);

            IObserver newBidder = new Bidder("Harry", 2);
            auctioneer.Register(newBidder);
            auctioneer.AcceptBid(100.0d);
            auctioneer.Unregister(newBidder);
            auctioneer.AcceptBid(125.0d);

            Console.ReadLine();
        }
    }
}