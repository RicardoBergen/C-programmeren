using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Peter", "is", "de", "broer", "van", "Hans", "" };
            // 1 voor 1 de worden laten zien op de zelfde lijn
            foreach (string word in array)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine("");
            // De worden Peter en Hans met elkaar wisselen
            array[6] = array[5];
            array[5] = array[0];
            array[0] = array[6];
            array[6] = "";
            foreach (string word in array)
            {
                Console.Write(word + " ");
            }
        }
    }
}
