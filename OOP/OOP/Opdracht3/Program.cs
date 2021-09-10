using System;
using Personen;
using System.Collections.Generic;
using static System.Console;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persoon> personen = new List<Persoon>();
        }
        //private static List<Persoon> personen = new List<Persoon>();
        private static List<Persoon> personen;
    }

    private static void Invullen()
    {
        Persoon Persoon1 = new Persoon();
        Persoon1.Voornaam = "Piet";
        Persoon1.Achternaam = "Pieterson";
        Persoon1.Geboortedatum = new DateTime(2018, 7, 24);
        Persoon1.Geslacht = "M/M";
        Persoon1.Lengte = 190;
        personen.Add(Persoon1);
    }

}
