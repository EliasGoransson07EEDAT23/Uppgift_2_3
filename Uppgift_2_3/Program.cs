using System;
namespace Uppgift_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, välkommen till \"CRABSSONS LÅNA BILAR AB\" här kan du nu låna en bil från 300kr + 500kr per dag!");
            Console.WriteLine("Följ stegen nedan för att få reda på hur mycket det kostar för dig!");
            Console.WriteLine("");
            Console.WriteLine("Börja med att skriva in hur många dagar du vill låna bilen:");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine("Sedan skriver du hur många kilometer du kommer köra under denna period:");
            int km = int.Parse(Console.ReadLine());
            int pris = 300 + (1 * km) + ((days - 1) * 500);
            Console.WriteLine("Okej, ditt totala pris är " + pris + "kr!");
            Console.ReadKey();
        }
    }
}