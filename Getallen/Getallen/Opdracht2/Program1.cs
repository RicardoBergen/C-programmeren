using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vul een getal in van 1 t/m 4");
            int nummer = 0;
            do
            {
                nummer = InLezen();
            // door gaan totdat het tussen/ gelijk aan 1 en 4 is
            } while (nummer <= 1 && nummer >=4);
            Console.WriteLine("U heeft " + Convert.ToString( nummer ) + " gekozen. Dat is " + GeefKaart(nummer) + ".");
        }
        //Het lezen van het nummer
        private static int InLezen()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        //De suit van de kaart geven
        private static string GeefKaart(int nummer)
        {
            string[] kaarten = new string[] { "ruiten", "harten", "klaveren", "schopen" };
            return kaarten[nummer - 1];
        }
    }
}
