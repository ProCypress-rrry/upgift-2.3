using System;
namespace upgift2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hej, stat avgiften på bilen börjar på 300 för fösta dagen. Hur mycket hade du tängt köra våra fordon i kilometer");
            String kiloM = Console.ReadLine();
            int KM = int.Parse(kiloM);
            Console.WriteLine("Hur många dagar efter första låne datumet skulle ni velja ha bilen i Dagar");
            string dagar = Console.ReadLine();
            int D = int.Parse(dagar);
            int svar = D * 500 + 300 + KM;
            Console.WriteLine("totala kostnaden blir" + " " + svar);

        }
    }
}