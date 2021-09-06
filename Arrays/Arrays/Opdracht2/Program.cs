using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            int nummer = 1;
            int som;
            for (int rij = 0; rij < 3; rij++)
            {
                for (int colom = 0; colom < 3; colom++)
                {
                    array[rij, colom] = nummer;
                    nummer++;
                }
            }
            for (int rij = 0; rij < 3; rij++)
            {
                som = 0;
                for (int colom = 0; colom < 3; colom++)
                {
                    Console.Write(array[rij, colom] + " ");
                    som += array[rij, colom];
                }
                Console.Write("Som: " + som);
                Console.WriteLine();
            }
        }
    }
}
