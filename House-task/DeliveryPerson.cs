using System;
using System.Threading;

namespace House_task
{
    public class BellEventArgs : EventArgs
    {
        public Bell Bell { get; set; }
    }
    public class DeliveryPerson
    {
        public event EventHandler<BellEventArgs> Ring;
        public void Door(Bell bell)
        {
            Console.WriteLine("Bell is ringing for any random door ... ");
            Thread.Sleep(2000);
            OnRing(bell);
        }

        protected virtual void OnRing(Bell bell)
        {
            if (Ring != null)
                Ring(this, new BellEventArgs(){Bell = bell });
        }
    }
}