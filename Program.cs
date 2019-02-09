using System;

namespace MovieStorage
{
    class Program
    {
        static void Main(string[] args)
        {

            Movie TommyBoy = new Movie("Tommy Boy","Peter Segal", "1995" );
            Movie BlackSheep = new Movie("Black Sheep", "Penelope Spheeris", "1996");

            TommyBoy.title = "Tommy Boy";
            TommyBoy.director = "Peter Segal";
            TommyBoy.year = "1995";

            BlackSheep.title = "Black Sheep";
            BlackSheep.director = "Penelope Spheers";
            BlackSheep.year = "1996";

            Console.WriteLine(TommyBoy.title + TommyBoy.director + " " + TommyBoy.year + ", " + BlackSheep.title + BlackSheep.director + " " + BlackSheep.year);

            Console.ReadLine();



        }

    }
}
