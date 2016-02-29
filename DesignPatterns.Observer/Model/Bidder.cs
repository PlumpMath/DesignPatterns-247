using System;

namespace DesignPatterns.Observer.Model
{
    public class Bidder : IObserver
    {
        public string Name { get; set; }

        public int BiddingNumber { get; set; }

        private double _currentBid;

        public Bidder(string name, int biddingNumber)
        {
            this.Name = name;
            this.BiddingNumber = biddingNumber;
        }

        public void Update(double bid)
        {
            this._currentBid = bid;
            Console.WriteLine(string.Format("{0} (#{1}) acknowledges new bid: {2}", this.Name, BiddingNumber, this._currentBid));
        }
    }
}