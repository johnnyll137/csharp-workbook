using System;

namespace _03Week
{
    class Program
    {
        static void Main(string[] args)
        {
            Land land = new Land();
            Console.WriteLine("How many houses do you want?");
            land.house = Convert.ToInt32(Console.ReadLine());
            int countHouses = 1;
            while (countHouses <= land.house)
            {

                House house = new House();

                //Ask how many floors the house will have             
                Console.WriteLine("How many floors do you want?");
                house.floors = Convert.ToInt32(Console.ReadLine());
                int countFloors = 1;
                while (countFloors <= house.floors)
                {
                    Console.WriteLine("How many rooms do you want on floor number {0}?", countFloors);
                    house.rooms = Convert.ToInt32(Console.ReadLine());

                    // We have to count how many rooms the house will have
                    int countRooms = 1;
                    while (countRooms <= house.rooms)
                    {

                        Room room = new Room();
                        Console.WriteLine("What color do you want room number {0} on floor {0} to be?", countRooms);
                        room.color = Console.ReadLine();

                        string response = string.Format("Your room color will be {0}", room.color);
                        Console.WriteLine(response);

                        countRooms++;
                    }
                    countFloors++;
                }
                countHouses++;
            }
            // Console.WriteLine("Hello World!");
        }
    }
}
