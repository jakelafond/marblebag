using System;

namespace counting_marbles
{
    class Program
    {
        class MarbleBag
        {
            //properties
            public int RedMarble { get; set; } = 0;
            public int GreenMarble { get; set; } = 0;
            public int BlueMarble { get; set; } = 0;

            //constructor
            public MarbleBag(int redMarble, int greenMarble, int blueMarble)
            {
                RedMarble = redMarble;
                GreenMarble = greenMarble;
                BlueMarble = blueMarble;
            }

            //methods
            public int getTotalNumberOfMarbles() => RedMarble + GreenMarble + BlueMarble;


            public override string ToString()
            {
                return $"{RedMarble} Red marbles, {GreenMarble} green marbles, and {BlueMarble} blue marbles are in the bag.";
            }

            public int removeAllGreenMarbles() => GreenMarble = 0;

        }
        static void Main(string[] args)
        {
            var marbleBag = new MarbleBag(3, 1, 2);
            Console.WriteLine(marbleBag);

            marbleBag.BlueMarble = 5;

            Console.WriteLine(marbleBag);

            if (marbleBag.getTotalNumberOfMarbles() == 9)
            {
                Console.WriteLine("Total is 9, as expected");
            }
            else
            {
                Console.WriteLine("PANIC!!!");
            }

            marbleBag.removeAllGreenMarbles();
            if (marbleBag.getTotalNumberOfMarbles() == 8)
            {
                Console.WriteLine("Total is 8, as expected");
            }
            else
            {
                Console.WriteLine("Panic even more!!!");
            }
        }
    }
}
