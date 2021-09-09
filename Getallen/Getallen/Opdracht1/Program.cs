using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            //De getallen op roepen
            Console.WriteLine("Schrijf het eerste getal op");
            int getal1 = Leesgeheelgetal();
            Console.WriteLine("Schrijf het tweede getal op");
            int getal2 = Leesgeheelgetal();
            Console.WriteLine("Uw gekozen getallen: " + Convert.ToString(getal1) + " en " + Convert.ToString(getal2));
            Console.WriteLine("De som van uw getallen is: " + Convert.ToString(Som(getal1, getal2)));
            Console.WriteLine("De verschil van uw getallen is: " + Convert.ToString(Verschil(getal1, getal2)));
            Console.WriteLine("De product van uw getallen is: " + Convert.ToString(Product(getal1, getal2)));
        }
        private static int Leesgeheelgetal()
        {
            //Een try in een while true loop zodat je altijd een nummer krijgt
            int nummer = 0;
            while (true)
            {
                try
                {
                    nummer = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Het lijkt er op dat u geen volledig getal heb ingevoert, probeer het opnieuw");
                }
            };
            return nummer;
        }
        private static int Som(int getal1, int getal2)
        {
            return getal1 + getal2;
        }
        private static int Verschil (int getal1, int getal2)
        {
            return getal1 - getal2;
        }
        private static int Product(int getal1, int getal2)
        {
            return getal1 * getal2;
        }
    }
}
