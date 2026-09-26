using System;

namespace House_task
{
    class Program
    {
        static void Main(string[] args)
        {
            var bell = new Bell(){Title = "Bell is ringing:"};
            var deliveryperson = new DeliveryPerson();
            var room1 = new Room1();
            var room2 = new Room2();

            deliveryperson.Ring += room1.OnRoom1;
            deliveryperson.Ring += room2.OnRoom2;



            deliveryperson.Door(bell);
        }
    }
}
