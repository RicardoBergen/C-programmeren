using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rij = 1;
            for (int colom = 0; colom < 3; colom++)
            {
                for (rij; rij < 3; rij++)
                {
                    Console.Write(rij + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
